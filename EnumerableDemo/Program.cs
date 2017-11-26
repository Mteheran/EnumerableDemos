using System;
using System.Collections.Generic;
using System.Linq;

namespace EnumerableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> lmovies = new List<Movie>();
            lmovies.Add(new Movie() { Tittle = "Titanic", Genre = "Drama", Year = 1998 });
            lmovies.Add(new Movie() { Tittle = "Avengers", Genre = "Action", Year = 2012 });
            lmovies.Add(new Movie() { Tittle = "Annabelle", Genre = "Terror", Year = 2014 });


            //Get the max value on the list by a numeric field
            var maxmovie = Enumerable.Max<Movie>(lmovies, c => c.Year);
            Console.WriteLine("Demo Max");
            Console.WriteLine(maxmovie);

            //Get the min value on the list by a numeric field
            var minmovie = Enumerable.Min<Movie>(lmovies, c => c.Year);
            Console.WriteLine("Demo Min");
            Console.WriteLine(minmovie);

            // create N numbers of copy of an object 
            var listmovies = Enumerable.Repeat<Movie>(new Movie() {  Tittle = "Movie Example" }, 5);
            Console.WriteLine("Demo Repeat");
          
            foreach (var item in listmovies)            
                Console.WriteLine(item.Tittle); 
            

            // sum a collections of numbers on a field
            var sumMovie = Enumerable.Sum<Movie>(lmovies, c => c.Year);
            Console.WriteLine("Demo Sum");
            Console.WriteLine(sumMovie);

            // mix 2 colecction of the same type in only one collection 
            var lstconcat = Enumerable.Concat<Movie>(lmovies, listmovies);
            Console.WriteLine("Demo Concat");

            foreach (var item in lstconcat)            
                Console.WriteLine(item.Tittle);


            // caculate an average from a collection of numbers
            var averageMovie = Enumerable.Average<Movie>(lmovies, c => c.Year);
            Console.WriteLine("Demo Average");
            Console.WriteLine(averageMovie);

            
            //return a list except the elements on the exception
            var lstExcept = Enumerable.Except<Movie>(lstconcat, listmovies);
            Console.WriteLine("Demo Except");
            foreach (var item in lstExcept)
                Console.WriteLine(item.Tittle);


            Console.ReadLine();
        }
    }
}
