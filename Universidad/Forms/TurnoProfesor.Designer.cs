namespace Universidad.Forms
{
    partial class TurnoProfesor
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
            this.aCb = new System.Windows.Forms.CheckBox();
            this.bCb = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // aCb
            // 
            this.aCb.AutoSize = true;
            this.aCb.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.aCb.Location = new System.Drawing.Point(33, 22);
            this.aCb.Name = "aCb";
            this.aCb.Size = new System.Drawing.Size(65, 17);
            this.aCb.TabIndex = 0;
            this.aCb.Text = "Mañana";
            this.aCb.UseVisualStyleBackColor = true;
            // 
            // bCb
            // 
            this.bCb.AutoSize = true;
            this.bCb.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bCb.Location = new System.Drawing.Point(33, 45);
            this.bCb.Name = "bCb";
            this.bCb.Size = new System.Drawing.Size(54, 17);
            this.bCb.TabIndex = 1;
            this.bCb.Text = "Tarde";
            this.bCb.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // TurnoProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(120, 115);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bCb);
            this.Controls.Add(this.aCb);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(136, 154);
            this.MinimumSize = new System.Drawing.Size(136, 154);
            this.Name = "TurnoProfesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TurnoProfesor";
            this.Load += new System.EventHandler(this.TurnoProfesor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox aCb;
        private System.Windows.Forms.CheckBox bCb;
        private System.Windows.Forms.Button button1;
    }
}