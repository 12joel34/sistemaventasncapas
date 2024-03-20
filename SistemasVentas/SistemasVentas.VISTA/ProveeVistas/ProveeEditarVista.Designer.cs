namespace SistemasVentas.VISTA.ProveeVistas
{
    partial class ProveeEditarVista
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
            button4 = new Button();
            button3 = new Button();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button2 = new Button();
            button1 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(366, 122);
            button4.Name = "button4";
            button4.Size = new Size(180, 23);
            button4.TabIndex = 23;
            button4.Text = "SELECCIONA PROVEEDOR";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(366, 71);
            button3.Name = "button3";
            button3.Size = new Size(180, 23);
            button3.TabIndex = 22;
            button3.Text = "SELECCIONA PRODUCTO";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(189, 122);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(161, 23);
            textBox3.TabIndex = 21;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(189, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(161, 23);
            textBox1.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 123);
            label4.Name = "label4";
            label4.Size = new Size(162, 15);
            label4.TabIndex = 19;
            label4.Text = "PROVEEDOR SELECCIONADO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 71);
            label3.Name = "label3";
            label3.Size = new Size(156, 15);
            label3.TabIndex = 18;
            label3.Text = "PRODUCTO SELECCIONADA";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(189, 173);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(268, 23);
            dateTimePicker1.TabIndex = 17;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(325, 287);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 16;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(122, 287);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 15;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(189, 224);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(161, 23);
            textBox2.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(136, 227);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 13;
            label2.Text = "PRECIO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(139, 175);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 12;
            label1.Text = "FECHA";
            // 
            // ProveeEditarVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 376);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ProveeEditarVista";
            Text = "ProveeEditarVista";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Button button3;
        private TextBox textBox3;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Button button2;
        private Button button1;
        private TextBox textBox2;
        private Label label2;
        private Label label1;
    }
}