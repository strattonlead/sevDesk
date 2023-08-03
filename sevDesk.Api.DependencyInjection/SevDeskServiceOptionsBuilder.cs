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

        /// <summary>
        /// de ist standard. 
        /// </summary>
        /// <param name="countryCode"></param>
        /// <returns></returns>
        public SevDeskServiceOptionsBuilder UseSourceCountry(string countryCode)
        {
            _options.SourceCountry = countryCode;
            return this;
        }

        internal SevDeskServiceOptions Build()
        {
            return _options;
        }
    }
}
