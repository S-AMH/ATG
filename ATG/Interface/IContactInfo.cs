namespace ATG.Interface
{
    public interface IContactInfo
    {
        string Email { get; }
        string MobilePhoneNumber { get; }
        string? HousePhoneNumber { get; }
        string? WorkPhoneNumber { get; }
    }
}
