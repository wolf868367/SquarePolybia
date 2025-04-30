namespace SquarePolybiaLib
{
    public class PolybiusSquare
    {
        private char[,] symbols = {
            {'a', 'b', 'c', 'd', 'e' },
            {'f', 'g', 'h', 'i', 'k' },
            {'l', 'm', 'n', 'o', 'p' },
            {'q', 'r', 's', 't', 'u' },
            {'v', 'w', 'x', 'y', 'z' },
        };
        private char[,] symbolsRu = {
            {'а', 'б', 'в', 'г', 'д', 'е'},
            {'ж', 'з', 'и', 'к', 'л', 'м'},
            {'н', 'о', 'п', 'р', 'с', 'т'},
            {'у', 'ф', 'х', 'ц', 'ч', 'ш'},
            {'щ', 'ъ', 'ы', 'э', 'ю', 'я'},
        };

        public string Encrypt(string text)
        {
            string cipher = "";
            text = text.ToLower();

            foreach (char c in text)
            {
                if (c == 'j') cipher += "24";
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (symbols[i, j] == c)
                        {
                            cipher += (i + 1).ToString() + (j + 1).ToString();
                        }
                    }
                }
            }

            return cipher;
        }

        public string Decrypt(string cipher)
        {
            string text = "";
            for (int i = 0; i < cipher.Length; i += 2)
            {
                int row = int.Parse(cipher[i].ToString()) - 1;
                int col = int.Parse(cipher[i + 1].ToString()) - 1;
                text += symbols[row, col];
            }

            return text;
        }

        public string EncryptRu(string text)
        {
            string cipher = "";
            text = text.ToLower();

            foreach (char c in text)
            {
                if (c == 'ё') cipher += "16";
                if (c == 'й') cipher += "23";
                if (c == 'ь') cipher += "52";
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if (symbolsRu[i, j] == c)
                        {
                            cipher += (i + 1).ToString() + (j + 1).ToString();
                        }
                    }
                }
            }

            return cipher;
        }

        public string DecryptRu(string cipher)
        {            
            string text = "";
            for (int i = 0; i < cipher.Length; i += 2)
            {
                int row = int.Parse(cipher[i].ToString()) - 1;
                int col = int.Parse(cipher[i + 1].ToString()) - 1;
                text += symbolsRu[row, col];
            }

            return text;
        }
        
    }
}