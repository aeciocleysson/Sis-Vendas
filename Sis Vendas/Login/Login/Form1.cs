using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection conecta = null;
        MySqlCommand comando = null;
        string conexao = "SERVER=192.168.25.2; DATABASE=vendas_mega; UID=root; PWD=3103";
        private void btn_ok_Click(object sender, EventArgs e)
        {
          


        }
    }
}
