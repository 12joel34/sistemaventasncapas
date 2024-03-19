namespace SistemasVentas.VISTA.PersonaVistas
{
    partial class PersonaEditarVista
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
            button2 = new Button();
            button1 = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(338, 323);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 13;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(68, 323);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 14;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(75, 239);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 8;
            label5.Text = "CORREO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(110, 197);
            label4.Name = "label4";
            label4.Size = new Size(18, 15);
            label4.TabIndex = 9;
            label4.Text = "CI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 155);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 10;
            label3.Text = "TELEFONO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 113);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 11;
            label2.Text = "APELLIDO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 71);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 12;
            label1.Text = "NOMBRE";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(171, 231);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(242, 23);
            textBox5.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(171, 189);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(242, 23);
            textBox4.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(171, 147);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(242, 23);
            textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(171, 105);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(242, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(171, 63);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(242, 23);
            textBox1.TabIndex = 7;
            // 
            // PersonaEditarVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 388);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "PersonaEditarVista";
            Text = "PersonaEditarVista";
            Load += PersonaEditarVista_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}