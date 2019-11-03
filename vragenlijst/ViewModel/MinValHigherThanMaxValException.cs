using System;
using System.Runtime.Serialization;

namespace vragenlijst.ViewModel
{
    [Serializable]
    internal class MinValHigherThanMaxValException : Exception
    {
        public MinValHigherThanMaxValException()
        {
        }

        public MinValHigherThanMaxValException(string message) : base(message)
        {
        }

        public MinValHigherThanMaxValException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MinValHigherThanMaxValException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}