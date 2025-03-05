namespace Hospital
{
    partial class LoginPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPaciente));
            groupBox1 = new GroupBox();
            btnIniciar = new Button();
            textBoxContraseña = new TextBox();
            textBoxFolio = new TextBox();
            labelContraseña = new Label();
            labelFolio = new Label();
            titulo = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.RosyBrown;
            groupBox1.Controls.Add(btnIniciar);
            groupBox1.Controls.Add(textBoxContraseña);
            groupBox1.Controls.Add(textBoxFolio);
            groupBox1.Controls.Add(labelContraseña);
            groupBox1.Controls.Add(labelFolio);
            groupBox1.Controls.Add(titulo);
            groupBox1.Location = new Point(-1, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(803, 453);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnIniciar
            // 
            btnIniciar.FlatAppearance.BorderSize = 0;
            btnIniciar.FlatStyle = FlatStyle.Flat;
            btnIniciar.Image = (Image)resources.GetObject("btnIniciar.Image");
            btnIniciar.Location = new Point(405, 292);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(131, 90);
            btnIniciar.TabIndex = 11;
            btnIniciar.UseVisualStyleBackColor = true;
            // 
            // textBoxContraseña
            // 
            textBoxContraseña.BackColor = Color.RosyBrown;
            textBoxContraseña.Location = new Point(326, 236);
            textBoxContraseña.Name = "textBoxContraseña";
            textBoxContraseña.Size = new Size(318, 27);
            textBoxContraseña.TabIndex = 10;
            // 
            // textBoxFolio
            // 
            textBoxFolio.BackColor = Color.RosyBrown;
            textBoxFolio.Location = new Point(326, 162);
            textBoxFolio.Name = "textBoxFolio";
            textBoxFolio.Size = new Size(318, 27);
            textBoxFolio.TabIndex = 9;
            // 
            // labelContraseña
            // 
            labelContraseña.AutoSize = true;
            labelContraseña.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            labelContraseña.Location = new Point(159, 226);
            labelContraseña.Name = "labelContraseña";
            labelContraseña.Size = new Size(123, 23);
            labelContraseña.TabIndex = 8;
            labelContraseña.Text = "Contraseña";
            // 
            // labelFolio
            // 
            labelFolio.AutoSize = true;
            labelFolio.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            labelFolio.Location = new Point(159, 162);
            labelFolio.Name = "labelFolio";
            labelFolio.Size = new Size(56, 23);
            labelFolio.TabIndex = 7;
            labelFolio.Text = "Folio";
            // 
            // titulo
            // 
            titulo.AutoSize = true;
            titulo.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titulo.ForeColor = Color.Black;
            titulo.Location = new Point(369, 71);
            titulo.Name = "titulo";
            titulo.Size = new Size(215, 34);
            titulo.TabIndex = 6;
            titulo.Text = "Login Paciente";
            // 
            // LoginPaciente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "LoginPaciente";
            Text = "LoginPaciente";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnIniciar;
        private TextBox textBoxContraseña;
        private TextBox textBoxFolio;
        private Label labelContraseña;
        private Label labelFolio;
        private Label titulo;
    }
}