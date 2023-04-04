namespace Mvc_Mulakat.Models
{
    public class Customer: Entity<long>
    {
        public Customer()
        {
        }

        public string Name { get; set; }
        public string Password { get; set; }

        public Customer(string name, string password): this()
        {
            Name = name;
            Password = password;
        }
    }
}
