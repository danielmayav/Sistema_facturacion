namespace Pantallas_Sistema_facturacion
{
    partial class frmlogin
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlLoginLeft = new System.Windows.Forms.Panel();
            this.picLogin = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.TxtUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnValidar = new MaterialSkin.Controls.MaterialFlatButton();
            this.bntCancelar = new MaterialSkin.Controls.MaterialFlatButton();
            this.pnlLoginLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLoginLeft
            // 
            this.pnlLoginLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.pnlLoginLeft.Controls.Add(this.picLogin);
            this.pnlLoginLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLoginLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLoginLeft.Name = "pnlLoginLeft";
            this.pnlLoginLeft.Size = new System.Drawing.Size(200, 250);
            this.pnlLoginLeft.TabIndex = 0;
            // 
            // picLogin
            // 
            this.picLogin.Image = global::Pantallas_Sistema_facturacion.Properties.Resources.data_protection__1_;
            this.picLogin.Location = new System.Drawing.Point(0, 41);
            this.picLogin.Name = "picLogin";
            this.picLogin.Size = new System.Drawing.Size(200, 162);
            this.picLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogin.TabIndex = 0;
            this.picLogin.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Depth = 0;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitulo.Location = new System.Drawing.Point(262, 41);
            this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(167, 24);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "VALIDAR USUARIO";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Depth = 0;
            this.TxtUsuario.Hint = "Usuario";
            this.TxtUsuario.Location = new System.Drawing.Point(305, 93);
            this.TxtUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.PasswordChar = '\0';
            this.TxtUsuario.SelectedText = "";
            this.TxtUsuario.SelectionLength = 0;
            this.TxtUsuario.SelectionStart = 0;
            this.TxtUsuario.Size = new System.Drawing.Size(75, 28);
            this.TxtUsuario.TabIndex = 2;
            this.TxtUsuario.UseSystemPasswordChar = false;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Depth = 0;
            this.TxtPassword.Hint = "Password";
            this.TxtPassword.Location = new System.Drawing.Point(305, 145);
            this.TxtPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.SelectedText = "";
            this.TxtPassword.SelectionLength = 0;
            this.TxtPassword.SelectionStart = 0;
            this.TxtPassword.Size = new System.Drawing.Size(75, 28);
            this.TxtPassword.TabIndex = 3;
            this.TxtPassword.UseSystemPasswordChar = false;
            // 
            // btnValidar
            // 
            this.btnValidar.AutoSize = true;
            this.btnValidar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnValidar.Depth = 0;
            this.btnValidar.Location = new System.Drawing.Point(237, 199);
            this.btnValidar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnValidar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Primary = false;
            this.btnValidar.Size = new System.Drawing.Size(83, 36);
            this.btnValidar.TabIndex = 4;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            // 
            // bntCancelar
            // 
            this.bntCancelar.AutoSize = true;
            this.bntCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bntCancelar.Depth = 0;
            this.bntCancelar.Location = new System.Drawing.Point(364, 199);
            this.bntCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bntCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.bntCancelar.Name = "bntCancelar";
            this.bntCancelar.Primary = false;
            this.bntCancelar.Size = new System.Drawing.Size(100, 36);
            this.bntCancelar.TabIndex = 5;
            this.bntCancelar.Text = "Cancelar";
            this.bntCancelar.UseVisualStyleBackColor = true;
            this.bntCancelar.Click += new System.EventHandler(this.bntCancelar_Click);
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(500, 250);
            this.Controls.Add(this.bntCancelar);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlLoginLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmlogin";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlLoginLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlLoginLeft;
        private System.Windows.Forms.PictureBox picLogin;
        private MaterialSkin.Controls.MaterialLabel lblTitulo;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtUsuario;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtPassword;
        private MaterialSkin.Controls.MaterialFlatButton btnValidar;
        private MaterialSkin.Controls.MaterialFlatButton bntCancelar;
    }
}

