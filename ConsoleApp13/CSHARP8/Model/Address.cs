namespace ConsoleApp13.CSHARP8
{
    public class Address
    {
        public string City { get; set; }

        public string PostalCode { get; set; }

        public Address(string city, string postalCode)
        {
            City = city;
            PostalCode = postalCode;
        }

        public void Deconstruct(out string city, out string postalCode)
        {
            city = City;
            postalCode = PostalCode;
        }

    }
}


