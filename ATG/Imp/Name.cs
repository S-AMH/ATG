using ATG.Interface;

namespace ATG
{
    public class Name : IName
    {
        private string firstName;
        private string? middleName;
        private string lastName;
        public Name(string firstName, string lastName)
        {
            this.firstName = firstName ?? throw new ArgumentNullException(nameof(firstName), "Value can not be null.");
            this.lastName = lastName ?? throw new ArgumentNullException(nameof(lastName), "Value can not be null.");
        }
        public Name(string firstName, string middleName, string lastName) : this(firstName, lastName)
        {
            this.middleName = middleName;
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value ?? throw new ArgumentNullException(nameof(FirstName), "Value can not be null."); }
        }
        public string? MiddleName
        {
            get { return middleName; }
            set { middleName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value ?? throw new ArgumentNullException(nameof(LastName), "Value can not be null."); }
        }
    }
}
