namespace Hospital
{
    partial class EscogePaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EscogePaciente));
            groupBox1 = new GroupBox();
            label2 = new Label();
            btnAgregar = new Button();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.RosyBrown;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(5, -1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(501, 306);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(173, 149);
            label2.Name = "label2";
            label2.Size = new Size(156, 27);
            label2.TabIndex = 8;
            label2.Text = "Registrar cita";
            // 
            // btnAgregar
            // 
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Image = (Image)resources.GetObject("btnAgregar.Image");
            btnAgregar.Location = new Point(197, 204);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(117, 78);
            btnAgregar.TabIndex = 7;
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            label1.Location = new Point(184, 28);
            label1.Name = "label1";
            label1.Size = new Size(145, 37);
            label1.TabIndex = 6;
            label1.Text = "Paciente";
            // 
            // EscogePaciente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 301);
            Controls.Add(groupBox1);
            Name = "EscogePaciente";
            Text = "EscogePaciente";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Button btnAgregar;
        private Label label1;
    }
}