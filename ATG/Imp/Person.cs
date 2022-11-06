using ATG.Interface;

namespace ATG
{
    public class Person
    {
        private IName name;
        private readonly DateTime? birthday;
        private readonly uint? age;
        public Person(IName name)
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
        }
        public Person(IName name, DateTime? birthday) : this(name)
        {
            this.birthday = birthday ?? throw new ArgumentNullException(nameof(birthday));
            if (DateTime.Now.CompareTo(birthday.Value) > 0)
                this.age = (uint?)(DateTime.Now.Subtract(birthday.Value).TotalDays / Constants.Constants.DaysInYear);
            else
                throw new ArgumentOutOfRangeException(nameof(birthday), "Birthday Can not Be in Future.");
        }
        public IName Name
        {
            get { return name; }
            set { name = value ?? throw new ArgumentNullException(nameof(value)); }
        }
        public DateTime? Birthday
        {
            get { return birthday; }
        }
        public uint? Age
        {
            get { return age; }
        }
    }
}
