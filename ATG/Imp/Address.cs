using ATG.Interface;

namespace ATG
{
    public class Address : IAddress
    {
        private readonly ICountry country;
        private readonly string city;
        private readonly string firstLine;
        private readonly string? secondLine;
        private readonly string buildingNumber;
        private readonly uint? unit;
        private readonly string postalCode;
        public Address(ICountry country, string city, string firstLine, string buildingNumber, string postalCode)
        {
            this.country = country ?? throw new ArgumentNullException(nameof(country));
            this.city = city ?? throw new ArgumentNullException(nameof(city));
            this.firstLine = firstLine ?? throw new ArgumentNullException(nameof(firstLine));
            this.buildingNumber = buildingNumber ?? throw new ArgumentNullException(nameof(buildingNumber));
            this.postalCode = postalCode ?? throw new ArgumentNullException(nameof(postalCode));
        }
        public Address(ICountry country, string city, string firstLine, string? secondLine, string buildingNumber, uint? unit, string postalCode) : this(country, city, firstLine, postalCode, buildingNumber)
        {
            this.unit = unit;
            this.secondLine = secondLine;
        }
        public ICountry Country { get { return country; } }
        public string City { get { return city; } }
        public string FirstLine { get { return firstLine; } }
        public string? SecondLine { get { return secondLine; } }
        public string BuildingNumber { get { return buildingNumber; } }
        public uint? Unit { get { return unit; } }
        public string PostalCode { get { return postalCode; } }
    }
}
