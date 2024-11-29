using System;

namespace Functions
{
    internal class Program
    {
        private List<string> vragenLijst = new List<string>
        {
            "How long do you think you'd survive in a zombie apocalypse?",
            "What 1994 video game features James Bond and is named after the 1995 film?",
            "What arcade game was called 'Puckman' in Japan?",
            "If you could travel to any place in the world, where would it be?",
            "What would you do if you suddenly received a million euros?"
        };
        static void Main(string[] args)
        {
            //variabel is new program en het type variabel is "program"
            Program program = new Program();
            program.Run(); //functie is run en het type is void
        }

        public void Run()
        {
            Console.WriteLine("Dit is nu de start van mijn programma");

            Console.WriteLine("How long do you think you'd survive in a zombie apocalypse?");
            string response = Console.ReadLine();
            Console.WriteLine("You said: " + response);
      

            VraagZombieApocalypse();
            VraagSuperkracht();
            VraagHuisdier();
            VraagMiljoenEuro();
            VraagReizen();


            string vraag = GetRandomVraag();
            Console.WriteLine("Random vraag: " + vraag);


            string antwoord = StelVraag(vraag);
            Console.WriteLine("Je antwoord: " + antwoord);


            for (int i = 0; i < 4; i++)
            {
                AskRandomQuestion();
            }
        }

        private void VraagZombieApocalypse()
        {
            Console.WriteLine("How long do you think you'd survive in a zombie apocalypse?");
            string antwoord = Console.ReadLine();
            Console.WriteLine("You said: " + antwoord);
        }

        private void VraagSuperkracht()
        {
            Console.WriteLine("What superpower would you like to actually start manifesting?");
            string antwoord = Console.ReadLine();
            Console.WriteLine("You said: " + antwoord);
        }

        private void VraagHuisdier()
        {
            Console.WriteLine("If you could own any animal as a pet, what would it be?");
            string antwoord = Console.ReadLine();
            Console.WriteLine("You said: " + antwoord);
        }

        private void VraagMiljoenEuro()
        {
            Console.WriteLine("What would you do if you suddenly received a million euros?");
            string antwoord = Console.ReadLine();
            Console.WriteLine("You said: " + antwoord);
        }

        private void VraagReizen()
        {
            Console.WriteLine("If you could travel to any place in the world, where would it be?");
            string antwoord = Console.ReadLine();
            Console.WriteLine("You said: " + antwoord);
        }



        private string StelVraag(string vraag)
        {
            Console.WriteLine(vraag);
            string antwoord = Console.ReadLine();
            return antwoord;
        }
        private string GetRandomVraag()
        {
            Random random = new Random();
            int index = random.Next(vragenLijst.Count);
            return vragenLijst[index];
        }



        void AskRandomQuestion()
        {
            string vraag = GetRandomVraag();

            Console.WriteLine(vraag);

            Console.Write("Jouw antwoord: ");
            string antwoord = Console.ReadLine();

            Console.WriteLine("Je antwoord was: " + antwoord);
        }
    }
}