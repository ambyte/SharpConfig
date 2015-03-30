using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace SharpConfig
{
    class Secure
    {
        internal static bool EncryptFile(string inputFile, string outputFile, string key)
        {
            try
            {
                var keyBytes = Encoding.Unicode.GetBytes(key);

                Rfc2898DeriveBytes derivedKey = new Rfc2898DeriveBytes(key, keyBytes);

                RijndaelManaged rijndaelCsp = new RijndaelManaged();
                rijndaelCsp.Key = derivedKey.GetBytes(rijndaelCsp.KeySize / 8);
                rijndaelCsp.IV = derivedKey.GetBytes(rijndaelCsp.BlockSize / 8);

                ICryptoTransform encryptor = rijndaelCsp.CreateEncryptor();

                using (FileStream outputFileStream = new FileStream(outputFile, FileMode.Create))
                {
                    using (CryptoStream encryptStream = new CryptoStream(outputFileStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (FileStream inputFileStream = new FileStream(inputFile, FileMode.Open))
                        {
                            int data;
                            while ((data = inputFileStream.ReadByte()) != -1)
                                encryptStream.WriteByte((byte)data);
                            inputFileStream.Close();
                        }
                        encryptStream.Close();
                    }
                    outputFileStream.Close();
                }
                rijndaelCsp.Clear();

            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e);
                return false;
            }
            catch
            {
                return false;
            }
            return true;
        }

        internal static bool DecryptFile(string inputFile, string outputFile, string key)
        {
            try
            {
                byte[] keyBytes = Encoding.Unicode.GetBytes(key);

                Rfc2898DeriveBytes derivedKey = new Rfc2898DeriveBytes(key, keyBytes);

                RijndaelManaged rijndaelCsp = new RijndaelManaged();
                rijndaelCsp.Key = derivedKey.GetBytes(rijndaelCsp.KeySize / 8);
                rijndaelCsp.IV = derivedKey.GetBytes(rijndaelCsp.BlockSize / 8);
                ICryptoTransform decryptor = rijndaelCsp.CreateDecryptor();

                using (FileStream inputFileStream = new FileStream(inputFile, FileMode.Open))
                {
                    using (CryptoStream decryptStream = new CryptoStream(inputFileStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (FileStream outputFileStream = new FileStream(outputFile, FileMode.Create))
                        {
                            int data;
                            while ((data = decryptStream.ReadByte()) != -1)
                                outputFileStream.WriteByte((byte)data);

                            rijndaelCsp.Clear();
                            outputFileStream.Close();
                        }
                        decryptStream.Close();
                    }
                    inputFileStream.Close();
                }
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e);
                return false;
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
