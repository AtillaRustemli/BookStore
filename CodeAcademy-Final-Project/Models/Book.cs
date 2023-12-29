namespace CodeAcademy_Final_Project.Models
{
    public class Book:BookBase
    {
        public Book() : base() { }
        public double  Height { get; set; }
        public double  Length { get; set; }
        public double  Width { get; set; }

    }
}
