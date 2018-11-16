namespace FacetedBuilder
{
    public class PersonAddressBuilder: PersonBuilder
    {
        public PersonAddressBuilder(Person person)
        {
            this.person = person;
        }
        public PersonAddressBuilder At(string address)
        {
            person.StreetAddress = address;
            return this;
        }
        public PersonAddressBuilder WithPostalCode(string postcode)
        {
            person.Postcode = postcode;
            return this; 
        }
        public PersonAddressBuilder In(string city)
        {
            person.City = city;
            return this;
        }
    }
}
