class Person
{
    public int id;
    public string name;
    public int age;

    public void Display()
    {
        Console.WriteLine($"[ eId : {this.id}  ename : {this.name}  eAge : {this.age}]");
    }

    public bool IsLegalAge()
    {
        return age >= 18;
    }

    public void ChangeName(string name)
    {
        this.name = name;
    }

    public void GrowOlder() => this.age++;


}

internal class Program
{
    public static void Main(string[] args)
    {
        Person P1 = new Person()
        {
            name = "omkar",
            id = 1,
            age = 23

        };
        Person P2 = new Person()
        {
            name = "Om",
            id = 2,
            age = 17
        };

        P1.Display();
        Console.WriteLine($"Is {P1.name} legal age? {P1.IsLegalAge()}");
        P1.GrowOlder();
        P1.ChangeName("Omkar Kamble");
        P1.Display();
        P1.ChangeName("Omkar");

        P2.Display();
        P2.ChangeName("ajinkya");
        P2.GrowOlder();
        P2.Display();

    }
}
