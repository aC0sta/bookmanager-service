namespace BookManager.Domain.Interfaces.Services
{
    public interface IBookManagerService
    {
        /// <summary>
        /// Loads a book from the repository
        /// </summary>
        /// <param name="bookId"></param>
        /// <returns>The book name</returns>
        void LoadBookbyId(int bookId);
    }
}