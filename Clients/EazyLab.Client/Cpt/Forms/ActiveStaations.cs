using EazyLab.Client.Classes;
using EazyLabClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EazyLab.Client.Forms
{
    public partial class ActiveStaations : Form
    {
        public ActiveStaations()
        {
            InitializeComponent();
            foreach (RtuStation ST in Program.Chamber.Stations)
            {
                int Position = ST.PositionInRomm;
                switch (Position)
                {
                    case 1: CB1.Enabled = true; break;
                    case 2: CB2.Enabled = true; break;
                    case 3: CB3.Enabled = true; break;
                    case 4: CB4.Enabled = true; break;
                }
            }

            //foreach (RtuStation ST in Program.Chamber.ActiveSamples)
            //{
            //    int Position = ST.PositionInRomm;
            //    switch (Position)
            //    {
            //        case 1: CB1.Checked = true; break;
            //        case 2: CB2.Checked = true; break;
            //        case 3: CB3.Checked = true; break;
            //        case 4: CB4.Checked = true; break;
            //    }
            //}

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if (CB1.Checked)
            //    Program.Chamber.ActiveSamples.Add(Program.Chamber.Samples.Find(X  => X.PositionInRomm == 1));
            //if (CB2.Checked)
            //    Program.Chamber.ActiveSamples.Add(Program.Chamber.Samples.Find(X => X.PositionInRomm == 2));
            //if (CB3.Checked)
            //    Program.Chamber.ActiveSamples.Add(Program.Chamber.Samples.Find(X => X.PositionInRomm == 3));
            //if (CB4.Checked)
            //    Program.Chamber.ActiveSamples.Add(Program.Chamber.Samples.Find(X => X.PositionInRomm == 4));

            Close();
        }
    }
}
