namespace BookManager.Domain.Interfaces.Cache
{
    public interface ICache // Probably I'll not use this interface no more
    {
        string LoadBook(int bookId);
    }
}