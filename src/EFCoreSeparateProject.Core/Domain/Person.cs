namespace EFCoreSeparateProject.Core.Domain
{
    public class Person : Entity
    {
        public Address Address { get; private set; }
        public void AddAddress(string line1, string line2, string postcode)
        {
            Address = new Address(line1, line2, postcode);
        }
    }
}
