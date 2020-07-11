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
            List<char> keyText = new List<char>();
            Random random = new Random();

            for (int i = 0; i < keySize; i++)
            {
                char c = (char)random.Next(_initialRangeValue, _finalValueRangeValue);
                keyText.Add(c);
            }

            return new string (keyText.ToArray());
        }
    }
}