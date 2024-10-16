namespace Worship {
    partial class MainForm {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent() {
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblProgramName = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnTableOfContents = new System.Windows.Forms.Button();
            this.btnMorningWorshipPPT = new System.Windows.Forms.Button();
            this.btnIndividualHymnsPPT = new System.Windows.Forms.Button();
            this.btnChoirLyricsInput = new System.Windows.Forms.Button();
            this.pnlDesktop = new System.Windows.Forms.Panel();
            this.morningWorshipPPT1 = new Worship.MorningWorshipPPT();
            this.openingHymnsPPT1 = new Worship.OpeningHymnsPPT();
            this.choirLyricsInput1 = new Worship.ChoirLyricsInput();
            this.pnlTitleBar.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.pnlTitleBar.Controls.Add(this.btnMaximize);
            this.pnlTitleBar.Controls.Add(this.btnMinimize);
            this.pnlTitleBar.Controls.Add(this.btnClose);
            this.pnlTitleBar.Controls.Add(this.lblProgramName);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(1618, 29);
            this.pnlTitleBar.TabIndex = 2;
            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDown);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.Location = new System.Drawing.Point(1557, 3);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(25, 25);
            this.btnMaximize.TabIndex = 2;
            this.btnMaximize.Text = "☐";
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(1526, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(25, 25);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.Text = "―";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1588, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblProgramName
            // 
            this.lblProgramName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblProgramName.AutoSize = true;
            this.lblProgramName.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblProgramName.ForeColor = System.Drawing.Color.White;
            this.lblProgramName.Location = new System.Drawing.Point(743, 6);
            this.lblProgramName.Name = "lblProgramName";
            this.lblProgramName.Size = new System.Drawing.Size(133, 17);
            this.lblProgramName.TabIndex = 0;
            this.lblProgramName.Text = "Worship PPT Maker";
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.pnlMenu.Controls.Add(this.btnChoirLyricsInput);
            this.pnlMenu.Controls.Add(this.btnIndividualHymnsPPT);
            this.pnlMenu.Controls.Add(this.btnMorningWorshipPPT);
            this.pnlMenu.Controls.Add(this.btnTableOfContents);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1618, 28);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnTableOfContents
            // 
            this.btnTableOfContents.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTableOfContents.FlatAppearance.BorderSize = 0;
            this.btnTableOfContents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTableOfContents.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnTableOfContents.ForeColor = System.Drawing.Color.White;
            this.btnTableOfContents.Location = new System.Drawing.Point(0, 0);
            this.btnTableOfContents.Name = "btnTableOfContents";
            this.btnTableOfContents.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnTableOfContents.Size = new System.Drawing.Size(60, 28);
            this.btnTableOfContents.TabIndex = 4;
            this.btnTableOfContents.Text = "목차";
            this.btnTableOfContents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTableOfContents.UseVisualStyleBackColor = true;
            this.btnTableOfContents.Click += new System.EventHandler(this.btnTableOfContents_Click);
            // 
            // btnMorningWorshipPPT
            // 
            this.btnMorningWorshipPPT.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMorningWorshipPPT.FlatAppearance.BorderSize = 0;
            this.btnMorningWorshipPPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMorningWorshipPPT.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMorningWorshipPPT.ForeColor = System.Drawing.Color.White;
            this.btnMorningWorshipPPT.Location = new System.Drawing.Point(60, 0);
            this.btnMorningWorshipPPT.Name = "btnMorningWorshipPPT";
            this.btnMorningWorshipPPT.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnMorningWorshipPPT.Size = new System.Drawing.Size(108, 28);
            this.btnMorningWorshipPPT.TabIndex = 1;
            this.btnMorningWorshipPPT.Text = "오전예배 PPT";
            this.btnMorningWorshipPPT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMorningWorshipPPT.UseVisualStyleBackColor = true;
            this.btnMorningWorshipPPT.Click += new System.EventHandler(this.btnMorningWorshipPPT_Click);
            // 
            // btnIndividualHymnsPPT
            // 
            this.btnIndividualHymnsPPT.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnIndividualHymnsPPT.FlatAppearance.BorderSize = 0;
            this.btnIndividualHymnsPPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIndividualHymnsPPT.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnIndividualHymnsPPT.ForeColor = System.Drawing.Color.White;
            this.btnIndividualHymnsPPT.Location = new System.Drawing.Point(168, 0);
            this.btnIndividualHymnsPPT.Name = "btnIndividualHymnsPPT";
            this.btnIndividualHymnsPPT.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnIndividualHymnsPPT.Size = new System.Drawing.Size(123, 28);
            this.btnIndividualHymnsPPT.TabIndex = 3;
            this.btnIndividualHymnsPPT.Text = "시작 찬송가 PPT";
            this.btnIndividualHymnsPPT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIndividualHymnsPPT.UseVisualStyleBackColor = true;
            this.btnIndividualHymnsPPT.Click += new System.EventHandler(this.btnIndividualHymnsPPT_Click);
            // 
            // btnChoirLyricsInput
            // 
            this.btnChoirLyricsInput.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnChoirLyricsInput.FlatAppearance.BorderSize = 0;
            this.btnChoirLyricsInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoirLyricsInput.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnChoirLyricsInput.ForeColor = System.Drawing.Color.White;
            this.btnChoirLyricsInput.Location = new System.Drawing.Point(291, 0);
            this.btnChoirLyricsInput.Name = "btnChoirLyricsInput";
            this.btnChoirLyricsInput.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnChoirLyricsInput.Size = new System.Drawing.Size(130, 28);
            this.btnChoirLyricsInput.TabIndex = 2;
            this.btnChoirLyricsInput.Text = "성가대 가사 입력";
            this.btnChoirLyricsInput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChoirLyricsInput.UseVisualStyleBackColor = true;
            this.btnChoirLyricsInput.Click += new System.EventHandler(this.btnChoirLyricsInput_Click);
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(31)))));
            this.pnlDesktop.Controls.Add(this.choirLyricsInput1);
            this.pnlDesktop.Controls.Add(this.openingHymnsPPT1);
            this.pnlDesktop.Controls.Add(this.morningWorshipPPT1);
            this.pnlDesktop.Controls.Add(this.pnlMenu);
            this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktop.Location = new System.Drawing.Point(0, 29);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Size = new System.Drawing.Size(1618, 716);
            this.pnlDesktop.TabIndex = 1;
            // 
            // morningWorshipPPT1
            // 
            this.morningWorshipPPT1.Dock = System.Windows.Forms.DockStyle.Left;
            this.morningWorshipPPT1.Location = new System.Drawing.Point(0, 28);
            this.morningWorshipPPT1.Name = "morningWorshipPPT1";
            this.morningWorshipPPT1.Size = new System.Drawing.Size(492, 688);
            this.morningWorshipPPT1.TabIndex = 5;
            // 
            // openingHymnsPPT1
            // 
            this.openingHymnsPPT1.Dock = System.Windows.Forms.DockStyle.Left;
            this.openingHymnsPPT1.Location = new System.Drawing.Point(492, 28);
            this.openingHymnsPPT1.Name = "openingHymnsPPT1";
            this.openingHymnsPPT1.Size = new System.Drawing.Size(492, 688);
            this.openingHymnsPPT1.TabIndex = 6;
            // 
            // choirLyricsInput1
            // 
            this.choirLyricsInput1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(31)))));
            this.choirLyricsInput1.Dock = System.Windows.Forms.DockStyle.Left;
            this.choirLyricsInput1.Location = new System.Drawing.Point(984, 28);
            this.choirLyricsInput1.Name = "choirLyricsInput1";
            this.choirLyricsInput1.Size = new System.Drawing.Size(492, 688);
            this.choirLyricsInput1.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1618, 745);
            this.Controls.Add(this.pnlDesktop);
            this.Controls.Add(this.pnlTitleBar);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(508, 576);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Worship";
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlDesktop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Label lblProgramName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnChoirLyricsInput;
        private System.Windows.Forms.Button btnIndividualHymnsPPT;
        private System.Windows.Forms.Button btnMorningWorshipPPT;
        private System.Windows.Forms.Button btnTableOfContents;
        private System.Windows.Forms.Panel pnlDesktop;
        private ChoirLyricsInput choirLyricsInput1;
        private OpeningHymnsPPT openingHymnsPPT1;
        private MorningWorshipPPT morningWorshipPPT1;
    }
}

