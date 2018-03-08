using System;
using System.Security.Cryptography;

namespace EPatient.Utilities
{
    class HashingPassword
    {
        public static string Hash(string clearPassword)
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
            //use Rfc2898DeriveBytes to hash based on HMACSHA1 algorithm
            var pbkdf2 = new Rfc2898DeriveBytes(clearPassword, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);
            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);
            string savedPasswordHash = Convert.ToBase64String(hashBytes);
            return savedPasswordHash;
        }

        public static bool CheckPassword(string clearPassword, string hashPassword)
        {
           /* Extract the bytes */
            byte[] hashBytes = Convert.FromBase64String(hashPassword);
            /* Get the salt */
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);
            /* Compute the hash on the password the user entered */
            var pbkdf2 = new Rfc2898DeriveBytes(clearPassword, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);
            /* Compare the results */
            for (int i = 0; i < 20; i++)
                if (hashBytes[i + 16] != hash[i])
                    return false;

            return true;
        }
    }
}
