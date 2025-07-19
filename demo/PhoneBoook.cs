using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal struct PhoneBoook
    {
        string[] names;
        long[] numbers;

        public PhoneBoook(int size)
        {
            names = new string[size];
            numbers = new long[size];
        }
        public void addPerson(string name, long number, int index)
        {
            names[index] = name;
            numbers[index] = number;

        }

        public long GetNumber(string name)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == name)
                    return numbers[i];
            }
            return -1;
        }

        public void UpdateNumber(long newNumb, string name)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == name)
                    numbers[i] = newNumb;

            }

        }

        // Used Indexer: Special Properties


        public long this[string name]
        {
            get
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == name)
                        return numbers[i];
                }
                return -1;
            }

            set
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == name)
                        numbers[i] = value;

                }
            }
        }


    }
}
