namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnStream = new System.Windows.Forms.Button();
            this.PictureStream = new System.Windows.Forms.PictureBox();
            this.PictureCapture = new System.Windows.Forms.PictureBox();
            this.PictureActual = new System.Windows.Forms.PictureBox();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.BtnCOMPARE = new System.Windows.Forms.Button();
            this.BtnCAPTURE = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.HsbRadius = new System.Windows.Forms.HScrollBar();
            this.RbRadius = new System.Windows.Forms.RadioButton();
            this.HsbThreshold = new System.Windows.Forms.HScrollBar();
            this.RbThreshold = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureStream)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureCapture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureActual)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnStream
            // 
            this.BtnStream.Location = new System.Drawing.Point(17, 24);
            this.BtnStream.Name = "BtnStream";
            this.BtnStream.Size = new System.Drawing.Size(110, 44);
            this.BtnStream.TabIndex = 0;
            this.BtnStream.Text = "STREAM";
            this.BtnStream.UseVisualStyleBackColor = true;
            this.BtnStream.Click += new System.EventHandler(this.BtnStream_Click);
            // 
            // PictureStream
            // 
            this.PictureStream.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureStream.Location = new System.Drawing.Point(6, 16);
            this.PictureStream.Name = "PictureStream";
            this.PictureStream.Size = new System.Drawing.Size(444, 236);
            this.PictureStream.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureStream.TabIndex = 2;
            this.PictureStream.TabStop = false;
            // 
            // PictureCapture
            // 
            this.PictureCapture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureCapture.Location = new System.Drawing.Point(6, 16);
            this.PictureCapture.Name = "PictureCapture";
            this.PictureCapture.Size = new System.Drawing.Size(444, 236);
            this.PictureCapture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureCapture.TabIndex = 4;
            this.PictureCapture.TabStop = false;
            // 
            // PictureActual
            // 
            this.PictureActual.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureActual.Location = new System.Drawing.Point(6, 16);
            this.PictureActual.Name = "PictureActual";
            this.PictureActual.Size = new System.Drawing.Size(444, 236);
            this.PictureActual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureActual.TabIndex = 5;
            this.PictureActual.TabStop = false;
            // 
            // BtnLoad
            // 
            this.BtnLoad.Location = new System.Drawing.Point(17, 139);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(110, 44);
            this.BtnLoad.TabIndex = 6;
            this.BtnLoad.Text = "LOAD";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // BtnCOMPARE
            // 
            this.BtnCOMPARE.Location = new System.Drawing.Point(17, 193);
            this.BtnCOMPARE.Name = "BtnCOMPARE";
            this.BtnCOMPARE.Size = new System.Drawing.Size(110, 44);
            this.BtnCOMPARE.TabIndex = 7;
            this.BtnCOMPARE.Text = "COMPARE";
            this.BtnCOMPARE.UseVisualStyleBackColor = true;
            this.BtnCOMPARE.Click += new System.EventHandler(this.BtnCOMPARE_Click);
            // 
            // BtnCAPTURE
            // 
            this.BtnCAPTURE.Location = new System.Drawing.Point(17, 81);
            this.BtnCAPTURE.Name = "BtnCAPTURE";
            this.BtnCAPTURE.Size = new System.Drawing.Size(110, 44);
            this.BtnCAPTURE.TabIndex = 8;
            this.BtnCAPTURE.Text = "CAPTURE";
            this.BtnCAPTURE.UseVisualStyleBackColor = true;
            this.BtnCAPTURE.Click += new System.EventHandler(this.BtnCAPTURE_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.HsbRadius);
            this.groupBox1.Controls.Add(this.RbRadius);
            this.groupBox1.Controls.Add(this.HsbThreshold);
            this.groupBox1.Controls.Add(this.RbThreshold);
            this.groupBox1.Controls.Add(this.BtnCAPTURE);
            this.groupBox1.Controls.Add(this.BtnLoad);
            this.groupBox1.Controls.Add(this.BtnCOMPARE);
            this.groupBox1.Controls.Add(this.BtnStream);
            this.groupBox1.Location = new System.Drawing.Point(478, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 249);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CONTROL";
            // 
            // HsbRadius
            // 
            this.HsbRadius.Location = new System.Drawing.Point(173, 165);
            this.HsbRadius.Name = "HsbRadius";
            this.HsbRadius.Size = new System.Drawing.Size(243, 14);
            this.HsbRadius.TabIndex = 12;
            this.HsbRadius.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HsbRadius_Scroll);
            // 
            // RbRadius
            // 
            this.RbRadius.AutoSize = true;
            this.RbRadius.Location = new System.Drawing.Point(173, 139);
            this.RbRadius.Name = "RbRadius";
            this.RbRadius.Size = new System.Drawing.Size(65, 19);
            this.RbRadius.TabIndex = 11;
            this.RbRadius.TabStop = true;
            this.RbRadius.Text = "RADIUS";
            this.RbRadius.UseVisualStyleBackColor = true;
            // 
            // HsbThreshold
            // 
            this.HsbThreshold.Location = new System.Drawing.Point(173, 75);
            this.HsbThreshold.Name = "HsbThreshold";
            this.HsbThreshold.Size = new System.Drawing.Size(243, 14);
            this.HsbThreshold.TabIndex = 10;
            this.HsbThreshold.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HsbThreshold_Scroll);
            // 
            // RbThreshold
            // 
            this.RbThreshold.AutoSize = true;
            this.RbThreshold.Location = new System.Drawing.Point(173, 49);
            this.RbThreshold.Name = "RbThreshold";
            this.RbThreshold.Size = new System.Drawing.Size(91, 19);
            this.RbThreshold.TabIndex = 9;
            this.RbThreshold.TabStop = true;
            this.RbThreshold.Text = "THRESHOLD";
            this.RbThreshold.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PictureStream);
            this.groupBox2.Location = new System.Drawing.Point(10, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(456, 258);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "STREAMING";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.PictureCapture);
            this.groupBox3.Location = new System.Drawing.Point(10, 267);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(456, 258);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CAPTURE";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.PictureActual);
            this.groupBox4.Location = new System.Drawing.Point(472, 267);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(456, 258);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ACTUAL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 534);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MaximumSize = new System.Drawing.Size(953, 573);
            this.MinimumSize = new System.Drawing.Size(953, 573);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImageCompare";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureStream)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureCapture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureActual)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button BtnStream;
        private PictureBox PictureStream;
        private PictureBox PictureCapture;
        private PictureBox PictureActual;
        private Button BtnLoad;
        private Button BtnCOMPARE;
        private Button BtnCAPTURE;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private HScrollBar HsbRadius;
        private RadioButton RbRadius;
        private HScrollBar HsbThreshold;
        private RadioButton RbThreshold;
    }
}