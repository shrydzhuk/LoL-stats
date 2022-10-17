namespace LoL.Stats.Riot.Api.Exceptions
{
    [Serializable]
    public class RiotException : ApplicationException
    {
        public RiotException(string message)
            : this(message, null)
        {

        }

        public RiotException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
