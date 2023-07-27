namespace sevDesk.Api
{
    public class SevDeskServiceOptionsBuilder
    {
        private readonly SevDeskServiceOptions _options = new SevDeskServiceOptions();
        public SevDeskServiceOptionsBuilder UseToken(string token)
        {
            _options.Token = token;
            return this;
        }

        internal SevDeskServiceOptions Build()
        {
            return _options;
        }
    }
}
