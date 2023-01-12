using BookManager.Domain.Interfaces.Repository;
using BookManager.Domain.Models;

namespace BookManager.Infrastructure.Repository
{
    public class BookRepository : IBookRepository
    {
        private List<Book> _books = new List<Book>()
        {
            new Book() { Id = 1, Genre = "Fiction", Title = "StarWars", Author = "George Lucas" },
            new Book() { Id = 2, Genre = "Fiction", Title = "SpiderMan", Author = "Stan Lee" },
            new Book() { Id = 3, Genre = "Fiction", Title = "Vida", Author = "Eu" }
        };

        public void DeleteBookbyId(int id)
        {
            //_books.RemoveAt(id);
            var search = GetBookbyId(id);
            
        }

        public List<Book> GetAllBooks()
        {
            return _books.ToList();
        }

        public Book GetBookbyId(int id)
        {
            return _books.Where(_ => _.Id == id).FirstOrDefault();
        }

        public void IncludeNewBook(Book book)
        {
             _books.Add(book);
        }
    }
}