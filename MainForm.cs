using System;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;
using System.Collections.Generic;


namespace Flying47
{
    public partial class MainForm : Form
    {
        // Base address value for pointers.
        int baseAddress = 0x10000000;

        // Other variables.
        System.Text.Encoding enc = System.Text.Encoding.UTF8;
        Process[] myProcess;
        string processName;

        float readCoordX = 0;
        float readCoordY = 0;
        float readCoordZ = 0;

        float CoordZ = 0;

        int adressCoord = 0x00E21358;
        int[] offsetX = new int[] { 0x44, 0x28 };
        int[] offsetY = new int[] { 0x44, 0x2c };
        int[] offsetZ = new int[] { 0x44, 0x30 };

        Keys ToggleKey = Keys.F2;

        Keys Up = Keys.NumPad9;
        Keys Down = Keys.NumPad3;

        string CurrentKeyChange;

        bool freezeEnabled;
        bool settingInputKey;


        /*------------------
        -- INITIALIZATION --
        ------------------*/
        public MainForm()
        {
            InitializeComponent();
            processName = "hma";
        }

        bool foundProcess = false;

        private void Timer_Tick(object sender, EventArgs e)
        {
            myProcess = Process.GetProcessesByName(processName);
            if (myProcess.Length > 0)
            {
                IntPtr startOffset = myProcess[0].MainModule.BaseAddress;
                IntPtr endOffset = IntPtr.Add(startOffset, myProcess[0].MainModule.ModuleMemorySize);
                baseAddress = startOffset.ToInt32();
                if (foundProcess == false)
                    System.Threading.Thread.Sleep(1000);
                foundProcess = true;
            }
            else
                foundProcess = false;

            if (foundProcess)
            {
                // The game is running, ready for memory reading.
                LB_Running.Text = "Hitman: Absolution is running";
                LB_Running.ForeColor = Color.Green;

                readCoordX = Trainer.ReadPointerFloat(processName, baseAddress + adressCoord, offsetX);
                L_X.Text = readCoordX.ToString();
                readCoordY = Trainer.ReadPointerFloat(processName, baseAddress + adressCoord, offsetY);
                L_Y.Text = readCoordY.ToString();
                readCoordZ = Trainer.ReadPointerFloat(processName, baseAddress + adressCoord, offsetZ);
                L_Z.Text = readCoordZ.ToString();

                if (freezeEnabled)
                    freeze();
                InitHotkey();
            }
            else
            {
                // The game process has not been found, reseting values.
                LB_Running.Text = "Hitman: Absolution is NOT running";
                LB_Running.ForeColor = Color.Red;
                ResetValues();
            }
        }

        // Called when the game is not running or no mission is active.
        // Used to reset all the values.
        private void ResetValues()
        {
            L_X.Text = "0";
            L_Y.Text = "0";
            L_Z.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitHotkey();
            Timer.Start();
        }

        public void InitHotkey()
        {
            if (!KeyGrabber.Hooked)
            {
                KeyGrabber.key.Clear();
                KeyGrabber.keyPressEvent += KeyGrabber_KeyPress;
                if (ToggleKey != Keys.None)
                    KeyGrabber.key.Add(ToggleKey);

                if (Up != Keys.None)
                    KeyGrabber.key.Add(Up);

                if (Down != Keys.None)
                    KeyGrabber.key.Add(Down);

                KeyGrabber.SetHook();
            }
            else
            {
                if (ToggleKey != Keys.None || Down != Keys.None || Up != Keys.None)
                {
                    KeyGrabber.key.Clear();
                    KeyGrabber.key.Add(ToggleKey);
                    KeyGrabber.key.Add(Up);
                    KeyGrabber.key.Add(Down);
                }
            }
        }

        public void UnHook()
        {
            KeyGrabber.UnHook();
        }


        private void KeyGrabber_KeyPress(object sender, EventArgs e)
        {
            if (((Keys)sender) == ToggleKey)
            {
                if (C_Freeze.Checked)
                    C_Freeze.Checked = false;
                else
                    C_Freeze.Checked = true;
            }
            if (((Keys)sender) == Up)
                SendMeUp();
            else if (((Keys)sender) == Down)
                SendMeDown();
        }

        private void freeze()
        {
            if (readCoordZ != CoordZ)
                Trainer.WritePointerFloat(processName, baseAddress + adressCoord, offsetZ, CoordZ);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (settingInputKey)
            {
                C_Freeze.Checked = false;
                if (CurrentKeyChange == "ToggleKey")
                {
                    ToggleKey = keyData;
                    b_ToggleKey_mod.Text = ToggleKey.ToString();
                    b_ToggleKey_mod.Checked = false;
                }
                else if (CurrentKeyChange == "UpKey")
                {
                    Up = keyData;
                    b_Up_mod.Text = Up.ToString();
                    b_Up_mod.Checked = false;
                }
                else if (CurrentKeyChange == "DownKey")
                {
                    Down = keyData;
                    b_Down_mod.Text = Down.ToString();
                    b_Down_mod.Checked = false;
                }
                InitHotkey();
                return true;
            }
                
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void B_Key_CheckedChanged(object sender, EventArgs e)
        {
            if (b_ToggleKey_mod.Checked)
            {
                settingInputKey = true;
                b_ToggleKey_mod.Text = "";
                CurrentKeyChange = "ToggleKey";
            }
            else
            {
                settingInputKey = false;
            }
        }

        private void b_Up_mod_CheckedChanged(object sender, EventArgs e)
        {
            if (b_Up_mod.Checked)
            {
                settingInputKey = true;
                b_Up_mod.Text = "";
                CurrentKeyChange = "UpKey";
            }
            else
            {
                settingInputKey = false;
            }

        }

        private void b_Down_mod_CheckedChanged(object sender, EventArgs e)
        {
            if (b_Down_mod.Checked)
            {
                settingInputKey = true;
                b_Down_mod.Text = "";
                CurrentKeyChange = "DownKey";
            }
            else
            {
                settingInputKey = false;
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnHook();
        }

        private void C_KeyMode_CheckedChanged(object sender, EventArgs e)
        {
            if (C_Freeze.Checked)
            {
                CoordZ = readCoordZ;
                freezeEnabled = true;
            }
            else
            {
                freezeEnabled = false;
            }
        }

        private void SendMeUp()
        {
            CoordZ = CoordZ + 0.5f;
        }
        private void SendMeDown()
        {
            CoordZ = CoordZ - 0.5f;
        }
    }
}
