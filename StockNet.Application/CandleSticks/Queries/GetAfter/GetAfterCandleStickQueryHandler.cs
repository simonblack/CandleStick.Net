using System.Threading;
using System.Threading.Tasks;
using StockNet.Application.Common.Interfaces;

namespace StockNet.Application.CandleSticks.Queries.GetAfter
{
    public class GetAfterCandleStickQueryHandler : IQueryHandler<GetAfterCandleStickQuery, GetAfterCandleStickQueryResult>
    {
        private readonly ICandleStickRepository _repository;

        public GetAfterCandleStickQueryHandler(ICandleStickRepository repository){
            _repository = repository;
        }

        public async Task<GetAfterCandleStickQueryResult> Handle(GetAfterCandleStickQuery query, CancellationToken cancellationToken)
        {
            var result = GetAfterCandleStickQueryResult.Create();

            result.CandleSticks = await _repository.GetCandlesAfter(query, cancellationToken);

            return result;
        }
    }
}
