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
            b = Convert.ToString(Interaction.InputBox("¬вед≥ть назву виданн€", "¬веденн€", "ћоЇ ¬иданн€"));
            c = Convert.ToInt16(Interaction.InputBox("¬вед≥ть к≥льк≥сть випуск≥в на р≥к", "¬веденн€", "12"));
            a = Convert.ToDouble(Interaction.InputBox("¬вед≥ть варт≥сть п≥дписки", "¬веденн€", "140,0"));
            d = Convert.ToInt32(Interaction.InputBox("¬вед≥ть к≥льк≥сть стор≥нок", "¬веденн€", "15"));
            f = Convert.ToDouble(Interaction.InputBox("¬вед≥ть час (в секундах) необх≥дний на прочитанн€ стор≥нки", "¬веденн€", "60"));
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
            b = Convert.ToString(Interaction.InputBox("¬вед≥ть назву виданн€", "¬веденн€", "ћоЇ ¬иданн€"));
            c = Convert.ToInt16(Interaction.InputBox("¬вед≥ть к≥льк≥сть випуск≥в на р≥к", "¬веденн€", "12"));
            a = Convert.ToDouble(Interaction.InputBox("¬вед≥ть варт≥сть п≥дписки", "¬веденн€", "140,0"));
            d = Convert.ToInt32(Interaction.InputBox("¬вед≥ть к≥льк≥сть стор≥нок", "¬веденн€", "15"));
            f = Convert.ToDouble(Interaction.InputBox("¬вед≥ть час (в секундах) необх≥дний на прочитанн€ стор≥нки", "¬веденн€", "60"));
            Newspaper temp = new(a, b, c, d, f);
            temp.Info();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ѕоточна к≥льк≥сть об'Їкт≥в: " + PeriodicPublication.count);
        }
    }
}