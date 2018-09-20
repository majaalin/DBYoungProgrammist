namespace DByoungProgramist
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnString = new System.Windows.Forms.Button();
            this.txt = new System.Windows.Forms.TextBox();
            this.dgGridDescription = new System.Windows.Forms.DataGridView();
            this.gbButton = new System.Windows.Forms.GroupBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnForm = new System.Windows.Forms.Button();
            this.btnPrograms = new System.Windows.Forms.Button();
            this.btnAsp = new System.Windows.Forms.Button();
            this.btnSql = new System.Windows.Forms.Button();
            this.btnLinq = new System.Windows.Forms.Button();
            this.btnInterface = new System.Windows.Forms.Button();
            this.btnCollections = new System.Windows.Forms.Button();
            this.btnLoop = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblHead = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbAll = new System.Windows.Forms.GroupBox();
            this.btnDeleteRow = new System.Windows.Forms.Button();
            this.btnAllSeek = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportBazyDanychToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importBazyDanychToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuńBazęDanychToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgGridDescription)).BeginInit();
            this.gbButton.SuspendLayout();
            this.gbAll.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnString
            // 
            this.btnString.BackColor = System.Drawing.Color.Gainsboro;
            this.btnString.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnString.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnString.Location = new System.Drawing.Point(27, 19);
            this.btnString.Margin = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.btnString.Name = "btnString";
            this.btnString.Size = new System.Drawing.Size(75, 23);
            this.btnString.TabIndex = 0;
            this.btnString.Text = "string";
            this.btnString.UseVisualStyleBackColor = false;
            this.btnString.Click += new System.EventHandler(this.String_Click);
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(511, 36);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(189, 20);
            this.txt.TabIndex = 1;
            // 
            // dgGridDescription
            // 
            this.dgGridDescription.AllowUserToAddRows = false;
            this.dgGridDescription.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgGridDescription.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgGridDescription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGridDescription.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgGridDescription.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgGridDescription.Location = new System.Drawing.Point(26, 227);
            this.dgGridDescription.Name = "dgGridDescription";
            this.dgGridDescription.RowHeadersVisible = false;
            this.dgGridDescription.Size = new System.Drawing.Size(776, 307);
            this.dgGridDescription.TabIndex = 2;
            this.dgGridDescription.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgGridDescription_CellClick);
            // 
            // gbButton
            // 
            this.gbButton.Controls.Add(this.btnTest);
            this.gbButton.Controls.Add(this.btnForm);
            this.gbButton.Controls.Add(this.btnPrograms);
            this.gbButton.Controls.Add(this.btnAsp);
            this.gbButton.Controls.Add(this.btnSql);
            this.gbButton.Controls.Add(this.btnLinq);
            this.gbButton.Controls.Add(this.btnInterface);
            this.gbButton.Controls.Add(this.btnCollections);
            this.gbButton.Controls.Add(this.btnLoop);
            this.gbButton.Controls.Add(this.btnString);
            this.gbButton.Location = new System.Drawing.Point(26, 71);
            this.gbButton.Name = "gbButton";
            this.gbButton.Size = new System.Drawing.Size(555, 105);
            this.gbButton.TabIndex = 3;
            this.gbButton.TabStop = false;
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.Color.Gainsboro;
            this.btnTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTest.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTest.Location = new System.Drawing.Point(447, 63);
            this.btnTest.Margin = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 9;
            this.btnTest.Text = "Testy";
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnForm
            // 
            this.btnForm.BackColor = System.Drawing.Color.Gainsboro;
            this.btnForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnForm.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnForm.Location = new System.Drawing.Point(342, 63);
            this.btnForm.Margin = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.btnForm.Name = "btnForm";
            this.btnForm.Size = new System.Drawing.Size(75, 23);
            this.btnForm.TabIndex = 8;
            this.btnForm.Text = "Win Form";
            this.btnForm.UseVisualStyleBackColor = false;
            this.btnForm.Click += new System.EventHandler(this.btnForm_Click);
            // 
            // btnPrograms
            // 
            this.btnPrograms.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPrograms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrograms.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrograms.Location = new System.Drawing.Point(237, 63);
            this.btnPrograms.Margin = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.btnPrograms.Name = "btnPrograms";
            this.btnPrograms.Size = new System.Drawing.Size(75, 23);
            this.btnPrograms.TabIndex = 7;
            this.btnPrograms.Text = "Programy";
            this.btnPrograms.UseVisualStyleBackColor = false;
            this.btnPrograms.Click += new System.EventHandler(this.btnPrograms_Click);
            // 
            // btnAsp
            // 
            this.btnAsp.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAsp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsp.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAsp.Location = new System.Drawing.Point(132, 62);
            this.btnAsp.Margin = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.btnAsp.Name = "btnAsp";
            this.btnAsp.Size = new System.Drawing.Size(75, 23);
            this.btnAsp.TabIndex = 6;
            this.btnAsp.Text = "Asp";
            this.btnAsp.UseVisualStyleBackColor = false;
            this.btnAsp.Click += new System.EventHandler(this.btnAsp_Click);
            // 
            // btnSql
            // 
            this.btnSql.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSql.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSql.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSql.Location = new System.Drawing.Point(27, 62);
            this.btnSql.Margin = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.btnSql.Name = "btnSql";
            this.btnSql.Size = new System.Drawing.Size(75, 23);
            this.btnSql.TabIndex = 5;
            this.btnSql.Text = "Sql";
            this.btnSql.UseVisualStyleBackColor = false;
            this.btnSql.Click += new System.EventHandler(this.btnSql_Click);
            // 
            // btnLinq
            // 
            this.btnLinq.BackColor = System.Drawing.Color.Gainsboro;
            this.btnLinq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLinq.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLinq.Location = new System.Drawing.Point(447, 20);
            this.btnLinq.Margin = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.btnLinq.Name = "btnLinq";
            this.btnLinq.Size = new System.Drawing.Size(75, 23);
            this.btnLinq.TabIndex = 4;
            this.btnLinq.Text = "Linq";
            this.btnLinq.UseVisualStyleBackColor = false;
            this.btnLinq.Click += new System.EventHandler(this.btnLinq_Click);
            // 
            // btnInterface
            // 
            this.btnInterface.BackColor = System.Drawing.Color.Gainsboro;
            this.btnInterface.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInterface.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnInterface.Location = new System.Drawing.Point(342, 20);
            this.btnInterface.Margin = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.btnInterface.Name = "btnInterface";
            this.btnInterface.Size = new System.Drawing.Size(75, 23);
            this.btnInterface.TabIndex = 3;
            this.btnInterface.Text = "Interfejsy";
            this.btnInterface.UseVisualStyleBackColor = false;
            this.btnInterface.Click += new System.EventHandler(this.btnInterface_Click);
            // 
            // btnCollections
            // 
            this.btnCollections.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCollections.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCollections.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCollections.Location = new System.Drawing.Point(237, 20);
            this.btnCollections.Margin = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.btnCollections.Name = "btnCollections";
            this.btnCollections.Size = new System.Drawing.Size(75, 23);
            this.btnCollections.TabIndex = 2;
            this.btnCollections.Text = "Kolekcje";
            this.btnCollections.UseVisualStyleBackColor = false;
            this.btnCollections.Click += new System.EventHandler(this.btnCollections_Click);
            // 
            // btnLoop
            // 
            this.btnLoop.BackColor = System.Drawing.Color.Gainsboro;
            this.btnLoop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoop.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLoop.Location = new System.Drawing.Point(132, 20);
            this.btnLoop.Margin = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.btnLoop.Name = "btnLoop";
            this.btnLoop.Size = new System.Drawing.Size(75, 23);
            this.btnLoop.TabIndex = 1;
            this.btnLoop.Text = "Pętle";
            this.btnLoop.UseVisualStyleBackColor = false;
            this.btnLoop.Click += new System.EventHandler(this.btnLoop_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdd.Location = new System.Drawing.Point(645, 83);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHead.ForeColor = System.Drawing.Color.White;
            this.lblHead.Location = new System.Drawing.Point(62, 200);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(0, 18);
            this.lblHead.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCancel.Location = new System.Drawing.Point(645, 117);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gbAll
            // 
            this.gbAll.Controls.Add(this.btnDeleteRow);
            this.gbAll.Controls.Add(this.gbButton);
            this.gbAll.Controls.Add(this.btnAllSeek);
            this.gbAll.Controls.Add(this.txt);
            this.gbAll.Controls.Add(this.dgGridDescription);
            this.gbAll.Controls.Add(this.btnCancel);
            this.gbAll.Controls.Add(this.lblHead);
            this.gbAll.Controls.Add(this.btnAdd);
            this.gbAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAll.Location = new System.Drawing.Point(0, 0);
            this.gbAll.Name = "gbAll";
            this.gbAll.Size = new System.Drawing.Size(800, 540);
            this.gbAll.TabIndex = 6;
            this.gbAll.TabStop = false;
            // 
            // btnDeleteRow
            // 
            this.btnDeleteRow.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDeleteRow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteRow.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDeleteRow.Location = new System.Drawing.Point(645, 155);
            this.btnDeleteRow.Name = "btnDeleteRow";
            this.btnDeleteRow.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteRow.TabIndex = 7;
            this.btnDeleteRow.Text = "Usuń";
            this.btnDeleteRow.UseVisualStyleBackColor = false;
            this.btnDeleteRow.Click += new System.EventHandler(this.btnDeleteRow_Click);
            // 
            // btnAllSeek
            // 
            this.btnAllSeek.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAllSeek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAllSeek.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAllSeek.Location = new System.Drawing.Point(712, 34);
            this.btnAllSeek.Name = "btnAllSeek";
            this.btnAllSeek.Size = new System.Drawing.Size(76, 23);
            this.btnAllSeek.TabIndex = 6;
            this.btnAllSeek.Text = "Wyszukaj";
            this.btnAllSeek.UseVisualStyleBackColor = false;
            this.btnAllSeek.Click += new System.EventHandler(this.btnAllSeek_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.oProgramieToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportBazyDanychToolStripMenuItem,
            this.importBazyDanychToolStripMenuItem,
            this.usuńBazęDanychToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // exportBazyDanychToolStripMenuItem
            // 
            this.exportBazyDanychToolStripMenuItem.Name = "exportBazyDanychToolStripMenuItem";
            this.exportBazyDanychToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.exportBazyDanychToolStripMenuItem.Text = "Export Bazy danych";
            this.exportBazyDanychToolStripMenuItem.Click += new System.EventHandler(this.exportBazyDanychToolStripMenuItem_Click);
            // 
            // importBazyDanychToolStripMenuItem
            // 
            this.importBazyDanychToolStripMenuItem.Name = "importBazyDanychToolStripMenuItem";
            this.importBazyDanychToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.importBazyDanychToolStripMenuItem.Text = "Import Bazy danych";
            this.importBazyDanychToolStripMenuItem.Click += new System.EventHandler(this.importBazyDanychToolStripMenuItem_Click);
            // 
            // usuńBazęDanychToolStripMenuItem
            // 
            this.usuńBazęDanychToolStripMenuItem.Name = "usuńBazęDanychToolStripMenuItem";
            this.usuńBazęDanychToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.usuńBazęDanychToolStripMenuItem.Text = "Usuń Bazę danych";
            this.usuńBazęDanychToolStripMenuItem.Click += new System.EventHandler(this.usuńBazęDanychToolStripMenuItem_Click);
            // 
            // oProgramieToolStripMenuItem
            // 
            this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            this.oProgramieToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.oProgramieToolStripMenuItem.Text = "O programie";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gbAll);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DBYoungProgrammist";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgGridDescription)).EndInit();
            this.gbButton.ResumeLayout(false);
            this.gbAll.ResumeLayout(false);
            this.gbAll.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnString;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.DataGridView dgGridDescription;
        private System.Windows.Forms.GroupBox gbButton;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnForm;
        private System.Windows.Forms.Button btnPrograms;
        private System.Windows.Forms.Button btnAsp;
        private System.Windows.Forms.Button btnSql;
        private System.Windows.Forms.Button btnLinq;
        private System.Windows.Forms.Button btnInterface;
        private System.Windows.Forms.Button btnCollections;
        private System.Windows.Forms.Button btnLoop;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gbAll;
        private System.Windows.Forms.Button btnAllSeek;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportBazyDanychToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importBazyDanychToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuńBazęDanychToolStripMenuItem;
        private System.Windows.Forms.Button btnDeleteRow;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

