using computer_club.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace computer_club
{
    public partial class Form1 : Form
    {
        private ComputerClub _club;
        private List<Label> _computerLabels;
        private List<Button> _computerButtons;
        public Form1()
        {
            InitializeComponent();

            _club = new ComputerClub(11);

            InitComputerUI();
            UpdateUI();
        }
        private void InitComputerUI()
        {
            _computerLabels = new List<Label> { labelPc1, labelPc2, labelPc3};

            _computerButtons = new List<Button>{ buttonPc1, buttonPc2, buttonPc3, };

            for (int i = 0; i < _computerButtons.Count; i++)
            {
                _computerButtons[i].Tag = i;
                _computerButtons[i].Click += ComputerButton_Click;
            }
        }

        private void ComputerButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int index = (int)button.Tag;

            bool success = _club.TrySeatClient(index);

            if (!success)
                MessageBox.Show("Нельзя посадить клиента за этот компьютер");

            UpdateUI();
        }

       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonOtkaz_Click(object sender, EventArgs e)
        {
            _club.RejectClient();
            UpdateUI();
        }


        private void UpdateUI()
        {
            UpdateClientInfo();
            UpdateComputersInfo();
            UpdateBalance();
        }
        private void UpdateClientInfo()
        {
            Client client = _club.CurrentClient;

            labelClientName.Text = $"Имя: {client.Name}";
            labelClientMinutes.Text = $"Минут: {client.DesiredMinutes}";
        }


        private void UpdateComputersInfo()
        {
            for (int i = 0; i < _computerLabels.Count; i++)
            {
                Computer pc = _club.Computers[i];

                if (pc.IsTaken)
                    _computerLabels[i].Text = $"Занят ({pc.MinutesRemaining} мин)";
                else
                    _computerLabels[i].Text = $"Свободен ({pc.PricePerMinute}/мин)";
            }
        }
        private void UpdateBalance()
        {
            labelBalance.Text = $"Баланс: {_club.Money}";
        }
    }
}
