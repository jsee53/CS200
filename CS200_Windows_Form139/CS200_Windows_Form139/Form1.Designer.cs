namespace CS200_Windows_Form139
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtR = new System.Windows.Forms.TextBox();
            this.txtG = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.srcR = new System.Windows.Forms.HScrollBar();
            this.srcG = new System.Windows.Forms.HScrollBar();
            this.srcB = new System.Windows.Forms.HScrollBar();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(119, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 184);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Red";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Green";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "Blue";
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(529, 273);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(128, 21);
            this.txtR.TabIndex = 4;
            this.txtR.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(529, 305);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(128, 21);
            this.txtG.TabIndex = 5;
            this.txtG.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(529, 337);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(128, 21);
            this.txtB.TabIndex = 6;
            this.txtB.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // srcR
            // 
            this.srcR.Location = new System.Drawing.Point(190, 273);
            this.srcR.Name = "srcR";
            this.srcR.Size = new System.Drawing.Size(307, 17);
            this.srcR.TabIndex = 7;
            this.srcR.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scr_Scroll);
            // 
            // srcG
            // 
            this.srcG.Location = new System.Drawing.Point(190, 308);
            this.srcG.Name = "srcG";
            this.srcG.Size = new System.Drawing.Size(307, 17);
            this.srcG.TabIndex = 8;
            this.srcG.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scr_Scroll);
            // 
            // srcB
            // 
            this.srcB.Location = new System.Drawing.Point(190, 341);
            this.srcB.Name = "srcB";
            this.srcB.Size = new System.Drawing.Size(307, 17);
            this.srcB.TabIndex = 9;
            this.srcB.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scr_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.srcB);
            this.Controls.Add(this.srcG);
            this.Controls.Add(this.srcR);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtG);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.TextBox txtG;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.HScrollBar srcR;
        private System.Windows.Forms.HScrollBar srcG;
        private System.Windows.Forms.HScrollBar srcB;
    }
}

