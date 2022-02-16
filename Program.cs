namespace bin2dec;

public class Program {
    static void Main(string[] args)
    {
        foreach (string s in args) {
            try {
                System.Console.WriteLine(s + ": " + Bin2dec.Convert(s));
            } catch (Exception e) {
                System.Console.WriteLine(s + ": " + e.Message);
            }
        } 
    }
}
