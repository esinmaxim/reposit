namespace Gauss
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.инфоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тестовыеПримерыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пример1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пример2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пример3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пример4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.layoutVectorB = new System.Windows.Forms.TableLayoutPanel();
            this.layoutVectorX = new System.Windows.Forms.TableLayoutPanel();
            this.layoutMatrixA = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.layoutMatrixA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.инфоToolStripMenuItem,
            this.тестовыеПримерыToolStripMenuItem,
            this.выходToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(569, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // инфоToolStripMenuItem
            // 
            this.инфоToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("инфоToolStripMenuItem.Image")));
            this.инфоToolStripMenuItem.Name = "инфоToolStripMenuItem";
            this.инфоToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.инфоToolStripMenuItem.Text = "О программе";
            this.инфоToolStripMenuItem.Click += new System.EventHandler(this.оПрогаммеToolStripMenuItem_Click);
            // 
            // тестовыеПримерыToolStripMenuItem
            // 
            this.тестовыеПримерыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пример1ToolStripMenuItem,
            this.пример2ToolStripMenuItem,
            this.пример3ToolStripMenuItem,
            this.пример4ToolStripMenuItem});
            this.тестовыеПримерыToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("тестовыеПримерыToolStripMenuItem.Image")));
            this.тестовыеПримерыToolStripMenuItem.Name = "тестовыеПримерыToolStripMenuItem";
            this.тестовыеПримерыToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.тестовыеПримерыToolStripMenuItem.Text = "Тестовые примеры";
            // 
            // пример1ToolStripMenuItem
            // 
            this.пример1ToolStripMenuItem.Name = "пример1ToolStripMenuItem";
            this.пример1ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.пример1ToolStripMenuItem.Text = "Пример #1";
            this.пример1ToolStripMenuItem.Click += new System.EventHandler(this.пример1ToolStripMenuItem_Click);
            // 
            // пример2ToolStripMenuItem
            // 
            this.пример2ToolStripMenuItem.Name = "пример2ToolStripMenuItem";
            this.пример2ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.пример2ToolStripMenuItem.Text = "Пример #2";
            this.пример2ToolStripMenuItem.Click += new System.EventHandler(this.пример2ToolStripMenuItem_Click);
            // 
            // пример3ToolStripMenuItem
            // 
            this.пример3ToolStripMenuItem.Name = "пример3ToolStripMenuItem";
            this.пример3ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.пример3ToolStripMenuItem.Text = "Пример #3";
            this.пример3ToolStripMenuItem.Click += new System.EventHandler(this.пример3ToolStripMenuItem_Click);
            // 
            // пример4ToolStripMenuItem
            // 
            this.пример4ToolStripMenuItem.Name = "пример4ToolStripMenuItem";
            this.пример4ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.пример4ToolStripMenuItem.Text = "Пример #4";
            this.пример4ToolStripMenuItem.Click += new System.EventHandler(this.пример4ToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem1
            // 
            this.выходToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("выходToolStripMenuItem1.Image")));
            this.выходToolStripMenuItem1.Name = "выходToolStripMenuItem1";
            this.выходToolStripMenuItem1.Size = new System.Drawing.Size(68, 20);
            this.выходToolStripMenuItem1.Text = "Выход";
            this.выходToolStripMenuItem1.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 253);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(569, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.OwnerDraw = true;
            this.toolTip1.ReshowDelay = 1;
            this.toolTip1.ShowAlways = true;
            this.toolTip1.Tag = "Находит корни уравнения";
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Находит корни уравнения";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(407, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Корни X";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel1, 3);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.numericUpDown1);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(419, 29);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество неизвестных величин";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDown1.Location = new System.Drawing.Point(188, 4);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(87, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.Location = new System.Drawing.Point(281, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Решить уравнение";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(488, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Результат B";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Матрица А";
            // 
            // layoutVectorB
            // 
            this.layoutVectorB.ColumnCount = 1;
            this.layoutVectorB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutVectorB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutVectorB.Location = new System.Drawing.Point(480, 51);
            this.layoutVectorB.Name = "layoutVectorB";
            this.layoutVectorB.RowCount = 1;
            this.layoutVectorB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutVectorB.Size = new System.Drawing.Size(86, 175);
            this.layoutVectorB.TabIndex = 2;
            // 
            // layoutVectorX
            // 
            this.layoutVectorX.CausesValidation = false;
            this.layoutVectorX.ColumnCount = 1;
            this.layoutVectorX.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutVectorX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutVectorX.Location = new System.Drawing.Point(389, 51);
            this.layoutVectorX.Name = "layoutVectorX";
            this.layoutVectorX.RowCount = 1;
            this.layoutVectorX.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutVectorX.Size = new System.Drawing.Size(85, 175);
            this.layoutVectorX.TabIndex = 1;
            // 
            // layoutMatrixA
            // 
            this.layoutMatrixA.ColumnCount = 1;
            this.layoutMatrixA.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutMatrixA.Controls.Add(this.pictureBox2, 0, 0);
            this.layoutMatrixA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutMatrixA.Location = new System.Drawing.Point(3, 51);
            this.layoutMatrixA.Name = "layoutMatrixA";
            this.layoutMatrixA.RowCount = 2;
            this.layoutMatrixA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutMatrixA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutMatrixA.Size = new System.Drawing.Size(380, 175);
            this.layoutMatrixA.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 149);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.Controls.Add(this.layoutMatrixA, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.layoutVectorX, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.layoutVectorB, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(569, 229);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 275);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Решение СЛАУ методом Гаусса";
            this.toolTip1.SetToolTip(this, "Программа для решения СЛАУ ");
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.layoutMatrixA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem инфоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тестовыеПримерыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пример1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пример2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пример3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пример4ToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel layoutMatrixA;
        private System.Windows.Forms.TableLayoutPanel layoutVectorX;
        private System.Windows.Forms.TableLayoutPanel layoutVectorB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem1;
    }
}

