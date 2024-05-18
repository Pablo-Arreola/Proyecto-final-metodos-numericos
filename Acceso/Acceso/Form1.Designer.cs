namespace Acceso
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
            panel1 = new Panel();
            CERRAR = new Button();
            pictureBox1 = new PictureBox();
            user = new TextBox();
            password = new TextBox();
            Muestra = new CheckBox();
            entrar = new Button();
            label1 = new Label();
            button1 = new Button();
            text3 = new TextBox();
            text4 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(CERRAR);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(312, 34);
            panel1.TabIndex = 0;
            // 
            // CERRAR
            // 
            CERRAR.FlatAppearance.BorderColor = Color.White;
            CERRAR.FlatAppearance.BorderSize = 0;
            CERRAR.FlatAppearance.MouseDownBackColor = Color.White;
            CERRAR.FlatAppearance.MouseOverBackColor = Color.White;
            CERRAR.FlatStyle = FlatStyle.Flat;
            CERRAR.Font = new Font("Arial Narrow", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CERRAR.Image = (Image)resources.GetObject("CERRAR.Image");
            CERRAR.Location = new Point(278, 0);
            CERRAR.Name = "CERRAR";
            CERRAR.Size = new Size(31, 31);
            CERRAR.TabIndex = 0;
            CERRAR.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(95, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(115, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // user
            // 
            user.BorderStyle = BorderStyle.None;
            user.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            user.Location = new Point(61, 146);
            user.Name = "user";
            user.Size = new Size(196, 21);
            user.TabIndex = 2;
            user.Text = "INGRESE SU USUARIO";
            user.TextAlign = HorizontalAlignment.Center;
            // 
            // password
            // 
            password.BorderStyle = BorderStyle.None;
            password.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password.Location = new Point(61, 237);
            password.Name = "password";
            password.Size = new Size(196, 21);
            password.TabIndex = 2;
            password.Text = "INGRESE SU CONTRASEÑA";
            password.TextAlign = HorizontalAlignment.Center;
            // 
            // Muestra
            // 
            Muestra.AutoSize = true;
            Muestra.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Muestra.Location = new Point(216, 267);
            Muestra.Name = "Muestra";
            Muestra.Size = new Size(69, 20);
            Muestra.TabIndex = 3;
            Muestra.Text = "Mostrar";
            Muestra.UseVisualStyleBackColor = true;
            // 
            // entrar
            // 
            entrar.BackColor = Color.SteelBlue;
            entrar.FlatAppearance.BorderColor = Color.IndianRed;
            entrar.FlatAppearance.BorderSize = 0;
            entrar.FlatAppearance.MouseDownBackColor = Color.IndianRed;
            entrar.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            entrar.FlatStyle = FlatStyle.Flat;
            entrar.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            entrar.Location = new Point(95, 333);
            entrar.Name = "entrar";
            entrar.Size = new Size(115, 28);
            entrar.TabIndex = 4;
            entrar.Text = "Entrar";
            entrar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(61, 378);
            label1.Name = "label1";
            label1.Size = new Size(171, 19);
            label1.TabIndex = 5;
            label1.Text = "¿No estas registrado?";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.SteelBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            button1.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.CornflowerBlue;
            button1.Location = new Point(95, 400);
            button1.Name = "button1";
            button1.Size = new Size(100, 28);
            button1.TabIndex = 6;
            button1.Text = "Registrarme";
            button1.UseVisualStyleBackColor = true;
            // 
            // text3
            // 
            text3.BorderStyle = BorderStyle.FixedSingle;
            text3.Location = new Point(95, 173);
            text3.Name = "text3";
            text3.Size = new Size(115, 23);
            text3.TabIndex = 8;
            text3.TextAlign = HorizontalAlignment.Center;
            // 
            // text4
            // 
            text4.BorderStyle = BorderStyle.FixedSingle;
            text4.Location = new Point(95, 264);
            text4.Name = "text4";
            text4.Size = new Size(115, 23);
            text4.TabIndex = 9;
            text4.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(312, 450);
            Controls.Add(text4);
            Controls.Add(text3);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(entrar);
            Controls.Add(Muestra);
            Controls.Add(password);
            Controls.Add(user);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button CERRAR;
        private PictureBox pictureBox1;
        private TextBox user;
        private TextBox password;
        private CheckBox Muestra;
        private Button entrar;
        private Label label1;
        private Button button1;
        private TextBox text3;
        private TextBox text4;
    }
}
