namespace Worship {
    partial class OpeningHymnsPPT {
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
            this.btnNumberAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtHymn = new System.Windows.Forms.TextBox();
            this.lblOrder = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNumberAdd
            // 
            this.btnNumberAdd.FlatAppearance.BorderSize = 0;
            this.btnNumberAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNumberAdd.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnNumberAdd.Location = new System.Drawing.Point(256, 14);
            this.btnNumberAdd.Name = "btnNumberAdd";
            this.btnNumberAdd.Size = new System.Drawing.Size(70, 23);
            this.btnNumberAdd.TabIndex = 43;
            this.btnNumberAdd.Text = "번호 추가";
            this.btnNumberAdd.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(31)))));
            this.label4.Location = new System.Drawing.Point(43, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 15);
            this.label4.TabIndex = 41;
            this.label4.Text = "찬송가 번호를 입력해 주세요.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnNumberAdd);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 47);
            this.panel1.TabIndex = 45;
            // 
            // txtHymn
            // 
            this.txtHymn.BackColor = System.Drawing.Color.White;
            this.txtHymn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHymn.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtHymn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(31)))));
            this.txtHymn.Location = new System.Drawing.Point(82, 22);
            this.txtHymn.MaxLength = 3;
            this.txtHymn.Name = "txtHymn";
            this.txtHymn.Size = new System.Drawing.Size(244, 23);
            this.txtHymn.TabIndex = 36;
            this.txtHymn.Text = "1";
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(31)))));
            this.lblOrder.Location = new System.Drawing.Point(59, 24);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(17, 15);
            this.lblOrder.TabIndex = 37;
            this.lblOrder.Text = "1.";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtHymn);
            this.panel2.Controls.Add(this.lblOrder);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(465, 57);
            this.panel2.TabIndex = 46;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAdd.Location = new System.Drawing.Point(256, 16);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 23);
            this.btnAdd.TabIndex = 43;
            this.btnAdd.Text = "첨부";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreate.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCreate.Location = new System.Drawing.Point(332, 16);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(70, 23);
            this.btnCreate.TabIndex = 42;
            this.btnCreate.Text = "개별 생성";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Controls.Add(this.btnCreate);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 104);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(465, 578);
            this.panel3.TabIndex = 47;
            // 
            // OpeningHymnsPPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "OpeningHymnsPPT";
            this.Size = new System.Drawing.Size(465, 682);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNumberAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtHymn;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Panel panel3;
    }
}
