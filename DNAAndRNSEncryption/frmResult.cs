using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DNAAndRNSEncryption
{
    public partial class frmResult : Form
    {
        public List<DNAAndRNSEncryption.frmMain.RNSPic> Pic { get; set; }
        public frmResult()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            gridEXExporter1.Export(new FileStream("D:\\test.xls", FileMode.CreateNew));
        }

        private void frmResult_Load(object sender, EventArgs e)
        {
            grdCordinateRGBAlpha.DataSource = Pic;
        }
    }
}
