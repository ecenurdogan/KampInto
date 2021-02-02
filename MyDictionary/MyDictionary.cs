using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<TKey,TValue> 
    {
        TKey[] Keys;
        TValue[] Values;

        public MyDictionary()
        {
            Keys = new TKey[0];
            Values = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            TKey[] TempKey = Keys;
            TValue[] TempValue = Values;
            Keys = new TKey[Keys.Length + 1];
            Values = new TValue[Values.Length + 1];

            for (int i = 0; i < TempKey.Length; i++)
            {
                Keys[i] = TempKey[i];
                Values[i] = TempValue[i];
            }

            Keys[Keys.Length - 1] = key;
            Values[Values.Length - 1] = value;
            }
        public int Length
        {
            get { return Keys.Length; }
        }

        public  TKey[] keys
        {
            get { return Keys; }
        }

        public TValue[] values
        {
            get { return Values; }
        }
    }
       
    
    
}
