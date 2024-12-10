using System.Text;

namespace Home_Work_10._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;

            bool exit = true;

            StringBuilder sbuilderResult = new StringBuilder();
            while (exit)
            {
                Console.Write("Заголовок: ");
                string headline = Console.ReadLine();

                DateTime data = DateTime.UtcNow;


                sbuilderResult.AppendLine($"Дата: {data:dd.MM.yyy} Година: {data:HH:mm}");
                sbuilderResult.AppendLine($"Заголовок: {headline}");
                sbuilderResult.AppendLine();

                Console.WriteLine("Якщо хочете вийти натисніть на 1, якщо хочете продовжити нажміть 2");
                int inputExit = Convert.ToInt32(Console.ReadLine());

                if(inputExit == 1)
                {
                    exit = false;
                }
                else if(inputExit == 2)
                {
                    continue;
                }
            }

            Console.WriteLine($"Резуьтат: \n{sbuilderResult.ToString()}");
        }
    }
}
