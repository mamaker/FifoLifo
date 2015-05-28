namespace FifoLifo
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
            this.fifoButton = new System.Windows.Forms.Button();
            this.lifoButton = new System.Windows.Forms.Button();
            this.queueStackList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fifoButton
            // 
            this.fifoButton.Location = new System.Drawing.Point(13, 13);
            this.fifoButton.Name = "fifoButton";
            this.fifoButton.Size = new System.Drawing.Size(118, 23);
            this.fifoButton.TabIndex = 0;
            this.fifoButton.Text = "A Queue is FIFO";
            this.fifoButton.UseVisualStyleBackColor = true;
            this.fifoButton.Click += new System.EventHandler(this.fifoButton_Click);
            // 
            // lifoButton
            // 
            this.lifoButton.Location = new System.Drawing.Point(13, 54);
            this.lifoButton.Name = "lifoButton";
            this.lifoButton.Size = new System.Drawing.Size(118, 23);
            this.lifoButton.TabIndex = 1;
            this.lifoButton.Text = "A Stack is LIFO";
            this.lifoButton.UseVisualStyleBackColor = true;
            this.lifoButton.Click += new System.EventHandler(this.lifoButton_Click);
            // 
            // queueStackList
            // 
            this.queueStackList.Location = new System.Drawing.Point(13, 96);
            this.queueStackList.Name = "queueStackList";
            this.queueStackList.Size = new System.Drawing.Size(118, 23);
            this.queueStackList.TabIndex = 2;
            this.queueStackList.Text = "Queue Stack List";
            this.queueStackList.UseVisualStyleBackColor = true;
            this.queueStackList.Click += new System.EventHandler(this.queueStackList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.queueStackList);
            this.Controls.Add(this.lifoButton);
            this.Controls.Add(this.fifoButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Fifo Lifo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button fifoButton;
        private System.Windows.Forms.Button lifoButton;
        private System.Windows.Forms.Button queueStackList;
    }
}

