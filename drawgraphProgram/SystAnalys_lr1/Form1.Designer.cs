namespace SystAnalys_lr1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.executeButton = new System.Windows.Forms.Button();
            this.enterNumbLabel = new System.Windows.Forms.Label();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.CBchoice = new System.Windows.Forms.ComboBox();
            this.InsertButton = new System.Windows.Forms.Button();
            this.deleteALLButton = new System.Windows.Forms.Button();
            this.InorderTree = new System.Windows.Forms.Button();
            this.sheet = new System.Windows.Forms.PictureBox();
            this.TBresult = new System.Windows.Forms.TextBox();
            this.Lhelp = new System.Windows.Forms.Label();
            this.Lres = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sheet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1468, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // executeButton
            // 
            this.executeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.executeButton.Location = new System.Drawing.Point(457, 642);
            this.executeButton.Margin = new System.Windows.Forms.Padding(4);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(249, 51);
            this.executeButton.TabIndex = 1;
            this.executeButton.Text = "OK";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.drawVertexButton_Click);
            // 
            // enterNumbLabel
            // 
            this.enterNumbLabel.AutoSize = true;
            this.enterNumbLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterNumbLabel.Location = new System.Drawing.Point(12, 562);
            this.enterNumbLabel.Name = "enterNumbLabel";
            this.enterNumbLabel.Size = new System.Drawing.Size(238, 48);
            this.enterNumbLabel.TabIndex = 15;
            this.enterNumbLabel.Text = "Введите значение новой\r\nвершины:";
            this.enterNumbLabel.Click += new System.EventHandler(this.enterNumbLabel_Click);
            // 
            // tbValue
            // 
            this.tbValue.Location = new System.Drawing.Point(16, 613);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(219, 22);
            this.tbValue.TabIndex = 16;
            this.tbValue.TextChanged += new System.EventHandler(this.tbValue_TextChanged);
            // 
            // CBchoice
            // 
            this.CBchoice.FormattingEnabled = true;
            this.CBchoice.Items.AddRange(new object[] {
            "Поиск элемента",
            "Поиск наименьшего элемента",
            "Поиск наибольшего элемента",
            "Поиск следующего элемента",
            "Поиск предыдущего элемента",
            "Удаление элемента",
            "Печать дерева"});
            this.CBchoice.Location = new System.Drawing.Point(457, 613);
            this.CBchoice.Name = "CBchoice";
            this.CBchoice.Size = new System.Drawing.Size(249, 24);
            this.CBchoice.TabIndex = 17;
            this.CBchoice.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // InsertButton
            // 
            this.InsertButton.Image = global::SystAnalys_lr1.Properties.Resources.edge;
            this.InsertButton.Location = new System.Drawing.Point(16, 642);
            this.InsertButton.Margin = new System.Windows.Forms.Padding(4);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(219, 51);
            this.InsertButton.TabIndex = 10;
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // deleteALLButton
            // 
            this.deleteALLButton.Image = global::SystAnalys_lr1.Properties.Resources.deleteAll;
            this.deleteALLButton.Location = new System.Drawing.Point(1236, 639);
            this.deleteALLButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteALLButton.Name = "deleteALLButton";
            this.deleteALLButton.Size = new System.Drawing.Size(219, 51);
            this.deleteALLButton.TabIndex = 5;
            this.deleteALLButton.UseVisualStyleBackColor = true;
            this.deleteALLButton.Click += new System.EventHandler(this.deleteALLButton_Click);
            // 
            // InorderTree
            // 
            this.InorderTree.Image = global::SystAnalys_lr1.Properties.Resources.cycle;
            this.InorderTree.Location = new System.Drawing.Point(1009, 639);
            this.InorderTree.Margin = new System.Windows.Forms.Padding(4);
            this.InorderTree.Name = "InorderTree";
            this.InorderTree.Size = new System.Drawing.Size(219, 51);
            this.InorderTree.TabIndex = 3;
            this.InorderTree.UseVisualStyleBackColor = true;
            this.InorderTree.Click += new System.EventHandler(this.InorderTreeButton_Click);
            // 
            // sheet
            // 
            this.sheet.BackColor = System.Drawing.SystemColors.Control;
            this.sheet.Location = new System.Drawing.Point(13, 13);
            this.sheet.Margin = new System.Windows.Forms.Padding(4);
            this.sheet.Name = "sheet";
            this.sheet.Size = new System.Drawing.Size(1442, 530);
            this.sheet.TabIndex = 0;
            this.sheet.TabStop = false;
            // 
            // TBresult
            // 
            this.TBresult.Location = new System.Drawing.Point(457, 583);
            this.TBresult.Name = "TBresult";
            this.TBresult.Size = new System.Drawing.Size(249, 22);
            this.TBresult.TabIndex = 18;
            this.TBresult.TextChanged += new System.EventHandler(this.TBresult_TextChanged);
            // 
            // Lhelp
            // 
            this.Lhelp.AutoSize = true;
            this.Lhelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lhelp.Location = new System.Drawing.Point(453, 560);
            this.Lhelp.Name = "Lhelp";
            this.Lhelp.Size = new System.Drawing.Size(53, 20);
            this.Lhelp.TabIndex = 19;
            this.Lhelp.Text = "label1";
            this.Lhelp.Visible = false;
            this.Lhelp.Click += new System.EventHandler(this.Lhelp_Click);
            // 
            // Lres
            // 
            this.Lres.AutoSize = true;
            this.Lres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lres.Location = new System.Drawing.Point(770, 590);
            this.Lres.Name = "Lres";
            this.Lres.Size = new System.Drawing.Size(53, 20);
            this.Lres.TabIndex = 20;
            this.Lres.Text = "label2";
            this.Lres.Visible = false;
            this.Lres.Click += new System.EventHandler(this.Lres_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.InsertButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1468, 703);
            this.Controls.Add(this.Lres);
            this.Controls.Add(this.Lhelp);
            this.Controls.Add(this.TBresult);
            this.Controls.Add(this.CBchoice);
            this.Controls.Add(this.tbValue);
            this.Controls.Add(this.enterNumbLabel);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.deleteALLButton);
            this.Controls.Add(this.InorderTree);
            this.Controls.Add(this.executeButton);
            this.Controls.Add(this.sheet);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab №5";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sheet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox sheet;
        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.Button InorderTree;
        private System.Windows.Forms.Button deleteALLButton;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label enterNumbLabel;
        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.ComboBox CBchoice;
        private System.Windows.Forms.TextBox TBresult;
        private System.Windows.Forms.Label Lhelp;
        private System.Windows.Forms.Label Lres;
    }
}

