namespace CryptoApp
{
    internal class Gronsfeld
    {
        public static string CryptGF(string input, string key, bool check)
        {
            string alphabet = ":;'?/!123456789-,. abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int num;
            string cryptString = "";

            for (int i = 0; i < input.Length; i++)
            {
                char cryptChar;
                char symb = input[i];
                num = key[i % key.Length] - 48;
                if (check)
                    cryptChar = alphabet[(alphabet.IndexOf(symb) - num) % alphabet.Length];
                else
                    cryptChar = alphabet[(alphabet.IndexOf(symb) + num) % alphabet.Length];

                cryptString += cryptChar;
            }
            return cryptString;
        }
    }
}
