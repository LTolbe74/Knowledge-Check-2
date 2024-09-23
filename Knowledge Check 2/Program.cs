using System.Drawing;
using System.Runtime.InteropServices;

namespace Knowledge_Check_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many records do you want to add? ");
            
            var numberOfRecords = int.Parse(Console.ReadLine());
            
            var recordList = new List<Shoe>();
            for (int i = 0; i < numberOfRecords; i++)
            {
                // In this loop, populate the object's properties using Console.ReadLine()
                var shoe = new Shoe();

                Console.WriteLine("Enter the name brand of shoe you would like to purchase. ");
                shoe.Name = Console.ReadLine();
               

                Console.WriteLine("Enter the color of shoe. ");
                shoe.Color = Console.ReadLine();
              

                Console.WriteLine("Enter the price of the shoe. ");
                shoe.Price = Decimal.Parse(Console.ReadLine());
               

                Console.WriteLine("Enter the quantity you would like to purchase.");
                shoe.Quantity =  int.Parse(Console.ReadLine());

                Console.WriteLine("Enter your shoe size.");
                shoe.Size = int.Parse(Console.ReadLine());


                recordList.Add(shoe);
                
                
            }
            foreach (var item in recordList)
            {
                Console.WriteLine(item);
            }
            // Print out the list of records using Console.WriteLine()

        }
    }
}
