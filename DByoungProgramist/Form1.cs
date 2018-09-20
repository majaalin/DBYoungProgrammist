using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using LiteDB;
using System.Xml;

namespace DByoungProgramist
{
    public partial class Form1 : Form
    {
        public int id, idKategoria;
        int idDgGrid;
        bool areControlsVisible = true;
        bool pressed = true;
        bool delete = false;
        string title, shortDescription, Longdescription;
        public string ButtonName;
        XmlSerializer xs;
        List<Description> ls;
        static List<Category> categoryBase = new List<Category>
        {
            new Category {Id=1,CategoryName="string" },
            new Category {Id=2,CategoryName="pętle" },
            new Category {Id=3,CategoryName="kolekcje" },
            new Category {Id=4,CategoryName="interfejsy" },
            new Category {Id=5,CategoryName="sql" },
            new Category {Id=6,CategoryName="linq" },
            new Category {Id=7,CategoryName="win forms" },
            new Category {Id=8,CategoryName="asp" },
            new Category {Id=9,CategoryName="testy" },
            new Category {Id=10,CategoryName="programy" }
        };

        #region Funkcje
        public void ColorOffButtonDelete()
        {
            if (delete == true)
            {
               
                btnDeleteRow.BackColor = Color.Gainsboro;
                btnDeleteRow.ForeColor = Color.Black;
                btnDeleteRow.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                delete = false;
            }
        }
        public void SearchButton(string name, Button nameoftheButton)
        {
            if (name == "string") nameoftheButton = btnString;
            if (name == "pętle") nameoftheButton = btnLoop;
            if (name == "kolekcje") nameoftheButton = btnCollections;
            if (name == "interfejsy") nameoftheButton = btnInterface;
            if (name == "sql") nameoftheButton = btnSql;
            if (name == "linq") nameoftheButton = btnLinq;
            if (name == "win forms") nameoftheButton = btnForm;
            if (name == "asp") nameoftheButton = btnAsp;
            if (name == "testy") nameoftheButton = btnTest;
            if (name == "programy") nameoftheButton = btnPrograms;
          // ColorButton(gbButton, nameoftheButton);
            CheckNumberIdAndNameDataBase(name);

            pressed = true;
            if (pressed && areControlsVisible)
            {
                BoldButton(gbButton, nameoftheButton);
                ColorButton(gbButton, nameoftheButton);
                filldgGrid(dgGridDescription, id);
                LabelName(id);
            }
            else
            {
                CreateNewForm();
            }
            pressed = false;
        }
        public void CheckNumberIdAndNameDataBase(string nameBase)
        {
            var s = from p in categoryBase
                    where p.CategoryName == nameBase
                    select p;
            foreach (var c in s)
            {
                id = c.Id;
                idKategoria = c.Id;
                ButtonName = c.CategoryName;

            }
        }

