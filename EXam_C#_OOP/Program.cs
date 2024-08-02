using System.Diagnostics;

namespace EXam_C__OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject(20, "C#");
            subject.CreateExam();
            Console.Clear();
            Console.WriteLine("Do You Want To Take the Exam now ? (Y|N)");
            if (char.Parse(Console.ReadLine()) == 'Y')
            {
                Stopwatch s = new Stopwatch();
                s.Start();
                subject.SubExam.ShowExam();
                s.Stop();
                Console.WriteLine($"the Elapsed Time ={s.Elapsed}");
            }
        }
    }
}
