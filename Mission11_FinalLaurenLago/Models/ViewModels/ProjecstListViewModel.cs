namespace Mission11_FinalLaurenLago.Models.ViewModels
{
    public class ProjecstListViewModel
    {
        public IQueryable<Book> Books { get; set; }
        
        public PaginationInfo PaginationInfo { get; set; } = new PaginationInfo();
    }
}
