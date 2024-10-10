namespace Home_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Ortalam = 98;
            if (Ortalam < 65)
            {
                Console.WriteLine("Kesildin");
            }
            else if (Ortalam>=65 && Ortalam < 85)
            {
                Console.WriteLine("Diplom");

            } 
            else if (Ortalam>=85 && Ortalam < 95)
            {
                Console.WriteLine("Şeref Diplomu");
            }
            else
            {
                Console.WriteLine("Yuksek Şeref Diplomu");
            }

        }
    }
}
