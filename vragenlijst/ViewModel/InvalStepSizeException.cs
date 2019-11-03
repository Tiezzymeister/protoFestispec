using System;
using System.Runtime.Serialization;

namespace vragenlijst.ViewModel
{
    [Serializable]
    internal class InvalStepSizeException : Exception
    {
        public InvalStepSizeException()
        {
        }

        public InvalStepSizeException(string message) : base(message)
        {
        }

        public InvalStepSizeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalStepSizeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}