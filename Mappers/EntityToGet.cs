using movies.Entities;
using movies.Models;

namespace movies.Mappers
{
    public static class EntityToGet
    {
        public static GetGenre ToGetObject(this Genre genre)
            => new GetGenre() 
            {
                Id = genre.Id,
                Name = genre.Name
            };
        public static GetActor ToGetObject(this Actor actor)
            => new GetActor()
            {
                Id = actor.Id,
                Fullname = actor.Fullname,
                Birthdate = actor.Birthdate
            };
        public static GetMovie ToGetObject(this Movie movie)
            => new GetMovie()
            {
                Id = movie.Id,
                Title = movie.Title,
                Description = movie.Description,
                Rating = movie.Rating,
                ReleaseDate = movie.ReleaseDate
            };
    }
}