using BookManager.Domain.Interfaces.Cache;
using BookManager.Domain.Interfaces.Repository;
using BookManager.Domain.Interfaces.Services;

namespace BookManager.Service
{
    public class BookManagerService : IBookManagerService
    {
        private readonly ICache _cache;
        private readonly IBookRepository _bookRepository;

        public BookManagerService(ICache bookManager, IBookRepository bookRepository)
        {
            _cache = bookManager;
            _bookRepository = bookRepository;
        }

        public void LoadBookbyId(int bookId)
        {
            _bookRepository.GetBookbyId(bookId);
        }
    }
}