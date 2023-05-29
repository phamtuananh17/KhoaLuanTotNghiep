using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingCar_KLTN
{
    public partial class frm_ThongKe : Form
    {
        public frm_ThongKe()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frm_DoanhThu));
            if (frm != null)
                frm.Activate();
            else
            {
                frm_DoanhThu f = new frm_DoanhThu();
                f.MdiParent = this.MdiParent;
                f.Show();
            }
        }

        private Form KiemTraTonTai(Type formType)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == formType)
                    return f;
            }
            return null;
        }

        private void frm_ThongKe_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }

        private void bt_xera_Click(object sender, EventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frm_TkXe));
            if (frm != null)
                frm.Activate();
            else
            {
                frm_TkXe f = new frm_TkXe();
                f.MdiParent = this.MdiParent;
                f.Show();
            }
        }

        private void bt_xevao_Click(object sender, EventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frm_TkXe));
            if (frm != null)
                frm.Activate();
            else
            {
                frm_TkXe f = new frm_TkXe();
                f.MdiParent = this.MdiParent;
                f.Show();
            }
        }

        private void bt_hoadondv_Click(object sender, EventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frm_HoaDonDV));
            if (frm != null)
                frm.Activate();
            else
            {
                frm_HoaDonDV f = new frm_HoaDonDV();
                f.MdiParent = this.MdiParent;
                f.Show();
            }
        }
    }
}
