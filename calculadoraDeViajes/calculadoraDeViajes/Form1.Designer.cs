namespace calculadoraDeViajes
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
            puntoDestino = new TextBox();
            velocidadConstante = new TextBox();
            calcular = new Button();
            label2 = new Label();
            puntoOrigen = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(285, 58);
            label1.Name = "label1";
            label1.Size = new Size(183, 20);
            label1.TabIndex = 0;
            label1.Text = "CALCULADORA DE VIAJES";
            // 
            // puntoDestino
            // 
            puntoDestino.Location = new Point(312, 123);
            puntoDestino.Name = "puntoDestino";
            puntoDestino.Size = new Size(125, 27);
            puntoDestino.TabIndex = 1;
            // 
            // velocidadConstante
            // 
            velocidadConstante.Location = new Point(312, 156);
            velocidadConstante.Name = "velocidadConstante";
            velocidadConstante.Size = new Size(125, 27);
            velocidadConstante.TabIndex = 4;
            // 
            // calcular
            // 
            calcular.Location = new Point(312, 291);
            calcular.Name = "calcular";
            calcular.Size = new Size(94, 29);
            calcular.TabIndex = 5;
            calcular.Text = "Calcular";
            calcular.UseVisualStyleBackColor = true;
            calcular.Click += calcular_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(326, 221);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 6;
            label2.Text = "OUTPUT";
            // 
            // puntoOrigen
            // 
            puntoOrigen.Location = new Point(312, 90);
            puntoOrigen.Name = "puntoOrigen";
            puntoOrigen.Size = new Size(125, 27);
            puntoOrigen.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(puntoOrigen);
            Controls.Add(label2);
            Controls.Add(calcular);
            Controls.Add(velocidadConstante);
            Controls.Add(puntoDestino);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox puntoDestino;
        private TextBox velocidadConstante;
        private Button calcular;
        private Label label2;
        private TextBox puntoOrigen;
    }
}
