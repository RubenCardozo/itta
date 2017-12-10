namespace SmsLogin
{
    partial class FormIdentification
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnObtenirCle = new System.Windows.Forms.Button();
            this.chBoxSauver = new System.Windows.Forms.CheckBox();
            this.chBoxProxy = new System.Windows.Forms.CheckBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblAPI = new System.Windows.Forms.Label();
            this.txtBoxMail = new System.Windows.Forms.TextBox();
            this.txtBoxApi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Orange;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Open Sans Light", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(333, 212);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(160, 56);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // btnObtenirCle
            // 
            this.btnObtenirCle.BackColor = System.Drawing.Color.Orange;
            this.btnObtenirCle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnObtenirCle.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnObtenirCle.FlatAppearance.BorderSize = 0;
            this.btnObtenirCle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObtenirCle.Font = new System.Drawing.Font("Open Sans Light", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObtenirCle.ForeColor = System.Drawing.Color.White;
            this.btnObtenirCle.Location = new System.Drawing.Point(590, 227);
            this.btnObtenirCle.Name = "btnObtenirCle";
            this.btnObtenirCle.Size = new System.Drawing.Size(200, 28);
            this.btnObtenirCle.TabIndex = 1;
            this.btnObtenirCle.Text = "Obtenir une clé API";
            this.btnObtenirCle.UseVisualStyleBackColor = false;
            // 
            // chBoxSauver
            // 
            this.chBoxSauver.AutoSize = true;
            this.chBoxSauver.Location = new System.Drawing.Point(92, 212);
            this.chBoxSauver.Name = "chBoxSauver";
            this.chBoxSauver.Size = new System.Drawing.Size(161, 23);
            this.chBoxSauver.TabIndex = 2;
            this.chBoxSauver.Text = "Sauver les valeurs";
            this.chBoxSauver.UseVisualStyleBackColor = true;
            // 
            // chBoxProxy
            // 
            this.chBoxProxy.AutoSize = true;
            this.chBoxProxy.Location = new System.Drawing.Point(92, 245);
            this.chBoxProxy.Name = "chBoxProxy";
            this.chBoxProxy.Size = new System.Drawing.Size(150, 23);
            this.chBoxProxy.TabIndex = 3;
            this.chBoxProxy.Text = "Utiliser un proxy";
            this.chBoxProxy.UseVisualStyleBackColor = true;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Open Sans Light", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(8, 146);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(57, 19);
            this.lblMail.TabIndex = 4;
            this.lblMail.Text = "E-mail:";
            // 
            // lblAPI
            // 
            this.lblAPI.AutoSize = true;
            this.lblAPI.Font = new System.Drawing.Font("Open Sans Light", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAPI.Location = new System.Drawing.Point(406, 146);
            this.lblAPI.Name = "lblAPI";
            this.lblAPI.Size = new System.Drawing.Size(60, 19);
            this.lblAPI.TabIndex = 5;
            this.lblAPI.Text = "Clé API";
            // 
            // txtBoxMail
            // 
            this.txtBoxMail.Location = new System.Drawing.Point(92, 146);
            this.txtBoxMail.Name = "txtBoxMail";
            this.txtBoxMail.Size = new System.Drawing.Size(270, 26);
            this.txtBoxMail.TabIndex = 6;
            // 
            // txtBoxApi
            // 
            this.txtBoxApi.Location = new System.Drawing.Point(520, 146);
            this.txtBoxApi.Name = "txtBoxApi";
            this.txtBoxApi.Size = new System.Drawing.Size(270, 26);
            this.txtBoxApi.TabIndex = 7;
            // 
            // FormIdentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 284);
            this.Controls.Add(this.txtBoxApi);
            this.Controls.Add(this.txtBoxMail);
            this.Controls.Add(this.lblAPI);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.chBoxProxy);
            this.Controls.Add(this.chBoxSauver);
            this.Controls.Add(this.btnObtenirCle);
            this.Controls.Add(this.btnLogin);
            this.Font = new System.Drawing.Font("Open Sans Light", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormIdentification";
            this.Text = "Identification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnObtenirCle;
        private System.Windows.Forms.CheckBox chBoxSauver;
        private System.Windows.Forms.CheckBox chBoxProxy;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblAPI;
        private System.Windows.Forms.TextBox txtBoxMail;
        private System.Windows.Forms.TextBox txtBoxApi;
    }
}

