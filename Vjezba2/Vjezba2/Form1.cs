using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vjezba2
{
    public partial class Form1 : Form
    {
        List<string> listaTroskova;

        public Form1()
        {
            InitializeComponent();
            listaTroskova = new List<string>();
            uiActionOdaberiKategoriju.Items.Add("Hrana");
            uiActionOdaberiKategoriju.Items.Add("Piće");
            uiActionOdaberiKategoriju.Items.Add("Zabava");
            uiActionOdaberiKategoriju.Items.Add("Kurve");

            uiActionOdaberiKategoriju.SelectedIndex = 0;

            uiActionFiltriraj.Items.Add("Hrana");
            uiActionFiltriraj.Items.Add("Piće");
            uiActionFiltriraj.Items.Add("Zabava");
            uiActionFiltriraj.Items.Add("Kurve");

            uiActionFiltriraj.SelectedIndex = 0;
        }

        private void uiDodajTrosak_Click(object sender, EventArgs e)
        {
            string unos = uiActionOdaberiKategoriju.SelectedItem + " - " + uiUnosTroska.Text + " kn";
            listaTroskova.Add(unos);

            uiIspisTroskova.Text = "";

            for (int i = listaTroskova.Count -1; i >= 0 ; i--)
            {
                uiIspisTroskova.Text += listaTroskova[i] + Environment.NewLine;
            }
        }

        private void uiActionFiltriraj_SelectedIndexChanged(object sender, EventArgs e)
        {
            uiIspisTroskova.Text = "";

            for (int i = listaTroskova.Count - 1; i >= 0; i--)
            {
                if (listaTroskova[i].Contains((string)uiActionFiltriraj.SelectedItem))
                uiIspisTroskova.Text += listaTroskova[i] + Environment.NewLine;
            }
        }
    }
}
