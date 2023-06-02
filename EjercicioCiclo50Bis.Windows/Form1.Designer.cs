namespace EjercicioCiclo50Bis.Windows
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btnLimpiar = new Button();
            btnSalir = new Button();
            btnCancelar = new Button();
            btnOK = new Button();
            txtCelsiusFinal = new TextBox();
            label2 = new Label();
            txtCelsiusInicial = new TextBox();
            label1 = new Label();
            dgvDatos = new DataGridView();
            colCelsius = new DataGridViewTextBoxColumn();
            colFahrenheit = new DataGridViewTextBoxColumn();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(46, 446);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(277, 52);
            btnLimpiar.TabIndex = 14;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(248, 504);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 52);
            btnSalir.TabIndex = 15;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(248, 112);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 52);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(43, 112);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 52);
            btnOK.TabIndex = 10;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // txtCelsiusFinal
            // 
            txtCelsiusFinal.Location = new Point(223, 67);
            txtCelsiusFinal.Name = "txtCelsiusFinal";
            txtCelsiusFinal.Size = new Size(100, 23);
            txtCelsiusFinal.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 70);
            label2.Name = "label2";
            label2.Size = new Size(165, 15);
            label2.TabIndex = 6;
            label2.Text = "Ingrese la última temperatura:";
            // 
            // txtCelsiusInicial
            // 
            txtCelsiusInicial.Location = new Point(223, 29);
            txtCelsiusInicial.Name = "txtCelsiusInicial";
            txtCelsiusInicial.Size = new Size(100, 23);
            txtCelsiusInicial.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 32);
            label1.Name = "label1";
            label1.Size = new Size(166, 15);
            label1.TabIndex = 8;
            label1.Text = "Ingrese la primer temperatura:";
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colCelsius, colFahrenheit });
            dgvDatos.Location = new Point(50, 186);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowTemplate.Height = 25;
            dgvDatos.Size = new Size(273, 239);
            dgvDatos.TabIndex = 16;
            // 
            // colCelsius
            // 
            colCelsius.HeaderText = "Celsius";
            colCelsius.Name = "colCelsius";
            colCelsius.ReadOnly = true;
            // 
            // colFahrenheit
            // 
            colFahrenheit.HeaderText = "Fahrenheit";
            colFahrenheit.Name = "colFahrenheit";
            colFahrenheit.ReadOnly = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 568);
            Controls.Add(dgvDatos);
            Controls.Add(btnLimpiar);
            Controls.Add(btnSalir);
            Controls.Add(btnCancelar);
            Controls.Add(btnOK);
            Controls.Add(txtCelsiusFinal);
            Controls.Add(label2);
            Controls.Add(txtCelsiusInicial);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLimpiar;
        private Button btnSalir;
        private Button btnCancelar;
        private Button btnOK;
        private TextBox txtCelsiusFinal;
        private Label label2;
        private TextBox txtCelsiusInicial;
        private Label label1;
        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn colCelsius;
        private DataGridViewTextBoxColumn colFahrenheit;
        private ErrorProvider errorProvider1;
    }
}