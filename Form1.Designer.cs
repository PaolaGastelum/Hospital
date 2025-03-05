namespace Hospital
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            labelPaciente = new Label();
            labeladministrativo = new Label();
            btnPaciente = new Button();
            btnAdministrativo = new Button();
            titulo = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Purple;
            groupBox1.Controls.Add(labelPaciente);
            groupBox1.Controls.Add(labeladministrativo);
            groupBox1.Controls.Add(btnPaciente);
            groupBox1.Controls.Add(btnAdministrativo);
            groupBox1.Controls.Add(titulo);
            groupBox1.Location = new Point(2, -19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(799, 494);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // labelPaciente
            // 
            labelPaciente.AutoSize = true;
            labelPaciente.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            labelPaciente.ForeColor = Color.White;
            labelPaciente.Location = new Point(581, 236);
            labelPaciente.Name = "labelPaciente";
            labelPaciente.Size = new Size(96, 23);
            labelPaciente.TabIndex = 9;
            labelPaciente.Text = "Paciente";
            // 
            // labeladministrativo
            // 
            labeladministrativo.AutoSize = true;
            labeladministrativo.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labeladministrativo.ForeColor = Color.White;
            labeladministrativo.Location = new Point(107, 236);
            labeladministrativo.Name = "labeladministrativo";
            labeladministrativo.Size = new Size(148, 23);
            labeladministrativo.TabIndex = 8;
            labeladministrativo.Text = "Administrativo";
            // 
            // btnPaciente
            // 
            btnPaciente.Image = (Image)resources.GetObject("btnPaciente.Image");
            btnPaciente.Location = new Point(581, 278);
            btnPaciente.Name = "btnPaciente";
            btnPaciente.Size = new Size(110, 95);
            btnPaciente.TabIndex = 7;
            btnPaciente.UseVisualStyleBackColor = true;
            // 
            // btnAdministrativo
            // 
            btnAdministrativo.Image = (Image)resources.GetObject("btnAdministrativo.Image");
            btnAdministrativo.Location = new Point(124, 278);
            btnAdministrativo.Name = "btnAdministrativo";
            btnAdministrativo.Size = new Size(106, 95);
            btnAdministrativo.TabIndex = 6;
            btnAdministrativo.UseVisualStyleBackColor = true;
            // 
            // titulo
            // 
            titulo.AutoSize = true;
            titulo.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold);
            titulo.ForeColor = Color.White;
            titulo.Location = new Point(362, 106);
            titulo.Name = "titulo";
            titulo.Size = new Size(104, 34);
            titulo.TabIndex = 5;
            titulo.Text = "LOGIN";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 474);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label labelPaciente;
        private Label labeladministrativo;
        private Button btnPaciente;
        private Button btnAdministrativo;
        private Label titulo;
    }
}
