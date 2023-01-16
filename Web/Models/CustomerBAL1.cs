namespace Web.Models
{
    public class CustomerBAL1
    {
        public Customer1 GetCustomer()
        {
            Customer1 c = new Customer1();
            c.CustomerName = "Natty";
            c.Address = "1254 roger road";
            c.Age = 55;
            return c;

        }
    }
}
