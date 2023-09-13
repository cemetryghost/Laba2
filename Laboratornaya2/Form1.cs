namespace Laboratornaya2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            MessageBox.Show(button.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            
            // 
            // pictureBox1
            // 
            PictureBox pictureBox1 = new PictureBox();
            pictureBox1.BackgroundImage = Image.FromFile("C:\\Users\\matve\\OneDrive\\Изображения\\icons8_get_cash_64.png");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Size = new Size(152, 130);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            Button button1 = new Button();
            button1.BackColor = SystemColors.ActiveCaption;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(12, 159);
            button1.Name = "button1";
            button1.Size = new Size(152, 72);
            button1.TabIndex = 1;
            button1.Text = "Абоненты";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button_Click;
            // 
            // button2
            // 
            Button button2 = new Button();
            button2.BackColor = SystemColors.ActiveCaption;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(12, 538);
            button2.Name = "button2";
            button2.Size = new Size(152, 72);
            button2.TabIndex = 2;
            button2.Text = "Поддержка пользователей";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button_Click;
            // 
            // button3
            // 
            Button button3 = new Button();
            button3.BackColor = SystemColors.ActiveCaption;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Location = new Point(12, 442);
            button3.Name = "button3";
            button3.Size = new Size(152, 72);
            button3.TabIndex = 3;
            button3.Text = "Биллинг";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button_Click;
            // 
            // button4
            // 
            Button button4 = new Button();
            button4.BackColor = SystemColors.ActiveCaption;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Location = new Point(12, 348);
            button4.Name = "button4";
            button4.Size = new Size(152, 72);
            button4.TabIndex = 4;
            button4.Text = "Активы";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button_Click;
            // 
            // button5
            // 
            Button button5 = new Button();  
            button5.BackColor = SystemColors.ActiveCaption;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Location = new Point(12, 253);
            button5.Name = "button5";
            button5.Size = new Size(152, 72);
            button5.TabIndex = 5;
            button5.Text = "Управление оборудованием";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button_Click;
            // 
            // label1
            // 
            Label label1 = new Label(); 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(219, 77);
            label1.Name = "label1";
            label1.Size = new Size(360, 65);
            label1.TabIndex = 6;
            label1.Text = "Абоненты ТНС";
            // 
            // dataGridView1
            // 
            DataGridView dataGridView1 = new DataGridView();
            dataGridView1.BackgroundColor = SystemColors.Info;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle13.BackColor = SystemColors.Control;
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            
            dataGridView1.GridColor = SystemColors.InactiveCaptionText;
            dataGridView1.Location = new Point(219, 159);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = SystemColors.Control;
            dataGridViewCellStyle18.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle18.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1004, 702);
            dataGridView1.TabIndex = 7;

            var column1 = new DataGridViewTextBoxColumn();
            var column2 = new DataGridViewTextBoxColumn();
            var column3 = new DataGridViewTextBoxColumn();
            var column4 = new DataGridViewTextBoxColumn();

            column1.HeaderText = "ФИО";
            column1.Name = "fio";
            column1.Width = 250;

            column2.HeaderText = "Абонентский номер";
            column2.Name = "number";
            column2.Width = 250;

            column3.HeaderText = "Лицевой счёт";
            column3.Name = "schet";
            column3.Width = 250;

            column4.HeaderText = "Услуги";
            column4.Name = "yslygi";
            column4.Width = 250;

            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { column1, column2, column3, column4 });
            
            // 
            // button6
            // 
            Button button6 = new Button();
            button6.BackColor = SystemColors.ActiveCaption;
            button6.FlatStyle = FlatStyle.Popup;
            button6.Location = new Point(12, 636);
            button6.Name = "button6";
            button6.Size = new Size(152, 72);
            button6.TabIndex = 8;
            button6.Text = "CRM";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button_Click;
            // 
            // button7
            // 
            Button button7 = new Button();  
            button7.BackColor = SystemColors.ActiveCaption;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Location = new Point(52, 758);
            button7.Name = "button7";
            button7.Size = new Size(69, 72);
            button7.TabIndex = 9;
            button7.Text = "проф.";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button_Click;
            // 
            // button8
            // 
            Button button8 = new Button();
            button8.BackColor = SystemColors.ActiveCaption;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Location = new Point(52, 849);
            button8.Name = "button8";
            button8.Size = new Size(69, 72);
            button8.TabIndex = 10;
            button8.Text = "?";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button_Click;
            // 
            // pictureBox2
            // 
            PictureBox pictureBox2 = new PictureBox();
            pictureBox2.BackgroundImage = Image.FromFile("C:\\Users\\matve\\OneDrive\\Изображения\\icons8_user_location_32.png");
            pictureBox2.Location = new Point(1367, 25);
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 34);
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // comboBox1
            // 
            ComboBox comboBox1 = new ComboBox();
            comboBox1.BackColor = Color.Coral;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Матвей Марусик", "Михотин Иван" });
            comboBox1.Location = new Point(1124, 25);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(208, 33);
            comboBox1.TabIndex = 13;
            comboBox1.Text = "ФИО_пользователя";
            // 
            // button9
            // 
            Button button9 = new Button();
            button9.BackColor = Color.GreenYellow;
            button9.FlatStyle = FlatStyle.Popup;
            button9.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button9.Location = new Point(1246, 159);
            button9.Name = "button9";
            button9.Size = new Size(169, 130);
            button9.TabIndex = 14;
            button9.Text = "Собрание менеджеров";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button_Click;
            // 
            // button10
            // 
            Button button10 = new Button();
            button10.BackColor = Color.GreenYellow;
            button10.FlatStyle = FlatStyle.Popup;
            button10.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button10.Location = new Point(1246, 295);
            button10.Name = "button10";
            button10.Size = new Size(169, 130);
            button10.TabIndex = 15;
            button10.Text = "Отчет по инвентаризации";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button_Click;
            // 
            // button11
            // 
            Button button11 = new Button();
            button11.BackColor = Color.GreenYellow;
            button11.FlatStyle = FlatStyle.Popup;
            button11.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button11.Location = new Point(1246, 431);
            button11.Name = "button11";
            button11.Size = new Size(169, 130);
            button11.TabIndex = 16;
            button11.Text = "Собрание акционеров";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button_Click;
            // 
            // button12
            // 
            Button button12 = new Button();
            button12.BackColor = Color.GreenYellow;
            button12.FlatStyle = FlatStyle.Popup;
            button12.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button12.Location = new Point(1246, 567);
            button12.Name = "button12";
            button12.Size = new Size(169, 130);
            button12.TabIndex = 17;
            button12.Text = "Отчет по району";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button_Click;
            // 
            // radioButton1
            // 
            RadioButton radioButton1 = new RadioButton();
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.Location = new Point(289, 872);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(189, 49);
            radioButton1.TabIndex = 18;
            radioButton1.TabStop = true;
            radioButton1.Text = "Активные";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            RadioButton radioButton2 = new RadioButton();
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.Location = new Point(584, 872);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(224, 49);
            radioButton2.TabIndex = 19;
            radioButton2.TabStop = true;
            radioButton2.Text = "Неактивные";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(1427, 933);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(comboBox1);
            Controls.Add(pictureBox2);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);

            System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath();
            myPath.AddEllipse(0, 0, button7.Width, button7.Height);

            Region myRegion = new Region(myPath);
            button7.Region = myRegion;

            System.Drawing.Drawing2D.GraphicsPath myPath2 = new System.Drawing.Drawing2D.GraphicsPath();
            myPath2.AddEllipse(0, 0, button8.Width, button8.Height);

            Region myRegion2 = new Region(myPath);
            button8.Region = myRegion2;
        }
    }
}