using Microsoft.VisualBasic;

namespace Lab_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            _ = new PeriodicPublication();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            double a;
            string b;
            int c;
            int d;
            double f;
            b = Convert.ToString(Interaction.InputBox("������ ����� �������", "��������", "�� �������"));
            c = Convert.ToInt16(Interaction.InputBox("������ ������� ������� �� ��", "��������", "12"));
            a = Convert.ToDouble(Interaction.InputBox("������ ������� �������", "��������", "140,0"));
            d = Convert.ToInt32(Interaction.InputBox("������ ������� �������", "��������", "15"));
            f = Convert.ToDouble(Interaction.InputBox("������ ��� (� ��������) ���������� �� ���������� �������", "��������", "60"));
            Magazine second = new(a, b, c, d, f);
            second.Info();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Magazine temp = new();
            temp.Info();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Newspaper temp = new();
            temp.Info();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            double a;
            string b;
            int c;
            int d;
            double f;
            b = Convert.ToString(Interaction.InputBox("������ ����� �������", "��������", "�� �������"));
            c = Convert.ToInt16(Interaction.InputBox("������ ������� ������� �� ��", "��������", "12"));
            a = Convert.ToDouble(Interaction.InputBox("������ ������� �������", "��������", "140,0"));
            d = Convert.ToInt32(Interaction.InputBox("������ ������� �������", "��������", "15"));
            f = Convert.ToDouble(Interaction.InputBox("������ ��� (� ��������) ���������� �� ���������� �������", "��������", "60"));
            Newspaper temp = new(a, b, c, d, f);
            temp.Info();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("������� ������� ��'����: " + PeriodicPublication.count);
        }
    }
}