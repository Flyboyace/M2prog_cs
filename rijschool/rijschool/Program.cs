using System;
using System.Collections.Generic;

namespace Rijschool
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Auto auto = new Auto("Volkswagen", "Golf");
            RijLeeraar rijLeeraar = new RijLeeraar("Jan Jansen");
            Student student = new Student("Piet Pietersen");

            Console.WriteLine($"Auto: {auto.Merk} {auto.Model}");
            Console.WriteLine($"RijLeeraar: {rijLeeraar.Naam}");
            Console.WriteLine($"Student: {student.Naam}");
  
            Rijschool rijschool = new Rijschool("Veilig Rijschool");
            Instructeur instructeur = new Instructeur("Jan de Vries");
            Les les = new Les("2024-12-01", "10:00");
            rijschool.VoegLesToe(les);
            Planning planning = new Planning();
            planning.VoegDagToe("2024-12-01", les);
  
            Console.WriteLine($"Rijschool: {rijschool.Naam}");
            Console.WriteLine("Lessen:");
            foreach (var l in rijschool.Lessen)
            {
                Console.WriteLine($" - {l.Datum} om {l.Tijd}");
            }
  
            Dag dag = new Dag();
            Student student1 = new Student("Jan", 20);
            Student student2 = new Student("Piet", 22);
            dag.VoegStudentToe(student1);
            dag.VoegStudentToe(student2);
            dag.ToonStudenten();
        }
    }

    public class Auto
    {
        public string Merk { get; set; }
        public string Model { get; set; }

        public Auto(string merk, string model)
        {
            Merk = merk;
            Model = model;
        }
    }

    public class RijLeeraar
    {
        public string Naam { get; set; }

        public RijLeeraar(string naam)
        {
            Naam = naam;
        }
    }

    public class Student
    {
        public string Naam { get; set; }
        public int Leeftijd { get; set; }

        public Student(string naam, int leeftijd)
        {
            Naam = naam;
            Leeftijd = leeftijd;
        }
    }

    public class Lespakket
    {
        public string PakketNaam { get; set; }

        public Lespakket(string pakketNaam)
        {
            PakketNaam = pakketNaam;
        }
    }

    public class RijTest
    {
        public bool IsGeslaagd { get; set; }

        public RijTest(bool isGeslaagd)
        {
            IsGeslaagd = isGeslaagd;
        }
    }

    public class TheorieTest
    {
        public bool IsGeslaagd { get; set; }

        public TheorieTest(bool isGeslaagd)
        {
            IsGeslaagd = isGeslaagd;
        }
    }

    public class Dag
    {
        private List<Student> studenten;

        public Dag()
        {
            studenten = new List<Student>();
        }

        public void VoegStudentToe(Student student)
        {
            studenten.Add(student);
        }

        public void ToonStudenten()
        {
            foreach (var student in studenten)
            {
                Console.WriteLine($"Naam: {student.Naam}, Leeftijd: {student.Leeftijd}");
            }
        }
    }

    public class LesUur
    {
        public string Tijd { get; set; }

        public LesUur(string tijd)
        {
            Tijd = tijd;
        }
    }

    public class Rijschool
    {
        public string Naam { get; set; }
        public List<Les> Lessen { get; set; }

        public Rijschool(string naam)
        {
            Naam = naam;
            Lessen = new List<Les>();
        }

        public void VoegLesToe(Les les)
        {
            Lessen.Add(les);
        }
    }

    public class Les
    {
        public string Datum { get; set; }
        public string Tijd { get; set; }

        public Les(string datum, string tijd)
        {
            Datum = datum;
            Tijd = tijd;
        }
    }

    public class Instructeur
    {
        public string Naam { get; set; }

        public Instructeur(string naam)
        {
            Naam = naam;
        }
    }

    public class Planning
    {
        public Dictionary<string, List<Les>> Dagen { get; set; }

        public Planning()
        {
            Dagen = new Dictionary<string, List<Les>>();
        }

        public void VoegDagToe(string datum, Les les)
        {
            if (!Dagen.ContainsKey(datum))
            {
                Dagen[datum] = new List<Les>();
            }
            Dagen[datum].Add(les);
        }
    }
}