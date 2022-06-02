namespace Hospitaldigital
{
    partial class Form2
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
            this.lblPrimernombre = new System.Windows.Forms.Label();
            this.lblSegundonombre = new System.Windows.Forms.Label();
            this.lblprimerapellido = new System.Windows.Forms.Label();
            this.lblSegundoapellido = new System.Windows.Forms.Label();
            this.txtPrimernombre = new System.Windows.Forms.TextBox();
            this.txtSegundonombre = new System.Windows.Forms.TextBox();
            this.txtPrimerapellido = new System.Windows.Forms.TextBox();
            this.txtSegundoapellido = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrimernombre
            // 
            this.lblPrimernombre.AutoSize = true;
            this.lblPrimernombre.Location = new System.Drawing.Point(72, 54);
            this.lblPrimernombre.Name = "lblPrimernombre";
            this.lblPrimernombre.Size = new System.Drawing.Size(77, 13);
            this.lblPrimernombre.TabIndex = 0;
            this.lblPrimernombre.Text = "Primer nombre ";
            this.lblPrimernombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSegundonombre
            // 
            this.lblSegundonombre.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblSegundonombre.AutoSize = true;
            this.lblSegundonombre.Location = new System.Drawing.Point(72, 114);
            this.lblSegundonombre.Name = "lblSegundonombre";
            this.lblSegundonombre.Size = new System.Drawing.Size(88, 13);
            this.lblSegundonombre.TabIndex = 1;
            this.lblSegundonombre.Text = "Segundo nombre";
            // 
            // lblprimerapellido
            // 
            this.lblprimerapellido.AutoSize = true;
            this.lblprimerapellido.Location = new System.Drawing.Point(72, 182);
            this.lblprimerapellido.Name = "lblprimerapellido";
            this.lblprimerapellido.Size = new System.Drawing.Size(76, 13);
            this.lblprimerapellido.TabIndex = 2;
            this.lblprimerapellido.Text = "Primer Apellido";
            this.lblprimerapellido.Click += new System.EventHandler(this.lbl_Click);
            // 
            // lblSegundoapellido
            // 
            this.lblSegundoapellido.AutoSize = true;
            this.lblSegundoapellido.Location = new System.Drawing.Point(68, 238);
            this.lblSegundoapellido.Name = "lblSegundoapellido";
            this.lblSegundoapellido.Size = new System.Drawing.Size(92, 13);
            this.lblSegundoapellido.TabIndex = 3;
            this.lblSegundoapellido.Text = "Segundo apellido ";
            // 
            // txtPrimernombre
            // 
            this.txtPrimernombre.Location = new System.Drawing.Point(261, 51);
            this.txtPrimernombre.Name = "txtPrimernombre";
            this.txtPrimernombre.Size = new System.Drawing.Size(131, 20);
            this.txtPrimernombre.TabIndex = 4;
            this.txtPrimernombre.TextChanged += new System.EventHandler(this.txtPrimernombre_TextChanged);
            // 
            // txtSegundonombre
            // 
            this.txtSegundonombre.Location = new System.Drawing.Point(261, 107);
            this.txtSegundonombre.Name = "txtSegundonombre";
            this.txtSegundonombre.Size = new System.Drawing.Size(131, 20);
            this.txtSegundonombre.TabIndex = 5;
            this.txtSegundonombre.TextChanged += new System.EventHandler(this.txtSegundonombre_TextChanged);
            // 
            // txtPrimerapellido
            // 
            this.txtPrimerapellido.Location = new System.Drawing.Point(261, 175);
            this.txtPrimerapellido.Name = "txtPrimerapellido";
            this.txtPrimerapellido.Size = new System.Drawing.Size(131, 20);
            this.txtPrimerapellido.TabIndex = 6;
            this.txtPrimerapellido.TextChanged += new System.EventHandler(this.txtPrimerapellido_TextChanged);
            // 
            // txtSegundoapellido
            // 
            this.txtSegundoapellido.Location = new System.Drawing.Point(261, 235);
            this.txtSegundoapellido.Name = "txtSegundoapellido";
            this.txtSegundoapellido.Size = new System.Drawing.Size(131, 20);
            this.txtSegundoapellido.TabIndex = 7;
            this.txtSegundoapellido.TextChanged += new System.EventHandler(this.txtSegundoapellido_TextChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnGuardar.Location = new System.Drawing.Point(0, 427);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(643, 23);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCancelar.Location = new System.Drawing.Point(0, 404);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(643, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtSegundoapellido);
            this.Controls.Add(this.txtPrimerapellido);
            this.Controls.Add(this.txtSegundonombre);
            this.Controls.Add(this.txtPrimernombre);
            this.Controls.Add(this.lblSegundoapellido);
            this.Controls.Add(this.lblprimerapellido);
            this.Controls.Add(this.lblSegundonombre);
            this.Controls.Add(this.lblPrimernombre);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrimernombre;
        private System.Windows.Forms.Label lblSegundonombre;
        private System.Windows.Forms.Label lblprimerapellido;
        private System.Windows.Forms.Label lblSegundoapellido;
        private System.Windows.Forms.TextBox txtPrimernombre;
        private System.Windows.Forms.TextBox txtSegundonombre;
        private System.Windows.Forms.TextBox txtPrimerapellido;
        private System.Windows.Forms.TextBox txtSegundoapellido;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}