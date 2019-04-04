namespace EV3RemoteControlWifi
{
    partial class Mainform
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
            this.components = new System.ComponentModel.Container();
            this.buttonForward = new System.Windows.Forms.Button();
            this.sendMessageGroupBox = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonBackward = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.connectionGroupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ipAddressBox = new System.Windows.Forms.TextBox();
            this.connectedDeviceLabel = new System.Windows.Forms.Label();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.receivedDataGroupBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sendMessageGroupBox.SuspendLayout();
            this.connectionGroupBox.SuspendLayout();
            this.receivedDataGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonForward
            // 
            this.buttonForward.Location = new System.Drawing.Point(123, 16);
            this.buttonForward.Name = "buttonForward";
            this.buttonForward.Size = new System.Drawing.Size(63, 40);
            this.buttonForward.TabIndex = 1;
            this.buttonForward.Text = "Forward";
            this.buttonForward.UseVisualStyleBackColor = true;
            this.buttonForward.Click += new System.EventHandler(this.sendForwardButton_Click);
            // 
            // sendMessageGroupBox
            // 
            this.sendMessageGroupBox.Controls.Add(this.button2);
            this.sendMessageGroupBox.Controls.Add(this.button1);
            this.sendMessageGroupBox.Controls.Add(this.buttonBackward);
            this.sendMessageGroupBox.Controls.Add(this.buttonLeft);
            this.sendMessageGroupBox.Controls.Add(this.buttonRight);
            this.sendMessageGroupBox.Controls.Add(this.buttonForward);
            this.sendMessageGroupBox.Location = new System.Drawing.Point(12, 102);
            this.sendMessageGroupBox.Name = "sendMessageGroupBox";
            this.sendMessageGroupBox.Size = new System.Drawing.Size(299, 156);
            this.sendMessageGroupBox.TabIndex = 2;
            this.sendMessageGroupBox.TabStop = false;
            this.sendMessageGroupBox.Text = "EV3 Move";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(26, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonBackward
            // 
            this.buttonBackward.Location = new System.Drawing.Point(121, 92);
            this.buttonBackward.Name = "buttonBackward";
            this.buttonBackward.Size = new System.Drawing.Size(65, 40);
            this.buttonBackward.TabIndex = 4;
            this.buttonBackward.Text = "Backward";
            this.buttonBackward.UseVisualStyleBackColor = true;
            this.buttonBackward.Click += new System.EventHandler(this.sendBackwardButton_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Location = new System.Drawing.Point(61, 53);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(64, 42);
            this.buttonLeft.TabIndex = 3;
            this.buttonLeft.Text = "Left";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.sendLeftButton_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Location = new System.Drawing.Point(184, 52);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(62, 44);
            this.buttonRight.TabIndex = 2;
            this.buttonRight.Text = "Right";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.sendRightButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(116, 124);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Start";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // connectionGroupBox
            // 
            this.connectionGroupBox.Controls.Add(this.label3);
            this.connectionGroupBox.Controls.Add(this.ipAddressBox);
            this.connectionGroupBox.Controls.Add(this.connectedDeviceLabel);
            this.connectionGroupBox.Controls.Add(this.disconnectButton);
            this.connectionGroupBox.Controls.Add(this.connectButton);
            this.connectionGroupBox.Location = new System.Drawing.Point(10, 10);
            this.connectionGroupBox.Name = "connectionGroupBox";
            this.connectionGroupBox.Size = new System.Drawing.Size(680, 86);
            this.connectionGroupBox.TabIndex = 3;
            this.connectionGroupBox.TabStop = false;
            this.connectionGroupBox.Text = "Connection";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "IP address of EV3";
            // 
            // ipAddressBox
            // 
            this.ipAddressBox.Location = new System.Drawing.Point(45, 36);
            this.ipAddressBox.Name = "ipAddressBox";
            this.ipAddressBox.Size = new System.Drawing.Size(114, 20);
            this.ipAddressBox.TabIndex = 11;
            // 
            // connectedDeviceLabel
            // 
            this.connectedDeviceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.connectedDeviceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectedDeviceLabel.Location = new System.Drawing.Point(430, 20);
            this.connectedDeviceLabel.Name = "connectedDeviceLabel";
            this.connectedDeviceLabel.Size = new System.Drawing.Size(145, 47);
            this.connectedDeviceLabel.TabIndex = 10;
            this.connectedDeviceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // disconnectButton
            // 
            this.disconnectButton.Enabled = false;
            this.disconnectButton.Location = new System.Drawing.Point(305, 50);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(75, 23);
            this.disconnectButton.TabIndex = 9;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(305, 15);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 7;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // receivedDataGroupBox
            // 
            this.receivedDataGroupBox.Controls.Add(this.label5);
            this.receivedDataGroupBox.Controls.Add(this.label2);
            this.receivedDataGroupBox.Controls.Add(this.button3);
            this.receivedDataGroupBox.Controls.Add(this.label1);
            this.receivedDataGroupBox.Location = new System.Drawing.Point(326, 102);
            this.receivedDataGroupBox.Name = "receivedDataGroupBox";
            this.receivedDataGroupBox.Size = new System.Drawing.Size(197, 156);
            this.receivedDataGroupBox.TabIndex = 4;
            this.receivedDataGroupBox.TabStop = false;
            this.receivedDataGroupBox.Text = "Timer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(118, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 37);
            this.label5.TabIndex = 9;
            this.label5.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 73);
            this.label2.TabIndex = 8;
            this.label2.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Press start to start playing";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 484);
            this.Controls.Add(this.connectionGroupBox);
            this.Controls.Add(this.receivedDataGroupBox);
            this.Controls.Add(this.sendMessageGroupBox);
            this.Name = "Mainform";
            this.Text = "EV3 Remote Control Wifi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Mainform_FormClosed);
            this.sendMessageGroupBox.ResumeLayout(false);
            this.connectionGroupBox.ResumeLayout(false);
            this.connectionGroupBox.PerformLayout();
            this.receivedDataGroupBox.ResumeLayout(false);
            this.receivedDataGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox sendMessageGroupBox;
        private System.Windows.Forms.Button buttonForward;
        private System.Windows.Forms.Button buttonBackward;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.GroupBox connectionGroupBox;
        private System.Windows.Forms.GroupBox receivedDataGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label connectedDeviceLabel;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ipAddressBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
    }
}

