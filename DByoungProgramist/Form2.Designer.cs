namespace DByoungProgramist
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.txtName = new System.Windows.Forms.TextBox();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.cmsDescription = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kopiujToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.wklejToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rtxtContents = new System.Windows.Forms.RichTextBox();
            this.cmsContent = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kopiujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmList = new System.Windows.Forms.ToolStripMenuItem();
            this.kopiujToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.wklejToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModyfiy = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbForm2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.wyjścieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.przypnijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odepnijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drukujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.podgladWydrukuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.cmsDescription.SuspendLayout();
            this.cmsContent.SuspendLayout();
            this.gbForm2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Gainsboro;
            this.txtName.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtName.Location = new System.Drawing.Point(21, 19);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(750, 31);
            this.txtName.TabIndex = 0;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.AcceptsTab = true;
            this.rtxtDescription.BackColor = System.Drawing.Color.Gainsboro;
            this.rtxtDescription.ContextMenuStrip = this.cmsDescription;
            this.rtxtDescription.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rtxtDescription.Location = new System.Drawing.Point(21, 55);
            this.rtxtDescription.MaxLength = 320;
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.ReadOnly = true;
            this.rtxtDescription.Size = new System.Drawing.Size(750, 84);
            this.rtxtDescription.TabIndex = 1;
            this.rtxtDescription.Text = " ";
            // 
            // cmsDescription
            // 
            this.cmsDescription.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kopiujToolStripMenuItem2,
            this.wklejToolStripMenuItem1});
            this.cmsDescription.Name = "cmsDescription";
            this.cmsDescription.Size = new System.Drawing.Size(109, 48);
            // 
            // kopiujToolStripMenuItem2
            // 
            this.kopiujToolStripMenuItem2.Name = "kopiujToolStripMenuItem2";
            this.kopiujToolStripMenuItem2.Size = new System.Drawing.Size(108, 22);
            this.kopiujToolStripMenuItem2.Text = "Kopiuj";
            this.kopiujToolStripMenuItem2.Click += new System.EventHandler(this.kopiujToolStripMenuItem2_Click);
            // 
            // wklejToolStripMenuItem1
            // 
            this.wklejToolStripMenuItem1.Name = "wklejToolStripMenuItem1";
            this.wklejToolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
            this.wklejToolStripMenuItem1.Text = "Wklej";
            this.wklejToolStripMenuItem1.Click += new System.EventHandler(this.wklejToolStripMenuItem1_Click);
            // 
            // rtxtContents
            // 
            this.rtxtContents.AcceptsTab = true;
            this.rtxtContents.BackColor = System.Drawing.Color.Gainsboro;
            this.rtxtContents.ContextMenuStrip = this.cmsContent;
            this.rtxtContents.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rtxtContents.Location = new System.Drawing.Point(21, 145);
            this.rtxtContents.Name = "rtxtContents";
            this.rtxtContents.ReadOnly = true;
            this.rtxtContents.Size = new System.Drawing.Size(750, 353);
            this.rtxtContents.TabIndex = 2;
            this.rtxtContents.Text = " ";
            this.rtxtContents.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtxtContents_KeyDown);
            // 
            // cmsContent
            // 
            this.cmsContent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kopiujToolStripMenuItem,
            this.cmList,
            this.kopiujToolStripMenuItem1,
            this.wklejToolStripMenuItem});
            this.cmsContent.Name = "contextMenuStrip1";
            this.cmsContent.Size = new System.Drawing.Size(133, 92);
            // 
            // kopiujToolStripMenuItem
            // 
            this.kopiujToolStripMenuItem.Name = "kopiujToolStripMenuItem";
            this.kopiujToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.kopiujToolStripMenuItem.Text = "Separator";
            this.kopiujToolStripMenuItem.Click += new System.EventHandler(this.kopiujToolStripMenuItem_Click);
            // 
            // cmList
            // 
            this.cmList.Name = "cmList";
            this.cmList.Size = new System.Drawing.Size(132, 22);
            this.cmList.Text = "Włącz Listę";
            this.cmList.Click += new System.EventHandler(this.cmList_Click);
            // 
            // kopiujToolStripMenuItem1
            // 
            this.kopiujToolStripMenuItem1.Name = "kopiujToolStripMenuItem1";
            this.kopiujToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.kopiujToolStripMenuItem1.Text = "Kopiuj";
            this.kopiujToolStripMenuItem1.Click += new System.EventHandler(this.kopiujToolStripMenuItem1_Click);
            // 
            // wklejToolStripMenuItem
            // 
            this.wklejToolStripMenuItem.Name = "wklejToolStripMenuItem";
            this.wklejToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.wklejToolStripMenuItem.Text = "Wklej";
            this.wklejToolStripMenuItem.Click += new System.EventHandler(this.wklejToolStripMenuItem_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(21, 509);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "DODAJ";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModyfiy
            // 
            this.btnModyfiy.BackColor = System.Drawing.Color.Gainsboro;
            this.btnModyfiy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModyfiy.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnModyfiy.ForeColor = System.Drawing.Color.Black;
            this.btnModyfiy.Location = new System.Drawing.Point(119, 509);
            this.btnModyfiy.Name = "btnModyfiy";
            this.btnModyfiy.Size = new System.Drawing.Size(87, 23);
            this.btnModyfiy.TabIndex = 4;
            this.btnModyfiy.Text = "MODYFIKUJ";
            this.btnModyfiy.UseVisualStyleBackColor = false;
            this.btnModyfiy.Click += new System.EventHandler(this.btnModyfiy_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(232, 509);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "USUŃ";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(696, 509);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "ANULUJ";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gbForm2
            // 
            this.gbForm2.Controls.Add(this.txtName);
            this.gbForm2.Controls.Add(this.rtxtDescription);
            this.gbForm2.Controls.Add(this.rtxtContents);
            this.gbForm2.Controls.Add(this.btnCancel);
            this.gbForm2.Controls.Add(this.btnDelete);
            this.gbForm2.Controls.Add(this.btnModyfiy);
            this.gbForm2.Controls.Add(this.btnAdd);
            this.gbForm2.Location = new System.Drawing.Point(0, 23);
            this.gbForm2.Name = "gbForm2";
            this.gbForm2.Size = new System.Drawing.Size(800, 542);
            this.gbForm2.TabIndex = 7;
            this.gbForm2.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wyjścieToolStripMenuItem,
            this.przypnijToolStripMenuItem,
            this.odepnijToolStripMenuItem,
            this.drukujToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // wyjścieToolStripMenuItem
            // 
            this.wyjścieToolStripMenuItem.Name = "wyjścieToolStripMenuItem";
            this.wyjścieToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.wyjścieToolStripMenuItem.Text = "Wyjście";
            this.wyjścieToolStripMenuItem.Click += new System.EventHandler(this.wyjścieToolStripMenuItem_Click);
            // 
            // przypnijToolStripMenuItem
            // 
            this.przypnijToolStripMenuItem.Name = "przypnijToolStripMenuItem";
            this.przypnijToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.przypnijToolStripMenuItem.Text = "Przypnij";
            this.przypnijToolStripMenuItem.Click += new System.EventHandler(this.przypnijToolStripMenuItem_Click);
            // 
            // odepnijToolStripMenuItem
            // 
            this.odepnijToolStripMenuItem.Name = "odepnijToolStripMenuItem";
            this.odepnijToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.odepnijToolStripMenuItem.Text = "Odepnij";
            this.odepnijToolStripMenuItem.Click += new System.EventHandler(this.odepnijToolStripMenuItem_Click);
            // 
            // drukujToolStripMenuItem
            // 
            this.drukujToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.podgladWydrukuToolStripMenuItem});
            this.drukujToolStripMenuItem.Name = "drukujToolStripMenuItem";
            this.drukujToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.drukujToolStripMenuItem.Text = "Drukuj";
            // 
            // podgladWydrukuToolStripMenuItem
            // 
            this.podgladWydrukuToolStripMenuItem.Name = "podgladWydrukuToolStripMenuItem";
            this.podgladWydrukuToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.podgladWydrukuToolStripMenuItem.Text = "Podglad wydruku";
            this.podgladWydrukuToolStripMenuItem.Click += new System.EventHandler(this.podgladWydrukuToolStripMenuItem_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 567);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gbForm2);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.cmsDescription.ResumeLayout(false);
            this.cmsContent.ResumeLayout(false);
            this.gbForm2.ResumeLayout(false);
            this.gbForm2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.RichTextBox rtxtContents;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnModyfiy;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gbForm2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem wyjścieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem przypnijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odepnijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drukujToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsContent;
        private System.Windows.Forms.ToolStripMenuItem kopiujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmList;
        private System.Windows.Forms.ToolStripMenuItem kopiujToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem wklejToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ToolStripMenuItem podgladWydrukuToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsDescription;
        private System.Windows.Forms.ToolStripMenuItem kopiujToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem wklejToolStripMenuItem1;
    }
}