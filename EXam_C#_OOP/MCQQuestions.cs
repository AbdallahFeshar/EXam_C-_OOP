using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXam_C__OOP
{
    internal class MCQQuestions : QuestionBase
    {
        public override string Header { get; } 
        public MCQQuestions(string _body = "", double _marks = 0) : base(_body, _marks)
        {
            AnswerList = new Answers[3];
        }
        public override string ToString()
        {
            return $"{Header}Marks({Marks})\n" +
                $" {Body}\n" +
                   $"1.{AnswerList[0].AnswerText}\t" +
                   $" 2.{AnswerList[1].AnswerText} \t" +
                   $" {AnswerList[2].AnswerText}";
        }
        public static MCQQuestions AddMCQQuestion()
        {
            MCQQuestions question = new MCQQuestions();
            Console.WriteLine(question.Header);
            Console.WriteLine("Body Of Question:");
            question.Body = Console.ReadLine();
            Console.WriteLine(" Marks Of Question:");
            question.Marks = double.Parse(Console.ReadLine());

            for (int i = 0; i < question.AnswerList?.Length; i++)
            {
                question.AnswerList[i] = new Answers();
                Console.WriteLine($" Number of Choice  {i + 1}");
                question.AnswerList[i].AnswerText = Console.ReadLine();
                question.AnswerList[i].AnswerId = i + 1;
            }
            question.RightAnswer = new Answers();
            string answer = "";
            do
            {
                Console.WriteLine($"Correct Answer For the Question");
                answer = Console.ReadLine();
            } while (!(answer is string));
            question.RightAnswer.AnswerText = answer;
            return question;
        }
    }
}
