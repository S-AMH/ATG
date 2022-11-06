namespace ATG.Interface
{
    public interface IPerson
    {
        IName Name { get; }
        DateTime? Birthday { get; }
        uint? Age { get; }
    }
}
