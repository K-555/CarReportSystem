namespace CarReportSystem
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelCreatedDate = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelMaker = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelReport = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpCreatedDate = new System.Windows.Forms.DateTimePicker();
            this.cbAuthor = new System.Windows.Forms.ComboBox();
            this.btOpenArticle = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btOpenImage = new System.Windows.Forms.Button();
            this.btDeleteImage = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btRetouching = new System.Windows.Forms.Button();
            this.btDeleteReport = new System.Windows.Forms.Button();
            this.btEnd = new System.Windows.Forms.Button();
            this.cbName = new System.Windows.Forms.ComboBox();
            this.tbReport = new System.Windows.Forms.TextBox();
            this.dgvArticle = new System.Windows.Forms.DataGridView();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.rbT = new System.Windows.Forms.RadioButton();
            this.rbN = new System.Windows.Forms.RadioButton();
            this.rbH = new System.Windows.Forms.RadioButton();
            this.rbS = new System.Windows.Forms.RadioButton();
            this.rbG = new System.Windows.Forms.RadioButton();
            this.rbNull = new System.Windows.Forms.RadioButton();
            this.gbMaker = new System.Windows.Forms.GroupBox();
            this.ofdOpenImage = new System.Windows.Forms.OpenFileDialog();
            this.sfdSaveData = new System.Windows.Forms.SaveFileDialog();
            this.ofdOpenData = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.gbMaker.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCreatedDate
            // 
            this.labelCreatedDate.AutoSize = true;
            this.labelCreatedDate.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelCreatedDate.Location = new System.Drawing.Point(43, 30);
            this.labelCreatedDate.Name = "labelCreatedDate";
            this.labelCreatedDate.Size = new System.Drawing.Size(48, 16);
            this.labelCreatedDate.TabIndex = 0;
            this.labelCreatedDate.Text = "日付：";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelAuthor.Location = new System.Drawing.Point(27, 66);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(64, 16);
            this.labelAuthor.TabIndex = 0;
            this.labelAuthor.Text = "記録者：";
            // 
            // labelMaker
            // 
            this.labelMaker.AutoSize = true;
            this.labelMaker.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelMaker.Location = new System.Drawing.Point(27, 114);
            this.labelMaker.Name = "labelMaker";
            this.labelMaker.Size = new System.Drawing.Size(64, 16);
            this.labelMaker.TabIndex = 0;
            this.labelMaker.Text = "メーカー：";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelName.Location = new System.Drawing.Point(43, 164);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(48, 16);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "車名：";
            // 
            // labelReport
            // 
            this.labelReport.AutoSize = true;
            this.labelReport.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelReport.Location = new System.Drawing.Point(26, 207);
            this.labelReport.Name = "labelReport";
            this.labelReport.Size = new System.Drawing.Size(65, 16);
            this.labelReport.TabIndex = 0;
            this.labelReport.Text = "レポート：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(499, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "画像：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(11, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "記事一覧：";
            // 
            // dtpCreatedDate
            // 
            this.dtpCreatedDate.CalendarFont = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtpCreatedDate.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtpCreatedDate.Location = new System.Drawing.Point(97, 30);
            this.dtpCreatedDate.Name = "dtpCreatedDate";
            this.dtpCreatedDate.Size = new System.Drawing.Size(235, 23);
            this.dtpCreatedDate.TabIndex = 1;
            // 
            // cbAuthor
            // 
            this.cbAuthor.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbAuthor.FormattingEnabled = true;
            this.cbAuthor.Location = new System.Drawing.Point(97, 66);
            this.cbAuthor.Name = "cbAuthor";
            this.cbAuthor.Size = new System.Drawing.Size(269, 24);
            this.cbAuthor.TabIndex = 2;
            // 
            // btOpenArticle
            // 
            this.btOpenArticle.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btOpenArticle.Location = new System.Drawing.Point(14, 381);
            this.btOpenArticle.Name = "btOpenArticle";
            this.btOpenArticle.Size = new System.Drawing.Size(65, 27);
            this.btOpenArticle.TabIndex = 4;
            this.btOpenArticle.Text = "開く";
            this.btOpenArticle.UseVisualStyleBackColor = true;
            this.btOpenArticle.Click += new System.EventHandler(this.btOpenArticle_Click);
            // 
            // btSave
            // 
            this.btSave.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btSave.Location = new System.Drawing.Point(14, 427);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(65, 27);
            this.btSave.TabIndex = 4;
            this.btSave.Text = "保存";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btOpenImage
            // 
            this.btOpenImage.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btOpenImage.Location = new System.Drawing.Point(596, 30);
            this.btOpenImage.Name = "btOpenImage";
            this.btOpenImage.Size = new System.Drawing.Size(90, 27);
            this.btOpenImage.TabIndex = 4;
            this.btOpenImage.Text = "開く";
            this.btOpenImage.UseVisualStyleBackColor = true;
            this.btOpenImage.Click += new System.EventHandler(this.btOpenImage_Click);
            // 
            // btDeleteImage
            // 
            this.btDeleteImage.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btDeleteImage.Location = new System.Drawing.Point(703, 30);
            this.btDeleteImage.Name = "btDeleteImage";
            this.btDeleteImage.Size = new System.Drawing.Size(84, 27);
            this.btDeleteImage.TabIndex = 4;
            this.btDeleteImage.Text = "削除";
            this.btDeleteImage.UseVisualStyleBackColor = true;
            this.btDeleteImage.Click += new System.EventHandler(this.btDeleteImage_Click);
            // 
            // btAdd
            // 
            this.btAdd.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btAdd.Location = new System.Drawing.Point(502, 293);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(84, 27);
            this.btAdd.TabIndex = 4;
            this.btAdd.Text = "追加";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btRetouching
            // 
            this.btRetouching.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btRetouching.Location = new System.Drawing.Point(602, 293);
            this.btRetouching.Name = "btRetouching";
            this.btRetouching.Size = new System.Drawing.Size(84, 27);
            this.btRetouching.TabIndex = 4;
            this.btRetouching.Text = "修正";
            this.btRetouching.UseVisualStyleBackColor = true;
            this.btRetouching.Click += new System.EventHandler(this.btRetouching_Click);
            // 
            // btDeleteReport
            // 
            this.btDeleteReport.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btDeleteReport.Location = new System.Drawing.Point(703, 293);
            this.btDeleteReport.Name = "btDeleteReport";
            this.btDeleteReport.Size = new System.Drawing.Size(84, 27);
            this.btDeleteReport.TabIndex = 4;
            this.btDeleteReport.Text = "削除";
            this.btDeleteReport.UseVisualStyleBackColor = true;
            this.btDeleteReport.Click += new System.EventHandler(this.btDeleteReport_Click);
            // 
            // btEnd
            // 
            this.btEnd.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btEnd.Location = new System.Drawing.Point(678, 535);
            this.btEnd.Name = "btEnd";
            this.btEnd.Size = new System.Drawing.Size(109, 27);
            this.btEnd.TabIndex = 4;
            this.btEnd.Text = "終了";
            this.btEnd.UseVisualStyleBackColor = true;
            this.btEnd.Click += new System.EventHandler(this.btEnd_Click);
            // 
            // cbName
            // 
            this.cbName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbName.FormattingEnabled = true;
            this.cbName.Location = new System.Drawing.Point(97, 161);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(269, 24);
            this.cbName.TabIndex = 2;
            // 
            // tbReport
            // 
            this.tbReport.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbReport.Location = new System.Drawing.Point(97, 207);
            this.tbReport.Multiline = true;
            this.tbReport.Name = "tbReport";
            this.tbReport.Size = new System.Drawing.Size(391, 113);
            this.tbReport.TabIndex = 5;
            // 
            // dgvArticle
            // 
            this.dgvArticle.AllowUserToAddRows = false;
            this.dgvArticle.AllowUserToDeleteRows = false;
            this.dgvArticle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticle.Location = new System.Drawing.Point(97, 342);
            this.dgvArticle.Name = "dgvArticle";
            this.dgvArticle.RowTemplate.Height = 21;
            this.dgvArticle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticle.Size = new System.Drawing.Size(690, 187);
            this.dgvArticle.TabIndex = 6;
            this.dgvArticle.Click += new System.EventHandler(this.dgvArticle_Click);
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Location = new System.Drawing.Point(502, 66);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(285, 201);
            this.pbImage.TabIndex = 7;
            this.pbImage.TabStop = false;
            // 
            // rbT
            // 
            this.rbT.AutoSize = true;
            this.rbT.Location = new System.Drawing.Point(14, 16);
            this.rbT.Name = "rbT";
            this.rbT.Size = new System.Drawing.Size(47, 16);
            this.rbT.TabIndex = 3;
            this.rbT.TabStop = true;
            this.rbT.Text = "トヨタ";
            this.rbT.UseVisualStyleBackColor = true;
            // 
            // rbN
            // 
            this.rbN.AutoSize = true;
            this.rbN.Location = new System.Drawing.Point(67, 16);
            this.rbN.Name = "rbN";
            this.rbN.Size = new System.Drawing.Size(47, 16);
            this.rbN.TabIndex = 3;
            this.rbN.TabStop = true;
            this.rbN.Text = "日産";
            this.rbN.UseVisualStyleBackColor = true;
            // 
            // rbH
            // 
            this.rbH.AutoSize = true;
            this.rbH.Location = new System.Drawing.Point(120, 18);
            this.rbH.Name = "rbH";
            this.rbH.Size = new System.Drawing.Size(51, 16);
            this.rbH.TabIndex = 3;
            this.rbH.TabStop = true;
            this.rbH.Text = "ホンダ";
            this.rbH.UseVisualStyleBackColor = true;
            // 
            // rbS
            // 
            this.rbS.AutoSize = true;
            this.rbS.Location = new System.Drawing.Point(177, 18);
            this.rbS.Name = "rbS";
            this.rbS.Size = new System.Drawing.Size(52, 16);
            this.rbS.TabIndex = 3;
            this.rbS.TabStop = true;
            this.rbS.Text = "スバル";
            this.rbS.UseVisualStyleBackColor = true;
            // 
            // rbG
            // 
            this.rbG.AutoSize = true;
            this.rbG.Location = new System.Drawing.Point(235, 18);
            this.rbG.Name = "rbG";
            this.rbG.Size = new System.Drawing.Size(47, 16);
            this.rbG.TabIndex = 3;
            this.rbG.TabStop = true;
            this.rbG.Text = "外車";
            this.rbG.UseVisualStyleBackColor = true;
            // 
            // rbNull
            // 
            this.rbNull.AutoSize = true;
            this.rbNull.Location = new System.Drawing.Point(288, 18);
            this.rbNull.Name = "rbNull";
            this.rbNull.Size = new System.Drawing.Size(54, 16);
            this.rbNull.TabIndex = 3;
            this.rbNull.TabStop = true;
            this.rbNull.Text = "その他";
            this.rbNull.UseVisualStyleBackColor = true;
            // 
            // gbMaker
            // 
            this.gbMaker.Controls.Add(this.rbNull);
            this.gbMaker.Controls.Add(this.rbT);
            this.gbMaker.Controls.Add(this.rbN);
            this.gbMaker.Controls.Add(this.rbH);
            this.gbMaker.Controls.Add(this.rbS);
            this.gbMaker.Controls.Add(this.rbG);
            this.gbMaker.Location = new System.Drawing.Point(97, 105);
            this.gbMaker.Name = "gbMaker";
            this.gbMaker.Size = new System.Drawing.Size(374, 40);
            this.gbMaker.TabIndex = 8;
            this.gbMaker.TabStop = false;
            this.gbMaker.Text = "メーカー";
            // 
            // ofdOpenImage
            // 
            this.ofdOpenImage.FileName = "openFileDialog1";
            // 
            // ofdOpenData
            // 
            this.ofdOpenData.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 571);
            this.Controls.Add(this.gbMaker);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.dgvArticle);
            this.Controls.Add(this.tbReport);
            this.Controls.Add(this.btEnd);
            this.Controls.Add(this.btDeleteReport);
            this.Controls.Add(this.btRetouching);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btDeleteImage);
            this.Controls.Add(this.btOpenImage);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btOpenArticle);
            this.Controls.Add(this.cbName);
            this.Controls.Add(this.cbAuthor);
            this.Controls.Add(this.dtpCreatedDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelReport);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelMaker);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.labelCreatedDate);
            this.Name = "Form1";
            this.Text = "試乗レポート管理システム";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.gbMaker.ResumeLayout(false);
            this.gbMaker.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCreatedDate;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelMaker;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelReport;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpCreatedDate;
        private System.Windows.Forms.ComboBox cbAuthor;
        private System.Windows.Forms.Button btOpenArticle;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btOpenImage;
        private System.Windows.Forms.Button btDeleteImage;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btRetouching;
        private System.Windows.Forms.Button btDeleteReport;
        private System.Windows.Forms.Button btEnd;
        private System.Windows.Forms.ComboBox cbName;
        private System.Windows.Forms.TextBox tbReport;
        private System.Windows.Forms.DataGridView dgvArticle;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.RadioButton rbT;
        private System.Windows.Forms.RadioButton rbN;
        private System.Windows.Forms.RadioButton rbH;
        private System.Windows.Forms.RadioButton rbS;
        private System.Windows.Forms.RadioButton rbG;
        private System.Windows.Forms.RadioButton rbNull;
        private System.Windows.Forms.GroupBox gbMaker;
        private System.Windows.Forms.OpenFileDialog ofdOpenImage;
        private System.Windows.Forms.SaveFileDialog sfdSaveData;
        private System.Windows.Forms.OpenFileDialog ofdOpenData;
    }
}

