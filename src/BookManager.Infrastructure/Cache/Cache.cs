using BookManager.Domain.Interfaces.Cache;

namespace BookManager.Infrastructure.Cache
{
    public class Cache : ICache // Probably I'll not use this class no more
    {
        public string LoadBook(int bookId)
        {
            throw new NotImplementedException();
        }
    }
}
