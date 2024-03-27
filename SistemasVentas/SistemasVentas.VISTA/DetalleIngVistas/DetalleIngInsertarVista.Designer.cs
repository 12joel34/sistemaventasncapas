namespace SistemasVentas.VISTA.DetalleIngVistas
{
    partial class DetalleIngInsertarVista
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
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 127);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 0;
            label1.Text = "FECHA VENCIMIENTO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 167);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 0;
            label2.Text = "CANTIDAD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(85, 207);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 0;
            label3.Text = "PRECIO COSTO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(87, 247);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 0;
            label4.Text = "PRECIO VENTA";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(109, 287);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 0;
            label5.Text = "SUB TOTAL";
            // 
            // button1
            // 
            button1.Location = new Point(123, 340);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(334, 340);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(212, 121);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(233, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(212, 159);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(233, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(212, 204);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(233, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(212, 239);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(233, 23);
            textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(212, 279);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(233, 23);
            textBox4.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 86);
            label6.Name = "label6";
            label6.Size = new Size(144, 15);
            label6.TabIndex = 6;
            label6.Text = "INGRESO SELECCIONADO";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 47);
            label7.Name = "label7";
            label7.Size = new Size(157, 15);
            label7.TabIndex = 7;
            label7.Text = "PRODUCTO SELECCIONADO";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(212, 39);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(129, 23);
            textBox5.TabIndex = 8;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(212, 78);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(129, 23);
            textBox6.TabIndex = 9;
            // 
            // button3
            // 
            button3.Location = new Point(347, 78);
            button3.Name = "button3";
            button3.Size = new Size(162, 23);
            button3.TabIndex = 10;
            button3.Text = "SELECCIONAR INGRESO";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(347, 39);
            button4.Name = "button4";
            button4.Size = new Size(162, 23);
            button4.TabIndex = 11;
            button4.Text = "SELECCIONAR PRODUCTO";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // DetalleIngInsertarVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 395);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "DetalleIngInsertarVista";
            Text = "DetalleIngInsertarVista";
            Load += DetalleIngInsertarVista_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button button2;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label6;
        private Label label7;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button button3;
        private Button button4;
    }
}