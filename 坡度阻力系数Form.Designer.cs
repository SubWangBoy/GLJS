namespace 平移电机功率计算
{
    partial class 坡度阻力系数Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(坡度阻力系数Form));
            this.btn_关闭 = new System.Windows.Forms.Button();
            this.pictureBox_摩擦力臂 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_摩擦力臂)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_关闭
            // 
            this.btn_关闭.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_关闭.BackColor = System.Drawing.Color.Salmon;
            this.btn_关闭.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_关闭.Location = new System.Drawing.Point(468, 0);
            this.btn_关闭.Name = "btn_关闭";
            this.btn_关闭.Size = new System.Drawing.Size(30, 23);
            this.btn_关闭.TabIndex = 5;
            this.btn_关闭.Text = "X";
            this.btn_关闭.UseVisualStyleBackColor = false;
            this.btn_关闭.Click += new System.EventHandler(this.btn_关闭_Click);
            // 
            // pictureBox_摩擦力臂
            // 
            this.pictureBox_摩擦力臂.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_摩擦力臂.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_摩擦力臂.Image")));
            this.pictureBox_摩擦力臂.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_摩擦力臂.Name = "pictureBox_摩擦力臂";
            this.pictureBox_摩擦力臂.Size = new System.Drawing.Size(498, 291);
            this.pictureBox_摩擦力臂.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_摩擦力臂.TabIndex = 4;
            this.pictureBox_摩擦力臂.TabStop = false;
            // 
            // 坡度阻力系数Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 291);
            this.Controls.Add(this.btn_关闭);
            this.Controls.Add(this.pictureBox_摩擦力臂);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "坡度阻力系数Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "坡度阻力系数Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_摩擦力臂)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_关闭;
        private System.Windows.Forms.PictureBox pictureBox_摩擦力臂;
    }
}