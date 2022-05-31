namespace FooExample;
public class FooTest
{
    public void Foo(int x)
    {
        x++;
    }
    public void Foo(ref int x)
    {
        x++;
    }
}
