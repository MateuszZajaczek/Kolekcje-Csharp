namespace Kolekcje_Csharp
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {


            //--------- Problem NR 1 --------------------------------------------- 


            var phonebook = new Dictionary<string, Tuple<string, string, string>>();

            // Dodawanie nowych wpisów do książki telefonicznej
            phonebook.Add("432-456-992", Tuple.Create("Jan", "Kowalski", "Warszawa"));
            phonebook.Add("098-765-4321", Tuple.Create("Anna", "Nowak", "Kraków"));

            // Wyszukiwanie wpisu po numerze telefonu
            var phoneNumber = "432-456-992";
            if (phonebook.TryGetValue(phoneNumber, out var contact))
            {
                Console.WriteLine("Imię: " + contact.Item1);
                Console.WriteLine("Nazwisko: " + contact.Item2);
                Console.WriteLine("Adres: " + contact.Item3);
            }
            else
            {
                Console.WriteLine("Nie znaleziono wpisu dla podanego numeru telefonu.");
            }
            Console.WriteLine("\n\n");

            //--------- Problem NR 2 --------------------------------------------- 


            var Listaobecnosci = new List<Tuple<string, bool>>();

            // Dodawanie nowych osób do listy obecności
            Listaobecnosci.Add(Tuple.Create("Jan Kowalski", true));
            Listaobecnosci.Add(Tuple.Create("Anna Nowak", true));
            Listaobecnosci.Add(Tuple.Create("Piotr Wiśniewski", false));

            // Wyszukiwanie obecności po imieniu i nazwisku
            var name = "Jan Kowalski";
            var found = false;
            foreach (var entry in Listaobecnosci)
            {
                if (entry.Item1 == name)
                {
                    Console.WriteLine("Obecność: " + entry.Item2);
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("Nie znaleziono wpisu dla podanej osoby.");
            }
            Console.WriteLine("\n\n");

            //--------- Problem NR 3 --------------------------------------------- 


            var students = new Dictionary<string, Student>();

            // Dodawanie nowych studentów
            students.Add("s12345", new Student("Jan", "Kowalski", 3, "Informatyka"));
            students.Add("s67890", new Student("Anna", "Nowak", 2, "Matematyka"));
            students.Add("s54321", new Student("Piotr", "Wiśniewski", 1, "Fizyka"));

            // Wyszukiwanie studenta po numerze indeksu
            var indexNumber = "s67890";
            if (students.ContainsKey(indexNumber))
            {
                Console.WriteLine("Student: " + students[indexNumber]);
            }
            else
            {
                Console.WriteLine("Nie znaleziono studenta o podanym numerze indeksu.");
            }

            Console.WriteLine("\n\n");

            //--------- Problem NR 4 --------------------------------------------- 

            List<Action> tasks = new List<Action>();
            tasks.Add(Task1);
            tasks.Add(Task2);
            tasks.Add(Task3);
            tasks.Add(Task4);

            foreach (var task in tasks)
            {
                task.Invoke();
            }


            Console.WriteLine("\n\n");


            //--------- Problem NR 5 --------------------------------------------- 

            List<ComputerEquipment> equipmentList = new List<ComputerEquipment>();
            equipmentList.Add(new ComputerEquipment("Monitor", 10, 300.0));
            equipmentList.Add(new ComputerEquipment("Keyboard", 15, 20.0));
            equipmentList.Add(new ComputerEquipment("Mouse", 20, 10.0));

        }

        static void Task1()
        {
            Console.WriteLine("zad 1");

        }

        static void Task2()
        {
            Console.WriteLine("zad 2");

        }

        static void Task3()
        {
            Console.WriteLine("zad 3");

        }

        static void Task4()
        {
            Console.WriteLine("zad 4");

        }






    }

    class ComputerEquipment
    {
        public string Nazwa { get; set; }
        public int Ilosc { get; set; }
        public double Cena { get; set; }

        public ComputerEquipment(string nazwa, int ilosc, double cena)
        {
            Nazwa = nazwa;
            Ilosc = ilosc;
            Cena = cena;
        }

    }
    class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Semester { get; set; }
        public string Degree { get; set; }

        public Student(string name, string surname, int semester, string degree)
        {
            Name = name;
            Surname = surname;
            Semester = semester;
            Degree = degree;
        }

        public override string ToString()
        {
            return Name + " " + Surname + " (" + Semester + " semestr, kierunek: " + Degree + ")";
        }
    }

}