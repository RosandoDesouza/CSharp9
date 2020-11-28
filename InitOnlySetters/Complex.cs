public class Complex 
{
    private readonly int field1;

    private int field2;

    public int Prop1 { get; init; }

    public int Prop2 { 
        get
        {
            return Prop2;
        }

        init
        {
            field1 = 42;
            field2 =43;
            Prop1 = 44;
            Prop2 = 45;
        }
    }
}