namespace Hospital
{
    partial class EscogeAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EscogeAdministrador));
            groupBox1 = new GroupBox();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            labelingresaradministrativo = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.PaleGoldenrod;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(labelingresaradministrativo);
            groupBox1.Location = new Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1028, 560);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            label1.Location = new Point(385, 112);
            label1.Name = "label1";
            label1.Size = new Size(220, 37);
            label1.TabIndex = 9;
            label1.Text = "Administrador";
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(633, 279);
            button2.Name = "button2";
            button2.Size = new Size(168, 170);
            button2.TabIndex = 8;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(228, 279);
            button1.Name = "button1";
            button1.Size = new Size(168, 170);
            button1.TabIndex = 7;
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            label2.Location = new Point(675, 181);
            label2.Name = "label2";
            label2.Size = new Size(89, 37);
            label2.TabIndex = 6;
            label2.Text = "Citas";
            // 
            // labelingresaradministrativo
            // 
            labelingresaradministrativo.AutoSize = true;
            labelingresaradministrativo.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            labelingresaradministrativo.Location = new Point(228, 181);
            labelingresaradministrativo.Name = "labelingresaradministrativo";
            labelingresaradministrativo.Size = new Size(129, 37);
            labelingresaradministrativo.TabIndex = 5;
            labelingresaradministrativo.Text = "Agraga";
            // 
            // EscogeAdministrador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 559);
            Controls.Add(groupBox1);
            Name = "EscogeAdministrador";
            Text = "EscogeAdministrador";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button button2;
        private Button button1;
        private Label label2;
        private Label labelingresaradministrativo;
    }
}