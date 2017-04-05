namespace ClassLibrary
{
    public class Customer
    {
        private readonly string _firstName;
        private readonly string _lastName;

        public Customer(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        public string Name()
        {
            return _firstName + ", "+ _lastName;
        }

    }
}
