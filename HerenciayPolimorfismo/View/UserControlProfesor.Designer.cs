namespace HerenciayPolimorfismo.View
{
    partial class UserControlProfesor
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFacultad = new System.Windows.Forms.TextBox();
            this.buttonEstadoCivil = new System.Windows.Forms.Button();
            this.ButtonFacultad = new System.Windows.Forms.Button();
            this.labelProfesor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nueva Facultad";
            // 
            // textBoxFacultad
            // 
            this.textBoxFacultad.Location = new System.Drawing.Point(192, 294);
            this.textBoxFacultad.Name = "textBoxFacultad";
            this.textBoxFacultad.Size = new System.Drawing.Size(184, 23);
            this.textBoxFacultad.TabIndex = 18;
            // 
            // buttonEstadoCivil
            // 
            this.buttonEstadoCivil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEstadoCivil.Location = new System.Drawing.Point(192, 352);
            this.buttonEstadoCivil.Name = "buttonEstadoCivil";
            this.buttonEstadoCivil.Size = new System.Drawing.Size(184, 23);
            this.buttonEstadoCivil.TabIndex = 17;
            this.buttonEstadoCivil.Text = "Cambiar Estado Civil";
            this.buttonEstadoCivil.UseVisualStyleBackColor = true;
            this.buttonEstadoCivil.Click += new System.EventHandler(this.ButtonEstadoCivil_Click);
            // 
            // ButtonFacultad
            // 
            this.ButtonFacultad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonFacultad.Location = new System.Drawing.Point(192, 323);
            this.ButtonFacultad.Name = "ButtonFacultad";
            this.ButtonFacultad.Size = new System.Drawing.Size(184, 23);
            this.ButtonFacultad.TabIndex = 16;
            this.ButtonFacultad.Text = "Cambiar Facultad";
            this.ButtonFacultad.UseVisualStyleBackColor = true;
            this.ButtonFacultad.Click += new System.EventHandler(this.ButtonFacultad_Click);
            // 
            // labelProfesor
            // 
            this.labelProfesor.AutoSize = true;
            this.labelProfesor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelProfesor.Location = new System.Drawing.Point(78, 152);
            this.labelProfesor.Name = "labelProfesor";
            this.labelProfesor.Size = new System.Drawing.Size(0, 21);
            this.labelProfesor.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(230, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Profesor";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControlProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFacultad);
            this.Controls.Add(this.buttonEstadoCivil);
            this.Controls.Add(this.ButtonFacultad);
            this.Controls.Add(this.labelProfesor);
            this.Controls.Add(this.label2);
            this.Name = "UserControlProfesor";
            this.Size = new System.Drawing.Size(569, 430);
            this.Load += new System.EventHandler(this.UserControlProfesor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBoxFacultad;
        private Button buttonEstadoCivil;
        private Button ButtonFacultad;
        private Label labelProfesor;
        private Label label2;
    }
}
