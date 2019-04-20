using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Autoverhuur
{
    public partial class Form1 : Form
    {
        // Tariefen
        int dagBedragAuto = 50;
        int dagBedragBus = 95;
        decimal auto = 0.20m;
        decimal bus = 0.30m;

        public Form1()
        {
            InitializeComponent();
        }
        private int daysPassed(DateTime d1, DateTime d2)
        {
            return (d2 - d1).Days;

        }

        private void Bereken_Click(object sender, EventArgs e)
        {
            DateTime d1 = VanDatum.Value;
            DateTime d2 = TotDatum.Value;

            decimal bedrag = 0;
            int days = daysPassed(d1, d2);
            int dKm = days * 100;
            int km = 0;
            int dagBedrag = 0;
            decimal kmBedrag = 0;

            if (radioAuto.Checked)
            {
                dagBedrag = dagBedragAuto;
                kmBedrag = auto;
            }
            else
            {
                dagBedrag = dagBedragBus;
                kmBedrag = bus;
            }

            if (Int32.TryParse(Kilometers.Text, out km))
            {
                bedrag += (days * dagBedrag);
                //MessageBox.Show((days * dagBedrag).ToString());
                km = (km - dKm) > 0 ? (km - dKm) : 0;
                bedrag += km * kmBedrag;
                //MessageBox.Show("Km = " + km.ToString());
            }
            else
                MessageBox.Show("Please enter a valid number in kilometers");
            //MessageBox.Show("Days: " + days.ToString());
            MessageBox.Show("Te betalen bedrag = " + bedrag.ToString());
        }
    }
}
