using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaMachine.Classes
{
    class Plugboard
    {
        // Internals Variables
        private Dictionary<string, string> connections;

        // Constructor
        public Plugboard()
        {
            ResetConnections();
        }

        // Properties
        public Dictionary<string, string> Connections
        {
            get
            {
                return connections;
            }
            set
            {
                ResetConnections();
                // Assumes that 'plugs' have valid and different connections
                foreach (KeyValuePair<string, string> plug in value)
                {
                    connections[plug.Key.ToUpper()] = plug.Value.ToUpper();
                    connections[plug.Value.ToUpper()] = plug.Key.ToUpper();
                }
            }
        }

        // Methods
        public string Output(string letter)
        {
            return connections[letter.ToUpper()];
        }

        // Private Functions
        private void ResetConnections()
        {
            connections = new Dictionary<string, string>()
            {
                {"A", "A"},
                {"B", "B"},
                {"C", "C"},
                {"D", "D"},
                {"E", "E"},
                {"F", "F"},
                {"G", "G"},
                {"H", "H"},
                {"I", "I"},
                {"J", "J"},

                {"K", "K"},
                {"L", "L"},
                {"M", "M"},
                {"N", "N"},
                {"O", "O"},
                {"P", "P"},
                {"Q", "Q"},
                {"R", "R"},
                {"S", "S"},
                {"T", "T"},

                {"U", "U"},
                {"V", "V"},
                {"W", "W"},
                {"X", "X"},
                {"Y", "Y"},
                {"Z", "Z"}
            };
        }

    }
}
