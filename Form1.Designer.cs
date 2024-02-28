namespace Crud
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
            txtPrimer = new TextBox();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtSegundo = new TextBox();
            txtPaterno = new TextBox();
            txtMaterno = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtTelefonico = new TextBox();
            txtCorreo = new TextBox();
            txtCasa = new TextBox();
            txtDUEÑO = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            txtBuscar = new TextBox();
            Ventana = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)Ventana).BeginInit();
            SuspendLayout();
            // 
            // txtPrimer
            // 
            txtPrimer.Location = new Point(107, 1);
            txtPrimer.Name = "txtPrimer";
            txtPrimer.Size = new Size(201, 23);
            txtPrimer.TabIndex = 0;
            txtPrimer.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-2, 1);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 1;
            label1.Text = "Primer nombre";
            // 
            // button1
            // 
            button1.Location = new Point(2, 309);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(-4, 40);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 3;
            label2.Text = "Segundo nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(-2, 85);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 4;
            label3.Text = "Apellido paterno";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(2, 124);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 5;
            label4.Text = "Apellido materno";
            // 
            // txtSegundo
            // 
            txtSegundo.Location = new Point(107, 37);
            txtSegundo.Name = "txtSegundo";
            txtSegundo.Size = new Size(201, 23);
            txtSegundo.TabIndex = 6;
            // 
            // txtPaterno
            // 
            txtPaterno.Location = new Point(107, 82);
            txtPaterno.Name = "txtPaterno";
            txtPaterno.Size = new Size(201, 23);
            txtPaterno.TabIndex = 7;
            // 
            // txtMaterno
            // 
            txtMaterno.Location = new Point(107, 121);
            txtMaterno.Name = "txtMaterno";
            txtMaterno.Size = new Size(201, 23);
            txtMaterno.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(2, 160);
            label5.Name = "label5";
            label5.Size = new Size(107, 15);
            label5.TabIndex = 9;
            label5.Text = "Numero telefonico";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(2, 195);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 10;
            label6.Text = "Correo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(2, 231);
            label7.Name = "label7";
            label7.Size = new Size(93, 15);
            label7.TabIndex = 11;
            label7.Text = "Numero de casa";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(2, 264);
            label8.Name = "label8";
            label8.Size = new Size(84, 15);
            label8.TabIndex = 12;
            label8.Text = "Renta o dueño";
            // 
            // txtTelefonico
            // 
            txtTelefonico.Location = new Point(107, 160);
            txtTelefonico.Name = "txtTelefonico";
            txtTelefonico.Size = new Size(201, 23);
            txtTelefonico.TabIndex = 13;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(107, 195);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(201, 23);
            txtCorreo.TabIndex = 14;
            // 
            // txtCasa
            // 
            txtCasa.Location = new Point(107, 231);
            txtCasa.Name = "txtCasa";
            txtCasa.Size = new Size(201, 23);
            txtCasa.TabIndex = 15;
            // 
            // txtDUEÑO
            // 
            txtDUEÑO.Location = new Point(107, 260);
            txtDUEÑO.Name = "txtDUEÑO";
            txtDUEÑO.Size = new Size(201, 23);
            txtDUEÑO.TabIndex = 16;
            // 
            // button2
            // 
            button2.Location = new Point(107, 309);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 17;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(207, 309);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 18;
            button3.Text = "Editar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(326, 1);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 19;
            button4.Text = "Buscar";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(107, 364);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 20;
            button5.Text = "Salir";
            button5.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(420, 2);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(345, 23);
            txtBuscar.TabIndex = 21;
            // 
            // Ventana
            // 
            Ventana.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Ventana.Location = new Point(326, 70);
            Ventana.Name = "Ventana";
            Ventana.Size = new Size(462, 236);
            Ventana.TabIndex = 22;
            Ventana.CellContentClick += Ventana_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Ventana);
            Controls.Add(txtBuscar);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(txtDUEÑO);
            Controls.Add(txtCasa);
            Controls.Add(txtCorreo);
            Controls.Add(txtTelefonico);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtMaterno);
            Controls.Add(txtPaterno);
            Controls.Add(txtSegundo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(txtPrimer);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Ventana).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPrimer;
        private Label label1;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtSegundo;
        private TextBox txtPaterno;
        private TextBox txtMaterno;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtTelefonico;
        private TextBox txtCorreo;
        private TextBox txtCasa;
        private TextBox txtDUEÑO;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private TextBox txtBuscar;
        private DataGridView Ventana;
    }
}
