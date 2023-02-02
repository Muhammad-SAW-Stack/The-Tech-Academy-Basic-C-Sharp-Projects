using ConsoleApp;
using System;

class Program
{
        static void Main(string[] args)
        {
            // Declares a variable using the "new" keyword. 
            var movie = new Movie("A Clockwork Orange", "Stanley Kubrick", 136);
            // Prints to the screen "The Academy of Motion Picture Arts and Sciences defines a feature as a film that runs for more than: 'Movie.MinLength2' minutes".
            Console.WriteLine("The Academy of Motion Picture Arts and Sciences defines a feature as a film that runs for more than: " + Movie.MinLength2 + " minutes");
            // Prints to the screen "However, the Screen Actors Guild asserts that a feature's running time is:  'Movie.MinLength1' minutes".
            Console.WriteLine("However, the Screen Actors Guild asserts that a feature's running time is: " + Movie.MinLength1 + " minutes");
            // Prints to the screen the movie title.
            Console.WriteLine("Title: " + movie.Title);
            // Prints to the screen the movie director.
            Console.WriteLine("Director: " + movie.Director);
            // Prints to the screen the movie length.
            Console.WriteLine("Length: " + movie.Length + " minutes");
            // Keeps the window from closing.
            Console.ReadLine();
        }

}
