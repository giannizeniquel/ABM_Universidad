namespace Universidad.Forms
{
    partial class MostrarAlumnos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.alumnoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimientoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paisaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provinciaaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alumnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.universidadDataSet = new Universidad.UniversidadDataSet();
            this.alumnoTableAdapter = new Universidad.UniversidadDataSetTableAdapters.alumnoTableAdapter();
            this.busquedaTb = new System.Windows.Forms.TextBox();
            this.modificarBt = new System.Windows.Forms.Button();
            this.borrarBt = new System.Windows.Forms.Button();
            this.consultarBt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.inscribirBt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universidadDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.BlanchedAlmond;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DimGray;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.alumnoIdDataGridViewTextBoxColumn,
            this.nombreaDataGridViewTextBoxColumn,
            this.apellidoaDataGridViewTextBoxColumn,
            this.dniaDataGridViewTextBoxColumn,
            this.telefonoaDataGridViewTextBoxColumn,
            this.fechaNacimientoaDataGridViewTextBoxColumn,
            this.edadaDataGridViewTextBoxColumn,
            this.direccionaDataGridViewTextBoxColumn,
            this.paisaDataGridViewTextBoxColumn,
            this.provinciaaDataGridViewTextBoxColumn,
            this.localidadaDataGridViewTextBoxColumn,
            this.generoaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.alumnoBindingSource;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridView1.Location = new System.Drawing.Point(1, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.DarkKhaki;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridView1.Size = new System.Drawing.Size(1098, 376);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellDoubleClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_CellMouseDoubleClick);
            // 
            // alumnoIdDataGridViewTextBoxColumn
            // 
            this.alumnoIdDataGridViewTextBoxColumn.DataPropertyName = "alumnoId";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.alumnoIdDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.alumnoIdDataGridViewTextBoxColumn.HeaderText = "MATRICULA";
            this.alumnoIdDataGridViewTextBoxColumn.Name = "alumnoIdDataGridViewTextBoxColumn";
            this.alumnoIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.alumnoIdDataGridViewTextBoxColumn.Width = 94;
            // 
            // nombreaDataGridViewTextBoxColumn
            // 
            this.nombreaDataGridViewTextBoxColumn.DataPropertyName = "nombre_a";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.nombreaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.nombreaDataGridViewTextBoxColumn.HeaderText = "NOMBRE";
            this.nombreaDataGridViewTextBoxColumn.Name = "nombreaDataGridViewTextBoxColumn";
            this.nombreaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreaDataGridViewTextBoxColumn.Width = 79;
            // 
            // apellidoaDataGridViewTextBoxColumn
            // 
            this.apellidoaDataGridViewTextBoxColumn.DataPropertyName = "apellido_a";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.apellidoaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.apellidoaDataGridViewTextBoxColumn.HeaderText = "APELLIDO";
            this.apellidoaDataGridViewTextBoxColumn.Name = "apellidoaDataGridViewTextBoxColumn";
            this.apellidoaDataGridViewTextBoxColumn.ReadOnly = true;
            this.apellidoaDataGridViewTextBoxColumn.Width = 84;
            // 
            // dniaDataGridViewTextBoxColumn
            // 
            this.dniaDataGridViewTextBoxColumn.DataPropertyName = "dni_a";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dniaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.dniaDataGridViewTextBoxColumn.HeaderText = "DNI";
            this.dniaDataGridViewTextBoxColumn.Name = "dniaDataGridViewTextBoxColumn";
            this.dniaDataGridViewTextBoxColumn.ReadOnly = true;
            this.dniaDataGridViewTextBoxColumn.Width = 51;
            // 
            // telefonoaDataGridViewTextBoxColumn
            // 
            this.telefonoaDataGridViewTextBoxColumn.DataPropertyName = "telefono_a";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.telefonoaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.telefonoaDataGridViewTextBoxColumn.HeaderText = "TELEFONO";
            this.telefonoaDataGridViewTextBoxColumn.Name = "telefonoaDataGridViewTextBoxColumn";
            this.telefonoaDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefonoaDataGridViewTextBoxColumn.Width = 89;
            // 
            // fechaNacimientoaDataGridViewTextBoxColumn
            // 
            this.fechaNacimientoaDataGridViewTextBoxColumn.DataPropertyName = "fechaNacimiento_a";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.fechaNacimientoaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.fechaNacimientoaDataGridViewTextBoxColumn.HeaderText = "FECHA DE NACIMIENTO";
            this.fechaNacimientoaDataGridViewTextBoxColumn.Name = "fechaNacimientoaDataGridViewTextBoxColumn";
            this.fechaNacimientoaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaNacimientoaDataGridViewTextBoxColumn.Width = 141;
            // 
            // edadaDataGridViewTextBoxColumn
            // 
            this.edadaDataGridViewTextBoxColumn.DataPropertyName = "edad_a";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.edadaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.edadaDataGridViewTextBoxColumn.HeaderText = "EDAD";
            this.edadaDataGridViewTextBoxColumn.Name = "edadaDataGridViewTextBoxColumn";
            this.edadaDataGridViewTextBoxColumn.ReadOnly = true;
            this.edadaDataGridViewTextBoxColumn.Width = 62;
            // 
            // direccionaDataGridViewTextBoxColumn
            // 
            this.direccionaDataGridViewTextBoxColumn.DataPropertyName = "direccion_a";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.direccionaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.direccionaDataGridViewTextBoxColumn.HeaderText = "DIRECCION";
            this.direccionaDataGridViewTextBoxColumn.Name = "direccionaDataGridViewTextBoxColumn";
            this.direccionaDataGridViewTextBoxColumn.ReadOnly = true;
            this.direccionaDataGridViewTextBoxColumn.Width = 91;
            // 
            // paisaDataGridViewTextBoxColumn
            // 
            this.paisaDataGridViewTextBoxColumn.DataPropertyName = "pais_a";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            this.paisaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.paisaDataGridViewTextBoxColumn.HeaderText = "PAIS";
            this.paisaDataGridViewTextBoxColumn.Name = "paisaDataGridViewTextBoxColumn";
            this.paisaDataGridViewTextBoxColumn.ReadOnly = true;
            this.paisaDataGridViewTextBoxColumn.Width = 56;
            // 
            // provinciaaDataGridViewTextBoxColumn
            // 
            this.provinciaaDataGridViewTextBoxColumn.DataPropertyName = "provincia_a";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.provinciaaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle12;
            this.provinciaaDataGridViewTextBoxColumn.HeaderText = "PROVINCIA";
            this.provinciaaDataGridViewTextBoxColumn.Name = "provinciaaDataGridViewTextBoxColumn";
            this.provinciaaDataGridViewTextBoxColumn.ReadOnly = true;
            this.provinciaaDataGridViewTextBoxColumn.Width = 90;
            // 
            // localidadaDataGridViewTextBoxColumn
            // 
            this.localidadaDataGridViewTextBoxColumn.DataPropertyName = "localidad_a";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            this.localidadaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle13;
            this.localidadaDataGridViewTextBoxColumn.HeaderText = "LOCALIDAD";
            this.localidadaDataGridViewTextBoxColumn.Name = "localidadaDataGridViewTextBoxColumn";
            this.localidadaDataGridViewTextBoxColumn.ReadOnly = true;
            this.localidadaDataGridViewTextBoxColumn.Width = 92;
            // 
            // generoaDataGridViewTextBoxColumn
            // 
            this.generoaDataGridViewTextBoxColumn.DataPropertyName = "genero_a";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            this.generoaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle14;
            this.generoaDataGridViewTextBoxColumn.HeaderText = "GENERO";
            this.generoaDataGridViewTextBoxColumn.Name = "generoaDataGridViewTextBoxColumn";
            this.generoaDataGridViewTextBoxColumn.ReadOnly = true;
            this.generoaDataGridViewTextBoxColumn.Width = 78;
            // 
            // alumnoBindingSource
            // 
            this.alumnoBindingSource.DataMember = "alumno";
            this.alumnoBindingSource.DataSource = this.universidadDataSet;
            // 
            // universidadDataSet
            // 
            this.universidadDataSet.DataSetName = "UniversidadDataSet";
            this.universidadDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alumnoTableAdapter
            // 
            this.alumnoTableAdapter.ClearBeforeFill = true;
            // 
            // busquedaTb
            // 
            this.busquedaTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busquedaTb.Location = new System.Drawing.Point(452, 32);
            this.busquedaTb.Name = "busquedaTb";
            this.busquedaTb.Size = new System.Drawing.Size(200, 24);
            this.busquedaTb.TabIndex = 1;
            this.busquedaTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.busquedaTb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BusquedaTb_KeyUp);
            // 
            // modificarBt
            // 
            this.modificarBt.Location = new System.Drawing.Point(93, 458);
            this.modificarBt.Name = "modificarBt";
            this.modificarBt.Size = new System.Drawing.Size(75, 23);
            this.modificarBt.TabIndex = 3;
            this.modificarBt.Text = "Modificar";
            this.modificarBt.UseVisualStyleBackColor = true;
            this.modificarBt.Click += new System.EventHandler(this.ModificarBt_Click);
            // 
            // borrarBt
            // 
            this.borrarBt.Location = new System.Drawing.Point(1014, 458);
            this.borrarBt.Name = "borrarBt";
            this.borrarBt.Size = new System.Drawing.Size(75, 23);
            this.borrarBt.TabIndex = 4;
            this.borrarBt.Text = "Borrar";
            this.borrarBt.UseVisualStyleBackColor = true;
            this.borrarBt.Click += new System.EventHandler(this.BorrarBt_Click);
            // 
            // consultarBt
            // 
            this.consultarBt.Location = new System.Drawing.Point(12, 458);
            this.consultarBt.Name = "consultarBt";
            this.consultarBt.Size = new System.Drawing.Size(75, 23);
            this.consultarBt.TabIndex = 5;
            this.consultarBt.Text = "Consultar";
            this.consultarBt.UseVisualStyleBackColor = true;
            this.consultarBt.Click += new System.EventHandler(this.ConsultarBt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Location = new System.Drawing.Point(529, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Buscar";
            // 
            // inscribirBt
            // 
            this.inscribirBt.Location = new System.Drawing.Point(174, 458);
            this.inscribirBt.Name = "inscribirBt";
            this.inscribirBt.Size = new System.Drawing.Size(75, 23);
            this.inscribirBt.TabIndex = 7;
            this.inscribirBt.Text = "Inscribir";
            this.inscribirBt.UseVisualStyleBackColor = true;
            this.inscribirBt.Click += new System.EventHandler(this.InscribirBt_Click);
            // 
            // MostrarAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1111, 502);
            this.Controls.Add(this.inscribirBt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.consultarBt);
            this.Controls.Add(this.borrarBt);
            this.Controls.Add(this.modificarBt);
            this.Controls.Add(this.busquedaTb);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1127, 541);
            this.MinimumSize = new System.Drawing.Size(1127, 541);
            this.Name = "MostrarAlumnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MostrarAlumnos";
            this.Load += new System.EventHandler(this.MostrarAlumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universidadDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private UniversidadDataSet universidadDataSet;
        private System.Windows.Forms.BindingSource alumnoBindingSource;
        private UniversidadDataSetTableAdapters.alumnoTableAdapter alumnoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn alumnoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimientoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paisaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn provinciaaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn generoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox busquedaTb;
        private System.Windows.Forms.Button modificarBt;
        private System.Windows.Forms.Button borrarBt;
        private System.Windows.Forms.Button consultarBt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button inscribirBt;
    }
}