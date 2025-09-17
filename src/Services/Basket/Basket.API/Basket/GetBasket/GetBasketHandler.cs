
namespace Basket.API.Basket.GetBasket
{
    public record GetBsketQuery(string UserName) : IQuery<GetBasketResult>;
    public record GetBasketResult(ShoppingCart cart);

    internal class GetBasketQueryHandler : IQueryHandler<GetBsketQuery, GetBasketResult>
    {
        public async Task<GetBasketResult> Handle(GetBsketQuery request, CancellationToken cancellationToken)
        {

            throw new NotImplementedException();
        }
    }
}
