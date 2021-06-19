
namespace SRCNservices
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnRecords = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOpenAddRecForm = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStudents = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRecords,
            this.btnStudents});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnRecords
            // 
            this.btnRecords.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpenAddRecForm});
            this.btnRecords.Name = "btnRecords";
            this.btnRecords.Size = new System.Drawing.Size(61, 20);
            this.btnRecords.Text = "Записи";
            // 
            // btnOpenAddRecForm
            // 
            this.btnOpenAddRecForm.Name = "btnOpenAddRecForm";
            this.btnOpenAddRecForm.Size = new System.Drawing.Size(180, 22);
            this.btnOpenAddRecForm.Text = "Добавить";
            this.btnOpenAddRecForm.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // btnStudents
            // 
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(103, 20);
            this.btnStudents.Text = "Воспитанники";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Учет услуг";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnRecords;
        private System.Windows.Forms.ToolStripMenuItem btnOpenAddRecForm;
        private System.Windows.Forms.ToolStripMenuItem btnStudents;
    }
}

