namespace frmExamen
{
    partial class frmCambios
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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label8 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            textBox6 = new TextBox();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(174, 181);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 72;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(93, 183);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 71;
            button2.Text = "Baja";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 181);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 70;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(354, 119);
            label8.Name = "label8";
            label8.Size = new Size(96, 15);
            label8.TabIndex = 68;
            label8.Text = "Fecha de Ingreso";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(188, 119);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 66;
            label6.Text = "Cantidad";
            label6.TextAlign = ContentAlignment.TopRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 118);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 64;
            label4.Text = "precio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(185, 52);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 63;
            label3.Text = "Descripcion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 62;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 61;
            label1.Text = "Id";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(183, 142);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 60;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 145);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 59;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(183, 78);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(371, 23);
            textBox3.TabIndex = 58;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 78);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 57;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(12, 26);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 56;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(346, 143);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 73;
            // 
            // frmCambios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "frmCambios";
            Text = "frmCambios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label8;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox6;
    }
}