using System;

namespace OOP
{
    class Person
    {
        public string name;
        public int age;
        public string email;
        public Person(string name, int age, string email)
        {
            this.name = name;
            this.age = age;
            this.email = email;
        }
        
        public void DataOutput()
        {
            Console.WriteLine("Имя: " + name);
            Console.WriteLine("Возраст: " +  age);
            Console.WriteLine("Почта: " + email);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person example = new Person("Alex", 19, "alex@mail.ru");
            example.DataOutput();
            Console.WriteLine("Введите имя, возраст и почту как в примере выше:");
            Person person = new Person(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()), Console.ReadLine());
            person.DataOutput();
        }
    }
}
