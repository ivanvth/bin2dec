namespace bin2dec
{
    public static class Bin2dec
    {
        public static int Convert(string bin) {
            if (bin.Length > 8) {
                return -1;
            }
            int sum = 0;
            for (int i=0; i<bin.Length; i++) {
                sum += ConvertN(bin.Length-i-1, bin[i]);
            }
            return sum;
        }

        private static int ConvertN(int place, char c) {
            int b = (c == '0') ? 0 : 1;
            int d = (int) (Math.Pow(2, place));
            return b * d;
        }
    }
}