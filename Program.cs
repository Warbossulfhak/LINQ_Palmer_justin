using LINQ_Palmer_justin;
using System.Linq;
using System.Net.Sockets;
using System.Reflection.Metadata;

namespace LINQ_Palmer_Justin
{
    internal class Program
    {
        static void Main(string[] args)
        {//array of games called games
            Games[] games = new Games[]
            {   // 10 games writing queries on collection types 
                new Games("Minecraft", 'E', "Action-Adventure"),
                new Games("CS:GO", 'E', "FPS"),
                new Games("Elden Ring", 'M', "Action-Adventure"),
                new Games("Valorant", 'T', "FPS"),
                new Games("Halo 3", 'M', "Action FPS"),
                new Games("ZombCube", 'E', "FPS Survival"),
                new Games("Magnet Destroyer", 'E', "Hyper-Casual"),
                new Games("Paddle Balls", 'E', "Arcede Casual"),
                new Games("Rocket League", 'E', "Action Racing"),
                new Games("Fifa 22", 'E', "Sport"),
            };
            // store the result in an implcity typed variable using the keyword var the from operator declares a range variable only used in query syntax
            // the where operator is used to select certain elements from a sequence 
            // the select determines what is returned for each element in the resuting query 
            var shortGames = from game in games
                             where game.Title.Length < 9
                             select $"Game Title: {game.Title.ToUpper()}";

            //foreach loop to iterate over the result of an executed LINQ query 
            foreach(var game in shortGames)
            {
                Console.WriteLine(game);
            }
            // games array write query method method query to find the game prints all the properties Esrb out and genre
            var mineCraft = games.Where(game => game.Title == "Minecraft")
                             .Select(game => $"Title: {game.Title}, ESRB: {game.Esrb}, Genre: {game.Genre}");
            //prints out that first thing that was stored variable
            Console.WriteLine(mineCraft.FirstOrDefault());

            var tRated = from game in games
                         where game.Esrb == 'T'
                         select game.Title;
            //prints to the console T Rated Games foreach loop var variable
            Console.WriteLine("T Rated Games:");
            foreach(var game in tRated)
            {
                Console.WriteLine(game);
            }
            // store the result in an implcity typed variable using the keyword var the from operator from game in games 
            var eRatedAction = from game in games
                               where game.Esrb == 'E' && game.Genre.Contains("Action")
                               select game.Title;
            //prints to the console T Rated Gamesforeach loop var variable
            Console.WriteLine("T Rated Games:");
            foreach (var game in eRatedAction)
            {
                Console.WriteLine(game);
            }
        }                    
    }
}