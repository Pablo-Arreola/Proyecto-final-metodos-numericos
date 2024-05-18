namespace Acceso
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            panel1 = new Panel();
            CERRAR2 = new Button();
            label1 = new Label();
            password1 = new TextBox();
            user1 = new TextBox();
            pictureBox2 = new PictureBox();
            Guardar = new Button();
            text1 = new TextBox();
            text2 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(CERRAR2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(301, 37);
            panel1.TabIndex = 0;
            // 
            // CERRAR2
            // 
            CERRAR2.FlatAppearance.BorderColor = Color.White;
            CERRAR2.FlatAppearance.BorderSize = 0;
            CERRAR2.FlatAppearance.MouseDownBackColor = Color.White;
            CERRAR2.FlatAppearance.MouseOverBackColor = Color.White;
            CERRAR2.FlatStyle = FlatStyle.Flat;
            CERRAR2.Font = new Font("Arial Narrow", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CERRAR2.Image = (Image)resources.GetObject("CERRAR2.Image");
            CERRAR2.Location = new Point(270, 0);
            CERRAR2.Name = "CERRAR2";
            CERRAR2.Size = new Size(31, 31);
            CERRAR2.TabIndex = 1;
            CERRAR2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(127, 117);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 1;
            label1.Click += label1_Click;
            // 
            // password1
            // 
            password1.BorderStyle = BorderStyle.None;
            password1.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password1.Location = new Point(52, 237);
            password1.Name = "password1";
            password1.Size = new Size(196, 21);
            password1.TabIndex = 3;
            password1.Text = "CONTRASEÑA";
            password1.TextAlign = HorizontalAlignment.Center;
            // 
            // user1
            // 
            user1.BorderStyle = BorderStyle.None;
            user1.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            user1.Location = new Point(52, 167);
            user1.Name = "user1";
            user1.Size = new Size(196, 21);
            user1.TabIndex = 4;
            user1.Text = " USUARIO";
            user1.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(93, 57);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(115, 86);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // Guardar
            // 
            Guardar.BackColor = Color.SteelBlue;
            Guardar.FlatAppearance.BorderColor = Color.IndianRed;
            Guardar.FlatAppearance.BorderSize = 0;
            Guardar.FlatAppearance.MouseDownBackColor = Color.IndianRed;
            Guardar.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            Guardar.FlatStyle = FlatStyle.Flat;
            Guardar.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Guardar.ForeColor = SystemColors.ButtonHighlight;
            Guardar.Location = new Point(93, 302);
            Guardar.Name = "Guardar";
            Guardar.Size = new Size(115, 28);
            Guardar.TabIndex = 6;
            Guardar.Text = "Guardar";
            Guardar.UseVisualStyleBackColor = false;
            // 
            // text1
            // 
            text1.BorderStyle = BorderStyle.FixedSingle;
            text1.Location = new Point(93, 194);
            text1.Name = "text1";
            text1.Size = new Size(115, 23);
            text1.TabIndex = 7;
            // 
            // text2
            // 
            text2.BorderStyle = BorderStyle.FixedSingle;
            text2.Location = new Point(93, 264);
            text2.Name = "text2";
            text2.Size = new Size(115, 23);
            text2.TabIndex = 8;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(301, 390);
            Controls.Add(text2);
            Controls.Add(text1);
            Controls.Add(Guardar);
            Controls.Add(pictureBox2);
            Controls.Add(password1);
            Controls.Add(user1);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Registro";
            Text = "Registro";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button CERRAR2;
        private Label label1;
        private TextBox password1;
        private TextBox user1;
        private PictureBox pictureBox2;
        private Button Guardar;
        private TextBox text1;
        private TextBox text2;
    }
}