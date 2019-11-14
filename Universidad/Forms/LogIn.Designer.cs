namespace Universidad.Forms
{
    partial class LogIn
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
            this.usuarioTb = new System.Windows.Forms.TextBox();
            this.passTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ingresarBt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // usuarioTb
            // 
            this.usuarioTb.Location = new System.Drawing.Point(22, 163);
            this.usuarioTb.Name = "usuarioTb";
            this.usuarioTb.Size = new System.Drawing.Size(179, 20);
            this.usuarioTb.TabIndex = 0;
            this.usuarioTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passTb
            // 
            this.passTb.Location = new System.Drawing.Point(22, 226);
            this.passTb.Name = "passTb";
            this.passTb.Size = new System.Drawing.Size(179, 20);
            this.passTb.TabIndex = 1;
            this.passTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passTb.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "USUARIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "CONTRASEÑA";
            // 
            // ingresarBt
            // 
            this.ingresarBt.BackColor = System.Drawing.Color.LightGreen;
            this.ingresarBt.FlatAppearance.BorderColor = System.Drawing.Color.LightGreen;
            this.ingresarBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ingresarBt.Location = new System.Drawing.Point(72, 263);
            this.ingresarBt.Name = "ingresarBt";
            this.ingresarBt.Size = new System.Drawing.Size(75, 23);
            this.ingresarBt.TabIndex = 5;
            this.ingresarBt.Text = "Ingresar";
            this.ingresarBt.UseVisualStyleBackColor = false;
            this.ingresarBt.Click += new System.EventHandler(this.IngresarBt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Universidad.Properties.Resources.logo_utn;
            this.pictureBox1.Location = new System.Drawing.Point(50, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(222, 298);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ingresarBt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passTb);
            this.Controls.Add(this.usuarioTb);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(238, 337);
            this.MinimumSize = new System.Drawing.Size(238, 337);
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usuarioTb;
        private System.Windows.Forms.TextBox passTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ingresarBt;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}