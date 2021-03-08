using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaMachine.Classes
{
    class Rotor
    {
        // Internal Variables
        protected Dictionary<string, string> dictionary = new Dictionary<string, string>();
        int position;

        // Constructor
        public Rotor(Dictionary<string, string> dict)
        {
            dictionary = cloneDictionary(dict);
            position = 0;
        }
        public Rotor(Rotor r)
        {
            dictionary = cloneDictionary(r.dictionary);
            position = 0;
        }

        // Properties
        public int Position
        {
            get
            {
                return position;
            }
            set
            {
                if (value >= 0 && value < 26)
                {
                    position = value;
                }
            }
        }

        // Methods
        public string Output(string letter)
        {
            int initPos = getIndexOfKey(letter.ToUpper());
            return dictionary.ElementAt((initPos + position) % 26).Value;
        }
        public string OutputInverse(string letter)
        {
            int initPos = getIndexOfValue(letter.ToUpper());
            return dictionary.ElementAt((initPos + (26 - position)) % 26).Key;
        }
        
        public int Rotate()
        {
            position = (position + 1) % 26;
            return position;
        }
        public int RotateInverse()
        {
            position = (position + 25) % 26;
            return position;
        }

        // Private Functions
        private Dictionary<string, string> cloneDictionary(Dictionary<string, string> dict)
        {
            Dictionary<string, string> newDict = new Dictionary<string, string>();
            foreach(var element in dict)
            {
                newDict.Add(element.Key.ToUpper(), element.Value.ToUpper());
            }
            return newDict;
        }
        private int getIndexOfKey(String key)
        {
            int index = -1;
            foreach (string value in dictionary.Keys)
            {
                index++;
                if (key == value)
                    return index;
            }
            return -1;
        }
        private int getIndexOfValue(String value)
        {
            int index = -1;
            foreach (string val in dictionary.Values)
            {
                index++;
                if (value == val)
                    return index;
            }
            return -1;
        }

    }
}
