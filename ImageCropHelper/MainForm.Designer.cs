
namespace ImageCropHelper
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtRatioWidth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRatioHeight = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSourceHeight = new System.Windows.Forms.TextBox();
            this.txtSourceWidth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDestinationHeight = new System.Windows.Forms.TextBox();
            this.txtDestinationWidth = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ratio:";
            // 
            // txtRatioWidth
            // 
            this.txtRatioWidth.Location = new System.Drawing.Point(55, 13);
            this.txtRatioWidth.Name = "txtRatioWidth";
            this.txtRatioWidth.Size = new System.Drawing.Size(100, 20);
            this.txtRatioWidth.TabIndex = 1;
            this.txtRatioWidth.Text = "16";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = ":";
            // 
            // txtRatioHeight
            // 
            this.txtRatioHeight.Location = new System.Drawing.Point(177, 13);
            this.txtRatioHeight.Name = "txtRatioHeight";
            this.txtRatioHeight.Size = new System.Drawing.Size(100, 20);
            this.txtRatioHeight.TabIndex = 3;
            this.txtRatioHeight.Text = "9";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSourceHeight);
            this.groupBox1.Controls.Add(this.txtSourceWidth);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(13, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 85);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source";
            // 
            // txtSourceHeight
            // 
            this.txtSourceHeight.Location = new System.Drawing.Point(48, 52);
            this.txtSourceHeight.Name = "txtSourceHeight";
            this.txtSourceHeight.Size = new System.Drawing.Size(100, 20);
            this.txtSourceHeight.TabIndex = 6;
            this.txtSourceHeight.Click += new System.EventHandler(this.txtSourceHeight_Click);
            this.txtSourceHeight.TextChanged += new System.EventHandler(this.txtSourceHeight_TextChanged);
            // 
            // txtSourceWidth
            // 
            this.txtSourceWidth.Location = new System.Drawing.Point(48, 21);
            this.txtSourceWidth.Name = "txtSourceWidth";
            this.txtSourceWidth.Size = new System.Drawing.Size(100, 20);
            this.txtSourceWidth.TabIndex = 5;
            this.txtSourceWidth.Click += new System.EventHandler(this.txtSourceWidth_Click);
            this.txtSourceWidth.TextChanged += new System.EventHandler(this.txtSourceWidth_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Width";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDestinationHeight);
            this.groupBox2.Controls.Add(this.txtDestinationWidth);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(196, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(165, 85);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Destination";
            // 
            // txtDestinationHeight
            // 
            this.txtDestinationHeight.Location = new System.Drawing.Point(48, 52);
            this.txtDestinationHeight.Name = "txtDestinationHeight";
            this.txtDestinationHeight.Size = new System.Drawing.Size(100, 20);
            this.txtDestinationHeight.TabIndex = 6;
            this.txtDestinationHeight.Click += new System.EventHandler(this.txtDestinationHeight_Click);
            // 
            // txtDestinationWidth
            // 
            this.txtDestinationWidth.Location = new System.Drawing.Point(48, 21);
            this.txtDestinationWidth.Name = "txtDestinationWidth";
            this.txtDestinationWidth.Size = new System.Drawing.Size(100, 20);
            this.txtDestinationWidth.TabIndex = 5;
            this.txtDestinationWidth.Click += new System.EventHandler(this.txtDestinationWidth_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Height";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Width";
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(321, 11);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(38, 23);
            this.btnHelp.TabIndex = 6;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 144);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtRatioHeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRatioWidth);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Image Crop Helper";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRatioWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRatioHeight;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSourceHeight;
        private System.Windows.Forms.TextBox txtSourceWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDestinationHeight;
        private System.Windows.Forms.TextBox txtDestinationWidth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnHelp;
    }
}

