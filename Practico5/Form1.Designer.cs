namespace Practico5
{
    partial class Form1
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
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            BAgregar = new Button();
            BFotos = new Button();
            RBMujer = new RadioButton();
            RBHombre = new RadioButton();
            dateTimePickerFechaNac = new DateTimePicker();
            TxtFotos = new TextBox();
            TxtSaldo = new TextBox();
            TxtApellido = new TextBox();
            TxtNombre = new TextBox();
            LSaldo = new Label();
            LSexo = new Label();
            LFechaNac = new Label();
            LApellido = new Label();
            LNombre = new Label();
            openFileDialog1 = new OpenFileDialog();
            Apellido = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            FechaNacimiento = new DataGridViewTextBoxColumn();
            Sexo = new DataGridViewTextBoxColumn();
            BEliminar = new DataGridViewButtonColumn();
            Saldo = new DataGridViewTextBoxColumn();
            Foto = new DataGridViewImageColumn();
            Ruta = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources._4857721;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(896, 646);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Apellido, Nombre, FechaNacimiento, Sexo, BEliminar, Saldo, Foto, Ruta });
            dataGridView1.GridColor = SystemColors.InactiveCaptionText;
            dataGridView1.Location = new Point(16, 433);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(851, 500);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(541, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(284, 280);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDarkDark;
            panel2.Controls.Add(BAgregar);
            panel2.Controls.Add(BFotos);
            panel2.Controls.Add(RBMujer);
            panel2.Controls.Add(RBHombre);
            panel2.Controls.Add(dateTimePickerFechaNac);
            panel2.Controls.Add(TxtFotos);
            panel2.Controls.Add(TxtSaldo);
            panel2.Controls.Add(TxtApellido);
            panel2.Controls.Add(TxtNombre);
            panel2.Controls.Add(LSaldo);
            panel2.Controls.Add(LSexo);
            panel2.Controls.Add(LFechaNac);
            panel2.Controls.Add(LApellido);
            panel2.Controls.Add(LNombre);
            panel2.Font = new Font("Papyrus", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.ForeColor = SystemColors.ControlLightLight;
            panel2.Location = new Point(41, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(479, 415);
            panel2.TabIndex = 1;
            // 
            // BAgregar
            // 
            BAgregar.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BAgregar.ForeColor = SystemColors.ActiveCaptionText;
            BAgregar.Image = Properties.Resources.icons8_ahorrar_40;
            BAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            BAgregar.Location = new Point(185, 354);
            BAgregar.Name = "BAgregar";
            BAgregar.Size = new Size(106, 49);
            BAgregar.TabIndex = 4;
            BAgregar.Text = "Agregar";
            BAgregar.TextAlign = ContentAlignment.MiddleRight;
            BAgregar.UseVisualStyleBackColor = true;
            BAgregar.Click += BAgregar_Click;
            // 
            // BFotos
            // 
            BFotos.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BFotos.ForeColor = SystemColors.ActiveCaptionText;
            BFotos.Location = new Point(28, 274);
            BFotos.Name = "BFotos";
            BFotos.Size = new Size(75, 33);
            BFotos.TabIndex = 4;
            BFotos.Text = "Foto";
            BFotos.UseVisualStyleBackColor = true;
            BFotos.Click += BFotos_Click;
            // 
            // RBMujer
            // 
            RBMujer.Font = new Font("Papyrus", 12F);
            RBMujer.Location = new Point(273, 194);
            RBMujer.Name = "RBMujer";
            RBMujer.Size = new Size(117, 37);
            RBMujer.TabIndex = 3;
            RBMujer.TabStop = true;
            RBMujer.Text = "Mujer";
            RBMujer.UseVisualStyleBackColor = true;
            // 
            // RBHombre
            // 
            RBHombre.Font = new Font("Papyrus", 12F);
            RBHombre.Location = new Point(150, 194);
            RBHombre.Name = "RBHombre";
            RBHombre.Size = new Size(117, 37);
            RBHombre.TabIndex = 3;
            RBHombre.TabStop = true;
            RBHombre.Text = "Hombre";
            RBHombre.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerFechaNac
            // 
            dateTimePickerFechaNac.Font = new Font("Papyrus", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerFechaNac.Format = DateTimePickerFormat.Short;
            dateTimePickerFechaNac.Location = new Point(236, 151);
            dateTimePickerFechaNac.Name = "dateTimePickerFechaNac";
            dateTimePickerFechaNac.Size = new Size(144, 28);
            dateTimePickerFechaNac.TabIndex = 2;
            // 
            // TxtFotos
            // 
            TxtFotos.Font = new Font("Papyrus", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtFotos.Location = new Point(131, 279);
            TxtFotos.Name = "TxtFotos";
            TxtFotos.Size = new Size(339, 28);
            TxtFotos.TabIndex = 1;
            // 
            // TxtSaldo
            // 
            TxtSaldo.Font = new Font("Papyrus", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtSaldo.Location = new Point(131, 232);
            TxtSaldo.Name = "TxtSaldo";
            TxtSaldo.Size = new Size(339, 28);
            TxtSaldo.TabIndex = 1;
            // 
            // TxtApellido
            // 
            TxtApellido.Font = new Font("Papyrus", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtApellido.Location = new Point(131, 93);
            TxtApellido.Name = "TxtApellido";
            TxtApellido.Size = new Size(339, 28);
            TxtApellido.TabIndex = 1;
            TxtApellido.Leave += TxtApellido_Leave;
            // 
            // TxtNombre
            // 
            TxtNombre.Font = new Font("Papyrus", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtNombre.Location = new Point(131, 35);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(339, 28);
            TxtNombre.TabIndex = 1;
            TxtNombre.Leave += TxtNombre_Leave;
            // 
            // LSaldo
            // 
            LSaldo.AutoSize = true;
            LSaldo.Location = new Point(21, 227);
            LSaldo.Name = "LSaldo";
            LSaldo.Size = new Size(82, 34);
            LSaldo.TabIndex = 0;
            LSaldo.Text = "Saldo:";
            // 
            // LSexo
            // 
            LSexo.AutoSize = true;
            LSexo.Location = new Point(21, 194);
            LSexo.Name = "LSexo";
            LSexo.Size = new Size(74, 34);
            LSexo.TabIndex = 0;
            LSexo.Text = "Sexo:";
            // 
            // LFechaNac
            // 
            LFechaNac.AutoSize = true;
            LFechaNac.Location = new Point(21, 149);
            LFechaNac.Name = "LFechaNac";
            LFechaNac.Size = new Size(194, 34);
            LFechaNac.TabIndex = 0;
            LFechaNac.Text = "Fecha Nacimiento:";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Location = new Point(21, 88);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(104, 34);
            LApellido.TabIndex = 0;
            LApellido.Text = "Apellido:";
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(21, 30);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(96, 34);
            LNombre.TabIndex = 0;
            LNombre.Text = "Nombre:";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // FechaNacimiento
            // 
            FechaNacimiento.HeaderText = "Fecha de Nacimiento";
            FechaNacimiento.Name = "FechaNacimiento";
            // 
            // Sexo
            // 
            Sexo.HeaderText = "Sexo";
            Sexo.Name = "Sexo";
            // 
            // BEliminar
            // 
            BEliminar.HeaderText = "Eliminar";
            BEliminar.Name = "BEliminar";
            // 
            // Saldo
            // 
            Saldo.HeaderText = "Saldo";
            Saldo.Name = "Saldo";
            Saldo.Resizable = DataGridViewTriState.True;
            Saldo.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Foto
            // 
            Foto.HeaderText = "Foto";
            Foto.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Foto.Name = "Foto";
            // 
            // Ruta
            // 
            Ruta.HeaderText = "Ruta";
            Ruta.Name = "Ruta";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 646);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Formulario de Datagrid";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label LNombre;
        private TextBox TxtNombre;
        private Label LSaldo;
        private Label LSexo;
        private Label LFechaNac;
        private Label LApellido;
        private DateTimePicker dateTimePickerFechaNac;
        private TextBox TxtApellido;
        private RadioButton RBHombre;
        private RadioButton RBMujer;
        private TextBox TxtSaldo;
        private Button BAgregar;
        private Button BFotos;
        private TextBox TxtFotos;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn FechaNacimiento;
        private DataGridViewTextBoxColumn Sexo;
        private DataGridViewButtonColumn BEliminar;
        private DataGridViewTextBoxColumn Saldo;
        private DataGridViewImageColumn Foto;
        private DataGridViewTextBoxColumn Ruta;
    }
}
