using ATG.Interface;

namespace ATG
{
    public class Country : ICountry
    {
        private readonly string name;
        private readonly string isoCode;

        internal Country(string name, string isoCode)
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.isoCode = isoCode ?? throw new ArgumentNullException(nameof(isoCode));
        }
        public Country(ICountry country)
        {
            this.name = country.Name;
            this.isoCode = country.IsoCode;
        }
        string ICountry.Name { get { return name; } }

        string ICountry.IsoCode { get { return isoCode; } }
    }
}
