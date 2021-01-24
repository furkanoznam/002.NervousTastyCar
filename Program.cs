using System;

namespace _002.NervousTastyCar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Burada new dediğimiz anda, class içerisindeki constructor çalışır.
            Customer customer1 = new Customer { Id = 1, FirstName = "Furkan", LastName = "Öznam", City = "İstanbul" };
            Customer customer2 = new Customer(2, "Efna", "Öznam", "Trabzon");
            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Mehmet";
            customer3.LastName = "Akıncı";
            customer3.City = "Konya";
        }
    }

    class Customer
    {
        //default constructor
        public Customer()
        {
            Console.WriteLine("Yapıcı blok çalıştı.");
        }

        public Customer(int id, string firstname, string lastname, string city)
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            City = city;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
