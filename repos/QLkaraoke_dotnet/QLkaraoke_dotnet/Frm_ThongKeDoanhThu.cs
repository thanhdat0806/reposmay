using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DoAn_QL_Karaoke
{
    public partial class Frm_ThongKeDoanhThu : Form
    {
        XyLyDatabase db = new XyLyDatabase();
        DataTable dtDoanhThu;
       // string ketnoi = ;
        SqlConnection connect = new SqlConnection(@"Data Source = MSI\SQLEXPRESS; Initial catalog=DB_QLKaraoke; integrated security=true;");
        public Frm_ThongKeDoanhThu()
        {
            InitializeComponent();
        }

        private void Frm_ThongKeDoanhThu_Load(object sender, EventArgs e)
        {
        }

        private void btn_DT_Click(object sender, EventArgs e)
        {

            String NgayCuoi = dpk_ngaycuoi.Value.ToString("yyyy-MM-dd");
            String NgayDau = dpk_ngaydau.Value.ToString("yyyy-MM-dd");
            showDoanhThu(NgayDau, NgayCuoi);



        }
        public void showDoanhThu(string ngaybd,String ngaykt)
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            dataGridView2.AutoGenerateColumns = false;
            dtDoanhThu = db.LayDuLieu(String.Format(@"select sum(TongTien) as tongtien,TGThanhToan from HOADON where TGThanhToan <= '{0}' and TGThanhToan >= '{1}' group by TGThanhToan", ngaykt, ngaybd));
            dataGridView2.DataSource = dtDoanhThu;
            dataGridView2.Columns[1].DataPropertyName = "tongtien";
            dataGridView2.Columns[0].DataPropertyName = "TGThanhToan";
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(String.Format(@"select sum(TongTien) as tongtien,TGThanhToan from HOADON where TGThanhToan <= '{0}' and TGThanhToan >= '{1}' group by TGThanhToan", ngaykt, ngaybd), connect);
                connect.Open();
                da.Fill(dt);
                connect.Close();
                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Ngày";
                chart1.ChartAreas["ChartArea1"].AxisY.Title = "Nghìn Đồng";
                chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    chart1.Series["Tong"].Points.AddXY(dt.Rows[i]["TGThanhToan"].ToString().Substring(0, 9), dt.Rows[i]["TongTien"]);
                }
                chart1.Series["Tong"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            }
            catch (Exception)
            {
                MessageBox.Show("OK");

            }
        }
    }
}
