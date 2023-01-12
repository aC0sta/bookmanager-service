using BookManager.Domain.Models;

namespace BookManager.Domain.Interfaces.Repository
{
    public interface IBookRepository
    {
        /// <summary>
        /// Brings the book by its id
        /// </summary>
        /// <param name="id">Book id</param>
        /// <returns></returns>
        Book GetBookbyId(int id);

        /// <summary>
        /// Brings all the stored books
        /// </summary>
        /// <returns></returns>
        List<Book> GetAllBooks();

        /// <summary>
        /// Includes a new book to the repository
        /// </summary>
        /// <param name="book">The book info</param>
        void IncludeNewBook(Book book);

        /// <summary>
        /// Removes the book by its id
        /// </summary>
        /// <param name="id">Book id</param>
        void DeleteBookbyId(int id);
    }
}