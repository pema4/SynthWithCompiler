//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from ControlScriptLanguage.g4 by ANTLR 4.7.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.1")]
[System.CLSCompliant(false)]
public partial class ControlScriptLanguageLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, T__15=16, T__16=17, 
		BooleanConstant=18, DecimalConstant=19, DecimalConstantSuffix=20, Plus=21, 
		Minus=22, Mult=23, Div=24, Mod=25, Not=26, Less=27, LessEqual=28, Greater=29, 
		GreaterEqual=30, Equal=31, NotEqual=32, And=33, Or=34, Xor=35, Assign=36, 
		Yield=37, Pause=38, Identifier=39, WhiteSpaces=40, OneLineComments=41, 
		MultipleLineComments=42;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"T__9", "T__10", "T__11", "T__12", "T__13", "T__14", "T__15", "T__16", 
		"BooleanConstant", "DecimalConstant", "DecimalConstantSuffix", "Digit", 
		"Sign", "Plus", "Minus", "Mult", "Div", "Mod", "Not", "Less", "LessEqual", 
		"Greater", "GreaterEqual", "Equal", "NotEqual", "And", "Or", "Xor", "Assign", 
		"Yield", "Pause", "Identifier", "WhiteSpaces", "OneLineComments", "MultipleLineComments"
	};


	public ControlScriptLanguageLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public ControlScriptLanguageLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "';'", "'{'", "'}'", "'if'", "'('", "')'", "'else'", "'while'", 
		"'for'", "'['", "']'", "','", "'+='", "'-='", "'*='", "'/='", "'%='", 
		null, null, null, "'+'", "'-'", "'*'", "'/'", "'%'", "'!'", "'<'", "'<='", 
		"'>'", "'>='", "'=='", "'!='", "'&'", "'|'", "'^'", "'='", "'yield'", 
		"'pause'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, "BooleanConstant", "DecimalConstant", 
		"DecimalConstantSuffix", "Plus", "Minus", "Mult", "Div", "Mod", "Not", 
		"Less", "LessEqual", "Greater", "GreaterEqual", "Equal", "NotEqual", "And", 
		"Or", "Xor", "Assign", "Yield", "Pause", "Identifier", "WhiteSpaces", 
		"OneLineComments", "MultipleLineComments"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "ControlScriptLanguage.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static ControlScriptLanguageLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', ',', '\x105', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', '\x10', '\x4', 
		'\x11', '\t', '\x11', '\x4', '\x12', '\t', '\x12', '\x4', '\x13', '\t', 
		'\x13', '\x4', '\x14', '\t', '\x14', '\x4', '\x15', '\t', '\x15', '\x4', 
		'\x16', '\t', '\x16', '\x4', '\x17', '\t', '\x17', '\x4', '\x18', '\t', 
		'\x18', '\x4', '\x19', '\t', '\x19', '\x4', '\x1A', '\t', '\x1A', '\x4', 
		'\x1B', '\t', '\x1B', '\x4', '\x1C', '\t', '\x1C', '\x4', '\x1D', '\t', 
		'\x1D', '\x4', '\x1E', '\t', '\x1E', '\x4', '\x1F', '\t', '\x1F', '\x4', 
		' ', '\t', ' ', '\x4', '!', '\t', '!', '\x4', '\"', '\t', '\"', '\x4', 
		'#', '\t', '#', '\x4', '$', '\t', '$', '\x4', '%', '\t', '%', '\x4', '&', 
		'\t', '&', '\x4', '\'', '\t', '\'', '\x4', '(', '\t', '(', '\x4', ')', 
		'\t', ')', '\x4', '*', '\t', '*', '\x4', '+', '\t', '+', '\x4', ',', '\t', 
		',', '\x4', '-', '\t', '-', '\x3', '\x2', '\x3', '\x2', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x4', '\x3', '\x4', '\x3', '\x5', '\x3', '\x5', 
		'\x3', '\x5', '\x3', '\x6', '\x3', '\x6', '\x3', '\a', '\x3', '\a', '\x3', 
		'\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\t', 
		'\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', 
		'\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\v', '\x3', '\v', 
		'\x3', '\f', '\x3', '\f', '\x3', '\r', '\x3', '\r', '\x3', '\xE', '\x3', 
		'\xE', '\x3', '\xE', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', 
		'\x10', '\x3', '\x10', '\x3', '\x10', '\x3', '\x11', '\x3', '\x11', '\x3', 
		'\x11', '\x3', '\x12', '\x3', '\x12', '\x3', '\x12', '\x3', '\x13', '\x3', 
		'\x13', '\x3', '\x13', '\x3', '\x13', '\x3', '\x13', '\x3', '\x13', '\x3', 
		'\x13', '\x3', '\x13', '\x3', '\x13', '\x5', '\x13', '\x96', '\n', '\x13', 
		'\x3', '\x14', '\x5', '\x14', '\x99', '\n', '\x14', '\x3', '\x14', '\x6', 
		'\x14', '\x9C', '\n', '\x14', '\r', '\x14', '\xE', '\x14', '\x9D', '\x3', 
		'\x14', '\x3', '\x14', '\a', '\x14', '\xA2', '\n', '\x14', '\f', '\x14', 
		'\xE', '\x14', '\xA5', '\v', '\x14', '\x5', '\x14', '\xA7', '\n', '\x14', 
		'\x3', '\x15', '\x3', '\x15', '\x3', '\x16', '\x3', '\x16', '\x3', '\x17', 
		'\x3', '\x17', '\x3', '\x18', '\x3', '\x18', '\x3', '\x19', '\x3', '\x19', 
		'\x3', '\x1A', '\x3', '\x1A', '\x3', '\x1B', '\x3', '\x1B', '\x3', '\x1C', 
		'\x3', '\x1C', '\x3', '\x1D', '\x3', '\x1D', '\x3', '\x1E', '\x3', '\x1E', 
		'\x3', '\x1F', '\x3', '\x1F', '\x3', '\x1F', '\x3', ' ', '\x3', ' ', '\x3', 
		'!', '\x3', '!', '\x3', '!', '\x3', '\"', '\x3', '\"', '\x3', '\"', '\x3', 
		'#', '\x3', '#', '\x3', '#', '\x3', '$', '\x3', '$', '\x3', '%', '\x3', 
		'%', '\x3', '&', '\x3', '&', '\x3', '\'', '\x3', '\'', '\x3', '(', '\x3', 
		'(', '\x3', '(', '\x3', '(', '\x3', '(', '\x3', '(', '\x3', ')', '\x3', 
		')', '\x3', ')', '\x3', ')', '\x3', ')', '\x3', ')', '\x3', '*', '\x3', 
		'*', '\a', '*', '\xE1', '\n', '*', '\f', '*', '\xE', '*', '\xE4', '\v', 
		'*', '\x3', '+', '\x6', '+', '\xE7', '\n', '+', '\r', '+', '\xE', '+', 
		'\xE8', '\x3', '+', '\x3', '+', '\x3', ',', '\x3', ',', '\x3', ',', '\x3', 
		',', '\a', ',', '\xF1', '\n', ',', '\f', ',', '\xE', ',', '\xF4', '\v', 
		',', '\x3', ',', '\x3', ',', '\x3', '-', '\x3', '-', '\x3', '-', '\x3', 
		'-', '\a', '-', '\xFC', '\n', '-', '\f', '-', '\xE', '-', '\xFF', '\v', 
		'-', '\x3', '-', '\x3', '-', '\x3', '-', '\x3', '-', '\x3', '-', '\x3', 
		'\xFD', '\x2', '.', '\x3', '\x3', '\x5', '\x4', '\a', '\x5', '\t', '\x6', 
		'\v', '\a', '\r', '\b', '\xF', '\t', '\x11', '\n', '\x13', '\v', '\x15', 
		'\f', '\x17', '\r', '\x19', '\xE', '\x1B', '\xF', '\x1D', '\x10', '\x1F', 
		'\x11', '!', '\x12', '#', '\x13', '%', '\x14', '\'', '\x15', ')', '\x16', 
		'+', '\x2', '-', '\x2', '/', '\x17', '\x31', '\x18', '\x33', '\x19', '\x35', 
		'\x1A', '\x37', '\x1B', '\x39', '\x1C', ';', '\x1D', '=', '\x1E', '?', 
		'\x1F', '\x41', ' ', '\x43', '!', '\x45', '\"', 'G', '#', 'I', '$', 'K', 
		'%', 'M', '&', 'O', '\'', 'Q', '(', 'S', ')', 'U', '*', 'W', '+', 'Y', 
		',', '\x3', '\x2', '\t', '\x4', '\x2', '\x64', '\x64', 'u', 'u', '\x3', 
		'\x2', '\x32', ';', '\x4', '\x2', '-', '-', '/', '/', '\x4', '\x2', '\x43', 
		'\\', '\x63', '|', '\x6', '\x2', '\x32', ';', '\x43', '\\', '\x61', '\x61', 
		'\x63', '|', '\x5', '\x2', '\v', '\f', '\xF', '\xF', '\"', '\"', '\x4', 
		'\x2', '\f', '\f', '\xF', '\xF', '\x2', '\x10B', '\x2', '\x3', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x5', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\a', '\x3', '\x2', '\x2', '\x2', '\x2', '\t', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\v', '\x3', '\x2', '\x2', '\x2', '\x2', '\r', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\xF', '\x3', '\x2', '\x2', '\x2', '\x2', '\x11', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x13', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x15', '\x3', '\x2', '\x2', '\x2', '\x2', '\x17', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x19', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1B', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x1D', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x1F', '\x3', '\x2', '\x2', '\x2', '\x2', '!', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '#', '\x3', '\x2', '\x2', '\x2', '\x2', '%', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\'', '\x3', '\x2', '\x2', '\x2', '\x2', ')', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '/', '\x3', '\x2', '\x2', '\x2', '\x2', '\x31', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x33', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x35', '\x3', '\x2', '\x2', '\x2', '\x2', '\x37', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x39', '\x3', '\x2', '\x2', '\x2', '\x2', ';', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '=', '\x3', '\x2', '\x2', '\x2', '\x2', '?', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x41', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x43', '\x3', '\x2', '\x2', '\x2', '\x2', '\x45', '\x3', '\x2', '\x2', 
		'\x2', '\x2', 'G', '\x3', '\x2', '\x2', '\x2', '\x2', 'I', '\x3', '\x2', 
		'\x2', '\x2', '\x2', 'K', '\x3', '\x2', '\x2', '\x2', '\x2', 'M', '\x3', 
		'\x2', '\x2', '\x2', '\x2', 'O', '\x3', '\x2', '\x2', '\x2', '\x2', 'Q', 
		'\x3', '\x2', '\x2', '\x2', '\x2', 'S', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'U', '\x3', '\x2', '\x2', '\x2', '\x2', 'W', '\x3', '\x2', '\x2', '\x2', 
		'\x2', 'Y', '\x3', '\x2', '\x2', '\x2', '\x3', '[', '\x3', '\x2', '\x2', 
		'\x2', '\x5', ']', '\x3', '\x2', '\x2', '\x2', '\a', '_', '\x3', '\x2', 
		'\x2', '\x2', '\t', '\x61', '\x3', '\x2', '\x2', '\x2', '\v', '\x64', 
		'\x3', '\x2', '\x2', '\x2', '\r', '\x66', '\x3', '\x2', '\x2', '\x2', 
		'\xF', 'h', '\x3', '\x2', '\x2', '\x2', '\x11', 'm', '\x3', '\x2', '\x2', 
		'\x2', '\x13', 's', '\x3', '\x2', '\x2', '\x2', '\x15', 'w', '\x3', '\x2', 
		'\x2', '\x2', '\x17', 'y', '\x3', '\x2', '\x2', '\x2', '\x19', '{', '\x3', 
		'\x2', '\x2', '\x2', '\x1B', '}', '\x3', '\x2', '\x2', '\x2', '\x1D', 
		'\x80', '\x3', '\x2', '\x2', '\x2', '\x1F', '\x83', '\x3', '\x2', '\x2', 
		'\x2', '!', '\x86', '\x3', '\x2', '\x2', '\x2', '#', '\x89', '\x3', '\x2', 
		'\x2', '\x2', '%', '\x95', '\x3', '\x2', '\x2', '\x2', '\'', '\x98', '\x3', 
		'\x2', '\x2', '\x2', ')', '\xA8', '\x3', '\x2', '\x2', '\x2', '+', '\xAA', 
		'\x3', '\x2', '\x2', '\x2', '-', '\xAC', '\x3', '\x2', '\x2', '\x2', '/', 
		'\xAE', '\x3', '\x2', '\x2', '\x2', '\x31', '\xB0', '\x3', '\x2', '\x2', 
		'\x2', '\x33', '\xB2', '\x3', '\x2', '\x2', '\x2', '\x35', '\xB4', '\x3', 
		'\x2', '\x2', '\x2', '\x37', '\xB6', '\x3', '\x2', '\x2', '\x2', '\x39', 
		'\xB8', '\x3', '\x2', '\x2', '\x2', ';', '\xBA', '\x3', '\x2', '\x2', 
		'\x2', '=', '\xBC', '\x3', '\x2', '\x2', '\x2', '?', '\xBF', '\x3', '\x2', 
		'\x2', '\x2', '\x41', '\xC1', '\x3', '\x2', '\x2', '\x2', '\x43', '\xC4', 
		'\x3', '\x2', '\x2', '\x2', '\x45', '\xC7', '\x3', '\x2', '\x2', '\x2', 
		'G', '\xCA', '\x3', '\x2', '\x2', '\x2', 'I', '\xCC', '\x3', '\x2', '\x2', 
		'\x2', 'K', '\xCE', '\x3', '\x2', '\x2', '\x2', 'M', '\xD0', '\x3', '\x2', 
		'\x2', '\x2', 'O', '\xD2', '\x3', '\x2', '\x2', '\x2', 'Q', '\xD8', '\x3', 
		'\x2', '\x2', '\x2', 'S', '\xDE', '\x3', '\x2', '\x2', '\x2', 'U', '\xE6', 
		'\x3', '\x2', '\x2', '\x2', 'W', '\xEC', '\x3', '\x2', '\x2', '\x2', 'Y', 
		'\xF7', '\x3', '\x2', '\x2', '\x2', '[', '\\', '\a', '=', '\x2', '\x2', 
		'\\', '\x4', '\x3', '\x2', '\x2', '\x2', ']', '^', '\a', '}', '\x2', '\x2', 
		'^', '\x6', '\x3', '\x2', '\x2', '\x2', '_', '`', '\a', '\x7F', '\x2', 
		'\x2', '`', '\b', '\x3', '\x2', '\x2', '\x2', '\x61', '\x62', '\a', 'k', 
		'\x2', '\x2', '\x62', '\x63', '\a', 'h', '\x2', '\x2', '\x63', '\n', '\x3', 
		'\x2', '\x2', '\x2', '\x64', '\x65', '\a', '*', '\x2', '\x2', '\x65', 
		'\f', '\x3', '\x2', '\x2', '\x2', '\x66', 'g', '\a', '+', '\x2', '\x2', 
		'g', '\xE', '\x3', '\x2', '\x2', '\x2', 'h', 'i', '\a', 'g', '\x2', '\x2', 
		'i', 'j', '\a', 'n', '\x2', '\x2', 'j', 'k', '\a', 'u', '\x2', '\x2', 
		'k', 'l', '\a', 'g', '\x2', '\x2', 'l', '\x10', '\x3', '\x2', '\x2', '\x2', 
		'm', 'n', '\a', 'y', '\x2', '\x2', 'n', 'o', '\a', 'j', '\x2', '\x2', 
		'o', 'p', '\a', 'k', '\x2', '\x2', 'p', 'q', '\a', 'n', '\x2', '\x2', 
		'q', 'r', '\a', 'g', '\x2', '\x2', 'r', '\x12', '\x3', '\x2', '\x2', '\x2', 
		's', 't', '\a', 'h', '\x2', '\x2', 't', 'u', '\a', 'q', '\x2', '\x2', 
		'u', 'v', '\a', 't', '\x2', '\x2', 'v', '\x14', '\x3', '\x2', '\x2', '\x2', 
		'w', 'x', '\a', ']', '\x2', '\x2', 'x', '\x16', '\x3', '\x2', '\x2', '\x2', 
		'y', 'z', '\a', '_', '\x2', '\x2', 'z', '\x18', '\x3', '\x2', '\x2', '\x2', 
		'{', '|', '\a', '.', '\x2', '\x2', '|', '\x1A', '\x3', '\x2', '\x2', '\x2', 
		'}', '~', '\a', '-', '\x2', '\x2', '~', '\x7F', '\a', '?', '\x2', '\x2', 
		'\x7F', '\x1C', '\x3', '\x2', '\x2', '\x2', '\x80', '\x81', '\a', '/', 
		'\x2', '\x2', '\x81', '\x82', '\a', '?', '\x2', '\x2', '\x82', '\x1E', 
		'\x3', '\x2', '\x2', '\x2', '\x83', '\x84', '\a', ',', '\x2', '\x2', '\x84', 
		'\x85', '\a', '?', '\x2', '\x2', '\x85', ' ', '\x3', '\x2', '\x2', '\x2', 
		'\x86', '\x87', '\a', '\x31', '\x2', '\x2', '\x87', '\x88', '\a', '?', 
		'\x2', '\x2', '\x88', '\"', '\x3', '\x2', '\x2', '\x2', '\x89', '\x8A', 
		'\a', '\'', '\x2', '\x2', '\x8A', '\x8B', '\a', '?', '\x2', '\x2', '\x8B', 
		'$', '\x3', '\x2', '\x2', '\x2', '\x8C', '\x8D', '\a', 'v', '\x2', '\x2', 
		'\x8D', '\x8E', '\a', 't', '\x2', '\x2', '\x8E', '\x8F', '\a', 'w', '\x2', 
		'\x2', '\x8F', '\x96', '\a', 'g', '\x2', '\x2', '\x90', '\x91', '\a', 
		'h', '\x2', '\x2', '\x91', '\x92', '\a', '\x63', '\x2', '\x2', '\x92', 
		'\x93', '\a', 'n', '\x2', '\x2', '\x93', '\x94', '\a', 'u', '\x2', '\x2', 
		'\x94', '\x96', '\a', 'g', '\x2', '\x2', '\x95', '\x8C', '\x3', '\x2', 
		'\x2', '\x2', '\x95', '\x90', '\x3', '\x2', '\x2', '\x2', '\x96', '&', 
		'\x3', '\x2', '\x2', '\x2', '\x97', '\x99', '\x5', '-', '\x17', '\x2', 
		'\x98', '\x97', '\x3', '\x2', '\x2', '\x2', '\x98', '\x99', '\x3', '\x2', 
		'\x2', '\x2', '\x99', '\x9B', '\x3', '\x2', '\x2', '\x2', '\x9A', '\x9C', 
		'\x5', '+', '\x16', '\x2', '\x9B', '\x9A', '\x3', '\x2', '\x2', '\x2', 
		'\x9C', '\x9D', '\x3', '\x2', '\x2', '\x2', '\x9D', '\x9B', '\x3', '\x2', 
		'\x2', '\x2', '\x9D', '\x9E', '\x3', '\x2', '\x2', '\x2', '\x9E', '\xA6', 
		'\x3', '\x2', '\x2', '\x2', '\x9F', '\xA3', '\a', '\x30', '\x2', '\x2', 
		'\xA0', '\xA2', '\x5', '+', '\x16', '\x2', '\xA1', '\xA0', '\x3', '\x2', 
		'\x2', '\x2', '\xA2', '\xA5', '\x3', '\x2', '\x2', '\x2', '\xA3', '\xA1', 
		'\x3', '\x2', '\x2', '\x2', '\xA3', '\xA4', '\x3', '\x2', '\x2', '\x2', 
		'\xA4', '\xA7', '\x3', '\x2', '\x2', '\x2', '\xA5', '\xA3', '\x3', '\x2', 
		'\x2', '\x2', '\xA6', '\x9F', '\x3', '\x2', '\x2', '\x2', '\xA6', '\xA7', 
		'\x3', '\x2', '\x2', '\x2', '\xA7', '(', '\x3', '\x2', '\x2', '\x2', '\xA8', 
		'\xA9', '\t', '\x2', '\x2', '\x2', '\xA9', '*', '\x3', '\x2', '\x2', '\x2', 
		'\xAA', '\xAB', '\t', '\x3', '\x2', '\x2', '\xAB', ',', '\x3', '\x2', 
		'\x2', '\x2', '\xAC', '\xAD', '\t', '\x4', '\x2', '\x2', '\xAD', '.', 
		'\x3', '\x2', '\x2', '\x2', '\xAE', '\xAF', '\a', '-', '\x2', '\x2', '\xAF', 
		'\x30', '\x3', '\x2', '\x2', '\x2', '\xB0', '\xB1', '\a', '/', '\x2', 
		'\x2', '\xB1', '\x32', '\x3', '\x2', '\x2', '\x2', '\xB2', '\xB3', '\a', 
		',', '\x2', '\x2', '\xB3', '\x34', '\x3', '\x2', '\x2', '\x2', '\xB4', 
		'\xB5', '\a', '\x31', '\x2', '\x2', '\xB5', '\x36', '\x3', '\x2', '\x2', 
		'\x2', '\xB6', '\xB7', '\a', '\'', '\x2', '\x2', '\xB7', '\x38', '\x3', 
		'\x2', '\x2', '\x2', '\xB8', '\xB9', '\a', '#', '\x2', '\x2', '\xB9', 
		':', '\x3', '\x2', '\x2', '\x2', '\xBA', '\xBB', '\a', '>', '\x2', '\x2', 
		'\xBB', '<', '\x3', '\x2', '\x2', '\x2', '\xBC', '\xBD', '\a', '>', '\x2', 
		'\x2', '\xBD', '\xBE', '\a', '?', '\x2', '\x2', '\xBE', '>', '\x3', '\x2', 
		'\x2', '\x2', '\xBF', '\xC0', '\a', '@', '\x2', '\x2', '\xC0', '@', '\x3', 
		'\x2', '\x2', '\x2', '\xC1', '\xC2', '\a', '@', '\x2', '\x2', '\xC2', 
		'\xC3', '\a', '?', '\x2', '\x2', '\xC3', '\x42', '\x3', '\x2', '\x2', 
		'\x2', '\xC4', '\xC5', '\a', '?', '\x2', '\x2', '\xC5', '\xC6', '\a', 
		'?', '\x2', '\x2', '\xC6', '\x44', '\x3', '\x2', '\x2', '\x2', '\xC7', 
		'\xC8', '\a', '#', '\x2', '\x2', '\xC8', '\xC9', '\a', '?', '\x2', '\x2', 
		'\xC9', '\x46', '\x3', '\x2', '\x2', '\x2', '\xCA', '\xCB', '\a', '(', 
		'\x2', '\x2', '\xCB', 'H', '\x3', '\x2', '\x2', '\x2', '\xCC', '\xCD', 
		'\a', '~', '\x2', '\x2', '\xCD', 'J', '\x3', '\x2', '\x2', '\x2', '\xCE', 
		'\xCF', '\a', '`', '\x2', '\x2', '\xCF', 'L', '\x3', '\x2', '\x2', '\x2', 
		'\xD0', '\xD1', '\a', '?', '\x2', '\x2', '\xD1', 'N', '\x3', '\x2', '\x2', 
		'\x2', '\xD2', '\xD3', '\a', '{', '\x2', '\x2', '\xD3', '\xD4', '\a', 
		'k', '\x2', '\x2', '\xD4', '\xD5', '\a', 'g', '\x2', '\x2', '\xD5', '\xD6', 
		'\a', 'n', '\x2', '\x2', '\xD6', '\xD7', '\a', '\x66', '\x2', '\x2', '\xD7', 
		'P', '\x3', '\x2', '\x2', '\x2', '\xD8', '\xD9', '\a', 'r', '\x2', '\x2', 
		'\xD9', '\xDA', '\a', '\x63', '\x2', '\x2', '\xDA', '\xDB', '\a', 'w', 
		'\x2', '\x2', '\xDB', '\xDC', '\a', 'u', '\x2', '\x2', '\xDC', '\xDD', 
		'\a', 'g', '\x2', '\x2', '\xDD', 'R', '\x3', '\x2', '\x2', '\x2', '\xDE', 
		'\xE2', '\t', '\x5', '\x2', '\x2', '\xDF', '\xE1', '\t', '\x6', '\x2', 
		'\x2', '\xE0', '\xDF', '\x3', '\x2', '\x2', '\x2', '\xE1', '\xE4', '\x3', 
		'\x2', '\x2', '\x2', '\xE2', '\xE0', '\x3', '\x2', '\x2', '\x2', '\xE2', 
		'\xE3', '\x3', '\x2', '\x2', '\x2', '\xE3', 'T', '\x3', '\x2', '\x2', 
		'\x2', '\xE4', '\xE2', '\x3', '\x2', '\x2', '\x2', '\xE5', '\xE7', '\t', 
		'\a', '\x2', '\x2', '\xE6', '\xE5', '\x3', '\x2', '\x2', '\x2', '\xE7', 
		'\xE8', '\x3', '\x2', '\x2', '\x2', '\xE8', '\xE6', '\x3', '\x2', '\x2', 
		'\x2', '\xE8', '\xE9', '\x3', '\x2', '\x2', '\x2', '\xE9', '\xEA', '\x3', 
		'\x2', '\x2', '\x2', '\xEA', '\xEB', '\b', '+', '\x2', '\x2', '\xEB', 
		'V', '\x3', '\x2', '\x2', '\x2', '\xEC', '\xED', '\a', '\x31', '\x2', 
		'\x2', '\xED', '\xEE', '\a', '\x31', '\x2', '\x2', '\xEE', '\xF2', '\x3', 
		'\x2', '\x2', '\x2', '\xEF', '\xF1', '\n', '\b', '\x2', '\x2', '\xF0', 
		'\xEF', '\x3', '\x2', '\x2', '\x2', '\xF1', '\xF4', '\x3', '\x2', '\x2', 
		'\x2', '\xF2', '\xF0', '\x3', '\x2', '\x2', '\x2', '\xF2', '\xF3', '\x3', 
		'\x2', '\x2', '\x2', '\xF3', '\xF5', '\x3', '\x2', '\x2', '\x2', '\xF4', 
		'\xF2', '\x3', '\x2', '\x2', '\x2', '\xF5', '\xF6', '\b', ',', '\x2', 
		'\x2', '\xF6', 'X', '\x3', '\x2', '\x2', '\x2', '\xF7', '\xF8', '\a', 
		'\x31', '\x2', '\x2', '\xF8', '\xF9', '\a', ',', '\x2', '\x2', '\xF9', 
		'\xFD', '\x3', '\x2', '\x2', '\x2', '\xFA', '\xFC', '\v', '\x2', '\x2', 
		'\x2', '\xFB', '\xFA', '\x3', '\x2', '\x2', '\x2', '\xFC', '\xFF', '\x3', 
		'\x2', '\x2', '\x2', '\xFD', '\xFE', '\x3', '\x2', '\x2', '\x2', '\xFD', 
		'\xFB', '\x3', '\x2', '\x2', '\x2', '\xFE', '\x100', '\x3', '\x2', '\x2', 
		'\x2', '\xFF', '\xFD', '\x3', '\x2', '\x2', '\x2', '\x100', '\x101', '\a', 
		',', '\x2', '\x2', '\x101', '\x102', '\a', '\x31', '\x2', '\x2', '\x102', 
		'\x103', '\x3', '\x2', '\x2', '\x2', '\x103', '\x104', '\b', '-', '\x2', 
		'\x2', '\x104', 'Z', '\x3', '\x2', '\x2', '\x2', '\f', '\x2', '\x95', 
		'\x98', '\x9D', '\xA3', '\xA6', '\xE2', '\xE8', '\xF2', '\xFD', '\x3', 
		'\b', '\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
