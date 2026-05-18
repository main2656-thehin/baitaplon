using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class fHoaDon : Form
    {
        // Khai báo biến toàn cục giống như bên C++
        string apiURL = "https://6a001ec82b7ab349603014ae.mockapi.io/hoaDon";
        HttpClient client = new HttpClient();

        public fHoaDon()
        {
            InitializeComponent();

            // Đăng ký sự kiện đổi món bằng if-else truyền thống
            cbMaHang.SelectedIndexChanged += new EventHandler(cbMaHang_SelectedIndexChanged);
        }

        private void cbMaHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Xử lý bằng chuỗi if-else cơ bản
            if (cbMaHang.Text == "Cafe Đen") txtDonGia.Text = "25000";
            else if (cbMaHang.Text == "Cafe Sữa") txtDonGia.Text = "30000";
            else if (cbMaHang.Text == "Bạc Xỉu") txtDonGia.Text = "35000";
            else if (cbMaHang.Text == "Trà Đào Cam Sả") txtDonGia.Text = "40000";
            else if (cbMaHang.Text == "Trà Thạch Vải") txtDonGia.Text = "45000";
        }

        private void fHoaDon_Load(object sender, EventArgs e)
        {
            LoadData(); // Gọi hàm bình thường không có await
        }

        // Hàm tải dữ liệu chạy đồng bộ (giống hàm void trong C++)
        private void LoadData()
        {
            try
            {
                // Dùng .Result để ép chạy tuần tự giống C++ chứ không chạy bất đồng bộ
                string res = client.GetStringAsync(apiURL).Result;

                // Giải mã JSON thành một List (giống như std::vector bên C++)
                List<HoaDonDTO> ds = JsonConvert.DeserializeObject<List<HoaDonDTO>>(res);

                dgvData.DataSource = null;
                if (ds != null)
                {
                    dgvData.DataSource = ds;
                    if (dgvData.Columns["id"] != null) dgvData.Columns["id"].Visible = false;

                    // ---------------------------------------------------------------------
                    // CHỈ ĐỔI DUY NHẤT CHỮ "maHang" THÀNH CHỮ "Tên món" TRÊN LƯỚI HIỂN THỊ
                    // ---------------------------------------------------------------------
                    if (dgvData.Columns["maHang"] != null) dgvData.Columns["maHang"].HeaderText = "tenMon";
                    // ---------------------------------------------------------------------

                    // TÍNH TỔNG TIỀN: Dùng vòng lặp for chạy chỉ số i cực kỳ "C++"
                    double tong = 0;
                    for (int i = 0; i < ds.Count; i++)
                    {
                        double dg = 0;
                        int sl = 0;

                        // Ép kiểu thủ công
                        double.TryParse(ds[i].donGia, out dg);
                        int.TryParse(ds[i].soLuong, out sl);

                        if (sl <= 0) sl = 1; // Mặc định nếu lỗi số lượng

                        tong = tong + (dg * sl); // Công thức cộng dồn quen thuộc
                    }

                    txtTongTien.Text = tong.ToString("N0") + " VNĐ";
                }
            }
            catch (Exception ex)
            {
                txtTongTien.Text = "0";
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo lỗi");
            }
        }

        // Nút Thêm hóa đơn
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Bắt ngoại lệ bằng cụm if-else kiểm tra điều kiện (Validation kiểu nhập môn)
            if (cbMaHang.Text == "")
            {
                MessageBox.Show("Vui lòng chọn món!", "Thông báo");
                return;
            }

            if (txtDonGia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đơn giá!", "Thông báo");
                return;
            }

            if (textBox1.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số lượng!", "Thông báo");
                return;
            }

            try
            {
                // Kiểm tra xem số lượng có phải là số dương không
                int sl = Convert.ToInt32(textBox1.Text);
                if (sl <= 0)
                {
                    MessageBox.Show("Số lượng phải lớn hơn 0!", "Thông báo");
                    return;
                }

                // Tự sinh mã hóa đơn bằng chuỗi thời gian (giống hàm sinh số ngẫu nhiên/time bên C++)
                string maTuDong = "HD" + DateTime.Now.ToString("yyyyMMddHHmmss");

                // Tạo đối tượng struct/class để lưu dữ liệu
                HoaDonDTO hd = new HoaDonDTO();
                hd.maHoaDon = maTuDong;
                hd.maHang = cbMaHang.Text;
                hd.donGia = txtDonGia.Text;
                hd.soLuong = textBox1.Text;
                hd.ghiChu = txtGhiChu.Text;

                string json = JsonConvert.SerializeObject(hd);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                // Gửi dữ liệu lên API và đợi kết quả (.Result)
                HttpResponseMessage response = client.PostAsync(apiURL, content).Result;

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Thêm thành công! Mã HD: " + maTuDong);
                    LoadData(); // Tải lại bảng

                    // Xóa trắng các ô nhập liệu bằng hàm Clear() hoặc gán chuỗi rỗng
                    txtDonGia.Text = "";
                    textBox1.Text = "";
                    txtGhiChu.Text = "";
                    cbMaHang.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng kiểm tra lại định dạng số lượng hoặc đơn giá!", "Lỗi nhập liệu");
            }
        }

        // Nút Xóa hóa đơn
        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng có chọn dòng nào không
            if (dgvData.CurrentRow == null)
            {
                MessageBox.Show("Hãy chọn 1 dòng để xóa!");
                return;
            }

            // Hỏi xác nhận (Yes/No)
            DialogResult chon = MessageBox.Show("Bạn có muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (chon == DialogResult.No)
            {
                return;
            }

            try
            {
                // Lấy ID ở dòng hiện tại
                string id = dgvData.CurrentRow.Cells["id"].Value.ToString();

                // Gọi API xóa và đợi phản hồi (.Result)
                HttpResponseMessage response = client.DeleteAsync(apiURL + "/" + id).Result;

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadData(); // Tính toán và tải lại bảng
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message);
            }
        }

        // Nút Tính / Tải lại
        private void btnTinh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        // Nút Đóng
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Click vào DataGridView đổ ngược lên các TextBox
        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có bấm trúng dòng tiêu đề không (e.RowIndex == -1)
            if (e.RowIndex >= 0)
            {
                // Ép kiểu sang chuỗi, nếu null thì gán chuỗi rỗng "" giống toán tử điều kiện bên C++
                cbMaHang.Text = dgvData.Rows[e.RowIndex].Cells["maHang"].Value != null ? dgvData.Rows[e.RowIndex].Cells["maHang"].Value.ToString() : "";
                txtDonGia.Text = dgvData.Rows[e.RowIndex].Cells["donGia"].Value != null ? dgvData.Rows[e.RowIndex].Cells["donGia"].Value.ToString() : "";
                textBox1.Text = dgvData.Rows[e.RowIndex].Cells["soLuong"].Value != null ? dgvData.Rows[e.RowIndex].Cells["soLuong"].Value.ToString() : "1";
                txtGhiChu.Text = dgvData.Rows[e.RowIndex].Cells["ghiChu"].Value != null ? dgvData.Rows[e.RowIndex].Cells["ghiChu"].Value.ToString() : "";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }

    // Class chứa thuộc tính dạng get; set; cơ bản để hứng dữ liệu JSON
    public class HoaDonDTO
    {
        public string id { get; set; }
        public string maHoaDon { get; set; }
        public string maHang { get; set; }
        public string donGia { get; set; }
        public string soLuong { get; set; }
        public string ghiChu { get; set; }
    }
}
