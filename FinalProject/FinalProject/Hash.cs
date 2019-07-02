using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
     public static class Hash
    {

         public static string GetHash(string password)
        {
            byte[] bytes = new ASCIIEncoding().GetBytes(password);
            byte[] EncPass = new SHA256Managed().ComputeHash(bytes);
            return new ASCIIEncoding().GetString(EncPass);
        }

        public static bool checkedHashCode(string hashCode,string password)
        {
            return hashCode == GetHash(password);
        } 
      
    }
}
