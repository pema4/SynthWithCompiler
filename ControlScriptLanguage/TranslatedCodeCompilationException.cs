using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ControlScriptLanguage
{
    [Serializable]
    public class TranslatedCodeCompilationException : Exception
    {
        public IEnumerable<string> Errors { get; internal set; }

        public TranslatedCodeCompilationException()
        {
        }

        public TranslatedCodeCompilationException(string message) : base(message)
        {
        }

        public TranslatedCodeCompilationException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected TranslatedCodeCompilationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}