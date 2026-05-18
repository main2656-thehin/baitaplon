using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class Form1 : Form
    {
        // THAY LINK MOCKAPI CỦA BẠN VÀO ĐÂY
        private string apiURL = "https://6a001ec82b7ab349603014ae.mockapi.io/hoaDon";
        private HttpClient client = new HttpClient();

        public Form1()
        {
            InitializeComponent();
            // Tự động điền đơn giá khi chọn món
            cbMaHang.SelectedIndexChanged += (s, e) => {
                if (cbMaHang.Text == "Cafe Đen") txtDonGia.Text = "25000";
                else if (cbMaHang.Text == "Cafe Sữa") txtDonGia.Text = "30000";
                else if (cbMaHang.Text == "Bạc Xỉu") txtDonGia.Text = "35000";
                else if (cbMaHang.Text == "Trà Đào Cam Sả") txtDonGia.Text = "40000";
                else if (cbMaHang.Text == "Trà Thạch Vải") txtDonGia.Text = "45000";
            };
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await LoadData();
        }

        // 1. Hàm tải dữ liệu và tính tổng tiền
        private async Task LoadData()
        {
            try
            {
                string res = await client.GetStringAsync(apiURL);
                var ds = JsonConvert.DeserializeObject<List<HoaDonDTO>>(res);

                dgvData.DataSource = null;
                if (ds != null)
                {
                    dgvData.DataSource = ds;
                    if (dgvData.Columns["id"] != null) dgvData.Columns["id"].Visible = false;

                    // Tính tổng tất cả các đơn hàng có trong danh sách
                    double tong = ds.Sum(x => {
                        double.TryParse(x.donGia, out double dg);
                        return dg;
                    });
                    txtTongTien.Text = tong.ToString("N0");
                }
            }
            catch { txtTongTien.Text = "0"; }
        }

        // 2. Nút Thêm - Đảm bảo hiện ngay xuống bảng
        private async void btnThem_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra đầu vào (Mai nhớ kiểm tra cả ô ghi chú nhé)
            if (string.IsNullOrEmpty(txtMaHD.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã hóa đơn!");
                return;
            }

            // 2. Tạo đối tượng bao gồm cả Ghi chú
            var hd = new HoaDonDTO
            {
                maHoaDon = txtMaHD.Text,
                maHang = cbMaHang.Text,
                donGia = txtDonGia.Text,
                ghiChu = txtGhiChu.Text // Lấy dữ liệu từ ô Ghi chú của Mai
            };

            var json = JsonConvert.SerializeObject(hd);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync(apiURL, content);

            if (response.IsSuccessStatusCode)
            {
                await LoadData(); // Tải lại bảng để thấy dòng mới và tính lại tổng tiền

                // Xóa sạch các ô nhập sau khi thêm thành công
                txtMaHD.Clear();
                txtDonGia.Clear();
                txtGhiChu.Clear();
                cbMaHang.SelectedIndex = -1;

                MessageBox.Show("Đã thêm thành công hóa đơn có ghi chú!");
            }
            else
            {
                MessageBox.Show("Lỗi kết nối API!");
            }
        }
        // 3. Nút Xóa - Xóa dòng đang chọn trên bảng
        private async void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvData.CurrentRow != null)
            {
                string id = dgvData.CurrentRow.Cells["id"].Value.ToString();
                var response = await client.DeleteAsync(apiURL + "/" + id);

                if (response.IsSuccessStatusCode)
                {
                    await LoadData(); // Tải lại bảng để cập nhật tổng tiền
                    MessageBox.Show("Đã xóa!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!");
            }
        }

        // 4. Nút Tính - Bấm vào để làm mới bảng và tính lại tổng
        private async void btnTinh_Click(object sender, EventArgs e)
        {
            await LoadData();
        }

        private void btnDong_Click(object sender, EventArgs e) => this.Close();


        // Click vào bảng để hiện ngược lên các ô nhập
        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaHD.Text = dgvData.Rows[e.RowIndex].Cells["maHoaDon"].Value?.ToString();
                cbMaHang.Text = dgvData.Rows[e.RowIndex].Cells["maHang"].Value?.ToString();
                txtDonGia.Text = dgvData.Rows[e.RowIndex].Cells["donGia"].Value?.ToString();
            }
        }

        // Các hàm trống để tránh lỗi Designer
        private void dtpNgayBan_ValueChanged(object sender, EventArgs e) { }
        private void lblMaHang_Click(object sender, EventArgs e) { }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

    // Lớp chứa dữ liệu (Phải khớp chính xác tên trên MockAPI)
    public class HoaDonDTO
    {
        public string id { get; set; }
        public string maHoaDon { get; set; }
        public string maHang { get; set; }
        public string donGia { get; set; }
        public string ghiChu { get; set; }
    }
}