namespace Login_WindowsForms
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
            label1 = new Label();
            label2 = new Label();
            txt_Usuario = new TextBox();
            txt_Contraseña = new TextBox();
            Inicio_Sesion = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(162, 101);
            label1.Name = "label1";
            label1.Size = new Size(79, 28);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(162, 181);
            label2.Name = "label2";
            label2.Size = new Size(110, 28);
            label2.TabIndex = 1;
            label2.Text = "Contraseña";
            // 
            // txt_Usuario
            // 
            txt_Usuario.Location = new Point(298, 98);
            txt_Usuario.Name = "txt_Usuario";
            txt_Usuario.Size = new Size(231, 27);
            txt_Usuario.TabIndex = 2;
            // 
            // txt_Contraseña
            // 
            txt_Contraseña.Location = new Point(298, 181);
            txt_Contraseña.Name = "txt_Contraseña";
            txt_Contraseña.Size = new Size(231, 27);
            txt_Contraseña.TabIndex = 3;
            txt_Contraseña.UseSystemPasswordChar = true;
            // 
            // Inicio_Sesion
            // 
            Inicio_Sesion.Location = new Point(283, 276);
            Inicio_Sesion.Name = "Inicio_Sesion";
            Inicio_Sesion.Size = new Size(231, 41);
            Inicio_Sesion.TabIndex = 4;
            Inicio_Sesion.Text = "Ingresar";
            Inicio_Sesion.UseVisualStyleBackColor = true;
            Inicio_Sesion.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Inicio_Sesion);
            Controls.Add(txt_Contraseña);
            Controls.Add(txt_Usuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Inicio de Sesion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_Usuario;
        private TextBox txt_Contraseña;
        private Button Inicio_Sesion;
    }
}