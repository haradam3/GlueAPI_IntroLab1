namespace HelloGlueWorld
{
   partial class GlueUI
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
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelRequest = new System.Windows.Forms.Label();
            this.labelResponse = new System.Windows.Forms.Label();
            this.textBoxRequest = new System.Windows.Forms.TextBox();
            this.textBoxResponse = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(27, 16);
            this.labelUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(79, 17);
            this.labelUserName.TabIndex = 0;
            this.labelUserName.Text = "User Name";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(27, 53);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(69, 17);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Password";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(120, 16);
            this.textBoxUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(256, 22);
            this.textBoxUserName.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(120, 53);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(256, 22);
            this.textBoxPassword.TabIndex = 3;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(184, 96);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(115, 28);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelRequest
            // 
            this.labelRequest.AutoSize = true;
            this.labelRequest.Location = new System.Drawing.Point(27, 144);
            this.labelRequest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRequest.Name = "labelRequest";
            this.labelRequest.Size = new System.Drawing.Size(61, 17);
            this.labelRequest.TabIndex = 5;
            this.labelRequest.Text = "Request";
            // 
            // labelResponse
            // 
            this.labelResponse.AutoSize = true;
            this.labelResponse.Location = new System.Drawing.Point(27, 240);
            this.labelResponse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResponse.Name = "labelResponse";
            this.labelResponse.Size = new System.Drawing.Size(72, 17);
            this.labelResponse.TabIndex = 6;
            this.labelResponse.Text = "Response";
            // 
            // textBoxRequest
            // 
            this.textBoxRequest.Location = new System.Drawing.Point(27, 164);
            this.textBoxRequest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxRequest.Multiline = true;
            this.textBoxRequest.Name = "textBoxRequest";
            this.textBoxRequest.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRequest.Size = new System.Drawing.Size(425, 70);
            this.textBoxRequest.TabIndex = 7;
            // 
            // textBoxResponse
            // 
            this.textBoxResponse.Location = new System.Drawing.Point(27, 258);
            this.textBoxResponse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxResponse.Multiline = true;
            this.textBoxResponse.Name = "textBoxResponse";
            this.textBoxResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResponse.Size = new System.Drawing.Size(425, 221);
            this.textBoxResponse.TabIndex = 8;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(106, 240);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(0, 17);
            this.labelStatus.TabIndex = 9;
            // 
            // GlueUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 507);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.textBoxResponse);
            this.Controls.Add(this.textBoxRequest);
            this.Controls.Add(this.labelResponse);
            this.Controls.Add(this.labelRequest);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUserName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GlueUI";
            this.Text = "Glue API Intro";
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label labelUserName;
      private System.Windows.Forms.Label labelPassword;
      private System.Windows.Forms.TextBox textBoxUserName;
      private System.Windows.Forms.TextBox textBoxPassword;
      private System.Windows.Forms.Button buttonLogin;
      private System.Windows.Forms.Label labelRequest;
      private System.Windows.Forms.Label labelResponse;
      private System.Windows.Forms.TextBox textBoxRequest;
      private System.Windows.Forms.TextBox textBoxResponse;
        private System.Windows.Forms.Label labelStatus;
    }
}

