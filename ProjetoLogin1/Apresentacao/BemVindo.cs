using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLogin1.Apresentacao
{
    public partial class BemVindo : Form
    {
        public BemVindo()
        {
            InitializeComponent();
        }

        private void lblBemVindo_Click(object sender, EventArgs e)
        {

        }

        private void lblEncerrarSistema_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
