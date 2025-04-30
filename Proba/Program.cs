using SquarePolybiaLib;

class Program
{
    static void Main(string[] args)
    {
        PolybiusSquare polybius = new PolybiusSquare();

        string textToEncrypt = "aboba";
        string encryptedText = polybius.Encrypt(textToEncrypt);
        Console.WriteLine($"Encrypted: {encryptedText}");

        string decryptedText = polybius.Decrypt(encryptedText);
        Console.WriteLine($"Decrypted: {decryptedText}");

        Console.WriteLine(polybius.Decrypt("242424"));
    }
}