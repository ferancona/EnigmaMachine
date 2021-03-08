using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnigmaMachine.Classes
{
    class RotorGroup
    {
        // Internal Variables
        private Rotor r1;
        private Rotor r2;
        private Rotor r3;
        private Rotor reflector = new Rotor(new Dictionary<string, string>()
        {
            {"a", "e"},
            {"b", "k"},
            {"c", "j"},
            {"d", "o"},
            {"e", "a"},
            {"f", "g"},
            {"g", "f"},
            {"h", "z"},
            {"i", "r"},
            {"j", "c"},

            {"k", "b"},
            {"l", "s"},
            {"m", "t"},
            {"n", "u"},
            {"o", "d"},
            {"p", "y"},
            {"q", "v"},
            {"r", "i"},
            {"s", "l"},
            {"t", "m"},

            {"u", "n"},
            {"v", "q"},
            {"w", "x"},
            {"x", "w"},
            {"y", "p"},
            {"z", "h"}
        });

        // Constructor
        public RotorGroup(Rotor rotor1, Rotor rotor2, Rotor rotor3)
        {
            if (rotor1 != null && rotor2 != null && rotor3 != null)
            {
                r1 = new Rotor(rotor1);
                r2 = new Rotor(rotor2);
                r3 = new Rotor(rotor3);
            }
        }

        // Properties
        public int PositionR1
        {
            get
            {
                return r1.Position;
            }
            set
            {
                r1.Position = value;
            }
        }
        public int PositionR2
        {
            get
            {
                return r2.Position;
            }
            set
            {
                r2.Position = value;
            }
        }
        public int PositionR3
        {
            get
            {
                return r3.Position;
            }
            set
            {
                r3.Position = value;
            }
        }
        public Rotor R1
        {
            get
            {
                return r1;
            }
        }
        public Rotor R2
        {
            get
            {
                return r2;
            }
        }
        public Rotor R3
        {
            get
            {
                return r3;
            }
        }

        // Methods
        public string Output(string letter)
        {
            string reflectedLetter = reflector.Output(r3.Output(r2.Output(r1.Output(letter))));
            string resultLetter = r1.OutputInverse(r2.OutputInverse(r3.OutputInverse(reflectedLetter)));
            return resultLetter;
        }

        public void Rotate()
        {
            bool fullTurnR1 = (r1.Rotate() == 0 ? true : false);
            if (fullTurnR1)
            {
                bool fullTurnR2 = (r2.Rotate() == 0 ? true : false);
                if (fullTurnR2)
                {
                    r3.Rotate();
                }
            }
        }
        public void RotateInverse()
        {
            bool turnBackR1 = (r1.RotateInverse() == 25 ? true : false);
            if (turnBackR1)
            {
                bool turnBackR2 = (r2.RotateInverse() == 25 ? true : false);
                if (turnBackR2)
                {
                    r3.RotateInverse();
                }
            }
        }

        public void SetRotors(Rotor rotor1, Rotor rotor2, Rotor rotor3)
        {
            if (rotor1 != null && rotor2 != null && rotor3 != null)
            {
                r1 = new Rotor(rotor1);
                r2 = new Rotor(rotor2);
                r3 = new Rotor(rotor3);
            }
        }

        // Private Functions
        private bool posInRange(int val)
        {
            return (val >= 0 && val <= 25);
        }

    }
}
