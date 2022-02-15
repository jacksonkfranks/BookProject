using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookProject.Models
{
    public class EFBookProjectRepository : IBookProjectRepository
    {
        private BookProjectContext context { get; set; }

        public EFBookProjectRepository (BookProjectContext temp)
        {
            context = temp;
        }
        public IQueryable<Book> Books => context.Books;
    }
}
