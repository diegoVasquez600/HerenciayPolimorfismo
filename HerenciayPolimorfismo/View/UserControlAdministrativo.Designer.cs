namespace HerenciayPolimorfismo.View
{
    partial class UserControlAdministrativo
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
            this.label2 = new System.Windows.Forms.Label();
            this.labelAdministrativo = new System.Windows.Forms.Label();
            this.buttonEstadoCivil = new System.Windows.Forms.Button();
            this.buttonDependencia = new System.Windows.Forms.Button();
            this.textBoxDependencia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(224, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Administrativo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAdministrativo
            // 
            this.labelAdministrativo.AutoSize = true;
            this.labelAdministrativo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAdministrativo.Location = new System.Drawing.Point(83, 146);
            this.labelAdministrativo.Name = "labelAdministrativo";
            this.labelAdministrativo.Size = new System.Drawing.Size(0, 21);
            this.labelAdministrativo.TabIndex = 6;
            // 
            // buttonEstadoCivil
            // 
            this.buttonEstadoCivil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEstadoCivil.Location = new System.Drawing.Point(194, 338);
            this.buttonEstadoCivil.Name = "buttonEstadoCivil";
            this.buttonEstadoCivil.Size = new System.Drawing.Size(184, 23);
            this.buttonEstadoCivil.TabIndex = 7;
            this.buttonEstadoCivil.Text = "Cambiar Estado Civil";
            this.buttonEstadoCivil.UseVisualStyleBackColor = true;
            this.buttonEstadoCivil.Click += new System.EventHandler(this.ButtonEstadoCivil_Click);
            // 
            // buttonDependencia
            // 
            this.buttonDependencia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDependencia.Location = new System.Drawing.Point(194, 309);
            this.buttonDependencia.Name = "buttonDependencia";
            this.buttonDependencia.Size = new System.Drawing.Size(184, 23);
            this.buttonDependencia.TabIndex = 8;
            this.buttonDependencia.Text = "Cambiar Dependencia";
            this.buttonDependencia.UseVisualStyleBackColor = true;
            this.buttonDependencia.Click += new System.EventHandler(this.ButtonDependencia_Click);
            // 
            // textBoxDependencia
            // 
            this.textBoxDependencia.Location = new System.Drawing.Point(194, 280);
            this.textBoxDependencia.Name = "textBoxDependencia";
            this.textBoxDependencia.Size = new System.Drawing.Size(184, 23);
            this.textBoxDependencia.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nueva Dependencia";
            // 
            // UserControlAdministrativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDependencia);
            this.Controls.Add(this.buttonDependencia);
            this.Controls.Add(this.buttonEstadoCivil);
            this.Controls.Add(this.labelAdministrativo);
            this.Controls.Add(this.label2);
            this.Name = "UserControlAdministrativo";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(569, 430);
            this.Load += new System.EventHandler(this.UserControlAdministrativo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private Label labelAdministrativo;
        private Button buttonEstadoCivil;
        private Button buttonDependencia;
        private TextBox textBoxDependencia;
        private Label label1;
    }
}
