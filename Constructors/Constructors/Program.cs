using System;
using System.Collections.Generic;

namespace QuizApp
{
    public class QuizVraag
    {
        public string Vraag { get; set; }
        public string Antwoord { get; set; }

        public QuizVraag(string vraag, string antwoord)
        {
            Vraag = vraag;
            Antwoord = antwoord;
        }
    }

    public class QuizVraagAntwoord
    {
        public string Vraag { get; set; }
        public string CorrectAntwoord { get; set; }

        public QuizVraagAntwoord(string vraag, string correctAntwoord)
        {
            Vraag = vraag;
            CorrectAntwoord = correctAntwoord;
        }

        public bool IsAntwoordGoed(string antwoord)
        {
            return antwoord.Equals(CorrectAntwoord, StringComparison.OrdinalIgnoreCase);
        }
    }

    public class Quiz
    {
        private List<QuizVraag> vragen = new List<QuizVraag>();
        private List<string> ingevuldeAntwoorden;

        public void VoegVraagToe(string vraag, string antwoord)
        {
            vragen.Add(new QuizVraag(vraag, antwoord));
        }

        public void StartQuiz()
        {
            ingevuldeAntwoorden = new List<string>(vragen.Count);
            foreach (var quizVraag in vragen)
            {
                StelVraag(quizVraag);
            }
            BerekenScore();
        }

        private void StelVraag(QuizVraag quizVraag)
        {
            Console.WriteLine(quizVraag.Vraag);
            string antwoord = Console.ReadLine();
            ingevuldeAntwoorden.Add(antwoord);

            var quizVraagAntwoord = new QuizVraagAntwoord(quizVraag.Vraag, quizVraag.Antwoord);
            bool isCorrect = quizVraagAntwoord.IsAntwoordGoed(antwoord);

            Console.WriteLine(isCorrect ? "Goed gedaan!" : "Helaas, dat is fout.");
        }

        private void BerekenScore()
        {
            int score = 0;
            for (int i = 0; i < vragen.Count; i++)
            {
                if (vragen[i].Antwoord.Equals(ingevuldeAntwoorden[i], StringComparison.OrdinalIgnoreCase))
                {
                    score++;
                }
            }
            Console.WriteLine($"Je score is: {score}/{vragen.Count}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Quiz quiz = new Quiz();
            quiz.VoegVraagToe("Wat is de hoofdstad van Nederland?", "Amsterdam");
            quiz.VoegVraagToe("Wat is 2 + 2?", "4");
            quiz.VoegVraagToe("Wie schreef '1984'?", "George Orwell");

            quiz.StartQuiz();
        }
    }
}