namespace Calculadoraa.Formularios
{
    partial class frmCalculadora
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
            txtVariableA = new TextBox();
            txtVariableB = new TextBox();
            btnCalcular = new Button();
            btnReset = new Button();
            rdbDivision = new RadioButton();
            rdbMultiplicacion = new RadioButton();
            rdbSuma = new RadioButton();
            rdbResta = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 26);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 0;
            label1.Text = "Variable A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 223);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 1;
            label2.Text = "Variable B";
            // 
            // txtVariableA
            // 
            txtVariableA.Location = new Point(39, 112);
            txtVariableA.Name = "txtVariableA";
            txtVariableA.Size = new Size(125, 27);
            txtVariableA.TabIndex = 2;
            // 
            // txtVariableB
            // 
            txtVariableB.Location = new Point(39, 323);
            txtVariableB.Name = "txtVariableB";
            txtVariableB.Size = new Size(125, 27);
            txtVariableB.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(258, 270);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += button1_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(258, 321);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 5;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click_1;
            // 
            // rdbDivision
            // 
            rdbDivision.AutoSize = true;
            rdbDivision.Location = new Point(67, 26);
            rdbDivision.Name = "rdbDivision";
            rdbDivision.Size = new Size(83, 24);
            rdbDivision.TabIndex = 6;
            rdbDivision.TabStop = true;
            rdbDivision.Text = "Division";
            rdbDivision.UseVisualStyleBackColor = true;
            // 
            // rdbMultiplicacion
            // 
            rdbMultiplicacion.AutoSize = true;
            rdbMultiplicacion.Location = new Point(67, 65);
            rdbMultiplicacion.Name = "rdbMultiplicacion";
            rdbMultiplicacion.Size = new Size(124, 24);
            rdbMultiplicacion.TabIndex = 7;
            rdbMultiplicacion.TabStop = true;
            rdbMultiplicacion.Text = "Multiplicacion";
            rdbMultiplicacion.UseVisualStyleBackColor = true;
            // 
            // rdbSuma
            // 
            rdbSuma.AutoSize = true;
            rdbSuma.Location = new Point(67, 105);
            rdbSuma.Name = "rdbSuma";
            rdbSuma.Size = new Size(67, 24);
            rdbSuma.TabIndex = 8;
            rdbSuma.TabStop = true;
            rdbSuma.Text = "Suma";
            rdbSuma.UseVisualStyleBackColor = true;
            // 
            // rdbResta
            // 
            rdbResta.AutoSize = true;
            rdbResta.Location = new Point(67, 148);
            rdbResta.Name = "rdbResta";
            rdbResta.Size = new Size(66, 24);
            rdbResta.TabIndex = 9;
            rdbResta.TabStop = true;
            rdbResta.Text = "Resta";
            rdbResta.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveBorder;
            groupBox1.Controls.Add(rdbSuma);
            groupBox1.Controls.Add(rdbResta);
            groupBox1.Controls.Add(rdbMultiplicacion);
            groupBox1.Controls.Add(rdbDivision);
            groupBox1.Location = new Point(188, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 187);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Operaciones";
            // 
            // frmCalculadora
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 450);
            Controls.Add(btnReset);
            Controls.Add(btnCalcular);
            Controls.Add(txtVariableB);
            Controls.Add(txtVariableA);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "frmCalculadora";
            Text = "frmCalculadora";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtVariableA;
        private TextBox txtVariableB;
        private Button btnCalcular;
        private Button btnReset;
        private RadioButton rdbDivision;
        private RadioButton rdbMultiplicacion;
        private RadioButton rdbSuma;
        private RadioButton rdbResta;
        private GroupBox groupBox1;
    }
}