namespace Worship {
    partial class ChoirLyricsInput {
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.rtbLyricsText = new System.Windows.Forms.RichTextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "가사를 입력해 주세요. 단락 간 빈 줄로 슬라이드를 구분합니다.";
            // 
            // rtbLyricsText
            // 
            this.rtbLyricsText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(31)))));
            this.rtbLyricsText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbLyricsText.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rtbLyricsText.ForeColor = System.Drawing.Color.White;
            this.rtbLyricsText.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.rtbLyricsText.Location = new System.Drawing.Point(38, 50);
            this.rtbLyricsText.Name = "rtbLyricsText";
            this.rtbLyricsText.Size = new System.Drawing.Size(417, 403);
            this.rtbLyricsText.TabIndex = 4;
            this.rtbLyricsText.Text = "ex)나 같은 죄인 살리신\n주 은혜 고마와\n\n나 처음 믿은 그 시간\n귀하고 귀하다\n";
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.Location = new System.Drawing.Point(385, 464);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "첨부";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // ChoirLyricsInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(31)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbLyricsText);
            this.Controls.Add(this.btnAdd);
            this.Name = "ChoirLyricsInput";
            this.Size = new System.Drawing.Size(492, 682);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbLyricsText;
        private System.Windows.Forms.Button btnAdd;
    }
}
