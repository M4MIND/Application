
namespace Application
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PriceFrom = new System.Windows.Forms.TextBox();
            this.PriceTo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Maker = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ValueOZU = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ValuePZU = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CountCPU = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Sale = new System.Windows.Forms.CheckBox();
            this.Search = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Производитель";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Цена от";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // PriceFrom
            // 
            this.PriceFrom.Location = new System.Drawing.Point(104, 34);
            this.PriceFrom.Name = "PriceFrom";
            this.PriceFrom.Size = new System.Drawing.Size(211, 20);
            this.PriceFrom.TabIndex = 3;
            // 
            // PriceTo
            // 
            this.PriceTo.Location = new System.Drawing.Point(366, 34);
            this.PriceTo.Name = "PriceTo";
            this.PriceTo.Size = new System.Drawing.Size(211, 20);
            this.PriceTo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "До";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Maker
            // 
            this.Maker.FormattingEnabled = true;
            this.Maker.Location = new System.Drawing.Point(104, 7);
            this.Maker.Name = "Maker";
            this.Maker.Size = new System.Drawing.Size(121, 21);
            this.Maker.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Объем оперативной памяти";
            // 
            // ValueOZU
            // 
            this.ValueOZU.FormattingEnabled = true;
            this.ValueOZU.Location = new System.Drawing.Point(168, 61);
            this.ValueOZU.Name = "ValueOZU";
            this.ValueOZU.Size = new System.Drawing.Size(121, 21);
            this.ValueOZU.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Объем встроенной памяти";
            // 
            // ValuePZU
            // 
            this.ValuePZU.FormattingEnabled = true;
            this.ValuePZU.Location = new System.Drawing.Point(168, 89);
            this.ValuePZU.Name = "ValuePZU";
            this.ValuePZU.Size = new System.Drawing.Size(121, 21);
            this.ValuePZU.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Количество ядер";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // CountCPU
            // 
            this.CountCPU.FormattingEnabled = true;
            this.CountCPU.Location = new System.Drawing.Point(168, 116);
            this.CountCPU.Name = "CountCPU";
            this.CountCPU.Size = new System.Drawing.Size(121, 21);
            this.CountCPU.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Учавствует в акции";
            // 
            // Sale
            // 
            this.Sale.AutoSize = true;
            this.Sale.Location = new System.Drawing.Point(168, 146);
            this.Sale.Name = "Sale";
            this.Sale.Size = new System.Drawing.Size(15, 14);
            this.Sale.TabIndex = 14;
            this.Sale.UseVisualStyleBackColor = true;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(15, 189);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 15;
            this.Search.Text = "Искать";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click_1);
            // 
            // Result
            // 
            this.Result.FormattingEnabled = true;
            this.Result.Location = new System.Drawing.Point(366, 92);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(512, 160);
            this.Result.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(363, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Результат";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 284);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Sale);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CountCPU);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ValuePZU);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ValueOZU);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Maker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PriceTo);
            this.Controls.Add(this.PriceFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Выбор смартфона. Толярук Г.С.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PriceFrom;
        private System.Windows.Forms.TextBox PriceTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Maker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ValueOZU;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ValuePZU;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CountCPU;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox Sale;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.ListBox Result;
        private System.Windows.Forms.Label label8;
    }
}

