namespace HerenciayPolimorfismo.View
{
    partial class UserControlEmpleado
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
            this.ButtonLabor = new System.Windows.Forms.Button();
            this.labelEmpleado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonEstadoCivil = new System.Windows.Forms.Button();
            this.textBoxLabor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonLabor
            // 
            this.ButtonLabor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonLabor.Location = new System.Drawing.Point(180, 321);
            this.ButtonLabor.Name = "ButtonLabor";
            this.ButtonLabor.Size = new System.Drawing.Size(184, 23);
            this.ButtonLabor.TabIndex = 10;
            this.ButtonLabor.Text = "Cambiar Labor";
            this.ButtonLabor.UseVisualStyleBackColor = true;
            this.ButtonLabor.Click += new System.EventHandler(this.ButtonLabor_Click);
            // 
            // labelEmpleado
            // 
            this.labelEmpleado.AutoSize = true;
            this.labelEmpleado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEmpleado.Location = new System.Drawing.Point(66, 150);
            this.labelEmpleado.Name = "labelEmpleado";
            this.labelEmpleado.Size = new System.Drawing.Size(0, 21);
            this.labelEmpleado.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(207, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Empleado";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonEstadoCivil
            // 
            this.buttonEstadoCivil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEstadoCivil.Location = new System.Drawing.Point(180, 350);
            this.buttonEstadoCivil.Name = "buttonEstadoCivil";
            this.buttonEstadoCivil.Size = new System.Drawing.Size(184, 23);
            this.buttonEstadoCivil.TabIndex = 11;
            this.buttonEstadoCivil.Text = "Cambiar Estado Civil";
            this.buttonEstadoCivil.UseVisualStyleBackColor = true;
            this.buttonEstadoCivil.Click += new System.EventHandler(this.ButtonEstadoCivil_Click_1);
            // 
            // textBoxLabor
            // 
            this.textBoxLabor.Location = new System.Drawing.Point(180, 292);
            this.textBoxLabor.Name = "textBoxLabor";
            this.textBoxLabor.Size = new System.Drawing.Size(184, 23);
            this.textBoxLabor.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nueva Labor";
            // 
            // UserControlEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxLabor);
            this.Controls.Add(this.buttonEstadoCivil);
            this.Controls.Add(this.ButtonLabor);
            this.Controls.Add(this.labelEmpleado);
            this.Controls.Add(this.label2);
            this.Name = "UserControlEmpleado";
            this.Size = new System.Drawing.Size(569, 430);
            this.Load += new System.EventHandler(this.UserControlEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ButtonLabor;
        private Label labelEmpleado;
        private Label label2;
        private Button buttonEstadoCivil;
        private TextBox textBoxLabor;
        private Label label1;
    }
}
