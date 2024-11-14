using System.Net;
using System.Numerics;
using System.Reflection;
using System.Xml.Linq;

namespace Lesson04.MVC.Models
{
    public class DataLocal
    {
        public static List<People> people = new List<People>
        {
            new People()
            {
                Id = 1,
                Name = "Phantom",
                Email = "Phantom@gmail.com",
                Phone = "0987656432",
                Address = "Pháp",
                Avatar = "Image/Avatar/Anh 1.jpg",
                Bio = "Phantom là nước hoa siêu thơm đến từ pháp",
                Birthday = new DateTime(1986 / 4 / 7),
                Gender = 1
            },
            new People()
            {
                Id = 2,
                Name = "Delina",
                Email = "Delina@gmail.com",
                Phone = "0987656432",
                Address = "Pháp",
                Avatar = "Image/Avatar/Anh 2.jpg",
                Bio = "Delina là nước hoa siêu thơm đến từ pháp",
                Birthday = new DateTime(1986 / 4 / 7),
                Gender = 1
            },
            new People()
            {
                Id = 3,
                Name = "Black Opium",
                Email = "Opium@gmail.com",
                Phone = "0987656432",
                Address = "Anh",
                Avatar = "Image/Avatar/Anh 3.jpg",
                Bio = "Black Opium là nước hoa siêu thơm đến từ Anh",
                Birthday = new DateTime(1986 / 4 / 7),
                Gender = 1
            },
            new People()
            {
                Id = 4,
                Name = "YSL Libre",
                Email = "Ysl@gmail.com",
                Phone = "0987656432",
                Address = "Ý",
                Avatar = "Image/Avatar/Anh 4.jpg",
                Bio = "YSL là nước hoa siêu thơm đến từ Ý",
                Birthday = new DateTime(1986 / 4 / 7),
                Gender = 1
            },
            new People()
            {
                Id = 5,
                Name = "Tomford Tabaco",
                Email = "Tabaco@gmail.com",
                Phone = "0987656432",
                Address = "Pháp",
                Avatar = "Image/Avatar/Anh 5.jpg",
                Bio = "Tomford là nước hoa siêu thơm đến từ pháp",
                Birthday = new DateTime(1986 / 4 / 7),
                Gender = 1
            },
            new People()
            {
                Id = 6,
                Name = "Acqua di Gio",
                Email = "Acqua@gmail.com",
                Phone = "0987656432",
                Address = "Bồ Đào Nha",
                Avatar = "Image/Avatar/Anh 2.jpg",
                Bio = "Acqua là nước hoa siêu thơm đến từ Bồ Đào Nha",
                Birthday = new DateTime(1986 / 4 / 7),
                Gender = 1
            },
        };
        public static List<People> GetPeoples()
        {
            return people;
        }
        public static People? GetPeopleById(int Id)
        {
            var people = GetPeoples().FirstOrDefault(x => x.Id == Id);
            return people;
        }

    }
}