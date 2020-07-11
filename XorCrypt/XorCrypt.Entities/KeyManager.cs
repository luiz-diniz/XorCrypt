using System;
using System.Collections.Generic;

namespace XorCrypt.Entities
{
    public class KeyManager
    {
        private int _initialRangeValue = 50;
        private int _finalValueRangeValue = 100;
        
        public int keySize { get; set; }

        public KeyManager(int keySize)
        {
            this.keySize = keySize;        
        }

        public string GenerateKey()
        {
            if(keySize > 0)
            {
                List<char> keyText = new List<char>();
                Random random = new Random();

                for (int i = 0; i < keySize; i++)
                {
                    char c = (char)random.Next(_initialRangeValue, _finalValueRangeValue);
                    keyText.Add(c);
                }

                return new string(keyText.ToArray()); 
            }
            else
            {
                throw new Exception("The key size must he higher than the 0.");
            }
        }
    }
}