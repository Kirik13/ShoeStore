using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoeStore
{
    public partial class Shoe_Category : Form
    {
        public Shoe_Category()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdmin admin = new MenuAdmin();
            admin.ShowDialog();
        }
    }
}
