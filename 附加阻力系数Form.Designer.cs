namespace 平移电机功率计算
{
    partial class 附加阻力系数Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(附加阻力系数Form));
            this.btn_关闭 = new System.Windows.Forms.Button();
            this.pictureBox_轴承系数 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_轴承系数)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_关闭
            // 
            this.btn_关闭.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_关闭.BackColor = System.Drawing.Color.Salmon;
            this.btn_关闭.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_关闭.Location = new System.Drawing.Point(489, 0);
            this.btn_关闭.Name = "btn_关闭";
            this.btn_关闭.Size = new System.Drawing.Size(30, 23);
            this.btn_关闭.TabIndex = 7;
            this.btn_关闭.Text = "X";
            this.btn_关闭.UseVisualStyleBackColor = false;
            this.btn_关闭.Click += new System.EventHandler(this.btn_关闭_Click);
            // 
            // pictureBox_轴承系数
            // 
            this.pictureBox_轴承系数.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_轴承系数.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_轴承系数.Image")));
            this.pictureBox_轴承系数.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_轴承系数.Name = "pictureBox_轴承系数";
            this.pictureBox_轴承系数.Size = new System.Drawing.Size(519, 157);
            this.pictureBox_轴承系数.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_轴承系数.TabIndex = 6;
            this.pictureBox_轴承系数.TabStop = false;
            // 
            // 附加阻力系数Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 157);
            this.Controls.Add(this.btn_关闭);
            this.Controls.Add(this.pictureBox_轴承系数);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "附加阻力系数Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "附加阻力系数Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_轴承系数)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_关闭;
        private System.Windows.Forms.PictureBox pictureBox_轴承系数;
    }
}