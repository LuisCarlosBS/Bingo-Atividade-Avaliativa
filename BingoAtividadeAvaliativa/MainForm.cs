using System;
using System.Windows.Forms;
using BingoAtividadeAvaliativa.Entities;

namespace BingoAtividadeAvaliativa
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            var business = new BingoBusiness();
            dataGridViewCard.DataSource = business.GenerateBingoCard(5);
        }
    }
}