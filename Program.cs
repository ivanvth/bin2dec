namespace bin2dec;

public class Program {
    static void Main(string[] args)
    {
        foreach (string s in args) {
            System.Console.WriteLine(s + ": " + Bin2dec.Convert(s));
        } 
    }
}
