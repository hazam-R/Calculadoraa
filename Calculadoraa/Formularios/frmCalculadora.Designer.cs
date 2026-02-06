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
            // textBox1
            // 
            txtVariableA.Location = new Point(39, 112);
            txtVariableA.Name = "textBox1";
            txtVariableA.Size = new Size(125, 27);
            txtVariableA.TabIndex = 2;
            // 
            // textBox2
            // 
            txtVariableB.Location = new Point(39, 323);
            txtVariableB.Name = "textBox2";
            txtVariableB.Size = new Size(125, 27);
            txtVariableB.TabIndex = 3;
            // 
            // button1
            // 
            btnCalcular.Location = new Point(558, 104);
            btnCalcular.Name = "button1";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += button1_Click;
            // 
            // frmCalculadora
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalcular);
            Controls.Add(txtVariableB);
            Controls.Add(txtVariableA);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmCalculadora";
            Text = "frmCalculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtVariableA;
        private TextBox txtVariableB;
        private Button btnCalcular;
    }
}