        public int LastId()
        {
            foreach (var p in Description.getAll())
            {
                id = p.Id;
            }
            return id;
        }
        public void ClearDataBase(int numberId)
        {
            try
            {
                if (MessageBox.Show("Czy na pewno usunąć Plik? \nOperacja nie do odwrócenia", "Uwaga!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    var s = Description.getById(numberId);
                    Description.del(s.Id);

                    MessageBox.Show("Dokument został usunięty");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void LabelName(int i)
        {
            var s = from p in categoryBase
                    where p.Id == i
                    select p;
            foreach (var c in s)
            {
                lblHead.Text = c.CategoryName.ToUpper();
            }
        }
        public void OnlyVisibleButtonsBroupBox(Control collect)
        {
            gbButton.Visible = true;
            foreach (Control group in collect.Controls)
            {

                if (group is Button)
                {
                    ((Button)group).Visible = true;
                }
            }
        }
        public void AllVisibleFalse(Control collect)
        {
            foreach (Control all in collect.Controls)
            {
                all.Visible = false;
            }
        }
        public void AllVisibleTrue(Control collect)
        {
            foreach (Control all in collect.Controls)
            {
                all.Visible = true;
            }
        }

        public void CommonPartSearchAndCreate(int i)
        {
            Form2 NewForm = new Form2();
            this.Visible = false;
            NewForm.IdCategoryForm2 = idKategoria;
            NewForm.publicId = idDgGrid;
            NewForm.titleForm2 = title;
            NewForm.shortDescriptionForm2 = shortDescription;
            NewForm.longDescriptionForm2 = Longdescription;
            NewForm.ButtonNameForm2 = ButtonName;
            var s = from p in categoryBase
                    where p.Id == i
                    select p;
            foreach (var c in s)
            {
                NewForm.Text = c.CategoryName.ToUpper();
            }
            NewForm.ShowDialog();
        }
        public void Search()
        {
            CommonPartSearchAndCreate(id);
        }

        public void CreateNewForm()
        {
            if (areControlsVisible == false)
            {
                CommonPartSearchAndCreate(id);
            }
        }
        public void NoName()
        {
            if (dgGridDescription.Rows.Count <= 0)
            {
                lblHead.Text = "";
            }
        }
        public void BoldButton(Control collect, Button element)
        {
            foreach (Control reminder in collect.Controls)
            {
                reminder.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));

                element.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            }
        }
        public void ColorButton(Control collect, Button element)
        {
            foreach (Control reminder in collect.Controls)
            {
                if (dgGridDescription.Rows.Count <= 0)
                {
                    reminder.BackColor = Color.Gainsboro;
                    reminder.ForeColor = Color.Black;
                    reminder.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                    NoName();
                }
                else
                {
                    reminder.BackColor = Color.Gainsboro;
                    reminder.ForeColor = Color.Black;
                    element.BackColor = Color.White;
                    element.ForeColor = Color.Red;
                }
            }
        }
        public void filldgGrid(DataGridView dg, int number)
        {
            dg.Rows.Clear();
            foreach (var r in Description.getAll())
            {
                if (r.IdCategory == number)
                {
                    dg.Rows.Add(r.Id, r.Name, r.ShortDescription, r.LongDescription, r.IdCategory);
                }
                else continue;
            }
        }

        public static void filldgGrid2(DataGridView dg)
        {
            dg.Rows.Clear();
            foreach (var r in Description.getAll())
            {
                dg.Rows.Add(r.Id, r.Name, r.ShortDescription, r.LongDescription);
            }
        }

        #endregion
        public Form1()
        {
            InitializeComponent();

            ls = new List<Description>();
            xs = new XmlSerializer(typeof(List<Description>));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgGridDescription.Rows.ToString().ToUpper();

            dgGridDescription.Columns.Add("id", "Id");
            dgGridDescription.Columns.Add("Name", "Nazwa");
            dgGridDescription.Columns.Add("ShortDescription", "Opis");
            dgGridDescription.Columns.Add("LongDescription", "LongDescription");
            dgGridDescription.Columns.Add("idCategory", "idCategory");

            dgGridDescription.Columns[0].Visible = false;
            dgGridDescription.Columns[3].Visible = false;
            dgGridDescription.Columns[4].Visible = false;

            if (id > 0)
            {
                SearchButton(ButtonName, btnLinq);
             
                //to sie powtarza przenieść do funkcji
                var s = from p in categoryBase
                        where p.Id == id
                        select p;
                foreach (var c in s)
                {
                    lblHead.Text = c.CategoryName.ToUpper();
                }
            }
        }

        private void String_Click(object sender, EventArgs e)
        {
            SearchButton("string", btnString);
            ColorOffButtonDelete();
            ColorButton(gbButton, btnString);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AllVisibleFalse(gbAll);
            OnlyVisibleButtonsBroupBox(gbButton);
            btnCancel.Visible = true;
            areControlsVisible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            AllVisibleTrue(gbAll);
            ColorOffButtonDelete();
        }

        private void btnAllSeek_Click(object sender, EventArgs e)
        {
            dgGridDescription.Rows.Clear();
            foreach (var r in Description.getAll())
            {
                dgGridDescription.Rows.Add(r.Id, r.Name, r.ShortDescription, r.LongDescription);
            }
           
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnLoop_Click(object sender, EventArgs e)
        {
            SearchButton("pętle", btnLoop);
            ColorOffButtonDelete();
            ColorButton(gbButton, btnLoop);
        }

        private void pętleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearDataBase(3);
        }

        private void btnInterface_Click(object sender, EventArgs e)
        {
            SearchButton("interfejsy", btnInterface);
            ColorOffButtonDelete();
            ColorButton(gbButton, btnInterface);
        }

        private void btnLinq_Click(object sender, EventArgs e)
        {
            SearchButton("linq", btnLinq);
            ColorOffButtonDelete();
            ColorButton(gbButton, btnLinq);
        }

        private void btnSql_Click(object sender, EventArgs e)
        {
            SearchButton("sql", btnSql);
            ColorOffButtonDelete();
            ColorButton(gbButton, btnSql);
        }

        private void btnAsp_Click(object sender, EventArgs e)
        {
            SearchButton("asp", btnAsp);
            ColorOffButtonDelete();
            ColorButton(gbButton, btnAsp);
        }

        private void btnPrograms_Click(object sender, EventArgs e)
        {
            SearchButton("programy", btnPrograms);
            ColorOffButtonDelete();
            ColorButton(gbButton, btnPrograms);
        }

        private void btnForm_Click(object sender, EventArgs e)
        {
            SearchButton("win forms", btnForm);
            ColorOffButtonDelete();
            ColorButton(gbButton, btnForm);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            SearchButton("testy", btnTest);
            ColorOffButtonDelete();
            ColorButton(gbButton, btnTest);
        }

        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            if (dgGridDescription.Rows.Count > 0)
            {
                btnDeleteRow.BackColor = Color.White;
                btnDeleteRow.ForeColor = Color.Red;
                btnDeleteRow.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                delete = true;
            }
            else
            {
                MessageBox.Show("Nie możesz usunąć pustki");
            }
        }

        private void exportBazyDanychToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Pliki tekstowe (*.xml)|*.xml";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string sciezka = saveFileDialog1.FileName;
                FileStream fs = new FileStream(sciezka, System.IO.FileMode.Create, FileAccess.Write);

                foreach (var p in Description.getAll())
                {
                    ls.Add(new Description(p.Id, p.Name, p.ShortDescription, p.LongDescription, p.IdCategory));
                }
                xs.Serialize(fs, ls);
                fs.Close();
                MessageBox.Show("Eksport bazy danych zakończył się sukcesem");
            }
        }

