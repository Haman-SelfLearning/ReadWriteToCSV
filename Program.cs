using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQtoCSV;

namespace ReadWriteToCSV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ReadFromFile();
            WriteToFile();
            Console.ReadKey();
        }


        static void ReadFromFile()
        {
            var csvFileDescription = new CsvFileDescription()
            {
                FirstLineHasColumnNames = true,
                IgnoreUnknownColumns = true,
                SeparatorChar = ',',
                UseFieldIndexForReadingData = false,

            };

            var csvContent = new CsvContext();
            var data =csvContent.Read<Deniro>("deniro.csv", csvFileDescription);
            foreach (var item in data)
            {
                Console.WriteLine($"{item.Year} \t {item.Score} \t {item.Title} ");
            }
        }

        static void WriteToFile()
        {

            var csvFileDescription = new CsvFileDescription()
            {
                FirstLineHasColumnNames = true,
                SeparatorChar = ',',

            };
            var csvContent = new CsvContext();
            var deniroMovie = new List<Deniro>()
            {
                new Deniro
                {
                    Score = "94",
                    Title = "Scarface",
                    Year = "1974"
                },
                new Deniro
                {
                    Score = "84",
                    Title = "Badday",
                    Year = "2004"
                },
            };
            csvContent.Write(deniroMovie,"DeniroFilms.csv",csvFileDescription);
            Console.WriteLine("New File Created");
        }
    }
}
