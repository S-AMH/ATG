namespace ATG.Interface
{
    public interface IAddress
    {
        ICountry Country { get; }
        string City { get; }
        string FirstLine { get; }
        string? SecondLine { get; }
        string BuildingNumber { get; }
        uint? Unit { get; }
        string PostalCode { get; }

    }
}
