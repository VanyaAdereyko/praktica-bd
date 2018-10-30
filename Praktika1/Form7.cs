using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktika1
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "practikaDataSet1.Молодой1". При необходимости она может быть перемещена или удалена.
            this.молодой1TableAdapter.Fill(this.practikaDataSet1.Молодой1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = молодой1BindingSource;
        }
    }
}
