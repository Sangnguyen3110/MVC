using Microsoft.AspNetCore.Mvc.Rendering;

namespace NetCoreMVCLab03.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public int GenresId { get; set; }
        public string Image { get; set; }
        public int Price { get; set; }
        public float TotalPage { get; set; }
        public string Sumary { get; set; }
        public List<Book> GetBookList()
        {
            List<Book> books = new List<Book>()
            {
                new Book()
                {
                    Id = 1,
                    Title = "Sang",
                    AuthorId = 1,
                    GenresId = 1,
                    Image="",
                    Price = 500000,
                    Sumary = "",
                    TotalPage = 250
                },
                 new Book()
                {
                    Id = 2,
                    Title = "Sang",
                    AuthorId = 1,
                    GenresId = 1,
                    Image="",
                    Price = 500000,
                    Sumary = "",
                    TotalPage = 250
                },
                  new Book()
                {
                    Id = 3,
                    Title = "Sang",
                    AuthorId = 1,
                    GenresId = 1,
                    Image="",
                    Price = 500000,
                    Sumary = "",
                    TotalPage = 250
                },
                   new Book()
                {
                    Id = 4,
                    Title = "Sang",
                    AuthorId = 1,
                    Genres  Id = 1,
                    Image="",
                    Price = 500000,
                    Sumary = "",
                    TotalPage = 250
                },

            };
            return books;
        }
        public Book GetBookById(int id)
        {
            Book book = this.GetBookList().FirstOrDefault(b => b.Id == id);
            return book;
        }
        public List<SelectListItem> Authors { get; } = new List<SelectListItem>
        {
            new SelectListItem{Value="1", Text="Nam Cao"},
            new SelectListItem{Value="2", Text="Nam Cam"},
            new SelectListItem{Value="3", Text="Viet Nam"},
            new SelectListItem{Value="4", Text="Trung Quoc"},
        };
        public List<SelectListItem> Genres { get; } = new List<SelectListItem>
        {
            new SelectListItem{Value="1", Text="Nam Cao"},
            new SelectListItem{Value="2", Text="Nam Cam"},
            new SelectListItem{Value="3", Text="Viet Nam"},
            new SelectListItem{Value="4", Text="Trung Quoc"},
        };

    }
}
