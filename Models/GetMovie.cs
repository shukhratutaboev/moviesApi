using System;

namespace movies.Models
{
    public class GetMovie
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Rating { get; set; }
        public DateTimeOffset ReleaseDate { get; set; }
    }
}