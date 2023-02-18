using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoCaro
{
    public partial class BanDiem : Form
    {
        public BanDiem()
        {
            InitializeComponent();
        }

        private void BanDiem_Load(object sender, EventArgs e)
        {

        }

        private void BanDiem_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'banDiemCoCaroDataSet2.DiemCoCaro' table. You can move, or remove it, as needed.
            this.diemCoCaroTableAdapter2.Fill(this.banDiemCoCaroDataSet2.DiemCoCaro);

        }
    }
}
