
namespace Basket.API.Basket.GetBasket
{
    public record GetBsketQuery(string UserName) : IQuery<GetBasketResult>;
    public record GetBasketResult(ShoppingCart Cart);

    internal class GetBasketQueryHandler(IBasketRepository repository) : IQueryHandler<GetBsketQuery, GetBasketResult>
    {
        public async Task<GetBasketResult> Handle(GetBsketQuery request, CancellationToken cancellationToken)
        {
            var basket = await repository.GetBasket(request.UserName, cancellationToken);

            return new GetBasketResult(basket);
        }
    }
}
