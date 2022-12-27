namespace Hubstaf
{
    partial class projectcontainer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblproject = new Guna.UI.WinForms.GunaLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblproject
            // 
            this.lblproject.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproject.ForeColor = System.Drawing.Color.Black;
            this.lblproject.Location = new System.Drawing.Point(3, 12);
            this.lblproject.Name = "lblproject";
            this.lblproject.Size = new System.Drawing.Size(312, 23);
            this.lblproject.TabIndex = 0;
            this.lblproject.Text = "name project";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 3);
            this.panel1.TabIndex = 1;
            // 
            // projectcontainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblproject);
            this.Name = "projectcontainer";
            this.Size = new System.Drawing.Size(318, 44);
            this.Enter += new System.EventHandler(this.projectcontainer_Enter);
            this.Leave += new System.EventHandler(this.projectcontainer_Leave);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel lblproject;
        private System.Windows.Forms.Panel panel1;
    }
}
