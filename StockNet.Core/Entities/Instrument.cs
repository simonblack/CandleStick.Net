using StockNet.Core.Abstracts;
using StockNet.Core.ValueObjects;

namespace StockNet.Core.Entities
{
    public class Instrument : Entity
    {
        private readonly long _agahId;
        private readonly long _tsetId;
        private readonly Isin _isin;
        private readonly string _symbol;
        private readonly string _companyName;

        public long AgahId => _agahId;
        public long TsetId => _tsetId;
        public Isin Isin => _isin;
        public string Symbol => _symbol;
        public string CompanyName => _companyName;

        public Instrument(long agahId, long tsetId, string isin, string symbol, string companyName){
            _isin = new Isin(isin);
            _agahId = agahId;
            _tsetId = tsetId;
            _symbol = symbol;
            _companyName = companyName;
        }
    }
}
