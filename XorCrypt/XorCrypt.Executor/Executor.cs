using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XorCrypt.Entities;

namespace XorCrypt.Executor
{
    public static class Executor
    {
        public static string GenerateKey(int keySize)
        {
            try
            {
                KeyManager keyManager = new KeyManager(keySize);
                return keyManager.GenerateKey();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}