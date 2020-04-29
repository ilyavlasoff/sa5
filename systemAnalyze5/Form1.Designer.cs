namespace systemAnalyze5
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
            this.relationsMatrixView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.topsCount = new System.Windows.Forms.NumericUpDown();
            this.okButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RValueLabel = new System.Windows.Forms.Label();
            this.EValueLabel = new System.Windows.Forms.Label();
            this.graphType = new System.Windows.Forms.Label();
            this.isUnorient = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.relationsMatrixView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topsCount)).BeginInit();
            this.SuspendLayout();
            // 
            // relationsMatrixView
            // 
            this.relationsMatrixView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.relationsMatrixView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.relationsMatrixView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.relationsMatrixView.Location = new System.Drawing.Point(12, 24);
            this.relationsMatrixView.Name = "relationsMatrixView";
            this.relationsMatrixView.Size = new System.Drawing.Size(535, 450);
            this.relationsMatrixView.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 482);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Количество вершин";
            // 
            // topsCount
            // 
            this.topsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.topsCount.Location = new System.Drawing.Point(423, 480);
            this.topsCount.Name = "topsCount";
            this.topsCount.ReadOnly = true;
            this.topsCount.Size = new System.Drawing.Size(43, 20);
            this.topsCount.TabIndex = 16;
            this.topsCount.ValueChanged += new System.EventHandler(this.topsCount_ValueChanged);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(472, 480);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 15;
            this.okButton.Text = "ОК";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Матрица А";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 487);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Значения характеристик";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 500);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "R=";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 513);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "ε²=";
            // 
            // RValueLabel
            // 
            this.RValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RValueLabel.AutoSize = true;
            this.RValueLabel.Location = new System.Drawing.Point(40, 500);
            this.RValueLabel.Name = "RValueLabel";
            this.RValueLabel.Size = new System.Drawing.Size(0, 13);
            this.RValueLabel.TabIndex = 22;
            // 
            // EValueLabel
            // 
            this.EValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EValueLabel.AutoSize = true;
            this.EValueLabel.Location = new System.Drawing.Point(40, 513);
            this.EValueLabel.Name = "EValueLabel";
            this.EValueLabel.Size = new System.Drawing.Size(0, 13);
            this.EValueLabel.TabIndex = 23;
            // 
            // graphType
            // 
            this.graphType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.graphType.AutoSize = true;
            this.graphType.Location = new System.Drawing.Point(12, 526);
            this.graphType.Name = "graphType";
            this.graphType.Size = new System.Drawing.Size(0, 13);
            this.graphType.TabIndex = 24;
            // 
            // isUnorient
            // 
            this.isUnorient.AutoSize = true;
            this.isUnorient.Location = new System.Drawing.Point(388, 509);
            this.isUnorient.Name = "isUnorient";
            this.isUnorient.Size = new System.Drawing.Size(159, 17);
            this.isUnorient.TabIndex = 25;
            this.isUnorient.Text = "Неориентированный граф";
            this.isUnorient.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 552);
            this.Controls.Add(this.isUnorient);
            this.Controls.Add(this.graphType);
            this.Controls.Add(this.EValueLabel);
            this.Controls.Add(this.RValueLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.topsCount);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.relationsMatrixView);
            this.Name = "Form1";
            this.Text = "Расчет показателей избыточности системы";
            ((System.ComponentModel.ISupportInitialize)(this.relationsMatrixView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topsCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView relationsMatrixView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown topsCount;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label RValueLabel;
        private System.Windows.Forms.Label EValueLabel;
        private System.Windows.Forms.Label graphType;
        private System.Windows.Forms.CheckBox isUnorient;
    }
}

