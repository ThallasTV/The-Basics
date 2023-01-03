// See https://aka.ms/new-console-template for more information

namespace Classes;

public class Test
{
    public int valueA;
    public int valueB;
    public int result;
    static void Main()
    {
        IfStatement T= new IfStatement();
        WhileLoopRefresh W = new WhileLoopRefresh();
        T.If();
        try
        {
            W.WhileLoop();
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine("Negative value was attempted!");
            Console.WriteLine(e.ToString());
        }





    }
}

