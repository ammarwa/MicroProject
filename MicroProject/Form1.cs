using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicroProject
{
    public partial class Form1 : Form
    {
        int TableKey = 0;
        string[] lines;
        DataTable Memory = new DataTable();
        DataTable Registers = new DataTable();
        Dictionary<String, String> instructionFunction;
        Dictionary<String, String> instructionOpcode;
        int clockCycle;
        string writeRegister = "";
        public Form1()
        {
            InitializeComponent();
        }
    }
}
