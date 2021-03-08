using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaMachine.Classes
{
    class Machine
    {
        // Internal Variables
        private Rotor rotor1;
        private Rotor rotor2;
        private Rotor rotor3;
        private Rotor rotor4;
        private Rotor rotor5;
        private RotorGroup rotorGroup;
        private Plugboard plugboard;

        // Constructor
        public Machine()
        {
            LoadRotors();
            rotorGroup = new RotorGroup(rotor1, rotor2, rotor3);
            plugboard = new Plugboard();
        }

        // Properties 
        public int PositionR1
        {
            get
            {
                return rotorGroup.PositionR1;
            }
            set
            {
                rotorGroup.PositionR1 = value;
            }
        }
        public int PositionR2
        {
            get
            {
                return rotorGroup.PositionR2;
            }
            set
            {
                rotorGroup.PositionR2 = value;
            }
        }
        public int PositionR3
        {
            get
            {
                return rotorGroup.PositionR3;
            }
            set
            {
                rotorGroup.PositionR3 = value;
            }
        }
        public Dictionary<string, string> Plugboard
        {
            get
            {
                return plugboard.Connections;
            }
            set
            {
                plugboard.Connections = value;
            }
        }

        // Methods
        public string EncodeLetter(string letter)
        {
            rotorGroup.Rotate();
            return plugboard.Output(rotorGroup.Output(plugboard.Output(letter)));
        }
        public void ReturnPreviousState()
        {
            rotorGroup.RotateInverse();
        }

        public void SetRotors(int[] rNums)
        {
            List<Rotor> rotors = new List<Rotor>();

            if (rNums[0] == 1 || rNums[1] == 1 || rNums[2] == 1)
            {
                rotors.Add(rotor1);
            }
            if (rNums[0] == 2 || rNums[1] == 2 || rNums[2] == 2)
            {
                rotors.Add(rotor2);
            }
            if (rNums[0] == 3 || rNums[1] == 3 || rNums[2] == 3)
            {
                rotors.Add(rotor3);
            }
            if (rNums[0] == 4 || rNums[1] == 4 || rNums[2] == 4)
            {
                rotors.Add(rotor4);
            }
            if (rNums[0] == 5 || rNums[1] == 5 || rNums[2] == 5)
            {
                rotors.Add(rotor5);
            }

            if (rotors.Count == 3)
            {
                rotorGroup.SetRotors(rotors[0], rotors[1], rotors[2]);
            }
        }

        // Private Functions
        private void LoadRotors()
        {
            Dictionary<string, string> dictionary1 = new Dictionary<string, string>()
            {
                {"a", "n"},
                {"b", "u"},
                {"c", "o"},
                {"d", "v"},
                {"e", "p"},
                {"f", "w"},
                {"g", "q"},
                {"h", "x"},
                {"i", "r"},
                {"j", "y"},

                {"k", "s"},
                {"l", "z"},
                {"m", "t"},
                {"n", "a"},
                {"o", "c"},
                {"p", "e"},
                {"q", "g"},
                {"r", "i"},
                {"s", "k"},
                {"t", "m"},

                {"u", "b"},
                {"v", "d"},
                {"w", "f"},
                {"x", "h"},
                {"y", "j"},
                {"z", "l"}
            };
            Dictionary<string, string> dictionary2 = new Dictionary<string, string>()
            {
                {"a", "n"},
                {"b", "p"},
                {"c", "r"},
                {"d", "t"},
                {"e", "v"},
                {"f", "x"},
                {"g", "z"},
                {"h", "o"},
                {"i", "q"},
                {"j", "s"},

                {"k", "u"},
                {"l", "w"},
                {"m", "y"},
                {"n", "a"},
                {"o", "h"},
                {"p", "b"},
                {"q", "i"},
                {"r", "c"},
                {"s", "j"},
                {"t", "d"},

                {"u", "k"},
                {"v", "e"},
                {"w", "l"},
                {"x", "f"},
                {"y", "m"},
                {"z", "g"}
            };
            Dictionary<string, string> dictionary3 = new Dictionary<string, string>()
            {
                {"a", "d"},
                {"b", "p"},
                {"c", "i"},
                {"d", "a"},
                {"e", "g"},
                {"f", "y"},
                {"g", "e"},
                {"h", "n"},
                {"i", "c"},
                {"j", "l"},

                {"k", "r"},
                {"l", "j"},
                {"m", "u"},
                {"n", "h"},
                {"o", "z"},
                {"p", "b"},
                {"q", "x"},
                {"r", "k"},
                {"s", "t"},
                {"t", "s"},

                {"u", "m"},
                {"v", "w"},
                {"w", "v"},
                {"x", "q"},
                {"y", "f"},
                {"z", "o"}
            };
            Dictionary<string, string> dictionary4 = new Dictionary<string, string>()
            {
                {"a", "b"},
                {"b", "a"},
                {"c", "z"},
                {"d", "n"},
                {"e", "v"},
                {"f", "g"},
                {"g", "f"},
                {"h", "o"},
                {"i", "q"},
                {"j", "y"},

                {"k", "r"},
                {"l", "u"},
                {"m", "x"},
                {"n", "d"},
                {"o", "h"},
                {"p", "t"},
                {"q", "i"},
                {"r", "k"},
                {"s", "w"},
                {"t", "p"},

                {"u", "l"},
                {"v", "e"},
                {"w", "s"},
                {"x", "m"},
                {"y", "j"},
                {"z", "c"}
            };
            Dictionary<string, string> dictionary5 = new Dictionary<string, string>()
            {
                {"a", "m"},
                {"b", "k"},
                {"c", "o"},
                {"d", "l"},
                {"e", "i"},
                {"f", "r"},
                {"g", "n"},
                {"h", "p"},
                {"i", "e"},
                {"j", "z"},

                {"k", "b"},
                {"l", "d"},
                {"m", "a"},
                {"n", "g"},
                {"o", "c"},
                {"p", "h"},
                {"q", "w"},
                {"r", "f"},
                {"s", "x"},
                {"t", "u"},

                {"u", "t"},
                {"v", "y"},
                {"w", "q"},
                {"x", "s"},
                {"y", "v"},
                {"z", "j"}
            };

            rotor1 = new Rotor(dictionary1);
            rotor2 = new Rotor(dictionary2);
            rotor3 = new Rotor(dictionary3);
            rotor4 = new Rotor(dictionary4);
            rotor5 = new Rotor(dictionary5);
        }
        
        private bool sameDictionaries(Dictionary<string, string> d1, Dictionary<string, string> d2)
        {   
            return (d1.Count == d2.Count && !d1.Except(d2).Any());
        }

    }
}
