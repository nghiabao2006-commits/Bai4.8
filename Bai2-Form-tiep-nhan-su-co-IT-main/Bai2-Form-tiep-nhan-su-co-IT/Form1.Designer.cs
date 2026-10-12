namespace Bai2_Form_tiep_nhan_su_co_IT
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
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblMaPhieu;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.Label lblNguoiYeuCau;
        private System.Windows.Forms.TextBox txtNguoiYeuCau;
        private System.Windows.Forms.Label lblNgayGhiNhan;
        private System.Windows.Forms.DateTimePicker dtpNgayGhiNhan;
        private System.Windows.Forms.GroupBox grpMucDo;
        private System.Windows.Forms.RadioButton rdoThap;
        private System.Windows.Forms.RadioButton rdoTrungBinh;
        private System.Windows.Forms.RadioButton rdoKhanCap;

        private System.Windows.Forms.GroupBox grpPhanLoai;
        private System.Windows.Forms.Label lblLoaiSuCo;
        private System.Windows.Forms.ComboBox cboLoai;
        private System.Windows.Forms.GroupBox grpThietBi;
        private System.Windows.Forms.CheckBox chkDesktop;
        private System.Windows.Forms.CheckBox chkLaptop;
        private System.Windows.Forms.CheckBox chkPrinter;
        private System.Windows.Forms.CheckBox chkPhone;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnLoadImage;

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnReset;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SuspendLayout();
            // 
            // grpThongTin
            // 
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.lblMaPhieu = new System.Windows.Forms.Label();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.lblNguoiYeuCau = new System.Windows.Forms.Label();
            this.txtNguoiYeuCau = new System.Windows.Forms.TextBox();
            this.lblNgayGhiNhan = new System.Windows.Forms.Label();
            this.dtpNgayGhiNhan = new System.Windows.Forms.DateTimePicker();
            this.grpMucDo = new System.Windows.Forms.GroupBox();
            this.rdoThap = new System.Windows.Forms.RadioButton();
            this.rdoTrungBinh = new System.Windows.Forms.RadioButton();
            this.rdoKhanCap = new System.Windows.Forms.RadioButton();

            // 
            // grpPhanLoai
            // 
            this.grpPhanLoai = new System.Windows.Forms.GroupBox();
            this.lblLoaiSuCo = new System.Windows.Forms.Label();
            this.cboLoai = new System.Windows.Forms.ComboBox();
            this.grpThietBi = new System.Windows.Forms.GroupBox();
            this.chkDesktop = new System.Windows.Forms.CheckBox();
            this.chkLaptop = new System.Windows.Forms.CheckBox();
            this.chkPrinter = new System.Windows.Forms.CheckBox();
            this.chkPhone = new System.Windows.Forms.CheckBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnLoadImage = new System.Windows.Forms.Button();

            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();

            // Form
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 420);
            this.Text = "Form Tiếp nhận sự cố IT";

            // grpThongTin
            this.grpThongTin.Text = "Thông tin phiếu";
            this.grpThongTin.Location = new System.Drawing.Point(12, 12);
            this.grpThongTin.Size = new System.Drawing.Size(360, 160);

            // lblMaPhieu
            this.lblMaPhieu.Text = "Mã phiếu:";
            this.lblMaPhieu.Location = new System.Drawing.Point(12, 25);
            this.lblMaPhieu.AutoSize = true;

            this.txtMaPhieu.Location = new System.Drawing.Point(120, 22);
            this.txtMaPhieu.Size = new System.Drawing.Size(220, 22);

            // lblNguoiYeuCau
            this.lblNguoiYeuCau.Text = "Người yêu cầu:";
            this.lblNguoiYeuCau.Location = new System.Drawing.Point(12, 58);
            this.lblNguoiYeuCau.AutoSize = true;

            this.txtNguoiYeuCau.Location = new System.Drawing.Point(120, 55);
            this.txtNguoiYeuCau.Size = new System.Drawing.Size(220, 22);

            // lblNgayGhiNhan
            this.lblNgayGhiNhan.Text = "Ngày ghi nhận:";
            this.lblNgayGhiNhan.Location = new System.Drawing.Point(12, 92);
            this.lblNgayGhiNhan.AutoSize = true;

            this.dtpNgayGhiNhan.Location = new System.Drawing.Point(120, 88);
            this.dtpNgayGhiNhan.Size = new System.Drawing.Size(220, 22);

            // grpMucDo
            this.grpMucDo.Text = "Mức độ ưu tiên";
            this.grpMucDo.Location = new System.Drawing.Point(15, 120);
            this.grpMucDo.Size = new System.Drawing.Size(325, 35);

            this.rdoThap.Text = "Thấp";
            this.rdoThap.Location = new System.Drawing.Point(6, 12);
            this.rdoTrungBinh.Text = "Trung bình";
            this.rdoTrungBinh.Location = new System.Drawing.Point(90, 12);
            this.rdoKhanCap.Text = "Khẩn cấp";
            this.rdoKhanCap.Location = new System.Drawing.Point(200, 12);

            this.rdoThap.AutoSize = true;
            this.rdoTrungBinh.AutoSize = true;
            this.rdoKhanCap.AutoSize = true;

            this.rdoThap.Checked = true;

            // add controls to grpMucDo
            this.grpMucDo.Controls.Add(this.rdoThap);
            this.grpMucDo.Controls.Add(this.rdoTrungBinh);
            this.grpMucDo.Controls.Add(this.rdoKhanCap);

            // add controls to grpThongTin
            this.grpThongTin.Controls.Add(this.lblMaPhieu);
            this.grpThongTin.Controls.Add(this.txtMaPhieu);
            this.grpThongTin.Controls.Add(this.lblNguoiYeuCau);
            this.grpThongTin.Controls.Add(this.txtNguoiYeuCau);
            this.grpThongTin.Controls.Add(this.lblNgayGhiNhan);
            this.grpThongTin.Controls.Add(this.dtpNgayGhiNhan);
            this.grpThongTin.Controls.Add(this.grpMucDo);

            // grpPhanLoai
            this.grpPhanLoai.Text = "Phân loại & Chi tiết";
            this.grpPhanLoai.Location = new System.Drawing.Point(390, 12);
            this.grpPhanLoai.Size = new System.Drawing.Size(360, 300);

            this.lblLoaiSuCo.Text = "Loại sự cố:";
            this.lblLoaiSuCo.Location = new System.Drawing.Point(12, 25);
            this.lblLoaiSuCo.AutoSize = true;

            this.cboLoai.Location = new System.Drawing.Point(110, 22);
            this.cboLoai.Size = new System.Drawing.Size(230, 24);
            this.cboLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoai.Items.AddRange(new object[] { "Phần cứng", "Phần mềm", "Mạng", "Tài khoản" });

            // grpThietBi
            this.grpThietBi.Text = "Thiết bị ảnh hưởng";
            this.grpThietBi.Location = new System.Drawing.Point(15, 60);
            this.grpThietBi.Size = new System.Drawing.Size(325, 90);

            this.chkDesktop.Text = "Máy tính bàn";
            this.chkDesktop.Location = new System.Drawing.Point(10, 22);
            this.chkLaptop.Text = "Laptop";
            this.chkLaptop.Location = new System.Drawing.Point(160, 22);
            this.chkPrinter.Text = "Máy in";
            this.chkPrinter.Location = new System.Drawing.Point(10, 50);
            this.chkPhone.Text = "Điện thoại";
            this.chkPhone.Location = new System.Drawing.Point(160, 50);

            this.chkDesktop.AutoSize = true;
            this.chkLaptop.AutoSize = true;
            this.chkPrinter.AutoSize = true;
            this.chkPhone.AutoSize = true;

            this.grpThietBi.Controls.Add(this.chkDesktop);
            this.grpThietBi.Controls.Add(this.chkLaptop);
            this.grpThietBi.Controls.Add(this.chkPrinter);
            this.grpThietBi.Controls.Add(this.chkPhone);

            // PictureBox
            this.pbImage.Location = new System.Drawing.Point(15, 160);
            this.pbImage.Size = new System.Drawing.Size(200, 120);
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            this.btnLoadImage.Text = "Tải ảnh lỗi";
            this.btnLoadImage.Location = new System.Drawing.Point(230, 200);
            this.btnLoadImage.Size = new System.Drawing.Size(110, 30);
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);

            // add to grpPhanLoai
            this.grpPhanLoai.Controls.Add(this.lblLoaiSuCo);
            this.grpPhanLoai.Controls.Add(this.cboLoai);
            this.grpPhanLoai.Controls.Add(this.grpThietBi);
            this.grpPhanLoai.Controls.Add(this.pbImage);
            this.grpPhanLoai.Controls.Add(this.btnLoadImage);

            // Buttons
            this.btnSubmit.Text = "Gửi yêu cầu";
            this.btnSubmit.Location = new System.Drawing.Point(480, 330);
            this.btnSubmit.Size = new System.Drawing.Size(120, 35);
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);

            this.btnReset.Text = "Nhập lại";
            this.btnReset.Location = new System.Drawing.Point(620, 330);
            this.btnReset.Size = new System.Drawing.Size(120, 35);
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);

            // add controls to form
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.grpPhanLoai);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnReset);

            this.ResumeLayout(false);
        }

        #endregion
    }
}

