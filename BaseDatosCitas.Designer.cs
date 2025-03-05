namespace Hospital
{
    partial class BaseDatosCitas
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
            groupBox1 = new GroupBox();
            label3 = new Label();
            groupBox2 = new GroupBox();
            dataGridView2 = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            labelModificar = new Label();
            labelbuscar = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gainsboro;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(labelbuscar);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(0, -2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1119, 588);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(515, 61);
            label3.Name = "label3";
            label3.Size = new Size(89, 37);
            label3.TabIndex = 9;
            label3.Text = "Citas";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.LightGray;
            groupBox2.Controls.Add(dataGridView2);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(labelModificar);
            groupBox2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(791, 115);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(325, 413);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(17, 236);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(277, 152);
            dataGridView2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(102, 201);
            label2.Name = "label2";
            label2.Size = new Size(103, 18);
            label2.TabIndex = 2;
            label2.Text = "Datos Doctor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 144);
            label1.Name = "label1";
            label1.Size = new Size(98, 18);
            label1.TabIndex = 1;
            label1.Text = "Eliminar cita";
            // 
            // labelModificar
            // 
            labelModificar.AutoSize = true;
            labelModificar.Location = new Point(6, 69);
            labelModificar.Name = "labelModificar";
            labelModificar.Size = new Size(79, 18);
            labelModificar.TabIndex = 0;
            labelModificar.Text = "Modificar";
            // 
            // labelbuscar
            // 
            labelbuscar.AutoSize = true;
            labelbuscar.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelbuscar.Location = new Point(11, 122);
            labelbuscar.Name = "labelbuscar";
            labelbuscar.Size = new Size(57, 18);
            labelbuscar.TabIndex = 7;
            labelbuscar.Text = "Buscar";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(89, 118);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(680, 27);
            textBox1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(2, 168);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(767, 360);
            dataGridView1.TabIndex = 5;
            // 
            // BaseDatosCitas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 590);
            Controls.Add(groupBox1);
            Name = "BaseDatosCitas";
            Text = "BaseDatosCitas";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private GroupBox groupBox2;
        private DataGridView dataGridView2;
        private Label label2;
        private Label label1;
        private Label labelModificar;
        private Label labelbuscar;
        private TextBox textBox1;
        private DataGridView dataGridView1;
    }
}