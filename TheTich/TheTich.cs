using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TheTich
{
    public partial class TheTich : DevExpress.XtraEditors.XtraForm
    {
        Dictionary<int, string> dv;

        public TheTich()
        {
            InitializeComponent();
            dv = new Dictionary<int, string>();
          
            dv.Add(1, "cm");
            dv.Add(2, "dm");
            dv.Add(3, "m");
            foreach(var donvi in dv.Values)
            {
                cbx_DonVi.Items.Add(donvi);
            }

        }

       
        

      

        private void btn_TheTich_Click(object sender, EventArgs e)
        {
            String dvtt=null;
                dvtt = cbx_DonVi.SelectedItem.ToString();
            
            
            
            
            double chieudai = double.Parse(txt_ChieuDai.Text);
            double chieurong = double.Parse(txt_ChieuRong.Text);
            double chieucao = double.Parse(txt_ChieuCao.Text);
            double thetich = chieudai * chieurong * chieucao;
            txt_TheTich.Text = thetich.ToString() + " "+dvtt + "3";
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
