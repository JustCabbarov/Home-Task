using System.ComponentModel.Design;

namespace Home_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            for (int i =1; i <=100; i++)
            {
                 if (i % 15 == 0)
                {
                    Console.WriteLine("Bolunur " +i );
                } 
            }
        }
    }
}
