﻿namespace CodeAcademy_Final_Project.Models
{
    public class Genre:BaseEntity
    {
        public string Name { get; set; }
        public List<BookGenre> BookGenre { get; set; }
    }
}
