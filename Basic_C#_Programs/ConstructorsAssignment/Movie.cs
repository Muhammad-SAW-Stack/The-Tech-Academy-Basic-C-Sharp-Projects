using System;

namespace ConsoleApp
{
    
    class Movie
    {
        // Creates a public const variable for the minimum length of a movie in minutes as defined by the Screen Actors Guild and The Academy of Motion Picture Arts and Sciences.
        public const int MinLength1 = 60;
        public const int MinLength2 = 40;
        // Declares the movie's title.
        public string Title { get; set; }
        // Declares the movie's director.
        public string Director { get; set; }
        // Declares the movies length in minutes.
        public int Length { get; set; }
        // Creates the first constuctor with two parameters, title and director. 
        public Movie(string title, string director)
        {
            Title = title;
            Director = director;
        }
        // Creates the second constructor with three parameters, title, director, and length.
        public Movie(string title, string director, int length) : this(title, director)
        {
            Length = length;
        }
    }
}   