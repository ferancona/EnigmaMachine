using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnigmaMachine.Classes;


namespace EnigmaMachine
{
    public partial class Enigma : Form
    {
        Machine machine;
        List<ComboBox> cbxs_plugboard;
        List<Label> lbls_keyboard;
        int previousCbxPlugValue;

        public Enigma()
        {
            InitializeComponent();

            InitializeMachine();
            InitializeUI();

            //tests();
        }

        public void InitializeMachine()
        {
            machine = new Machine();
        }
        public void InitializeUI()
        {
            initUIValues();     // For machine
            saveComboBoxesInList();
            saveButtonsInList();
        }
        private void saveComboBoxesInList()
        {
            cbxs_plugboard = new List<ComboBox>();
            cbxs_plugboard.Add(plug1_1);
            cbxs_plugboard.Add(plug1_2);
            cbxs_plugboard.Add(plug2_1);
            cbxs_plugboard.Add(plug2_2);
            cbxs_plugboard.Add(plug3_1);
            cbxs_plugboard.Add(plug3_2);
            cbxs_plugboard.Add(plug4_1);
            cbxs_plugboard.Add(plug4_2);
            cbxs_plugboard.Add(plug5_1);
            cbxs_plugboard.Add(plug5_2);

            cbxs_plugboard.Add(plug6_1);
            cbxs_plugboard.Add(plug6_2);
            cbxs_plugboard.Add(plug7_1);
            cbxs_plugboard.Add(plug7_2);
            cbxs_plugboard.Add(plug8_1);
            cbxs_plugboard.Add(plug8_2);
            cbxs_plugboard.Add(plug9_1);
            cbxs_plugboard.Add(plug9_2);
            cbxs_plugboard.Add(plug10_1);
            cbxs_plugboard.Add(plug10_2);
        }
        private void saveButtonsInList()
        {
            lbls_keyboard = new List<Label>();
            lbls_keyboard.Add(lbl_a);
            lbls_keyboard.Add(lbl_b);
            lbls_keyboard.Add(lbl_c);
            lbls_keyboard.Add(lbl_d);
            lbls_keyboard.Add(lbl_e);
            lbls_keyboard.Add(lbl_f);
            lbls_keyboard.Add(lbl_g);
            lbls_keyboard.Add(lbl_h);
            lbls_keyboard.Add(lbl_i);
            lbls_keyboard.Add(lbl_j);
            lbls_keyboard.Add(lbl_k);
            lbls_keyboard.Add(lbl_l);
            lbls_keyboard.Add(lbl_m);
            lbls_keyboard.Add(lbl_n);
            lbls_keyboard.Add(lbl_o);
            lbls_keyboard.Add(lbl_p);
            lbls_keyboard.Add(lbl_q);
            lbls_keyboard.Add(lbl_r);
            lbls_keyboard.Add(lbl_s);
            lbls_keyboard.Add(lbl_t);
            lbls_keyboard.Add(lbl_u);
            lbls_keyboard.Add(lbl_v);
            lbls_keyboard.Add(lbl_w);
            lbls_keyboard.Add(lbl_x);
            lbls_keyboard.Add(lbl_y);
            lbls_keyboard.Add(lbl_z);
        }
        private void initUIValues()
        {
            // Rotor Selection (1, 2, 3)
            cbx_rotor3.SelectedIndex = 0;
            cbx_rotor2.SelectedIndex = 1;
            cbx_rotor1.SelectedIndex = 2;

            // Rotor Positions (all start at 0)
            cbx_rotor1Pos.SelectedIndex = 0;
            cbx_rotor2Pos.SelectedIndex = 0;
            cbx_rotor3Pos.SelectedIndex = 0;
        }

        // Tests: Rotor, RotorGroup, Plugboard and Machine
        public void tests()
        {
            //testRotor();      // Good
            //testRotorGroup();     // Good
            //testPlugboard();        // Good
            testMachine();      // Good
        }
        public void testRotor()
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
                {"z", "k"}
            };
            Rotor r = new Rotor(dictionary1);
            
