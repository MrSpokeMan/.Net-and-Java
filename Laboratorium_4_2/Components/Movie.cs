using System;
using System.ComponentModel.DataAnnotations;

namespace Laboratorium_4_2.Components
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public string? Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime? RelaseDate { get; set; }
        public float? Rate { get; set; }
    }
}
