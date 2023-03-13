using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;



namespace B3
{
    class Firma
    {
       public string Name { get; set; }
       public string Adress { get; set; }
       public int Year { get; set; }
        public Firma(string name, string adress, int year) 
        {
            Name = name;
            Adress = adress;
            Year = year;
        }
    }
    internal class Program 
    {
        static void Main(string[] args)
        {

            Firma firma = new Firma("Kuskus", "molodezhnaya", 2005);

            // Выводим информацию об изделии
            Console.WriteLine("Name: " + firma.Name);
            Console.WriteLine("Adress: " + firma.Adress);
            Console.WriteLine("Year: " + firma.Year);
            Console.ReadKey();
        }
    }
}