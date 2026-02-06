namespace Calculadoraa.Formularios
{
    partial class frmBurbuja
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
            dgvDesordenado = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            dgvOrdenado = new DataGridView();
            DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            btnOrdenar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDesordenado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrdenado).BeginInit();
            SuspendLayout();
            // 
            // dgvDesordenado
            // 
            dgvDesordenado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDesordenado.Columns.AddRange(new DataGridViewColumn[] { Column1 });
            dgvDesordenado.Location = new Point(12, 28);
            dgvDesordenado.Name = "dgvDesordenado";
            dgvDesordenado.RowHeadersWidth = 51;
            dgvDesordenado.Size = new Size(167, 392);
            dgvDesordenado.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Desordenado";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // dgvOrdenado
            // 
            dgvOrdenado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrdenado.Columns.AddRange(new DataGridViewColumn[] { DataGridViewTextBoxColumn1 });
            dgvOrdenado.Location = new Point(429, 28);
            dgvOrdenado.Name = "dgvOrdenado";
            dgvOrdenado.RowHeadersWidth = 51;
            dgvOrdenado.Size = new Size(174, 392);
            dgvOrdenado.TabIndex = 1;
            // 
            // DataGridViewTextBoxColumn1
            // 
            DataGridViewTextBoxColumn1.HeaderText = "Ordenado";
            DataGridViewTextBoxColumn1.MinimumWidth = 6;
            DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
            DataGridViewTextBoxColumn1.Width = 125;
            // 
            // btnOrdenar
            // 
            btnOrdenar.Location = new Point(256, 165);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(94, 29);
            btnOrdenar.TabIndex = 2;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // frmBurbuja
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 450);
            Controls.Add(btnOrdenar);
            Controls.Add(dgvOrdenado);
            Controls.Add(dgvDesordenado);
            Name = "frmBurbuja";
            Text = "frmBurbuja";
            ((System.ComponentModel.ISupportInitialize)dgvDesordenado).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrdenado).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDesordenado;
        private DataGridViewTextBoxColumn Column1;
        private DataGridView dgvOrdenado;
        private Button btnOrdenar;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
    }
}