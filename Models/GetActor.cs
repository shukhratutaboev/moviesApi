using System;

namespace movies.Models
{
    public class GetActor
    {
        public Guid Id { get; set; }
        public string Fullname { get; set; }
        public DateTimeOffset Birthdate { get; set; }
    }
}