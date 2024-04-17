namespace DoAnCuoiKi_TraoDoiDo
{
    partial class FDanhGia
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
            this.PBAnh = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnGui = new Guna.UI2.WinForms.Guna2Button();
            this.txtNhanXet = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDanhGia = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2RatingStar1 = new Guna.UI2.WinForms.Guna2RatingStar();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PBAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // PBAnh
            // 
            this.PBAnh.BorderRadius = 10;
            this.PBAnh.ImageRotate = 0F;
            this.PBAnh.Location = new System.Drawing.Point(2, 3);
            this.PBAnh.Name = "PBAnh";
            this.PBAnh.Size = new System.Drawing.Size(415, 204);
            this.PBAnh.TabIndex = 11;
            this.PBAnh.TabStop = false;
            this.PBAnh.Click += new System.EventHandler(this.PBAnh_Click);
            // 
            // btnGui
            // 
            this.btnGui.BorderRadius = 10;
            this.btnGui.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGui.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGui.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGui.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGui.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnGui.ForeColor = System.Drawing.Color.White;
            this.btnGui.Location = new System.Drawing.Point(2, 561);
            this.btnGui.Name = "btnGui";
            this.btnGui.Size = new System.Drawing.Size(415, 45);
            this.btnGui.TabIndex = 10;
            this.btnGui.Text = "Gửi";
            // 
            // txtNhanXet
            // 
            this.txtNhanXet.BorderRadius = 10;
            this.txtNhanXet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNhanXet.DefaultText = "";
            this.txtNhanXet.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNhanXet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNhanXet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNhanXet.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNhanXet.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNhanXet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNhanXet.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNhanXet.Location = new System.Drawing.Point(2, 307);
            this.txtNhanXet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNhanXet.Name = "txtNhanXet";
            this.txtNhanXet.PasswordChar = '\0';
            this.txtNhanXet.PlaceholderText = "";
            this.txtNhanXet.SelectedText = "";
            this.txtNhanXet.Size = new System.Drawing.Size(415, 247);
            this.txtNhanXet.TabIndex = 9;
            // 
            // lblDanhGia
            // 
            this.lblDanhGia.BackColor = System.Drawing.Color.Transparent;
            this.lblDanhGia.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhGia.Location = new System.Drawing.Point(2, 262);
            this.lblDanhGia.Name = "lblDanhGia";
            this.lblDanhGia.Size = new System.Drawing.Size(154, 24);
            this.lblDanhGia.TabIndex = 8;
            this.lblDanhGia.Text = "Đánh giá tổng quát";
            // 
            // guna2RatingStar1
            // 
            this.guna2RatingStar1.BackColor = System.Drawing.Color.White;
            this.guna2RatingStar1.Location = new System.Drawing.Point(201, 262);
            this.guna2RatingStar1.Name = "guna2RatingStar1";
            this.guna2RatingStar1.Size = new System.Drawing.Size(202, 28);
            this.guna2RatingStar1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            // 
            // FDanhGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(423, 616);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PBAnh);
            this.Controls.Add(this.btnGui);
            this.Controls.Add(this.txtNhanXet);
            this.Controls.Add(this.lblDanhGia);
            this.Controls.Add(this.guna2RatingStar1);
            this.Name = "FDanhGia";
            this.Text = "FDanhGia";
            ((System.ComponentModel.ISupportInitialize)(this.PBAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2PictureBox PBAnh;
        private Guna.UI2.WinForms.Guna2Button btnGui;
        private Guna.UI2.WinForms.Guna2TextBox txtNhanXet;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDanhGia;
        private Guna.UI2.WinForms.Guna2RatingStar guna2RatingStar1;
        private System.Windows.Forms.Label label1;
    }
}