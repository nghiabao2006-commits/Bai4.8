using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4._6
{
    public partial class FormProduct : Form
    {
        private BindingList<ProductItem> products;

        public event Action<string> StatusMessageChanged;

        public FormProduct()
        {
            InitializeComponent();

            products = new BindingList<ProductItem>
            {
                new ProductItem { ProductId = "SP001", ProductName = "Bàn phím", UnitPrice = 250000, Quantity = 10 },
                new ProductItem { ProductId = "SP002", ProductName = "Chuột", UnitPrice = 180000, Quantity = 15 }
            };
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            dgvProducts.AutoGenerateColumns = true;
            dgvProducts.DataSource = products;
            NotifyStatus("Đã mở chức năng Quản lý Sản phẩm.");
        }

        private async void btnLoadProducts_Click(object sender, EventArgs e)
        {
            btnLoadProducts.Enabled = false;
            progressProducts.Value = 0;
            lblProductProgress.Text = "0%";
            NotifyStatus("Đang nạp dữ liệu sản phẩm... 0%");

            var progress = new Progress<int>(percent =>
            {
                progressProducts.Value = percent;
                lblProductProgress.Text = percent + "%";
                NotifyStatus("Đang nạp dữ liệu sản phẩm... " + percent + "%");
            });

            try
            {
                var loadedProducts = await LoadProductsAsync(progress);
                products = new BindingList<ProductItem>(loadedProducts);
                dgvProducts.DataSource = products;

                MessageBox.Show("Nạp dữ liệu sản phẩm hoàn tất.", "Async/Await", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NotifyStatus("Nạp dữ liệu sản phẩm hoàn tất.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nạp dữ liệu sản phẩm thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NotifyStatus("Nạp dữ liệu sản phẩm thất bại.");
            }
            finally
            {
                btnLoadProducts.Enabled = true;
            }
        }

        private Task<List<ProductItem>> LoadProductsAsync(IProgress<int> progress)
        {
            return Task.Run(() =>
            {
                var result = new List<ProductItem>();

                for (int i = 1; i <= 100; i++)
                {
                    Thread.Sleep(35);
                    result.Add(new ProductItem
                    {
                        ProductId = "SP" + i.ToString("000"),
                        ProductName = "Sản phẩm " + i,
                        UnitPrice = 100000 + (i * 2500),
                        Quantity = 5 + (i % 30)
                    });

                    if (progress != null)
                    {
                        progress.Report(i);
                    }
                }

                return result;
            });
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            products.Add(new ProductItem
            {
                ProductId = txtProductId.Text,
                ProductName = txtProductName.Text,
                UnitPrice = numericPrice.Value,
                Quantity = (int)numericQuantity.Value
            });
            NotifyStatus("Đã thêm sản phẩm: " + txtProductName.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null) return;

            var product = dgvProducts.CurrentRow.DataBoundItem as ProductItem;
            if (product == null) return;

            products.Remove(product);
            NotifyStatus("Đã xóa sản phẩm: " + product.ProductName);
        }

        private void NotifyStatus(string message)
        {
            if (StatusMessageChanged != null)
            {
                StatusMessageChanged(message);
            }
        }
    }

    public class ProductItem
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
}
