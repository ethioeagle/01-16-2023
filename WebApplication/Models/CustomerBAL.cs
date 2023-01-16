namespace WebApplication.Models
{
    public class CustomerBAL
    {
        public Customer GetCustomer()
        {
            Customer c = new Customer();
            c.CustomerName = "Natty";
            c.Address = "1254 roger road";
            c.Age = 55;
            return c;
            
        }
    }
}
