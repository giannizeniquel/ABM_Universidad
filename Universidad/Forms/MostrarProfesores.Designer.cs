namespace Universidad.Forms
{
    partial class MostrarProfesores
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
            this.mostrarProDg = new System.Windows.Forms.DataGridView();
            this.profesorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.universidadDataSet3 = new Universidad.UniversidadDataSet3();
            this.profesorTableAdapter = new Universidad.UniversidadDataSet3TableAdapters.profesorTableAdapter();
            this.asiganrMateriaBt = new System.Windows.Forms.Button();
            this.verMatAsignadaBt = new System.Windows.Forms.Button();
            this.borrarProfBt = new System.Windows.Forms.Button();
            this.modificarProfBt = new System.Windows.Forms.Button();
            this.profesorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dnipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimientopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paispDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provinciapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidadpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarProDg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universidadDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // mostrarProDg
            // 
            this.mostrarProDg.AutoGenerateColumns = false;
            this.mostrarProDg.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.mostrarProDg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mostrarProDg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.profesorIdDataGridViewTextBoxColumn,
            this.nombrepDataGridViewTextBoxColumn,
            this.apellidopDataGridViewTextBoxColumn,
            this.dnipDataGridViewTextBoxColumn,
            this.telefonopDataGridViewTextBoxColumn,
            this.fechaNacimientopDataGridViewTextBoxColumn,
            this.edadpDataGridViewTextBoxColumn,
            this.direccionpDataGridViewTextBoxColumn,
            this.paispDataGridViewTextBoxColumn,
            this.provinciapDataGridViewTextBoxColumn,
            this.localidadpDataGridViewTextBoxColumn,
            this.generopDataGridViewTextBoxColumn});
            this.mostrarProDg.DataSource = this.profesorBindingSource;
            this.mostrarProDg.Location = new System.Drawing.Point(12, 12);
            this.mostrarProDg.Name = "mostrarProDg";
            this.mostrarProDg.Size = new System.Drawing.Size(1087, 449);
            this.mostrarProDg.TabIndex = 0;
            // 
            // profesorBindingSource
            // 
            this.profesorBindingSource.DataMember = "profesor";
            this.profesorBindingSource.DataSource = this.universidadDataSet3;
            // 
            // universidadDataSet3
            // 
            this.universidadDataSet3.DataSetName = "UniversidadDataSet3";
            this.universidadDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // profesorTableAdapter
            // 
            this.profesorTableAdapter.ClearBeforeFill = true;
            // 
            // asiganrMateriaBt
            // 
            this.asiganrMateriaBt.BackColor = System.Drawing.Color.LightGreen;
            this.asiganrMateriaBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.asiganrMateriaBt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.asiganrMateriaBt.Location = new System.Drawing.Point(12, 467);
            this.asiganrMateriaBt.Name = "asiganrMateriaBt";
            this.asiganrMateriaBt.Size = new System.Drawing.Size(95, 23);
            this.asiganrMateriaBt.TabIndex = 1;
            this.asiganrMateriaBt.Text = "Asignar Materia";
            this.asiganrMateriaBt.UseVisualStyleBackColor = false;
            this.asiganrMateriaBt.Click += new System.EventHandler(this.AsiganrMateriaBt_Click);
            // 
            // verMatAsignadaBt
            // 
            this.verMatAsignadaBt.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.verMatAsignadaBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verMatAsignadaBt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.verMatAsignadaBt.Location = new System.Drawing.Point(154, 467);
            this.verMatAsignadaBt.Name = "verMatAsignadaBt";
            this.verMatAsignadaBt.Size = new System.Drawing.Size(120, 23);
            this.verMatAsignadaBt.TabIndex = 2;
            this.verMatAsignadaBt.Text = "Materias Asignadas";
            this.verMatAsignadaBt.UseVisualStyleBackColor = false;
            this.verMatAsignadaBt.Click += new System.EventHandler(this.VerMatAsignadaBt_Click);
            // 
            // borrarProfBt
            // 
            this.borrarProfBt.BackColor = System.Drawing.Color.IndianRed;
            this.borrarProfBt.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.borrarProfBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrarProfBt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.borrarProfBt.Location = new System.Drawing.Point(1024, 467);
            this.borrarProfBt.Name = "borrarProfBt";
            this.borrarProfBt.Size = new System.Drawing.Size(75, 23);
            this.borrarProfBt.TabIndex = 3;
            this.borrarProfBt.Text = "Borrar";
            this.borrarProfBt.UseVisualStyleBackColor = false;
            // 
            // modificarProfBt
            // 
            this.modificarProfBt.BackColor = System.Drawing.Color.LightSteelBlue;
            this.modificarProfBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificarProfBt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.modificarProfBt.Location = new System.Drawing.Point(916, 467);
            this.modificarProfBt.Name = "modificarProfBt";
            this.modificarProfBt.Size = new System.Drawing.Size(75, 23);
            this.modificarProfBt.TabIndex = 4;
            this.modificarProfBt.Text = "Modificar";
            this.modificarProfBt.UseVisualStyleBackColor = false;
            this.modificarProfBt.Click += new System.EventHandler(this.ModificarProfBt_Click);
            // 
            // profesorIdDataGridViewTextBoxColumn
            // 
            this.profesorIdDataGridViewTextBoxColumn.DataPropertyName = "profesorId";
            this.profesorIdDataGridViewTextBoxColumn.HeaderText = "Legajo";
            this.profesorIdDataGridViewTextBoxColumn.Name = "profesorIdDataGridViewTextBoxColumn";
            // 
            // nombrepDataGridViewTextBoxColumn
            // 
            this.nombrepDataGridViewTextBoxColumn.DataPropertyName = "nombre_p";
            this.nombrepDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombrepDataGridViewTextBoxColumn.Name = "nombrepDataGridViewTextBoxColumn";
            // 
            // apellidopDataGridViewTextBoxColumn
            // 
            this.apellidopDataGridViewTextBoxColumn.DataPropertyName = "apellido_p";
            this.apellidopDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidopDataGridViewTextBoxColumn.Name = "apellidopDataGridViewTextBoxColumn";
            // 
            // dnipDataGridViewTextBoxColumn
            // 
            this.dnipDataGridViewTextBoxColumn.DataPropertyName = "dni_p";
            this.dnipDataGridViewTextBoxColumn.HeaderText = "DNI";
            this.dnipDataGridViewTextBoxColumn.Name = "dnipDataGridViewTextBoxColumn";
            // 
            // telefonopDataGridViewTextBoxColumn
            // 
            this.telefonopDataGridViewTextBoxColumn.DataPropertyName = "telefono_p";
            this.telefonopDataGridViewTextBoxColumn.HeaderText = "Teléfono";
            this.telefonopDataGridViewTextBoxColumn.Name = "telefonopDataGridViewTextBoxColumn";
            // 
            // fechaNacimientopDataGridViewTextBoxColumn
            // 
            this.fechaNacimientopDataGridViewTextBoxColumn.DataPropertyName = "fechaNacimiento_p";
            this.fechaNacimientopDataGridViewTextBoxColumn.HeaderText = "Fecha de Nacimiento";
            this.fechaNacimientopDataGridViewTextBoxColumn.Name = "fechaNacimientopDataGridViewTextBoxColumn";
            // 
            // edadpDataGridViewTextBoxColumn
            // 
            this.edadpDataGridViewTextBoxColumn.DataPropertyName = "edad_p";
            this.edadpDataGridViewTextBoxColumn.HeaderText = "Edad";
            this.edadpDataGridViewTextBoxColumn.Name = "edadpDataGridViewTextBoxColumn";
            // 
            // direccionpDataGridViewTextBoxColumn
            // 
            this.direccionpDataGridViewTextBoxColumn.DataPropertyName = "direccion_p";
            this.direccionpDataGridViewTextBoxColumn.HeaderText = "Dirección";
            this.direccionpDataGridViewTextBoxColumn.Name = "direccionpDataGridViewTextBoxColumn";
            // 
            // paispDataGridViewTextBoxColumn
            // 
            this.paispDataGridViewTextBoxColumn.DataPropertyName = "pais_p";
            this.paispDataGridViewTextBoxColumn.HeaderText = "País";
            this.paispDataGridViewTextBoxColumn.Name = "paispDataGridViewTextBoxColumn";
            // 
            // provinciapDataGridViewTextBoxColumn
            // 
            this.provinciapDataGridViewTextBoxColumn.DataPropertyName = "provincia_p";
            this.provinciapDataGridViewTextBoxColumn.HeaderText = "Provincia";
            this.provinciapDataGridViewTextBoxColumn.Name = "provinciapDataGridViewTextBoxColumn";
            // 
            // localidadpDataGridViewTextBoxColumn
            // 
            this.localidadpDataGridViewTextBoxColumn.DataPropertyName = "localidad_p";
            this.localidadpDataGridViewTextBoxColumn.HeaderText = "Localidad";
            this.localidadpDataGridViewTextBoxColumn.Name = "localidadpDataGridViewTextBoxColumn";
            // 
            // generopDataGridViewTextBoxColumn
            // 
            this.generopDataGridViewTextBoxColumn.DataPropertyName = "genero_p";
            this.generopDataGridViewTextBoxColumn.HeaderText = "Género";
            this.generopDataGridViewTextBoxColumn.Name = "generopDataGridViewTextBoxColumn";
            // 
            // MostrarProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1111, 502);
            this.Controls.Add(this.modificarProfBt);
            this.Controls.Add(this.borrarProfBt);
            this.Controls.Add(this.verMatAsignadaBt);
            this.Controls.Add(this.asiganrMateriaBt);
            this.Controls.Add(this.mostrarProDg);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MostrarProfesores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MostrarProfesores";
            this.Load += new System.EventHandler(this.MostrarProfesores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mostrarProDg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universidadDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView mostrarProDg;
        private UniversidadDataSet3 universidadDataSet3;
        private System.Windows.Forms.BindingSource profesorBindingSource;
        private UniversidadDataSet3TableAdapters.profesorTableAdapter profesorTableAdapter;
        private System.Windows.Forms.Button asiganrMateriaBt;
        private System.Windows.Forms.Button verMatAsignadaBt;
        private System.Windows.Forms.Button borrarProfBt;
        private System.Windows.Forms.Button modificarProfBt;
        private System.Windows.Forms.DataGridViewTextBoxColumn profesorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dnipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimientopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paispDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn provinciapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidadpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn generopDataGridViewTextBoxColumn;
    }
}