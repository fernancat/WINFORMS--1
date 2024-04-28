namespace calculadoraGalonesVehiculo
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
            label1 = new Label();
            calcular = new Button();
            barraProgreso = new ProgressBar();
            DISTANCIA = new TextBox();
            RENDIMIENTO = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Bisque;
            label1.Font = new Font("Ebrima", 20F);
            label1.Location = new Point(185, 54);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(459, 46);
            label1.TabIndex = 0;
            label1.Text = "CALCULADORA DE GALONES";
            label1.Click += label1_Click;
            // 
            // calcular
            // 
            calcular.BackColor = Color.FloralWhite;
            calcular.Location = new Point(328, 388);
            calcular.Margin = new Padding(2);
            calcular.Name = "calcular";
            calcular.Size = new Size(90, 27);
            calcular.TabIndex = 1;
            calcular.Text = "CALCULAR GALONES";
            calcular.UseVisualStyleBackColor = false;
            calcular.Click += button1_Click;
            // 
            // barraProgreso
            // 
            barraProgreso.Location = new Point(313, 282);
            barraProgreso.Margin = new Padding(2);
            barraProgreso.Name = "barraProgreso";
            barraProgreso.Size = new Size(120, 27);
            barraProgreso.TabIndex = 2;
            barraProgreso.Visible = false;
            barraProgreso.Click += barraProgreso_Click;
            // 
            // DISTANCIA
            // 
            DISTANCIA.Location = new Point(313, 163);
            DISTANCIA.Margin = new Padding(2);
            DISTANCIA.Name = "DISTANCIA";
            DISTANCIA.Size = new Size(121, 27);
            DISTANCIA.TabIndex = 3;
            // 
            // RENDIMIENTO
            // 
            RENDIMIENTO.Location = new Point(313, 219);
            RENDIMIENTO.Margin = new Padding(2);
            RENDIMIENTO.Name = "RENDIMIENTO";
            RENDIMIENTO.Size = new Size(121, 27);
            RENDIMIENTO.TabIndex = 4;
            RENDIMIENTO.TextChanged += RENDIMIENTO_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(339, 326);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 5;
            label2.Text = "OUTPUT";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(936, 546);
            Controls.Add(label2);
            Controls.Add(RENDIMIENTO);
            Controls.Add(DISTANCIA);
            Controls.Add(barraProgreso);
            Controls.Add(calcular);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button calcular;
        private ProgressBar barraProgreso;
        private TextBox DISTANCIA;
        private TextBox RENDIMIENTO;
        private Label label2;
    }
}
