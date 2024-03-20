namespace SistemasVentas.VISTA.DetelleVentaVistas
{
    partial class DetalleVentaInsertarVista
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            label5 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(145, 164);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "CANTIDAD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(125, 218);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 1;
            label2.Text = "PRECIO VENTA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(147, 272);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 2;
            label3.Text = "SUB TOTAL";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(216, 159);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(179, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(216, 212);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(179, 23);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(216, 265);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(179, 23);
            textBox3.TabIndex = 3;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(99, 322);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(349, 325);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(80, 56);
            label4.Name = "label4";
            label4.Size = new Size(130, 15);
            label4.TabIndex = 6;
            label4.Text = "VENTA SELECCIONADA";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 110);
            label5.Name = "label5";
            label5.Size = new Size(157, 15);
            label5.TabIndex = 6;
            label5.Text = "PRODUCTO SELECCIONADO";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(216, 53);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(146, 23);
            textBox4.TabIndex = 7;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(216, 106);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(146, 23);
            textBox5.TabIndex = 8;
            // 
            // button3
            // 
            button3.Location = new Point(368, 52);
            button3.Name = "button3";
            button3.Size = new Size(148, 23);
            button3.TabIndex = 9;
            button3.Text = "SELECCIONA VENTA";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(368, 105);
            button4.Name = "button4";
            button4.Size = new Size(148, 23);
            button4.TabIndex = 10;
            button4.Text = "SELECCIONA PRODUCTO";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // DetalleVentaInsertarVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 398);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DetalleVentaInsertarVista";
            Text = "DetalleVentaInsertarVista";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private Label label4;
        private Label label5;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button3;
        private Button button4;
    }
}