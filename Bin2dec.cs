namespace bin2dec;
public static class Bin2dec {
    public static int Convert(string bin) {
        int sum = 0;
        for (int i = 0; i < bin.Length; i++) {
            switch (bin[i]) {
                    case '0':   break;
                    case '1':   sum += ConvertN(bin.Length - i - 1);
                                break;
                    default:    throw new ArgumentOutOfRangeException("That is not a valid binary number.");
            }
        }
        return sum;
    }

    private static int ConvertN(int pos) {
        return (int)(Math.Pow(2, pos));
    }
}