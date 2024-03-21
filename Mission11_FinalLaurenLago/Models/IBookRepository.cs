namespace Mission11_FinalLaurenLago.Models
{
    public interface IBookRepository
    {
        public IQueryable<Book> Books { get; }
    }
}
