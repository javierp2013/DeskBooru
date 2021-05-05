
namespace DeskBooruApp
{
    partial class Form3
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
            this.Gal_Name_Input = new System.Windows.Forms.TextBox();
            this.Gal_Name = new System.Windows.Forms.Label();
            this.Gal_Create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Gal_Name_Input
            // 
            this.Gal_Name_Input.Location = new System.Drawing.Point(12, 66);
            this.Gal_Name_Input.Name = "Gal_Name_Input";
            this.Gal_Name_Input.Size = new System.Drawing.Size(252, 23);
            this.Gal_Name_Input.TabIndex = 1;
            // 
            // Gal_Name
            // 
            this.Gal_Name.AutoSize = true;
            this.Gal_Name.Location = new System.Drawing.Point(82, 33);
            this.Gal_Name.Name = "Gal_Name";
            this.Gal_Name.Size = new System.Drawing.Size(108, 15);
            this.Gal_Name.TabIndex = 4;
            this.Gal_Name.Text = "Enter Gallery Name";
            this.Gal_Name.Click += new System.EventHandler(this.label1_Click);
            // 
            // Gal_Create
            // 
            this.Gal_Create.Location = new System.Drawing.Point(101, 105);
            this.Gal_Create.Name = "Gal_Create";
            this.Gal_Create.Size = new System.Drawing.Size(75, 23);
            this.Gal_Create.TabIndex = 5;
            this.Gal_Create.Text = "Create";
            this.Gal_Create.UseVisualStyleBackColor = true;
            this.Gal_Create.Click += new System.EventHandler(this.Gal_Create_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(276, 146);
            this.Controls.Add(this.Gal_Create);
            this.Controls.Add(this.Gal_Name);
            this.Controls.Add(this.Gal_Name_Input);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Gal_Name_Input;
        private System.Windows.Forms.Label Gal_Name;
        private System.Windows.Forms.Button Gal_Create;
    }
}