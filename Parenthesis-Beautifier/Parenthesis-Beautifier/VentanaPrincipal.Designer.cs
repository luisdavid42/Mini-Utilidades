namespace Parenthesis_Beautifier
{
    partial class VentanaPrincipal
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
            tbOriginal = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tbResultado = new TextBox();
            tablaResultado = new DataGridView();
            colProfundidad = new DataGridViewTextBoxColumn();
            colLiteral = new DataGridViewTextBoxColumn();
            arbolLiterales = new TreeView();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            ((System.ComponentModel.ISupportInitialize)tablaResultado).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tbOriginal
            // 
            tbOriginal.AcceptsTab = true;
            tbOriginal.Location = new Point(16, 53);
            tbOriginal.Multiline = true;
            tbOriginal.Name = "tbOriginal";
            tbOriginal.Size = new Size(158, 263);
            tbOriginal.TabIndex = 4;
            tbOriginal.TextChanged += tbOriginal_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 23);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 2;
            label1.Text = "Original";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(317, 23);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 4;
            label2.Text = "Resultado";
            // 
            // tbResultado
            // 
            tbResultado.AllowDrop = true;
            tbResultado.Location = new Point(24, 20);
            tbResultado.Multiline = true;
            tbResultado.Name = "tbResultado";
            tbResultado.Size = new Size(265, 201);
            tbResultado.TabIndex = 3;
            // 
            // tablaResultado
            // 
            tablaResultado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaResultado.Columns.AddRange(new DataGridViewColumn[] { colProfundidad, colLiteral });
            tablaResultado.Location = new Point(25, 15);
            tablaResultado.Name = "tablaResultado";
            tablaResultado.Size = new Size(273, 208);
            tablaResultado.TabIndex = 5;
            // 
            // colProfundidad
            // 
            colProfundidad.HeaderText = "P";
            colProfundidad.Name = "colProfundidad";
            colProfundidad.ReadOnly = true;
            colProfundidad.Width = 30;
            // 
            // colLiteral
            // 
            colLiteral.HeaderText = "Literal";
            colLiteral.Name = "colLiteral";
            colLiteral.ReadOnly = true;
            colLiteral.Width = 200;
            // 
            // arbolLiterales
            // 
            arbolLiterales.Location = new Point(18, 25);
            arbolLiterales.Name = "arbolLiterales";
            arbolLiterales.Size = new Size(147, 197);
            arbolLiterales.TabIndex = 6;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(207, 53);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(327, 267);
            tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tablaResultado);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(319, 239);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Tabla";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(arbolLiterales);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(319, 239);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Arbol";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(tbResultado);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(319, 239);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Texto";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // VentanaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 350);
            Controls.Add(tabControl1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbOriginal);
            Name = "VentanaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Parenthesis Beautifier";
            Load += VentanaPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)tablaResultado).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbOriginal;
        private Label label1;
        private Label label2;
        private TextBox tbResultado;
        private DataGridView tablaResultado;
        private DataGridViewTextBoxColumn colProfundidad;
        private DataGridViewTextBoxColumn colLiteral;
        private TreeView arbolLiterales;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
    }
}
