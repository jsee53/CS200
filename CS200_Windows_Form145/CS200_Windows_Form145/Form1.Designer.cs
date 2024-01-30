namespace CS200_Windows_Form145
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSelected = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.myListView = new System.Windows.Forms.ListView();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.rbList = new System.Windows.Forms.RadioButton();
            this.rbDetail = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtSelected
            // 
            this.txtSelected.Location = new System.Drawing.Point(504, 349);
            this.txtSelected.Name = "txtSelected";
            this.txtSelected.Size = new System.Drawing.Size(220, 21);
            this.txtSelected.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(422, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "Selected:";
            // 
            // myListView
            // 
            this.myListView.HideSelection = false;
            this.myListView.Location = new System.Drawing.Point(55, 106);
            this.myListView.Name = "myListView";
            this.myListView.Size = new System.Drawing.Size(669, 225);
            this.myListView.TabIndex = 11;
            this.myListView.UseCompatibleStateImageBehavior = false;
            this.myListView.SelectedIndexChanged += new System.EventHandler(this.myListView_SelectedIndexChanged);
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(562, 73);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(75, 16);
            this.rbLarge.TabIndex = 10;
            this.rbLarge.TabStop = true;
            this.rbLarge.Text = "큰 아이콘";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(424, 73);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(87, 16);
            this.rbSmall.TabIndex = 9;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "작은 아이콘";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // rbList
            // 
            this.rbList.AutoSize = true;
            this.rbList.Location = new System.Drawing.Point(279, 73);
            this.rbList.Name = "rbList";
            this.rbList.Size = new System.Drawing.Size(59, 16);
            this.rbList.TabIndex = 8;
            this.rbList.TabStop = true;
            this.rbList.Text = "리스트";
            this.rbList.UseVisualStyleBackColor = true;
            this.rbList.CheckedChanged += new System.EventHandler(this.rbList_CheckedChanged);
            // 
            // rbDetail
            // 
            this.rbDetail.AutoSize = true;
            this.rbDetail.Location = new System.Drawing.Point(152, 73);
            this.rbDetail.Name = "rbDetail";
            this.rbDetail.Size = new System.Drawing.Size(59, 16);
            this.rbDetail.TabIndex = 7;
            this.rbDetail.Text = "자세히";
            this.rbDetail.UseVisualStyleBackColor = true;
            this.rbDetail.CheckedChanged += new System.EventHandler(this.rbDetail_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSelected);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.myListView);
            this.Controls.Add(this.rbLarge);
            this.Controls.Add(this.rbSmall);
            this.Controls.Add(this.rbList);
            this.Controls.Add(this.rbDetail);
            this.Name = "Form1";
            this.Text = "ListView";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSelected;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView myListView;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.RadioButton rbList;
        private System.Windows.Forms.RadioButton rbDetail;
    }
}

