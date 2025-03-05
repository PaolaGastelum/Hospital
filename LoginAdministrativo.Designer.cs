namespace Hospital
{
    partial class LoginAdministrativo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginAdministrativo));
            groupBox1 = new GroupBox();
            btnEntrar = new Button();
            textBoxContraseña = new TextBox();
            textBoxFolio = new TextBox();
            labelContraseña = new Label();
            labelUsuario = new Label();
            titulo = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.PaleGoldenrod;
            groupBox1.Controls.Add(btnEntrar);
            groupBox1.Controls.Add(textBoxContraseña);
            groupBox1.Controls.Add(textBoxFolio);
            groupBox1.Controls.Add(labelContraseña);
            groupBox1.Controls.Add(labelUsuario);
            groupBox1.Controls.Add(titulo);
            groupBox1.Location = new Point(2, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(876, 508);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnEntrar
            // 
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Image = (Image)resources.GetObject("btnEntrar.Image");
            btnEntrar.Location = new Point(372, 330);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(174, 100);
            btnEntrar.TabIndex = 17;
            btnEntrar.UseVisualStyleBackColor = true;
            // 
            // textBoxContraseña
            // 
            textBoxContraseña.BackColor = Color.PaleGoldenrod;
            textBoxContraseña.Font = new Font("Century Gothic", 9F);
            textBoxContraseña.Location = new Point(361, 253);
            textBoxContraseña.Name = "textBoxContraseña";
            textBoxContraseña.Size = new Size(318, 26);
            textBoxContraseña.TabIndex = 16;
            // 
            // textBoxFolio
            // 
            textBoxFolio.BackColor = Color.PaleGoldenrod;
            textBoxFolio.Font = new Font("Century Gothic", 9F);
            textBoxFolio.Location = new Point(361, 165);
            textBoxFolio.Name = "textBoxFolio";
            textBoxFolio.Size = new Size(318, 26);
            textBoxFolio.TabIndex = 15;
            // 
            // labelContraseña
            // 
            labelContraseña.AutoSize = true;
            labelContraseña.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            labelContraseña.Location = new Point(197, 253);
            labelContraseña.Name = "labelContraseña";
            labelContraseña.Size = new Size(123, 23);
            labelContraseña.TabIndex = 14;
            labelContraseña.Text = "Contraseña";
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            labelUsuario.Location = new Point(197, 168);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(81, 23);
            labelUsuario.TabIndex = 13;
            labelUsuario.Text = "Usuario";
            // 
            // titulo
            // 
            titulo.AutoSize = true;
            titulo.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titulo.Location = new Point(324, 79);
            titulo.Name = "titulo";
            titulo.Size = new Size(272, 32);
            titulo.TabIndex = 12;
            titulo.Text = "Login Administrativo";
            // 
            // LoginAdministrativo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 508);
            Controls.Add(groupBox1);
            Name = "LoginAdministrativo";
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnEntrar;
        private TextBox textBoxContraseña;
        private TextBox textBoxFolio;
        private Label labelContraseña;
        private Label labelUsuario;
        private Label titulo;
    }
}