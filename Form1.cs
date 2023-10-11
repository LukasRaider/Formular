using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Lukas_Huvar_zkouska
{
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
            timer1.Start();
            timer2.Start();
            ProgBar.Maximum = 50;
            // dodelat do jednoho labelu 
            RBFabia.CheckedChanged += UpdateLabel;
            RBOctavia.CheckedChanged += UpdateLabel;
            RBYetti.CheckedChanged += UpdateLabel;
            RBRoomster.CheckedChanged += UpdateLabel;
            CBsvet.CheckedChanged += UpdateLabel;
            CBSTRES.CheckedChanged += UpdateLabel;
            CBBarva.SelectedIndexChanged += UpdateLabel;
            TBMesto.TextChanged += Obsah;
            TBPSC.TextChanged += Obsah;

            
        }
        private void UpdateLabel(object sender, EventArgs e)
        {
            // Vytvořte text na základě stavu radio buttonů a checkboxů
            string text = "Auto: ";
            if (RBFabia.Checked)
                text += "Fabia, ";
            if (RBOctavia.Checked)
                text += "Octavia, ";
            if (RBYetti.Checked)
                text += "Yetti, ";
            if (RBRoomster.Checked)
                text += "Roomster, ";
            if (CBsvet.Checked)
                text += "svetlomety, ";
            if (CBSTRES.Checked)
                text += "stresni nosic, ";


            

            if (CBBarva.SelectedIndex != -1)
               text += "barva " + CBBarva.SelectedItem.ToString();

            // Odstranit trailing "," pokud je potřeba
            if (text.EndsWith(", "))
                text = text.Remove(text.Length - 2);

            // Aktualizovat text labelu
            LabVypis.Text = text;
        }

        private void Obsah(object sender, EventArgs  e)
        {
            string Misto;
            Misto = TBMesto.Text + " , " + TBPSC.Text;
            LabMisto.Text = Misto;

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
        private void konecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            timer2.Stop();
        }

        private void ButtonEsc_Click(object sender, EventArgs e)
        {
            this.Close();
            timer2.Stop();
        }

        private void napovědaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pro nápovědu kontaktujte správce.");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.STATCAS.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            // casovac progress baru
            this.ProgBar.Increment(10);
            this.StatBar.Text = "stranka se nacita - čekejte(" + (5 - this.ProgBar.Value / 10).ToString() + "s)";
            if (this.ProgBar.Value == this.ProgBar.Maximum) timer2.Stop();
        }

        private void otevřítToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult DR = openFileDialog1.ShowDialog();
            if (DR == DialogResult.OK)
            {
                //nacitani souboru

                string cestaSoubor = openFileDialog1.FileName;

                String obsahSouboru = File.ReadAllText(cestaSoubor);
                TextBox.Text = "Obsah nacteneho souboru : " + obsahSouboru;

            }
            else
            {
                MessageBox.Show("Soubor nelze otevřít.");
            }
        }

        private void uložitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ukladani souboru

            DialogResult DR = saveFileDialog1.ShowDialog();
            if (DR == DialogResult.OK)
            {
                string fileToSave = saveFileDialog1.FileName;
                System.IO.File.WriteAllText(fileToSave, TextBox.Text);

            }
            else
            {
                MessageBox.Show("Soubor nelze uložit.");
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TBSyt_Scroll(object sender, EventArgs e)
        {
            STATBARS.Text = TBSyt.Value.ToString() + " %";
        }

        private void CBBarva_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                CBBarva.Items.Add(CBBarva.Text);
            }
        }

        private void TBMesto_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void labPSC_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void mesto(string M)
        {
            
            
        }
        private void PSC(string P)
        {
            
            
        }
        private void RBFabia_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void RBOctavia_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void RBYetti_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void RBRoomster_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void CBsvet_CheckedChanged(object sender, EventArgs e)
        {
            if (CBsvet.Checked)
            {
                
            }
            else
            {
                
            }
        }

        private void CBSTRES_CheckedChanged(object sender, EventArgs e)
        {
            if (CBSTRES.Checked)
            {
                
            }
            else
            {
                
            }
        }

        private void PocetKop_ValueChanged(object sender, EventArgs e)
        {
            StatPOCETT.Text = PocetKop.Value.ToString();
        }

        private void CBBarva_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
        public void ComboChange(String S)
        {
            LabVypis.Text += S;
        }

        private void labMesto_Click(object sender, EventArgs e)
        {

        }

        private void TBPSC_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Enter(object sender, KeyPressEventArgs e)
        {
            this.Close();
        }

        private void LabVypis_Click(object sender, EventArgs e)
        {
                
        }

        private void souborToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
