using Antlr4.Runtime;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CSharp;
using System.CodeDom.Compiler;
using System.Reflection;

namespace ControlScriptLanguage
{
    public class ControlScriptCompiler
    {
        static ControlScriptCompiler()
        {
            Environment.SetEnvironmentVariable("ROSLYN_COMPILER_LOCATION", "c:\\roslyn");
        }

        private static string codePrefix =
@"
using static System.Math;
using static ControlScriptLibrary.ControlScriptLibrary;
using System.Collections;
using System.Collections.Generic;
using System;
public class ControlScript : ControlScriptLanguage.IControlScript
{
    public ControlScript() => enumerator = ScriptEnumerator();
	private double _timer = 0;
	private double _currentValue;
	private IEnumerator<double> enumerator;
	public double Bpm { get; set; }
	public double SampleRate { get; set; }
    public double MidiNote { get; set; } = -1;
    public bool IsPlaying { get; set; }
	public double Current => enumerator.Current;
	object IEnumerator.Current => Current;
	public bool MoveNext() => enumerator.MoveNext();
	public void Reset() => enumerator.Reset();
#region IDisposable Support
	private bool disposedValue = false; // To detect redundant calls

	protected virtual void Dispose(bool disposing)
	{
		if (!disposedValue)
		{
			if (disposing)
			{
				// TODO: dispose managed state (managed objects).
			}

			// TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
			// TODO: set large fields to null.

			disposedValue = true;
		}
	}

	// TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
	// ~C() {
	//   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
	//   Dispose(false);
	// }

	// This code added to correctly implement the disposable pattern.
	public void Dispose()
	{
		// Do not change this code. Put cleanup code in Dispose(bool disposing) above.
		Dispose(true);
		// TODO: uncomment the following line if the finalizer is overridden above.
		// GC.SuppressFinalize(this);
	}
	#endregion
	public System.Collections.Generic.IEnumerator<double> ScriptEnumerator()
	{
        while (true)
        {
// Start of translated code.
";

        private static string codeSuffix =
    @"
// End of translated code.
        }
    }
}";

        static void Main(string[] args)
        {
            Test();
            if (args.Length == 0)
            {
                Console.WriteLine("");
                Console.WriteLine("Usage: ControlScriptLanguage.exe inputfile");
                Console.WriteLine("");
                return;
            }

            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            string filename = args[0];

            //From ANTLR4 Doc (antlr.org).
            ICharStream streamInput = CharStreams.fromPath(filename);
            ITokenSource lexer = new ControlScriptLanguageLexer(streamInput);
            ITokenStream flowTokens = new CommonTokenStream(lexer);
            ControlScriptLanguageParser parser = new ControlScriptLanguageParser(flowTokens);

            Console.WriteLine(codePrefix);
            parser.script();
            Console.WriteLine(codeSuffix);
        }

        private static void Test()
        {
            string scriptCode = @"
a = [1, 2, 3, 4]
n = 0f
direction = 1;
while (true)
{
    yield a[n];
    pause 1;
    n += direction;
    if (n == Length(a) - 1)
        direction = -1;
    else if (n == 0)
        direction = 1;
}
";

            var script = Compile(scriptCode).GetScript();
            script.SampleRate = 44100;
            script.Bpm = 140;
            for (int i = 0; i < 100; ++i)
                script.MoveNext();
        }

        public static string GetTranslatedCode(string sourceCode)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            var prevConsoleOut = Console.Out;
            var writer = new StringWriter();
            Console.SetOut(writer);

            ICharStream streamInput = CharStreams.fromstring(sourceCode);
            ITokenSource lexer = new ControlScriptLanguageLexer(streamInput);
            ITokenStream flowTokens = new CommonTokenStream(lexer);
            ControlScriptLanguageParser parser = new ControlScriptLanguageParser(flowTokens);

            Console.WriteLine(codePrefix);
            parser.script();
            Console.WriteLine(codeSuffix);
            
            Console.SetOut(prevConsoleOut);

            return writer.ToString();
        }

        public static IControlScriptFactory Compile(string scriptCode)
        {
            var translatedCode = GetTranslatedCode(scriptCode);
            var provider = new Microsoft.CodeDom.Providers.DotNetCompilerPlatform.CSharpCodeProvider();
            CompilerParameters parameters = new CompilerParameters();
            parameters.ReferencedAssemblies.Add(typeof(ControlScriptCompiler).Assembly.Location);
            parameters.ReferencedAssemblies.Add("System.dll");
            parameters.ReferencedAssemblies.Add(typeof(ControlScriptLibrary.ControlScriptLibrary).Assembly.Location);
            parameters.GenerateInMemory = true;
            parameters.CompilerOptions = "/optimize";
            CompilerResults results = provider.CompileAssemblyFromSource(parameters, translatedCode);
            if (results.Errors.HasErrors)
                throw new TranslatedCodeCompilationException()
                {
                    Errors = results.Errors.Cast<CompilerError>().Select(x => x.ErrorText),
                };
            var cls = results.CompiledAssembly.GetType("ControlScript");
            return new ControlScriptFactory(() => (IControlScript)cls.GetConstructors()[0].Invoke(null));
        }

        private class ControlScriptFactory : IControlScriptFactory
        {
            private Func<IControlScript> factoryFunction;

            public ControlScriptFactory(Func<IControlScript> factoryFunction)
            {
                this.factoryFunction = factoryFunction;
            }

            public IControlScript GetScript() => factoryFunction();
        }
    }
}
