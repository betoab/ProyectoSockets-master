namespace ProyectoSeguridad
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPortA = new System.Windows.Forms.TextBox();
            this.Port = new System.Windows.Forms.Label();
            this.txtIpA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPortB = new System.Windows.Forms.TextBox();
            this.txtIpB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.connect = new System.Windows.Forms.Button();
            this.txtsend = new System.Windows.Forms.TextBox();
            this.send = new System.Windows.Forms.Button();
            this.messages = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPortA);
            this.groupBox1.Controls.Add(this.Port);
            this.groupBox1.Controls.Add(this.txtIpA);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yo";
            // 
            // txtPortA
            // 
            this.txtPortA.Location = new System.Drawing.Point(48, 56);
            this.txtPortA.Name = "txtPortA";
            this.txtPortA.Size = new System.Drawing.Size(100, 20);
            this.txtPortA.TabIndex = 3;
            // 
            // Port
            // 
            this.Port.AutoSize = true;
            this.Port.Location = new System.Drawing.Point(7, 59);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(26, 13);
            this.Port.TabIndex = 2;
            this.Port.Text = "Port";
            // 
            // txtIpA
            // 
            this.txtIpA.Location = new System.Drawing.Point(48, 20);
            this.txtIpA.Name = "txtIpA";
            this.txtIpA.Size = new System.Drawing.Size(100, 20);
            this.txtIpA.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPortB);
            this.groupBox2.Controls.Add(this.txtIpB);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(267, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mi camarada";
            // 
            // txtPortB
            // 
            this.txtPortB.Location = new System.Drawing.Point(61, 56);
            this.txtPortB.Name = "txtPortB";
            this.txtPortB.Size = new System.Drawing.Size(100, 20);
            this.txtPortB.TabIndex = 7;
            // 
            // txtIpB
            // 
            this.txtIpB.Location = new System.Drawing.Point(61, 20);
            this.txtIpB.Name = "txtIpB";
            this.txtIpB.Size = new System.Drawing.Size(100, 20);
            this.txtIpB.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "IP";
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(267, 118);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(75, 23);
            this.connect.TabIndex = 2;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // txtsend
            // 
            this.txtsend.Location = new System.Drawing.Point(12, 247);
            this.txtsend.Name = "txtsend";
            this.txtsend.Size = new System.Drawing.Size(249, 20);
            this.txtsend.TabIndex = 4;
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(267, 244);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(75, 23);
            this.send.TabIndex = 5;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // messages
            // 
            this.messages.FormattingEnabled = true;
            this.messages.Location = new System.Drawing.Point(12, 118);
            this.messages.Name = "messages";
            this.messages.Size = new System.Drawing.Size(249, 108);
            this.messages.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(372, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Get IP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 275);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.messages);
            this.Controls.Add(this.send);
            this.Controls.Add(this.txtsend);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPortA;
        private System.Windows.Forms.Label Port;
        private System.Windows.Forms.TextBox txtIpA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPortB;
        private System.Windows.Forms.TextBox txtIpB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.TextBox txtsend;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.ListBox messages;
        private System.Windows.Forms.Button button1;
    }
}

