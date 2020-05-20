using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON_LV7
{
    class Program
    {
        static void Main(string[] args)
        {


            /*              1. zadatak 
            NumberSequence numberSequence1 = new NumberSequence(new double[] { 9.5, 5.6, 7.8, 5.2, 7.7, 1.2, 1.6, 2.9, 3.7, 4.1});
            NumberSequence numberSequence2 = new NumberSequence(new double[] { 9.5, 5.6, 7.8, 5.2, 7.7, 1.2, 1.6, 2.9, 3.7, 4.1 });
            NumberSequence numberSequence3 = new NumberSequence(new double[] { 9.5, 5.6, 7.8, 5.2, 7.7, 1.2, 1.6, 2.9, 3.7, 4.1 });


            Console.WriteLine(" Bubble sort: \n" + numberSequence1.ToString());
            numberSequence1.SetSortStrategy(new BubbleSort());
            numberSequence1.Sort();
            Console.WriteLine(numberSequence1.ToString());

            Console.WriteLine(" Sequential sort: \n" + numberSequence2.ToString());
            numberSequence2.SetSortStrategy(new SequentialSort());
            numberSequence2.Sort();
            Console.WriteLine(numberSequence2.ToString());

            Console.WriteLine(" Comb sort: \n" + numberSequence3.ToString());
            numberSequence3.SetSortStrategy(new CombSort());
            numberSequence3.Sort();
            Console.WriteLine(numberSequence3.ToString());
            */







            /*          2. zadatak
            NumberSequence numberSequence = new NumberSequence(new double[] { 9.5, 5.6, 7.8, 5.2, 7.7, 1.2, 1.6, 2.9, 3.7, 4.1 });
            numberSequence.SetSearchStrategy(new LinearSearch());
            Console.WriteLine(numberSequence.Search(7.8));
            Console.WriteLine(numberSequence.Search(1.1));
            */





            /*          3. i 4. zadatak
            SystemDataProvider systemDataProvider = new SystemDataProvider();
            ConsoleLogger consoleLogger = new ConsoleLogger();
            systemDataProvider.Attach(consoleLogger);

            while (true)
            {
                systemDataProvider.GetAvailableRAM();
                systemDataProvider.GetCPULoad();
                System.Threading.Thread.Sleep(1000);
            }
            */





            BuyVisitor buyVisitor = new BuyVisitor();
            Book book = new Book("The Chronicles of Narnia", 50);
            VHS vHS = new VHS("The Chronicles of Narnia", 60);
            DVD dVD = new DVD("Windows 7", DVDType.SOFTWARE, 100);

            Console.WriteLine(book.Accept(buyVisitor)+ ", " + vHS.Accept(buyVisitor) + ", " + dVD.Accept(buyVisitor));
            
;

        }
    }
}
