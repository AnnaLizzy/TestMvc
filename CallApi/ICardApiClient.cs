
using ViewModel.Card;

namespace CallApi
{
    public interface ICardApiClient
    {
        Task<int> Create(CardViewModel request);
    }
}