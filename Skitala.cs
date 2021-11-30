namespace CryptoApp
{
    internal class Skitala
    {
        public static string CryptS(string input, int height, bool check)
        {

            var k = input.Length % height;
            if (k > 0)
            {
                input += new string('*', height - k);
            }
            var width = input.Length / height;
            int index = 0;
            var cryptoString = new char[input.Length];

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (check)
                        cryptoString[i + width * j] = input[index];
                    else
                        cryptoString[index] += input[i + width * j];
                    index++;
                }
            }

            return string.Join("", cryptoString);
        }
    }
}
