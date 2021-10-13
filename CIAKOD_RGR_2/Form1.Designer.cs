namespace TPR_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbExample3 = new System.Windows.Forms.CheckBox();
            this.labelError = new System.Windows.Forms.Label();
            this.cbExample2 = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnMark = new System.Windows.Forms.Button();
            this.tbEtap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbStrat = new System.Windows.Forms.TextBox();
            this.tbSost = new System.Windows.Forms.TextBox();
            this.btnDispose = new System.Windows.Forms.Button();
            this.rtbResultPath = new System.Windows.Forms.RichTextBox();
            this.dataGridViewPerexod = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewDoxod = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPerexod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoxod)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.cbExample3);
            this.groupBox1.Controls.Add(this.labelError);
            this.groupBox1.Controls.Add(this.cbExample2);
            this.groupBox1.Controls.Add(this.btnOk);
            this.groupBox1.Controls.Add(this.btnMark);
            this.groupBox1.Controls.Add(this.tbEtap);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbStrat);
            this.groupBox1.Controls.Add(this.tbSost);
            this.groupBox1.Controls.Add(this.btnDispose);
            this.groupBox1.Location = new System.Drawing.Point(0, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 633);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // cbExample3
            // 
            this.cbExample3.AutoSize = true;
            this.cbExample3.Checked = true;
            this.cbExample3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbExample3.Location = new System.Drawing.Point(10, 279);
            this.cbExample3.Name = "cbExample3";
            this.cbExample3.Size = new System.Drawing.Size(116, 17);
            this.cbExample3.TabIndex = 32;
            this.cbExample3.Text = "Пример на 3 сост";
            this.cbExample3.UseVisualStyleBackColor = true;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(12, 276);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 31;
            // 
            // cbExample2
            // 
            this.cbExample2.AutoSize = true;
            this.cbExample2.Location = new System.Drawing.Point(10, 256);
            this.cbExample2.Name = "cbExample2";
            this.cbExample2.Size = new System.Drawing.Size(116, 17);
            this.cbExample2.TabIndex = 30;
            this.cbExample2.Text = "Пример на 2 сост";
            this.cbExample2.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(10, 103);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(142, 22);
            this.btnOk.TabIndex = 29;
            this.btnOk.Text = "Ок";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnMark
            // 
            this.btnMark.Location = new System.Drawing.Point(10, 209);
            this.btnMark.Name = "btnMark";
            this.btnMark.Size = new System.Drawing.Size(145, 23);
            this.btnMark.TabIndex = 28;
            this.btnMark.Text = "Марковский процесс";
            this.btnMark.UseVisualStyleBackColor = true;
            this.btnMark.Click += new System.EventHandler(this.btnMark_Click);
            // 
            // tbEtap
            // 
            this.tbEtap.Location = new System.Drawing.Point(10, 183);
            this.tbEtap.Name = "tbEtap";
            this.tbEtap.Size = new System.Drawing.Size(142, 20);
            this.tbEtap.TabIndex = 27;
            this.tbEtap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEtap_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Количество этапов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Количество Стратегий 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Количество Стратегий 1";
            // 
            // tbStrat
            // 
            this.tbStrat.Location = new System.Drawing.Point(10, 77);
            this.tbStrat.Name = "tbStrat";
            this.tbStrat.Size = new System.Drawing.Size(142, 20);
            this.tbStrat.TabIndex = 8;
            this.tbStrat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbStrat_KeyPress);
            // 
            // tbSost
            // 
            this.tbSost.Location = new System.Drawing.Point(10, 35);
            this.tbSost.Name = "tbSost";
            this.tbSost.Size = new System.Drawing.Size(142, 20);
            this.tbSost.TabIndex = 7;
            this.tbSost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSost_KeyPress);
            // 
            // btnDispose
            // 
            this.btnDispose.Location = new System.Drawing.Point(10, 570);
            this.btnDispose.Name = "btnDispose";
            this.btnDispose.Size = new System.Drawing.Size(145, 23);
            this.btnDispose.TabIndex = 3;
            this.btnDispose.Text = "Clear";
            this.btnDispose.UseVisualStyleBackColor = true;
            this.btnDispose.Click += new System.EventHandler(this.btnDispose_Click);
            // 
            // rtbResultPath
            // 
            this.rtbResultPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rtbResultPath.Location = new System.Drawing.Point(167, 169);
            this.rtbResultPath.Name = "rtbResultPath";
            this.rtbResultPath.Size = new System.Drawing.Size(1184, 512);
            this.rtbResultPath.TabIndex = 3;
            this.rtbResultPath.Text = "";
            // 
            // dataGridViewPerexod
            // 
            this.dataGridViewPerexod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPerexod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPerexod.Location = new System.Drawing.Point(167, 20);
            this.dataGridViewPerexod.Name = "dataGridViewPerexod";
            this.dataGridViewPerexod.Size = new System.Drawing.Size(597, 140);
            this.dataGridViewPerexod.TabIndex = 4;
            this.dataGridViewPerexod.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridViewPerexod_EditingControlShowing);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Матрица переходов";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(782, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Матрица доходностей";
            // 
            // dataGridViewDoxod
            // 
            this.dataGridViewDoxod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDoxod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoxod.Location = new System.Drawing.Point(785, 20);
            this.dataGridViewDoxod.Name = "dataGridViewDoxod";
            this.dataGridViewDoxod.Size = new System.Drawing.Size(566, 140);
            this.dataGridViewDoxod.TabIndex = 25;
            this.dataGridViewDoxod.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridViewDoxod_EditingControlShowing);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 634);
            this.Controls.Add(this.dataGridViewDoxod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewPerexod);
            this.Controls.Add(this.rtbResultPath);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Rgr CIAKOD";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPerexod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoxod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDispose;
        private System.Windows.Forms.TextBox tbStrat;
        private System.Windows.Forms.TextBox tbSost;
        private System.Windows.Forms.DataGridView dataGridViewPerexod;
        public System.Windows.Forms.RichTextBox rtbResultPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewDoxod;
        private System.Windows.Forms.Button btnMark;
        private System.Windows.Forms.TextBox tbEtap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOk;
        public System.Windows.Forms.CheckBox cbExample2;
        private System.Windows.Forms.Label labelError;
        public System.Windows.Forms.CheckBox cbExample3;
    }
}

