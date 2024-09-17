public class Person : IComparable<Person>
{
    public int Age { get; set; }
    public string FName { get; set; }
    public string LName { get; set; }

    public int CompareTo(Person other)
    {
        return this.FName.CompareTo(other.FName);
    }

    public override string ToString() =>
        $"Name: {FName} {LName}, Age {Age}";
}
