namespace HerenciayPolimorfismo
{
    partial class MainForm
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
            this.menuPanel = new System.Windows.Forms.Panel();
            this.buttonServicio = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonProfesor = new System.Windows.Forms.Button();
            this.buttonEstudiante = new System.Windows.Forms.Button();
            this.buttonEmpleado = new System.Windows.Forms.Button();
            this.buttonAdminitrativo = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.SystemColors.Window;
            this.menuPanel.Controls.Add(this.buttonServicio);
            this.menuPanel.Controls.Add(this.pictureBox1);
            this.menuPanel.Controls.Add(this.buttonProfesor);
            this.menuPanel.Controls.Add(this.buttonEstudiante);
            this.menuPanel.Controls.Add(this.buttonEmpleado);
            this.menuPanel.Controls.Add(this.buttonAdminitrativo);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(10, 10);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(211, 430);
            this.menuPanel.TabIndex = 0;
            // 
            // buttonServicio
            // 
            this.buttonServicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonServicio.AutoSize = true;
            this.buttonServicio.BackColor = System.Drawing.SystemColors.Window;
            this.buttonServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonServicio.Location = new System.Drawing.Point(3, 270);
            this.buttonServicio.Margin = new System.Windows.Forms.Padding(10);
            this.buttonServicio.Name = "buttonServicio";
            this.buttonServicio.Size = new System.Drawing.Size(205, 27);
            this.buttonServicio.TabIndex = 5;
            this.buttonServicio.Text = "Servicio";
            this.buttonServicio.UseVisualStyleBackColor = false;
            this.buttonServicio.Click += new System.EventHandler(this.ButtonServicio_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Image = global::HerenciayPolimorfismo.Properties.Resources.download;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // buttonProfesor
            // 
            this.buttonProfesor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProfesor.AutoSize = true;
            this.buttonProfesor.BackColor = System.Drawing.SystemColors.Window;
            this.buttonProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProfesor.Location = new System.Drawing.Point(3, 176);
            this.buttonProfesor.Margin = new System.Windows.Forms.Padding(10);
            this.buttonProfesor.Name = "buttonProfesor";
            this.buttonProfesor.Size = new System.Drawing.Size(205, 27);
            this.buttonProfesor.TabIndex = 3;
            this.buttonProfesor.Text = "Profesor";
            this.buttonProfesor.UseVisualStyleBackColor = false;
            this.buttonProfesor.Click += new System.EventHandler(this.ButtonProfesor_Click);
            // 
            // buttonEstudiante
            // 
            this.buttonEstudiante.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEstudiante.AutoSize = true;
            this.buttonEstudiante.BackColor = System.Drawing.SystemColors.Window;
            this.buttonEstudiante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEstudiante.Location = new System.Drawing.Point(3, 223);
            this.buttonEstudiante.Margin = new System.Windows.Forms.Padding(10);
            this.buttonEstudiante.Name = "buttonEstudiante";
            this.buttonEstudiante.Size = new System.Drawing.Size(205, 27);
            this.buttonEstudiante.TabIndex = 2;
            this.buttonEstudiante.Text = "Estudiante";
            this.buttonEstudiante.UseVisualStyleBackColor = false;
            this.buttonEstudiante.Click += new System.EventHandler(this.ButtonEstudiante_Click);
            // 
            // buttonEmpleado
            // 
            this.buttonEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEmpleado.AutoSize = true;
            this.buttonEmpleado.BackColor = System.Drawing.SystemColors.Window;
            this.buttonEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmpleado.Location = new System.Drawing.Point(3, 131);
            this.buttonEmpleado.Margin = new System.Windows.Forms.Padding(10);
            this.buttonEmpleado.Name = "buttonEmpleado";
            this.buttonEmpleado.Size = new System.Drawing.Size(205, 27);
            this.buttonEmpleado.TabIndex = 1;
            this.buttonEmpleado.Text = "Empleado";
            this.buttonEmpleado.UseVisualStyleBackColor = false;
            this.buttonEmpleado.Click += new System.EventHandler(this.buttonEmpleado_Click);
            // 
            // buttonAdminitrativo
            // 
            this.buttonAdminitrativo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdminitrativo.AutoSize = true;
            this.buttonAdminitrativo.BackColor = System.Drawing.SystemColors.Window;
            this.buttonAdminitrativo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdminitrativo.Location = new System.Drawing.Point(3, 84);
            this.buttonAdminitrativo.Margin = new System.Windows.Forms.Padding(10);
            this.buttonAdminitrativo.Name = "buttonAdminitrativo";
            this.buttonAdminitrativo.Size = new System.Drawing.Size(205, 27);
            this.buttonAdminitrativo.TabIndex = 0;
            this.buttonAdminitrativo.Text = "Administrativo";
            this.buttonAdminitrativo.UseVisualStyleBackColor = false;
            this.buttonAdminitrativo.Click += new System.EventHandler(this.buttonAdminitrativo_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(221, 10);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(569, 430);
            this.mainPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menuPanel);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Software de Gestion";
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel menuPanel;
        private Button buttonEstudiante;
        private Button buttonEmpleado;
        private Button buttonAdminitrativo;
        private Button buttonProfesor;
        private PictureBox pictureBox1;
        private Button buttonServicio;
        private Panel mainPanel;
    }
}