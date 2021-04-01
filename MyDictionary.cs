using System;
using System.Collections.Generic;
using System.Text;

namespace KeyValueStore
{
    struct KeyValue
    {
        public string key { get; }
        public object value { get; }

        public KeyValue(string inKey, object inValue)
        {
            key = inKey;
            value = inValue;
        }
    }
    class MyDictionary
    {
        KeyValue[] MyDict = new KeyValue[10];
        int values = 0;
        public object this[string key] 
        {
            get
            { 
                foreach (KeyValue X in MyDict)
                {
                    if (key == X.key)
                        return X.value;
                }
                throw new Exception("KeyNotFoundException");
            }
            set 
            {
                for (int i = 0; i < MyDict.Length; i++)
                {
                    if (key == MyDict[i].key)
                    {
                        MyDict[i] = new KeyValue(key, value);
                        return;
                    }
                }
                MyDict[values] = new KeyValue(key, value);
                values++;
            }
        }
    }
}
