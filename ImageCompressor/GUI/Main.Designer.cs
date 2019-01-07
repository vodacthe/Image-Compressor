namespace ImageCompressor
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btn_LoadFolder = new System.Windows.Forms.Button();
            this.btn_ProcessImages = new System.Windows.Forms.Button();
            this.lbl_ProgramName = new System.Windows.Forms.Label();
            this.grB = new System.Windows.Forms.GroupBox();
            this.lbl_progess = new System.Windows.Forms.Label();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.lbl_Processing = new System.Windows.Forms.Label();
            this.lbl_info = new System.Windows.Forms.Label();
            this.grB2 = new System.Windows.Forms.GroupBox();
            this.cmb_divider = new System.Windows.Forms.ComboBox();
            this.txt_quality = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sliderQuality = new System.Windows.Forms.TrackBar();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.grB.SuspendLayout();
            this.grB2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderQuality)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_LoadFolder
            // 
            this.btn_LoadFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_LoadFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LoadFolder.ForeColor = System.Drawing.Color.Blue;
            this.btn_LoadFolder.Location = new System.Drawing.Point(9, 248);
            this.btn_LoadFolder.Margin = new System.Windows.Forms.Padding(2);
            this.btn_LoadFolder.Name = "btn_LoadFolder";
            this.btn_LoadFolder.Size = new System.Drawing.Size(100, 45);
            this.btn_LoadFolder.TabIndex = 0;
            this.btn_LoadFolder.Text = "Load from folder";
            this.btn_LoadFolder.UseVisualStyleBackColor = true;
            this.btn_LoadFolder.Click += new System.EventHandler(this.btn_LoadFolder_Click);
            // 
            // btn_ProcessImages
            // 
            this.btn_ProcessImages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ProcessImages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ProcessImages.ForeColor = System.Drawing.Color.Red;
            this.btn_ProcessImages.Location = new System.Drawing.Point(183, 248);
            this.btn_ProcessImages.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ProcessImages.Name = "btn_ProcessImages";
            this.btn_ProcessImages.Size = new System.Drawing.Size(100, 45);
            this.btn_ProcessImages.TabIndex = 1;
            this.btn_ProcessImages.Text = "Compress";
            this.btn_ProcessImages.UseVisualStyleBackColor = true;
            this.btn_ProcessImages.Click += new System.EventHandler(this.btn_ProcessImages_Click);
            // 
            // lbl_ProgramName
            // 
            this.lbl_ProgramName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ProgramName.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProgramName.Location = new System.Drawing.Point(9, 7);
            this.lbl_ProgramName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ProgramName.Name = "lbl_ProgramName";
            this.lbl_ProgramName.Size = new System.Drawing.Size(274, 32);
            this.lbl_ProgramName.TabIndex = 2;
            this.lbl_ProgramName.Text = "Image Compressor";
            this.lbl_ProgramName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grB
            // 
            this.grB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grB.Controls.Add(this.lbl_progess);
            this.grB.Controls.Add(this.progress);
            this.grB.Controls.Add(this.lbl_Processing);
            this.grB.Controls.Add(this.lbl_info);
            this.grB.Location = new System.Drawing.Point(9, 42);
            this.grB.Margin = new System.Windows.Forms.Padding(2);
            this.grB.Name = "grB";
            this.grB.Padding = new System.Windows.Forms.Padding(2);
            this.grB.Size = new System.Drawing.Size(274, 113);
            this.grB.TabIndex = 4;
            this.grB.TabStop = false;
            this.grB.Text = "Info";
            // 
            // lbl_progess
            // 
            this.lbl_progess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_progess.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_progess.Location = new System.Drawing.Point(142, 69);
            this.lbl_progess.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_progess.Name = "lbl_progess";
            this.lbl_progess.Size = new System.Drawing.Size(128, 14);
            this.lbl_progess.TabIndex = 7;
            this.lbl_progess.Text = "0 / 0";
            this.lbl_progess.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // progress
            // 
            this.progress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progress.Location = new System.Drawing.Point(7, 37);
            this.progress.Margin = new System.Windows.Forms.Padding(2);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(262, 28);
            this.progress.TabIndex = 6;
            // 
            // lbl_Processing
            // 
            this.lbl_Processing.AutoSize = true;
            this.lbl_Processing.Location = new System.Drawing.Point(4, 89);
            this.lbl_Processing.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Processing.Name = "lbl_Processing";
            this.lbl_Processing.Size = new System.Drawing.Size(112, 13);
            this.lbl_Processing.TabIndex = 5;
            this.lbl_Processing.Text = "No image to compress";
            // 
            // lbl_info
            // 
            this.lbl_info.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info.Location = new System.Drawing.Point(4, 17);
            this.lbl_info.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(265, 17);
            this.lbl_info.TabIndex = 0;
            this.lbl_info.Text = "There are 0 image(s) in folder\r\n\r\n";
            this.lbl_info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grB2
            // 
            this.grB2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grB2.Controls.Add(this.cmb_divider);
            this.grB2.Controls.Add(this.txt_quality);
            this.grB2.Controls.Add(this.label2);
            this.grB2.Controls.Add(this.label1);
            this.grB2.Controls.Add(this.sliderQuality);
            this.grB2.Location = new System.Drawing.Point(9, 160);
            this.grB2.Margin = new System.Windows.Forms.Padding(2);
            this.grB2.Name = "grB2";
            this.grB2.Padding = new System.Windows.Forms.Padding(2);
            this.grB2.Size = new System.Drawing.Size(274, 82);
            this.grB2.TabIndex = 5;
            this.grB2.TabStop = false;
            this.grB2.Text = "Options";
            // 
            // cmb_divider
            // 
            this.cmb_divider.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_divider.FormattingEnabled = true;
            this.cmb_divider.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmb_divider.Location = new System.Drawing.Point(97, 16);
            this.cmb_divider.Name = "cmb_divider";
            this.cmb_divider.Size = new System.Drawing.Size(36, 22);
            this.cmb_divider.TabIndex = 12;
            this.cmb_divider.Text = "2";
            // 
            // txt_quality
            // 
            this.txt_quality.Location = new System.Drawing.Point(237, 43);
            this.txt_quality.Name = "txt_quality";
            this.txt_quality.Size = new System.Drawing.Size(32, 20);
            this.txt_quality.TabIndex = 8;
            this.txt_quality.Text = "30";
            this.txt_quality.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_quality.TextChanged += new System.EventHandler(this.txt_quality_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Resize divided by";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Quality";
            // 
            // sliderQuality
            // 
            this.sliderQuality.Location = new System.Drawing.Point(48, 43);
            this.sliderQuality.Margin = new System.Windows.Forms.Padding(2);
            this.sliderQuality.Maximum = 100;
            this.sliderQuality.Minimum = 30;
            this.sliderQuality.Name = "sliderQuality";
            this.sliderQuality.Size = new System.Drawing.Size(184, 45);
            this.sliderQuality.TabIndex = 6;
            this.sliderQuality.Value = 30;
            this.sliderQuality.Scroll += new System.EventHandler(this.sliderQuality_Scroll);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Stop.Location = new System.Drawing.Point(113, 248);
            this.btn_Stop.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(65, 45);
            this.btn_Stop.TabIndex = 6;
            this.btn_Stop.Text = "STOP";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 300);
            this.Controls.Add(this.grB2);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.grB);
            this.Controls.Add(this.lbl_ProgramName);
            this.Controls.Add(this.btn_ProcessImages);
            this.Controls.Add(this.btn_LoadFolder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Image Compressor";
            this.grB.ResumeLayout(false);
            this.grB.PerformLayout();
            this.grB2.ResumeLayout(false);
            this.grB2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderQuality)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_LoadFolder;
        private System.Windows.Forms.Button btn_ProcessImages;
        private System.Windows.Forms.Label lbl_ProgramName;
        private System.Windows.Forms.GroupBox grB;
        private System.Windows.Forms.Label lbl_Processing;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.GroupBox grB2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar sliderQuality;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Label lbl_progess;
        private System.Windows.Forms.TextBox txt_quality;
        private System.Windows.Forms.ComboBox cmb_divider;
    }
}

