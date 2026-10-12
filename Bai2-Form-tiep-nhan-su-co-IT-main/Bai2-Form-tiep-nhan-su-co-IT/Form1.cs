using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Bai2_Form_tiep_nhan_su_co_IT
{
    public partial class Form1 : Form
    {
        private string imagePath;

        public Form1()
        {
            InitializeComponent();
            this.dtpNgayGhiNhan.Value = DateTime.Now;
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png";
                dlg.Title = "Chọn ảnh lỗi";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // load image and store path
                        Image img = Image.FromFile(dlg.FileName);
                        this.pbImage.Image = img;
                        this.imagePath = dlg.FileName;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể tải ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("=== Tóm tắt yêu cầu ===");
            sb.AppendLine($"Mã phiếu: {this.txtMaPhieu.Text}");
            sb.AppendLine($"Người yêu cầu: {this.txtNguoiYeuCau.Text}");
            sb.AppendLine($"Ngày ghi nhận: {this.dtpNgayGhiNhan.Value:yyyy-MM-dd}");

            string mucdo = this.rdoThap.Checked ? "Thấp" : this.rdoTrungBinh.Checked ? "Trung bình" : "Khẩn cấp";
            sb.AppendLine($"Mức độ ưu tiên: {mucdo}");

            string loai = this.cboLoai.SelectedItem != null ? this.cboLoai.SelectedItem.ToString() : "(chưa chọn)";
            sb.AppendLine($"Loại sự cố: {loai}");

            var devices = new StringBuilder();
            if (this.chkDesktop.Checked) devices.Append("Máy tính bàn, ");
            if (this.chkLaptop.Checked) devices.Append("Laptop, ");
            if (this.chkPrinter.Checked) devices.Append("Máy in, ");
            if (this.chkPhone.Checked) devices.Append("Điện thoại, ");
            string devs = devices.Length > 0 ? devices.ToString().TrimEnd(' ', ',') : "(không khai báo)";
            sb.AppendLine($"Thiết bị ảnh hưởng: {devs}");

            sb.AppendLine($"Ảnh lỗi đính kèm: {(string.IsNullOrEmpty(this.imagePath) ? "(không có)" : this.imagePath)}");

            MessageBox.Show(sb.ToString(), "Tóm tắt yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txtMaPhieu.Text = string.Empty;
            this.txtNguoiYeuCau.Text = string.Empty;
            this.dtpNgayGhiNhan.Value = DateTime.Now;
            this.rdoThap.Checked = true;
            this.cboLoai.SelectedIndex = -1;
            this.chkDesktop.Checked = false;
            this.chkLaptop.Checked = false;
            this.chkPrinter.Checked = false;
            this.chkPhone.Checked = false;
            if (this.pbImage.Image != null)
            {
                this.pbImage.Image.Dispose();
                this.pbImage.Image = null;
            }
            this.imagePath = null;
        }
    }
}
