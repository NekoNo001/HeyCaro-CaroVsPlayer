using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace CoCaro
{
    public partial class from1 : Form
    {
        #region Properties
        private SqlConnection conn;
        private SqlCommand commd;
        private string sqlstr;
        private int lanchoi;
        ChessBoardsetup banco;
        #endregion
        public from1()
        {
            InitializeComponent();

            banco = new ChessBoardsetup(pnlbanco, txtplayername, htmark, txtscore1, txtscore2);

            newgame();
        }

        void newgame()
        {
            banco.resetscore();
            banco.vebanco();

        }

        void Quit()
        {
            Application.Exit();
        }


        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newgame();

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quit();
        }

        private void from1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)

                e.Cancel = true;
        }

        private void from1_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection("Server = DESKTOP-VGDTGBM\\ONMYPC;Initial Catalog=BanDiemCoCaro;Trusted_Connection=True  ;");
                commd = new SqlCommand("Select * From DiemCoCaro", conn);
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void bảngĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BanDiem frmbandiem = new BanDiem();
            frmbandiem.Show();
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                commd = new SqlCommand("Select max(Lan_Choi) from DiemCoCaro", conn);
                try
                {
                    lanchoi = Convert.ToInt32(commd.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    lanchoi = 0;
                }
                lanchoi++;
                sqlstr = "Insert into DiemCoCaRo Values (" + lanchoi.ToString()+",'" + txtscore1.Text +" Diem','"+txtscore2.Text+ " Diem')";
                MessageBox.Show(sqlstr);
                commd = new SqlCommand(sqlstr, conn);
                commd.ExecuteNonQuery();
                MessageBox.Show("Đã thêm vào cơ sơ dữ liệu, chọn bảng điểm đễ xem","thêm điểm thành công",MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
