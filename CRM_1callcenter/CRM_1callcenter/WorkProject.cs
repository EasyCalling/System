using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_1callcenter
{
    public partial class WorkProject : Form
    {
        public WorkProject()
        {
            InitializeComponent();
        }

        private void закончитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Вы уверены, что хотите закончить работу?",
                "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                MainForm MF = new MainForm();
                MF.Visible = true;
                Visible = false;
            }
            else if (dialog == DialogResult.No)
            {

            }
        }
    }
}