            MessageBox.Show(r.Output("a"));
            r.Rotate();
            MessageBox.Show(r.Output("a"));
            MessageBox.Show(r.OutputInverse("u"));

        }
        public void testRotorGroup()
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
                {"z", "k"}
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
            Rotor r1 = new Rotor(dictionary1);
            Rotor r2 = new Rotor(dictionary2);
            Rotor r3 = new Rotor(dictionary3);

            RotorGroup rg = new RotorGroup(r1, r2, r3);

            //rg.Output("a");
            //MessageBox.Show(rg.Output("a"));
            rg.Rotate();

            MessageBox.Show("Rotation Happened!");
            rg.Output("a");
            //MessageBox.Show(rg.Output("a"));
        }
        public void testPlugboard()
        {
            Plugboard p = new Plugboard();
            Dictionary<string, string> d = new Dictionary<string, string>()
            {
                {"B", "C" }
            };

            MessageBox.Show(p.Output("a"));
            MessageBox.Show(p.Output("b"));
            p.Connections = d;
            MessageBox.Show(p.Output("b"));
            MessageBox.Show(p.Output("c"));
        }
        public void testMachine()
        {
            MessageBox.Show(machine.EncodeLetter("a"));
            // 0 - A ; 16 - Q
            Dictionary<string, string> plugs = new Dictionary<string, string>() { {"A", "F" } };
            machine.Plugboard = plugs;

            //Dictionary<string, string> pb = machine.Plugboard;

            //foreach (KeyValuePair<string, string> pair in pb)
            //{
            //    MessageBox.Show("Key: " + pair.Key + ", Value: " + pair.Value);
            //}

            MessageBox.Show(machine.EncodeLetter("a"));
        }

        // Machine object control
        private void updateMachinePlugboard(Dictionary<string, string> plugs)
        {
            machine.Plugboard = plugs;
        }
        private void updateMachineRotors()
        {
            machine.SetRotors(new int[3] { cbx_rotor3.SelectedIndex + 1,
                cbx_rotor2.SelectedIndex + 1, cbx_rotor1.SelectedIndex + 1 });
        }

        private void Enigma_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue >= 65 && e.KeyValue <= 90)
            {
                txt_test.Text += machine.EncodeLetter(e.KeyCode.ToString()) + " ";
            }
            else if (e.KeyCode.ToString() == "Back")
            {

                txt_test.Text += "YES ";
            }

            cbx_rotor1Pos.SelectedIndex = machine.PositionR1;
        }

        // Validates that one rotor is not used more than once
        private void validateRotorSelection(object sender, EventArgs e)
        {
            ComboBox cbxSender = (ComboBox)sender;
            List<ComboBox> cbxs = new List<ComboBox>() { cbx_rotor3, cbx_rotor2, cbx_rotor1 };

            int cbxIndex = cbxs.IndexOf(cbxSender);
            int nextCbxIndex = (cbxs.IndexOf(cbxSender) + 1) % 3;
            int prevCbxIndex = (cbxs.IndexOf(cbxSender) + 2) % 3;

            int rotorSelection = cbxs[cbxIndex].SelectedIndex;
            int nextRotorSelection = cbxs[nextCbxIndex].SelectedIndex;
            int prevRotorSelection = cbxs[prevCbxIndex].SelectedIndex;

            if (rotorSelection == nextRotorSelection ||
                rotorSelection == prevRotorSelection)
            {
                if (rotorSelection == nextRotorSelection)
                {
                    int nextSelection = (nextRotorSelection + 1) % 5;
                    cbxs[nextCbxIndex].SelectedIndex = (nextSelection != prevRotorSelection) ? nextSelection : (nextSelection + 1) % 5;
                }
                else
                {
                    int nextSelection = (prevRotorSelection + 1) % 5;
                    cbxs[prevCbxIndex].SelectedIndex = (nextSelection != nextRotorSelection) ? nextSelection : (nextSelection + 1) % 5;
                }
            }

            updateMachineRotors();
        }

        // Reset Plugboard
        private void btn_resetPlugboard_Click(object sender, EventArgs e)
        {
            foreach (ComboBox cbx in cbxs_plugboard)
            {
                cbx.SelectedIndex = -1;
            }
        }

        // Control of plugs
        private void cbx_plugs_Enter(object sender, EventArgs e)
        {
            previousCbxPlugValue = ((ComboBox)sender).SelectedIndex;
        }
        private void cbx_plugs_IndexChanged(object sender, EventArgs e)
        {
            ComboBox cbx_sender = (ComboBox)sender;
            int selectedIndex = cbx_sender.SelectedIndex;
            if (isPlugPlaceTaken(selectedIndex) && selectedIndex != -1)
            {
                MessageBox.Show("This letter is being used by a plug!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbx_sender.SelectedIndex = previousCbxPlugValue;
            }
            else
            {
                RetrievePlugboardValues();
            }
        }
        private bool isPlugPlaceTaken(int i)
        {
            int counter = 0;
            foreach (ComboBox cbx in cbxs_plugboard)
            {
                if (cbx.SelectedIndex == i)
                {
                    counter++;
                }
            }
            return counter > 1;
        }
        private void RetrievePlugboardValues()
        {
            updateMachinePlugboard(GetSelectedPlugs());
        }
        private Dictionary<string, string> GetSelectedPlugs()
        {
            Dictionary<string, string> plugs = new Dictionary<string, string>();

            if (plug1_1.SelectedIndex != -1 && plug1_2.SelectedIndex != -1)
            {
                plugs.Add(plug1_1.Text, plug1_2.Text);
            }
            if (plug2_1.SelectedIndex != -1 && plug2_2.SelectedIndex != -1)
            {
                plugs.Add(plug2_1.Text, plug2_2.Text);
            }
            if (plug3_1.SelectedIndex != -1 && plug3_2.SelectedIndex != -1)
            {
                plugs.Add(plug3_1.Text, plug3_2.Text);
            }
            if (plug4_1.SelectedIndex != -1 && plug4_2.SelectedIndex != -1)
            {
                plugs.Add(plug4_1.Text, plug4_2.Text);
            }
            if (plug5_1.SelectedIndex != -1 && plug5_2.SelectedIndex != -1)
            {
                plugs.Add(plug5_1.Text, plug5_2.Text);
            }
            if (plug6_1.SelectedIndex != -1 && plug6_2.SelectedIndex != -1)
            {
                plugs.Add(plug6_1.Text, plug6_2.Text);
            }
            if (plug7_1.SelectedIndex != -1 && plug7_2.SelectedIndex != -1)
            {
                plugs.Add(plug7_1.Text, plug7_2.Text);
            }
            if (plug8_1.SelectedIndex != -1 && plug8_2.SelectedIndex != -1)
            {
                plugs.Add(plug8_1.Text, plug8_2.Text);
            }
            if (plug9_1.SelectedIndex != -1 && plug9_2.SelectedIndex != -1)
            {
                plugs.Add(plug9_1.Text, plug9_2.Text);
            }
            if (plug10_1.SelectedIndex != -1 && plug10_2.SelectedIndex != -1)
            {
                plugs.Add(plug10_1.Text, plug10_2.Text);
            }

            return plugs;
        }
        private string PlugboardToString()
        {
            Dictionary<string, string> plugs = GetSelectedPlugs();
            string plugsInString = "Plugboard: ";

            foreach(KeyValuePair<string, string> pair in plugs)
            {
                plugsInString += String.Format("[ {0}, {1} ]  ", pair.Key, pair.Value);
            }
            return plugsInString;
        }


        // Control of Rotor Positions
        private void cbx_rotor1Pos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_rotor1Pos.SelectedIndex != -1)
            {
                machine.PositionR1 = cbx_rotor1Pos.SelectedIndex;
            }
        }
        private void cbx_rotor2Pos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_rotor2Pos.SelectedIndex != -1)
            {
                machine.PositionR2 = cbx_rotor2Pos.SelectedIndex;
            }
        }
        private void cbx_rotor3Pos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_rotor3Pos.SelectedIndex != -1)
            {
                machine.PositionR3 = cbx_rotor3Pos.SelectedIndex;
            }
        }

        // Manage Encoding in machine and write in output
        private void txt_inEnc_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(e.KeyCode.ToString());

            if (e.KeyCode.ToString() != "Space")
            {
                if (e.KeyValue >= 65 && e.KeyValue <= 90)
                {
                    if (txt_inEnc.Text.Length == 0)
                    {
                        PrintMachineState(txt_configEnc);
                    }
                    string outLetter = machine.EncodeLetter(e.KeyCode.ToString());
                    txt_test.Text += outLetter + " ";
                    txt_outEnc.Text += outLetter;
                    RefreshKeyBoard(outLetter);
                }
                else if (e.KeyCode.ToString() == "Back")
                {
                    // Besides of text deleting last space Rotor returned to previous state
                    if (txt_inEnc.Text.Length > 0)
                    {
                        machine.ReturnPreviousState();
                        txt_outEnc.Text = txt_outEnc.Text.Remove(txt_outEnc.Text.Length - 1);
                    }
                    if (txt_inEnc.Text.Length == 1)
                    {
                        txt_configEnc.Text = "";
                    }
                }
                UpdateRotors();
            }
        }
        private void txt_inDec_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() != "Space")
            {
                if (e.KeyValue >= 65 && e.KeyValue <= 90)
                {
                    if (txt_inDec.Text.Length == 0)
                    {
                        PrintMachineState(txt_configDec);
                    }

                    //MessageBox.Show(typeof(string).Assembly.ImageRuntimeVersion);
                    string outLetter = machine.EncodeLetter(e.KeyCode.ToString());
                    txt_test.Text += outLetter + " ";
                    txt_outDec.Text += outLetter;
                    RefreshKeyBoard(outLetter);
                }
                else if (e.KeyCode.ToString() == "Back")
                {
                    // Besides of text deleting last space Rotor returned to previous state
                    if (txt_inDec.Text.Length > 0)
                    {
                        machine.ReturnPreviousState();
                        txt_outDec.Text = txt_outDec.Text.Remove(txt_outDec.Text.Length - 1);
                    }
                    if (txt_inDec.Text.Length == 1)
                    {
                        txt_configDec.Text = "";
                    }
                }
            }
            UpdateRotors();
        }
        private void RefreshKeyBoard(string letter)
        {
            foreach (Label lbl in lbls_keyboard)
            {
                lbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            }
            foreach (Label lbl in lbls_keyboard)
            {
                if (lbl.Text == letter)
                {
                    lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                }
            }
        }
        private void UpdateRotors()
        {
            cbx_rotor1Pos.SelectedIndex = machine.PositionR1;
            cbx_rotor2Pos.SelectedIndex = machine.PositionR2;
            cbx_rotor3Pos.SelectedIndex = machine.PositionR3;
        }

        private void PrintMachineState(TextBox t)
        {
            string rotorsConfig = String.Format("R#: {0} - {1} - {2} \r\n", cbx_rotor3.SelectedIndex+1,
                            cbx_rotor2.SelectedIndex + 1, cbx_rotor1.SelectedIndex + 1);
            string rotorsPosConfig = String.Format("Positions: {0} - {1} - {2} \r\n",
                cbx_rotor3Pos.SelectedIndex + 1, cbx_rotor2Pos.SelectedIndex + 1,
                cbx_rotor1Pos.SelectedIndex + 1);
            
            t.Text = rotorsConfig + rotorsPosConfig + PlugboardToString();
        }

        // Validates characters in input and removes selection in textboxes
        private void ValidateCharacters(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (!System.Text.RegularExpressions.Regex.IsMatch(textbox.Text, "^[a-zA-Z ]"))
            {
                //MessageBox.Show("This textbox accepts only alphabetical characters");

                if (textbox.Text.Length > 0)
                {
                    textbox.Text = textbox.Text.Remove(textbox.Text.Length - 1);
                }
            }
        }
        private void RemoveSelection(object sender, MouseEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (textbox != null)
            {
                textbox.SelectionLength = 0;
                textbox.SelectionStart = textbox.Text.Length;
            }
        }
    }
}
