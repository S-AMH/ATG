using ATG.Interface;

namespace ATG
{
    public class ContactInfo : IContactInfo
    {
        private string email;
        private string mobilePhoneNumber;
        private string? housePhoneNumber;
        private string? workPhoneNumber;

        public ContactInfo(string email, string mobilePhoneNumber)
        {
            this.email = email ?? throw new ArgumentNullException(nameof(email));
            this.mobilePhoneNumber = mobilePhoneNumber ?? throw new ArgumentNullException(nameof(mobilePhoneNumber));
        }
        public ContactInfo(string email, string mobilePhoneNumber, string? housePhoneNumber) : this(email, mobilePhoneNumber)
        {
            this.housePhoneNumber = housePhoneNumber;
        }
        public string Email
        {
            get { return email; }
            set
            {
                email = value ?? throw new ArgumentNullException(nameof(Email),
                "Value Can not Be Null");
            }
        }
        public string MobilePhoneNumber
        {
            get { return mobilePhoneNumber; }
            set
            {
                mobilePhoneNumber = value ?? throw new ArgumentNullException(nameof(MobilePhoneNumber),
                "Value Can not Be Null");
            }
        }
        public string? HousePhoneNumber
        {
            get { return housePhoneNumber; }
            set
            {
                housePhoneNumber = value ?? throw new ArgumentNullException(nameof(HousePhoneNumber),
                "Value Can not Be Null");
            }
        }
        public string? WorkPhoneNumber
        {
            get { return workPhoneNumber; }
            set
            {
                workPhoneNumber = value ?? throw new ArgumentNullException(nameof(WorkPhoneNumber),
                "Value Can not Be Null");
            }
        }
    }
}
