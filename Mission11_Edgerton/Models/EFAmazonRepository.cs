
namespace Mission11_Edgerton.Models
{
    public class EFAmazonRepository : IAmazonRepository
    {
        private AmazonContext _context;
        public EFAmazonRepository(AmazonContext temp) 
        {
            _context = temp;
        }
        public IQueryable<Book> Books =>  _context.Books;
    }
}
//I dont know what this file is and I don't know where it came from and I don't know what the little symbol on it means. No clue where it came from