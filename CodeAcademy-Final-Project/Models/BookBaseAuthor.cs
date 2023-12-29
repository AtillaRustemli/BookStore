﻿namespace CodeAcademy_Final_Project.Models
{
    public class BookBaseAuthor:BaseEntity
    {
        public int? BookBaseId { get; set; }
        public Book Book { get; set; }
        public EBook EBook { get; set; }
        public ABook ABook { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public int TypeId { get; set; }
    }
}