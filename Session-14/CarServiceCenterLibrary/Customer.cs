namespace CarServiceCenterLibrary
{
    public class Customer : Person
    {
        public string Phone { get; set; }
        public string TIN { get; set; }
        public List<Transaction> Transactions { get; set; }
        public Customer()
        {

        }

    }

}