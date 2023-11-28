using System.Dynamic;

namespace Lab_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Font = new Font("Consolas", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(287, 32);
            button2.Name = "button2";
            button2.Size = new Size(196, 60);
            button2.TabIndex = 1;
            button2.Text = "Видання за замовчуванням";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Consolas", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(415, 129);
            button1.Name = "button1";
            button1.Size = new Size(196, 60);
            button1.TabIndex = 2;
            button1.Text = "Визначений журнал";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button3_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Consolas", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            button3.Location = new Point(169, 129);
            button3.Name = "button3";
            button3.Size = new Size(196, 60);
            button3.TabIndex = 3;
            button3.Text = "Журнал за замовчуванням";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Button4_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Consolas", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            button4.Location = new Point(415, 209);
            button4.Name = "button4";
            button4.Size = new Size(196, 60);
            button4.TabIndex = 4;
            button4.Text = "Визначена газета";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // button5
            // 
            button5.Font = new Font("Consolas", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            button5.Location = new Point(169, 209);
            button5.Name = "button5";
            button5.Size = new Size(196, 60);
            button5.TabIndex = 5;
            button5.Text = "Газета за замовчуванням";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Consolas", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            button6.Location = new Point(287, 301);
            button6.Name = "button6";
            button6.Size = new Size(196, 60);
            button6.TabIndex = 6;
            button6.Text = "Кількість об'єктів";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Consolas", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            button7.Location = new Point(287, 378);
            button7.Name = "button7";
            button7.Size = new Size(196, 60);
            button7.TabIndex = 7;
            button7.Text = "Закінчити роботу";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        class PeriodicPublication
        {
            public double subPrice;
            public string title;
            public int numberOfIssuesPerYear;
            public static int count = 0;
            public int nomer;
            public PeriodicPublication(double price, string title, int numberOfIssuesPerYear)
            {
                this.subPrice = price;
                this.title = title;
                this.numberOfIssuesPerYear = numberOfIssuesPerYear;
                count++;
                nomer = count;
                this.Info();
            }
            public PeriodicPublication()
            {
                this.title = "------";
                this.numberOfIssuesPerYear = 12;
                this.subPrice = 0.0;
                count++;
                nomer = count;
                this.Info();
            }
            public double AnnualCost()
            {
                return subPrice * numberOfIssuesPerYear;
            }
            public double AverageIssueCost()
            {
                if (numberOfIssuesPerYear != 0)
                {
                    return subPrice / numberOfIssuesPerYear;
                }
                else return 0.0;
            }
            public virtual void Info()
            {
                MessageBox.Show("Інформація про видання:\n\nНазва видання:                        " + title.ToString() + "\n\nКількість випусків на рік:       " +
                    numberOfIssuesPerYear.ToString() + "шт\n\nВартість підписки:                   " + subPrice.ToString() + "грн", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ~PeriodicPublication()
            {
                count--;
                MessageBox.Show($"Об'єкт з номером {nomer} знищено.", "Деструктор", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        class Magazine : PeriodicPublication
        {
            public int pages;
            public double pageReadTime;
            public Magazine(double price, string title, int numberOfIssuesPerYear, int pages, double pageReadTime) : base(price, title, numberOfIssuesPerYear)
            {
                this.pageReadTime = pageReadTime;
                this.pages = pages;
            }
            public Magazine() : base()
            {
                this.pages = 1;
                this.pageReadTime = 10;
            }
            public double ReadTime()
            {
                return pages * pageReadTime;
            }
            public double CostPerPage()
            {
                return subPrice / pages;
            }
            public override void Info()
            {
                MessageBox.Show("Інформація про видання:\n\nНазва журналу:                           " + title.ToString() + "\n\nКількість випусків на рік:          " +
                                   numberOfIssuesPerYear.ToString() + "шт\n\nВартість підписки:                      " + subPrice.ToString() +
                                   "грн\n\nКількість сторінок:                      " + pages.ToString() + "шт\n\nШвидкість читання сторінки:   " + 
                                   pageReadTime.ToString() + "сек", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        class Newspaper : PeriodicPublication
        {
            public int pages;
            public double pageReadTime;
            public Newspaper(double price, string title, int numberOfIssuesPerYear, int pages, double pageReadTime) : base(price, title, numberOfIssuesPerYear)
            {
                this.pages = pages;
                this.pageReadTime = pageReadTime;
            }
            public Newspaper() : base()
            {
                this.pageReadTime = 5;
                this.pages = 5;
            }
            public double ReadTime()
            {
                return pages * pageReadTime;
            }
            public double CostPerPage()
            {
                return subPrice / pages;
            }
            public override void Info()
            {
                MessageBox.Show("Інформація про видання:\n\nНазва газети:                           " + title.ToString() + "\n\nКількість випусків на рік:          " +
                                   numberOfIssuesPerYear.ToString() + "шт\n\nВартість підписки:                      " + subPrice.ToString() +
                                   "грн\n\nКількість сторінок:                      " + pages.ToString() + "шт\n\nШвидкість читання сторінки:   " + pageReadTime.ToString() 
                                   + "сек", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private Button button2;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
    }
}