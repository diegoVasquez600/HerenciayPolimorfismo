namespace HerenciayPolimorfismo.View
{
    partial class UserControlEstudiante
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
            this.textBoxCurso = new System.Windows.Forms.TextBox();
            this.buttonEstadoCivil = new System.Windows.Forms.Button();
            this.ButtonCurso = new System.Windows.Forms.Button();
            this.labelEstudiante = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "Matricular Curso";
            // 
            // textBoxCurso
            // 
            this.textBoxCurso.Location = new System.Drawing.Point(191, 297);
            this.textBoxCurso.Name = "textBoxCurso";
            this.textBoxCurso.Size = new System.Drawing.Size(184, 23);
            this.textBoxCurso.TabIndex = 24;
            // 
            // buttonEstadoCivil
            // 
            this.buttonEstadoCivil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEstadoCivil.Location = new System.Drawing.Point(191, 355);
            this.buttonEstadoCivil.Name = "buttonEstadoCivil";
            this.buttonEstadoCivil.Size = new System.Drawing.Size(184, 23);
            this.buttonEstadoCivil.TabIndex = 23;
            this.buttonEstadoCivil.Text = "Cambiar Estado Civil";
            this.buttonEstadoCivil.UseVisualStyleBackColor = true;
            this.buttonEstadoCivil.Click += new System.EventHandler(this.ButtonEstadoCivil_Click);
            // 
            // ButtonCurso
            // 
            this.ButtonCurso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCurso.Location = new System.Drawing.Point(191, 326);
            this.ButtonCurso.Name = "ButtonCurso";
            this.ButtonCurso.Size = new System.Drawing.Size(184, 23);
            this.ButtonCurso.TabIndex = 22;
            this.ButtonCurso.Text = "Matricular Estudiante";
            this.ButtonCurso.UseVisualStyleBackColor = true;
            this.ButtonCurso.Click += new System.EventHandler(this.ButtonCurso_Click);
            // 
            // labelEstudiante
            // 
            this.labelEstudiante.AutoSize = true;
            this.labelEstudiante.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEstudiante.Location = new System.Drawing.Point(77, 155);
            this.labelEstudiante.Name = "labelEstudiante";
            this.labelEstudiante.Size = new System.Drawing.Size(0, 21);
            this.labelEstudiante.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(229, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Estudiante";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControlEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCurso);
            this.Controls.Add(this.buttonEstadoCivil);
            this.Controls.Add(this.ButtonCurso);
            this.Controls.Add(this.labelEstudiante);
            this.Controls.Add(this.label2);
            this.Name = "UserControlEstudiante";
            this.Size = new System.Drawing.Size(569, 430);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBoxCurso;
        private Button buttonEstadoCivil;
        private Button ButtonCurso;
        private Label labelEstudiante;
        private Label label2;
    }
}
