using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var videoGames = new List<string>() {"Forza", "Apex","COD", "Madden" };

            videoGames.OrderBy(x => x.Length).ToList().ForEach(Console.WriteLine);
           
            
        }
    }
}
