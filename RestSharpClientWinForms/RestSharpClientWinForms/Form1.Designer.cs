
namespace RestSharpClientWinForms
{
    partial class RestClientForm
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
            this.disconnectButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.toWhomTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fromWhomTextBox = new System.Windows.Forms.TextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.requestMessageTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.responseMessageTextBox = new System.Windows.Forms.TextBox();
            this.sendMessageButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // disconnectButton
            // 
            this.disconnectButton.Location = new System.Drawing.Point(473, 42);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(75, 23);
            this.disconnectButton.TabIndex = 25;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "To whom";
            // 
            // toWhomTextBox
            // 
            this.toWhomTextBox.Location = new System.Drawing.Point(112, 42);
            this.toWhomTextBox.Name = "toWhomTextBox";
            this.toWhomTextBox.Size = new System.Drawing.Size(355, 20);
            this.toWhomTextBox.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "From whom";
            // 
            // fromWhomTextBox
            // 
            this.fromWhomTextBox.Location = new System.Drawing.Point(112, 16);
            this.fromWhomTextBox.Name = "fromWhomTextBox";
            this.fromWhomTextBox.Size = new System.Drawing.Size(355, 20);
            this.fromWhomTextBox.TabIndex = 21;
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(473, 13);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 20;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Message:";
            // 
            // requestMessageTextBox
            // 
            this.requestMessageTextBox.Location = new System.Drawing.Point(112, 270);
            this.requestMessageTextBox.Multiline = true;
            this.requestMessageTextBox.Name = "requestMessageTextBox";
            this.requestMessageTextBox.Size = new System.Drawing.Size(355, 156);
            this.requestMessageTextBox.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Response:";
            // 
            // responseMessageTextBox
            // 
            this.responseMessageTextBox.Location = new System.Drawing.Point(112, 90);
            this.responseMessageTextBox.Multiline = true;
            this.responseMessageTextBox.Name = "responseMessageTextBox";
            this.responseMessageTextBox.Size = new System.Drawing.Size(355, 161);
            this.responseMessageTextBox.TabIndex = 15;
            // 
            // sendMessageButton
            // 
            this.sendMessageButton.Location = new System.Drawing.Point(473, 273);
            this.sendMessageButton.Name = "sendMessageButton";
            this.sendMessageButton.Size = new System.Drawing.Size(75, 23);
            this.sendMessageButton.TabIndex = 13;
            this.sendMessageButton.Text = "Send";
            this.sendMessageButton.UseVisualStyleBackColor = true;
            this.sendMessageButton.Click += new System.EventHandler(this.SendMessageButton_Click);
            // 
            // RestClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 438);
            this.Controls.Add(this.disconnectButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.toWhomTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fromWhomTextBox);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.requestMessageTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.responseMessageTextBox);
            this.Controls.Add(this.sendMessageButton);
            this.Name = "RestClient";
            this.Text = "RestClient";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RestClientForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox toWhomTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fromWhomTextBox;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox requestMessageTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox responseMessageTextBox;
        private System.Windows.Forms.Button sendMessageButton;
    }
}

