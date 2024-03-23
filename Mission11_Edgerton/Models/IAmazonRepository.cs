namespace Mission11_Edgerton.Models
{
    public interface IAmazonRepository
    {
        public IQueryable<Book> Books { get; }
    }
}
