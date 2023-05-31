/*
 Lazy Load в LINQ. Расширяющие методы.
Есть коллекция пользовательских объектов типа Person.
public class Person
{
public string Name { get; set; } 
public int Age { get; set; } 
public string City { get; set; }
}
List<Person> person = new List<Person>()
{
new Person(){ Name = "Andrey", Age = 24, City = "Kyiv"}, new Person(){ Name = "Liza", Age = 18, City = "Odesa" }, new Person(){ Name = "Oleg", Age = 15, City = "London" }, new Person(){ Name = "Sergey", Age = 55, City = "Kyiv" }, new Person(){ Name = "Sergey", Age = 32, City = "Lviv" }
};
1) Выбрать людей, старших 25 лет.
2) Выбрать людей, проживающих не в Лондоне.
3) Выбрать имена людей, проживающих в Киеве.
4) Выбрать людей, старших 35 лет, с именем Sergey.
5) Выбрать людей, проживающих в Одессе.
 */

using LINQ;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }
   
    class Program
    {
        static void Main(string[] args)
        {            
            List<Person> persons = new List<Person>()
            {
            new Person(){ Name = "Andrey", Age = 24, City = "Kyiv"},
            new Person(){ Name = "Liza", Age = 18, City = "Odesa" },
            new Person(){ Name = "Oleg", Age = 15, City = "London" },
            new Person(){ Name = "Sergey", Age = 55, City = "Kyiv" },
            new Person(){ Name = "Sergey", Age = 32, City = "Lviv" }
            };

            // Выбрать людей, старше 25 лет.
            var selectedPersons1 = from person in persons
                                   where person.Age > 25
                                   select person;

            Console.WriteLine("\nВыбрать людей, старше 25 лет\n");
            foreach (var person in selectedPersons1)
                Console.WriteLine("{0} - {1} - {2}", person.Name, person.Age, person.City);
            Console.WriteLine('\n');

            // Аналогичный запрос с помощью метода расширения Where
            selectedPersons1 = persons.Where(u => u.Age > 25);
            foreach (var person in selectedPersons1)
                Console.WriteLine("{0} - {1} - {2}", person.Name, person.Age, person.City);
            Console.WriteLine('\n');

            // Выбрать людей, проживающих не в Лондоне.
            var selectedPersons2 = from person in persons
                                   where person.City != "London"
                                   select person;

            Console.WriteLine("\nВыбрать людей, проживающих не в Лондоне\n");
            foreach (var person in selectedPersons2)
                Console.WriteLine("{0} - {1} - {2}", person.Name, person.Age, person.City);
            Console.WriteLine('\n');

            // Аналогичный запрос с помощью метода расширения Where
            selectedPersons2 = persons.Where(u => u.City != "London");
            foreach (var person in selectedPersons2)
                Console.WriteLine("{0} - {1} - {2}", person.Name, person.Age, person.City);
            Console.WriteLine('\n');
            
            // Выбрать имена людей, проживающих в Киеве.
            var selectedPersons3 = from person in persons
                                   where person.City == "Kyiv"
                                   select person;

            Console.WriteLine("\nВыбрать имена людей, проживающих в Киеве\n");
            foreach (var person in selectedPersons3)
                Console.WriteLine("{0} - {1} - {2}", person.Name, person.Age, person.City);
            Console.WriteLine('\n');

            // Аналогичный запрос с помощью метода расширения Where
            selectedPersons3 = persons.Where(u => u.City != "Kyiv");
            foreach (var person in selectedPersons3)
                Console.WriteLine("{0} - {1} - {2}", person.Name, person.Age, person.City);
            Console.WriteLine('\n');

            // Выбрать людей, старших 35 лет, с именем Sergey
            var selectedPersons4 = from person in persons
                                   where person.Age > 35
                                   where person.Name == "Sergey"
                                   select person;

            Console.WriteLine("\nВыбрать людей, старших 35 лет, с именем Sergey\n");
            foreach (var person in selectedPersons4)
                Console.WriteLine("{0} - {1} - {2}", person.Name, person.Age, person.City);
            Console.WriteLine('\n');

            // Аналогичный запрос с помощью метода расширения Where
            selectedPersons4 = persons.Where(u => u.Name == "Sergey"&&
                                                    u.Age > 35);
            foreach (var person in selectedPersons4)
                Console.WriteLine("{0} - {1} - {2}", person.Name, person.Age, person.City);
            Console.WriteLine('\n');

            // Выбрать людей, проживающих в Одессе
            var selectedPersons5 = from person in persons
                                   where person.City == "Odesa"
                                   select person;

            Console.WriteLine("\nВыбрать людей, проживающих в Одессе\n");
            foreach (var person in selectedPersons5)
                Console.WriteLine("{0} - {1} - {2}", person.Name, person.Age, person.City);
            Console.WriteLine('\n');

            // Аналогичный запрос с помощью метода расширения Where
            selectedPersons4 = persons.Where(u => u.Name == "Sergey" &&
                                                    u.Age > 35);
            foreach (var person in selectedPersons5)
                Console.WriteLine("{0} - {1} - {2}", person.Name, person.Age, person.City);
            Console.WriteLine('\n');
        }
    }
}
