using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DByoungProgramist
{
    public partial class Form2 : Form
    {
        public int IdCategoryForm2, publicId;
        public string ButtonNameForm2, titleForm2, shortDescriptionForm2, longDescriptionForm2, interval = "  ";

        public void UnblockingFields(Control coll)
        {
            txtName.ReadOnly = false;

            foreach (Control blokowanie in coll.Controls)
            {
                if (blokowanie is RichTextBox)
                {
                    ((RichTextBox)blokowanie).ReadOnly = false;
                }
            }
        }
        public void UnprotectedColor(Control coll)
        {
            foreach (Control changing in coll.Controls)
            {
                txtName.BackColor = Color.White;
                if (changing is RichTextBox)
                {
                    ((RichTextBox)changing).BackColor = Color.White;
                }
            }
        }
        public void ProtectedColor(Control coll)
        {
            foreach (Control changing in coll.Controls)
            {
                txtName.BackColor = Color.Gainsboro;
                if (changing is RichTextBox)
                {
                    ((RichTextBox)changing).BackColor = Color.Gainsboro;
                }
            }
        }

        public void BlockFields(Control coll)
        {
            txtName.ReadOnly = true;

            foreach (Control blokowanie in coll.Controls)
            {
                if (blokowanie is RichTextBox)
                {
                    ((RichTextBox)blokowanie).ReadOnly = true;
                }
            }
        }

        public void CheckName()
        {
            foreach (var r in Description.getAll())
            {
                if (r.Name == txtName.Text)
                {
                    MessageBox.Show("Taka nazwa już istnieje w bazie danych");
                    txtName.Text = "";
                }
            }
        }

        public void ClearFields(Control coll)
        {
            txtName.Text = "";

            foreach (Control clear in coll.Controls)
            {
                if (clear is RichTextBox)
                {
                    ((RichTextBox)clear).Text = "";
                }
            }
        }

        public void StringToFields()
        {
            txtName.Text = interval + titleForm2;
            rtxtDescription.Text = interval + shortDescriptionForm2;
            rtxtContents.Text = interval + longDescriptionForm2;
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            StringToFields();
            if (titleForm2 != null)
            {
                if (txtName.SelectedText.Length >= 0) txtName.SelectionStart = 0;
            }
            else
            {
                if (txtName.SelectedText.Length >= 0) txtName.SelectionStart = 0;
                UnprotectedColor(gbForm2);
                UnblockingFields(gbForm2);
                btnDelete.Enabled = false;
                btnModyfiy.Enabled = false;
                btnCancel.Enabled = false;
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form1 m = new Form1();
            m.id = IdCategoryForm2;
            m.ButtonName = ButtonNameForm2;
            m.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            BlockFields(gbForm2);
            txtName.Text = titleForm2;
            rtxtDescription.Text = interval + shortDescriptionForm2;
            rtxtContents.Text = interval + longDescriptionForm2;
            ProtectedColor(gbForm2);
            Form1 nowy = new Form1();
            nowy.OnlyVisibleButtonsBroupBox(gbForm2);
        }

        private void wyjścieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void przypnijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            TopMost = true;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void odepnijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.Fixed3D;
            TopMost = false;
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
        }

        string[] tekst = new string[9];
        int j = 1;
        string przedrostek = "              ";
        private void kopiujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string tekst = "        *";

            int i = rtxtContents.SelectionStart;

            for (int j = 0; j < 5; j++)
            {
                rtxtContents.Text = rtxtContents.Text.Insert(i, przedrostek+ tekst + " ");
            }
            rtxtContents.Text = rtxtContents.Text.Insert(i, Environment.NewLine);
            rtxtContents.SelectionStart = 150 + i;
        }

        private void cmList_Click(object sender, EventArgs e)
        {
            if (cmList.Text == "Włącz Listę") cmList.Text = "Wyłącz Listę";
            else cmList.Text = "Włącz Listę";
        }

        private void rtxtContents_KeyDown(object sender, KeyEventArgs e)
        {
            char sign = '-';//'●';

            if (cmList.Text == "Wyłącz Listę")
            {
                if (e.KeyCode == Keys.Enter)
                {
                    int i = rtxtContents.SelectionStart;
                    rtxtContents.Text = rtxtContents.Text.Insert(i, "\n " + " " + sign + "     ");
                    e.Handled = true;
                    rtxtContents.SelectionStart = 6 + i;
                }
            }
            else if (e.KeyCode == Keys.Enter)
            {
                int i = rtxtContents.SelectionStart;
                rtxtContents.Text = rtxtContents.Text.Insert(i, "\n " + " " + interval + " ");
                e.Handled = true;
                rtxtContents.SelectionStart = 4 + i;
            }
        }
        private StringReader sr = null;
        public string im { get; internal set; }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font czcionka2 = rtxtContents.Font;
            int wysokoscWiersza2 = (int)czcionka2.GetHeight(e.Graphics);
            int iloscLinii2 = e.MarginBounds.Height / wysokoscWiersza2;

            if (sr == null)
            {
                string tekst = "";
                string tekst1 = "";
                string tekst2 = "";

                for (int i = 0; i < txtName.Lines.Length; i++)
                {
                    float szerokosc = e.Graphics.MeasureString(170 + txtName.Lines[i], czcionka2).Width;
                    if (szerokosc < e.MarginBounds.Width)
                    {
                        tekst1 += txtName.Lines[i] + "\n";
                    }
                    else
                    {
                        float sredniaSerokoscLitery = szerokosc / txtName.Lines.Length;
                        int ileLiterWWierszu = (int)(e.MarginBounds.Width / sredniaSerokoscLitery);
                        string skracanyWiersz = txtName.Lines[i];
                        do
                        {
                            int ostatniaSpacja = skracanyWiersz.Substring(0, ileLiterWWierszu).LastIndexOf(' ');
                            int iloscLiter = ostatniaSpacja != -1 ? Math.Min(ostatniaSpacja, ileLiterWWierszu) : ileLiterWWierszu;
                            tekst1 += skracanyWiersz.Substring(0, iloscLiter) + "\n";
                            skracanyWiersz = skracanyWiersz.Substring(iloscLiter).TrimStart(' ');
                        } while (skracanyWiersz.Length > ileLiterWWierszu);
                        tekst1 += skracanyWiersz + "\n";
                    }
                }
                foreach (string wiersz in rtxtDescription.Lines)
                {

                    float szerokosc = e.Graphics.MeasureString(wiersz, czcionka2).Width;
                    if (szerokosc < e.MarginBounds.Width)
                    {
                        tekst += wiersz + "\n";
                    }
                    else
                    {
                        float sredniaSerokoscLitery = szerokosc / wiersz.Length;
                        int ileLiterWWierszu = (int)(e.MarginBounds.Width / sredniaSerokoscLitery);
                        string skracanyWiersz = wiersz;
                        do
                        {
                            int ostatniaSpacja = skracanyWiersz.Substring(0, ileLiterWWierszu).LastIndexOf(' ');
                            int iloscLiter = ostatniaSpacja != -1 ? Math.Min(ostatniaSpacja, ileLiterWWierszu) : ileLiterWWierszu;
                            tekst += skracanyWiersz.Substring(0, iloscLiter) + "\n";
                            skracanyWiersz = skracanyWiersz.Substring(iloscLiter).TrimStart(' ');
                        } while (skracanyWiersz.Length > ileLiterWWierszu);
                        tekst += skracanyWiersz + "\n";
                    }
                }

                foreach (string wiersz in rtxtContents.Lines)
                {
                    float szerokosc = e.Graphics.MeasureString(wiersz, czcionka2).Width;
                    if (szerokosc < e.MarginBounds.Width)
                    {
                        tekst2 += wiersz + "\n";
                    }
                    else
                    {
                        float sredniaSerokoscLitery = szerokosc / wiersz.Length;
                        int ileLiterWWierszu = (int)(e.MarginBounds.Width / sredniaSerokoscLitery);
                        string skracanyWiersz = wiersz;
                        do
                        {
                            int ostatniaSpacja = skracanyWiersz.Substring(0, ileLiterWWierszu).LastIndexOf(' ');
                            int iloscLiter = ostatniaSpacja != -1 ? Math.Min(ostatniaSpacja, ileLiterWWierszu) : ileLiterWWierszu;
                            tekst2 += skracanyWiersz.Substring(0, iloscLiter) + "\n";
                            skracanyWiersz = skracanyWiersz.Substring(iloscLiter).TrimStart(' ');
                        } while (skracanyWiersz.Length > ileLiterWWierszu);
                        tekst2 += skracanyWiersz + "\n";
                    }
                }
                sr = new StringReader(tekst + "\n\n" + tekst1 + "\n\n" + tekst2);
            }
            e.HasMorePages = true;
            for (int i = 0; i < iloscLinii2; i++)
            {
                string wiersz = sr.ReadLine();
                if (wiersz == null)
                {
                    e.HasMorePages = false;
                    sr = null;
                    break;
                }
                e.Graphics.DrawString(wiersz,
                             czcionka2,
                             Brushes.Black,
                             e.MarginBounds.Left,                     //x
                             e.MarginBounds.Top + i * wysokoscWiersza2);
            }
        }

        private void podgladWydrukuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void kopiujToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            rtxtContents.Copy();
        }

        private void kopiujToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            rtxtDescription.Copy();
        }

        private void wklejToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            rtxtDescription.Paste();
        }

        private void wklejToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxtContents.Paste();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var s = Description.getById(publicId);
                Description.del(s.Id);
                MessageBox.Show("Dokument został usunięty");
                Form1 m = new Form1();
                this.Hide();
                m.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModyfiy_Click(object sender, EventArgs e)
        {
            btnCancel.Text = "ANULUJ";
            if (txtName.ReadOnly == true)
            {
                UnprotectedColor(gbForm2);
                UnblockingFields(gbForm2);
            }
            else
            {
                if (txtName.Text != "")
                {
                    try
                    {
                        var up = Description.getById(publicId);
                        up.Name = txtName.Text;
                        up.ShortDescription = rtxtDescription.Text;
                        up.LongDescription = rtxtContents.Text;
                        Description.update(up);
                        MessageBox.Show("Modyfikacja przebiegła pomyślnie!!!");
                        BlockFields(gbForm2);
                        btnCancel.Text = "COFNIJ";
                        ProtectedColor(gbForm2);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Podaj nazwę Przedmiotu");
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (txtName.ReadOnly == true)
            {
                UnprotectedColor(gbForm2);
                UnblockingFields(gbForm2);
                ClearFields(gbForm2);
                rtxtContents.Text = interval;
                rtxtDescription.Text = interval;
            }
            else
            {

                CheckName();

                if (txtName.Text != interval && rtxtDescription.Text != interval && rtxtContents.Text != interval)
                {
                    try
                    {

                        Description model = new Description();

                        model.Name = txtName.Text.ToUpper();
                        model.ShortDescription = rtxtDescription.Text;
                        model.LongDescription = rtxtContents.Text;

                        model.IdCategory = IdCategoryForm2;
                        Description.add(model);
                        MessageBox.Show("Dodano przedmiot");
                        publicId++;
                        BlockFields(gbForm2);
                        titleForm2 = txtName.Text;
                        shortDescriptionForm2 = rtxtDescription.Text;
                        longDescriptionForm2 = rtxtContents.Text;
                        ProtectedColor(gbForm2);
                    }
                    catch (Exception ex)
                    {
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Pola nie mogą być puste");
                }
            }
        }
    }
}
