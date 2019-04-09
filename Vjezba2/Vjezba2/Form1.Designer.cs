namespace Vjezba2
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
            this.uiActionOdaberiKategoriju = new System.Windows.Forms.ComboBox();
            this.uiUnosTroska = new System.Windows.Forms.TextBox();
            this.uiIspisTroskova = new System.Windows.Forms.TextBox();
            this.uiDodajTrosak = new System.Windows.Forms.Button();
            this.uiActionFiltriraj = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // uiActionOdaberiKategoriju
            // 
            this.uiActionOdaberiKategoriju.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uiActionOdaberiKategoriju.FormattingEnabled = true;
            this.uiActionOdaberiKategoriju.Location = new System.Drawing.Point(58, 56);
            this.uiActionOdaberiKategoriju.Name = "uiActionOdaberiKategoriju";
            this.uiActionOdaberiKategoriju.Size = new System.Drawing.Size(121, 24);
            this.uiActionOdaberiKategoriju.TabIndex = 0;
            // 
            // uiUnosTroska
            // 
            this.uiUnosTroska.Location = new System.Drawing.Point(264, 57);
            this.uiUnosTroska.Name = "uiUnosTroska";
            this.uiUnosTroska.Size = new System.Drawing.Size(100, 22);
            this.uiUnosTroska.TabIndex = 1;
            // 
            // uiIspisTroskova
            // 
            this.uiIspisTroskova.Location = new System.Drawing.Point(58, 155);
            this.uiIspisTroskova.Multiline = true;
            this.uiIspisTroskova.Name = "uiIspisTroskova";
            this.uiIspisTroskova.Size = new System.Drawing.Size(202, 207);
            this.uiIspisTroskova.TabIndex = 2;
            // 
            // uiDodajTrosak
            // 
            this.uiDodajTrosak.Location = new System.Drawing.Point(185, 110);
            this.uiDodajTrosak.Name = "uiDodajTrosak";
            this.uiDodajTrosak.Size = new System.Drawing.Size(132, 23);
            this.uiDodajTrosak.TabIndex = 3;
            this.uiDodajTrosak.Text = "Dodaj trosak";
            this.uiDodajTrosak.UseVisualStyleBackColor = true;
            this.uiDodajTrosak.Click += new System.EventHandler(this.uiDodajTrosak_Click);
            // 
            // uiActionFiltriraj
            // 
            this.uiActionFiltriraj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uiActionFiltriraj.FormattingEnabled = true;
            this.uiActionFiltriraj.Location = new System.Drawing.Point(290, 207);
            this.uiActionFiltriraj.Name = "uiActionFiltriraj";
            this.uiActionFiltriraj.Size = new System.Drawing.Size(121, 24);
            this.uiActionFiltriraj.TabIndex = 4;
            this.uiActionFiltriraj.SelectedIndexChanged += new System.EventHandler(this.uiActionFiltriraj_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uiActionFiltriraj);
            this.Controls.Add(this.uiDodajTrosak);
            this.Controls.Add(this.uiIspisTroskova);
            this.Controls.Add(this.uiUnosTroska);
            this.Controls.Add(this.uiActionOdaberiKategoriju);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox uiActionOdaberiKategoriju;
        private System.Windows.Forms.TextBox uiUnosTroska;
        private System.Windows.Forms.TextBox uiIspisTroskova;
        private System.Windows.Forms.Button uiDodajTrosak;
        private System.Windows.Forms.ComboBox uiActionFiltriraj;
    }
}

