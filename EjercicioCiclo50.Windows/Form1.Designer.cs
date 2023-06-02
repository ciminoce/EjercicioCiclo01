namespace EjercicioCiclo50.Windows
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
            label1 = new Label();
            txtCelsiusInicial = new TextBox();
            label2 = new Label();
            txtCelsiusFinal = new TextBox();
            btnOK = new Button();
            btnCancelar = new Button();
            lsbCelsius = new ListBox();
            lsbFahrenheit = new ListBox();
            btnLimpiar = new Button();
            btnSalir = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 40);
            label1.Name = "label1";
            label1.Size = new Size(166, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese la primer temperatura:";
            // 
            // txtCelsiusInicial
            // 
            txtCelsiusInicial.Location = new Point(240, 37);
            txtCelsiusInicial.Name = "txtCelsiusInicial";
            txtCelsiusInicial.Size = new Size(100, 23);
            txtCelsiusInicial.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 78);
            label2.Name = "label2";
            label2.Size = new Size(165, 15);
            label2.TabIndex = 0;
            label2.Text = "Ingrese la última temperatura:";
            // 
            // txtCelsiusFinal
            // 
            txtCelsiusFinal.Location = new Point(240, 75);
            txtCelsiusFinal.Name = "txtCelsiusFinal";
            txtCelsiusFinal.Size = new Size(100, 23);
            txtCelsiusFinal.TabIndex = 1;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(60, 120);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 52);
            btnOK.TabIndex = 2;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(265, 120);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 52);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lsbCelsius
            // 
            lsbCelsius.FormattingEnabled = true;
            lsbCelsius.ItemHeight = 15;
            lsbCelsius.Location = new Point(63, 191);
            lsbCelsius.Name = "lsbCelsius";
            lsbCelsius.Size = new Size(120, 184);
            lsbCelsius.TabIndex = 3;
            // 
            // lsbFahrenheit
            // 
            lsbFahrenheit.FormattingEnabled = true;
            lsbFahrenheit.ItemHeight = 15;
            lsbFahrenheit.Location = new Point(220, 191);
            lsbFahrenheit.Name = "lsbFahrenheit";
            lsbFahrenheit.Size = new Size(120, 184);
            lsbFahrenheit.TabIndex = 3;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(63, 381);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(277, 52);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(265, 439);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 52);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 497);
            ControlBox = false;
            Controls.Add(lsbFahrenheit);
            Controls.Add(lsbCelsius);
            Controls.Add(btnLimpiar);
            Controls.Add(btnSalir);
            Controls.Add(btnCancelar);
            Controls.Add(btnOK);
            Controls.Add(txtCelsiusFinal);
            Controls.Add(label2);
            Controls.Add(txtCelsiusInicial);
            Controls.Add(label1);
            MaximumSize = new Size(419, 536);
            MinimumSize = new Size(419, 536);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tabla de Conversion de Temperaturas";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCelsiusInicial;
        private Label label2;
        private TextBox txtCelsiusFinal;
        private Button btnOK;
        private Button btnCancelar;
        private ListBox lsbCelsius;
        private ListBox lsbFahrenheit;
        private Button btnLimpiar;
        private Button btnSalir;
        private ErrorProvider errorProvider1;
    }
}