        private void importBazyDanychToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  openFileDialog1.Filter = "Pliki tekstowe (*.xml)|*.xml";







            openFileDialog1.Filter = "Pliki tekstowe (*.xml)|*.xml";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string sciezka = openFileDialog1.FileName;
                FileStream fs = new FileStream(sciezka, System.IO.FileMode.Open, FileAccess.Read);
                ls = (List<Description>)xs.Deserialize(fs);

                Description m = new Description();
                if (dgGridDescription.Rows.Count <= 0)
                {
                    foreach (var p in ls)
                    {
                        
                        dgGridDescription.Rows.Add(m.Id = p.Id, m.Name = p.Name, m.ShortDescription =p.ShortDescription, m.LongDescription = p.LongDescription, m.IdCategory = p.IdCategory);
                      
                        Description.add(m);
                    }
                    MessageBox.Show("Baza danych została zaimportowana");

                }
                else
                {
                    MessageBox.Show("Baza danych przed importem musi być pusta");
                }
                fs.Close();





                //if (openFileDialog1.ShowDialog() == DialogResult.OK)
                //{
                //    string sciezka = openFileDialog1.FileName;
                //    FileStream fs = new FileStream(sciezka, System.IO.FileMode.Open, FileAccess.Read);
                //    ls = (List<Description>)xs.Deserialize(fs);
                //    Description m = new Description();
                //    foreach (var p in ls)
                //    {
                //        if (dgGridDescription.Rows.Count < 0)
                //        {
                //            dgGridDescription.Rows.Add(m.Id = p.Id, m.Name = p.Name, m.ShortDescription = p.ShortDescription, m.LongDescription = p.LongDescription, m.IdCategory = p.IdCategory);
                //            Description.add(m);
                //        }else
                //        {
                //            MessageBox.Show("Baza danych przed importem musi być pusta");
                //            //id++;
                //        }

                //    }
                //    fs.Close();
                //}
                //MessageBox.Show("Baza danych została zaimportowana");
            } }

        private void usuńBazęDanychToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy na pewno usunąć Bazę danych? \nOperacja nie do odwrócenia", "Uwaga!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Description.ClearDb();
                MessageBox.Show("Dokument został usunięty");
                filldgGrid(dgGridDescription, id);
            }
        }

        private void btnCollections_Click(object sender, EventArgs e)
        {
            SearchButton("kolekcje", btnCollections);
            ColorOffButtonDelete();
            ColorButton(gbButton, btnCollections);
        }

        private void dgGridDescription_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           this.Visible = false;
            if (delete == true)
            {
                idDgGrid = Convert.ToInt32(dgGridDescription.Rows[e.RowIndex].Cells[0].Value);
                ClearDataBase(idDgGrid);
                filldgGrid(dgGridDescription, id);
                ColorOffButtonDelete();
            }
            else
            {
                if (e.RowIndex >= 0)
                {
                    idDgGrid = Convert.ToInt32(dgGridDescription.Rows[e.RowIndex].Cells[0].Value);
                    title = dgGridDescription.Rows[e.RowIndex].Cells[1].Value.ToString();
                    shortDescription = dgGridDescription.Rows[e.RowIndex].Cells[2].Value.ToString();
                    Longdescription = dgGridDescription.Rows[e.RowIndex].Cells[3].Value.ToString();
                }
                Search();
            }
        }
    }
}
