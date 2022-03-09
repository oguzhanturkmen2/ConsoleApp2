using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Keyval
    {
        public int key { get; set; }
        public int value { get; set; }
    }

    public class KeyvalArr
    {
        public List<Keyval> keys;

        public KeyvalArr()
        {
            keys=new List<Keyval>();
        }

        public void insertKey(int x, int y)
        {
            Keyval keyS = new Keyval();
            keyS.key = x;
            keyS.value = y;
            keys.Add(keyS);
        }

        public int getValue(int x)
        {
            int result = -1;
            for (int i = 0; i < keys.Count; i++)
            {
                if (keys[i].key == x)
                { 
                    result = keys[i].value;
                    break;
                }
            }
            return result;
        }

        public void addToKey(int x)
        {
            for (int i = 0; i < keys.Count; i++)
                keys[i].key = x;
        }

        public void addToValue(int y)
        {
            for (int i = 0; i < keys.Count; i++)
                keys[i].value = y;
        }
    }
}
