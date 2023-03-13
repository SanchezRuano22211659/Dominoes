public class Domino
{
    private int faceUp;
    private int faceDown;
        public Domino(int _faceUp,int _faceDown)
    {
        this.faceUp = _faceUp;
        this.faceDown = _faceDown;
    }
    public static Domino operator + (Domino a,Domino b)
    {
        int den= a.faceDown + b.faceDown;
        int num= a.faceUp + b.faceUp;
        return new Domino (num,den);
    }

    public void Print_()
    {
        Console.WriteLine(faceUp+faceDown);
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        Domino d1 = new Domino(0,1);
        Domino d2 = new Domino(2,3);
        Domino d3 = d1 + d2;
        d3.Print_();
    }
}