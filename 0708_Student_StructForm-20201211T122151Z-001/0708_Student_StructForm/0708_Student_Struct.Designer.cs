namespace _0708_Student_StructForm
{
    partial class FormList
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn儲存 = new System.Windows.Forms.Button();
            this.btn顯示 = new System.Windows.Forms.Button();
            this.lbl_grade = new System.Windows.Forms.Label();
            this.lbl成績欄 = new System.Windows.Forms.Label();
            this.lbl顯示 = new System.Windows.Forms.Label();
            this.btn最高低 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(111, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(111, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "國文 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(111, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "英文 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(111, 242);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 38);
            this.label4.TabIndex = 3;
            this.label4.Text = "數學 :";
            // 
            // btn儲存
            // 
            this.btn儲存.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn儲存.Location = new System.Drawing.Point(83, 304);
            this.btn儲存.Margin = new System.Windows.Forms.Padding(4);
            this.btn儲存.Name = "btn儲存";
            this.btn儲存.Size = new System.Drawing.Size(163, 60);
            this.btn儲存.TabIndex = 4;
            this.btn儲存.Text = "儲存";
            this.btn儲存.UseVisualStyleBackColor = true;
            this.btn儲存.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn顯示
            // 
            this.btn顯示.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn顯示.Location = new System.Drawing.Point(269, 304);
            this.btn顯示.Margin = new System.Windows.Forms.Padding(4);
            this.btn顯示.Name = "btn顯示";
            this.btn顯示.Size = new System.Drawing.Size(163, 60);
            this.btn顯示.TabIndex = 5;
            this.btn顯示.Text = "顯示儲存內容";
            this.btn顯示.UseVisualStyleBackColor = true;
            this.btn顯示.Click += new System.EventHandler(this.btn顯示_Click);
            // 
            // lbl_grade
            // 
            this.lbl_grade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_grade.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_grade.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_grade.Location = new System.Drawing.Point(459, 39);
            this.lbl_grade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_grade.Name = "lbl_grade";
            this.lbl_grade.Size = new System.Drawing.Size(78, 34);
            this.lbl_grade.TabIndex = 6;
            this.lbl_grade.Text = "成績";
            this.lbl_grade.UseCompatibleTextRendering = true;
            this.lbl_grade.UseWaitCursor = true;
            // 
            // lbl成績欄
            // 
            this.lbl成績欄.AllowDrop = true;
            this.lbl成績欄.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl成績欄.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl成績欄.Location = new System.Drawing.Point(459, 74);
            this.lbl成績欄.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl成績欄.MaximumSize = new System.Drawing.Size(399, 374);
            this.lbl成績欄.Name = "lbl成績欄";
            this.lbl成績欄.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl成績欄.Size = new System.Drawing.Size(277, 164);
            this.lbl成績欄.TabIndex = 7;
            // 
            // lbl顯示
            // 
            this.lbl顯示.AllowDrop = true;
            this.lbl顯示.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl顯示.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl顯示.Location = new System.Drawing.Point(459, 242);
            this.lbl顯示.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl顯示.MaximumSize = new System.Drawing.Size(399, 374);
            this.lbl顯示.Name = "lbl顯示";
            this.lbl顯示.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl顯示.Size = new System.Drawing.Size(277, 91);
            this.lbl顯示.TabIndex = 8;
            // 
            // btn最高低
            // 
            this.btn最高低.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn最高低.Location = new System.Drawing.Point(516, 338);
            this.btn最高低.Margin = new System.Windows.Forms.Padding(4);
            this.btn最高低.Name = "btn最高低";
            this.btn最高低.Size = new System.Drawing.Size(220, 60);
            this.btn最高低.TabIndex = 9;
            this.btn最高低.Text = "最高分/最低分項目";
            this.btn最高低.UseVisualStyleBackColor = true;
            this.btn最高低.Click += new System.EventHandler(this.btn最高低_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("新細明體", 18F);
            this.textBox1.Location = new System.Drawing.Point(200, 55);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 43);
            this.textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("新細明體", 18F);
            this.textBox2.Location = new System.Drawing.Point(200, 115);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 43);
            this.textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("新細明體", 18F);
            this.textBox3.Location = new System.Drawing.Point(200, 182);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(132, 43);
            this.textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("新細明體", 18F);
            this.textBox4.Location = new System.Drawing.Point(200, 245);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(132, 43);
            this.textBox4.TabIndex = 14;
            // 
            // FormList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 439);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn最高低);
            this.Controls.Add(this.lbl顯示);
            this.Controls.Add(this.lbl成績欄);
            this.Controls.Add(this.lbl_grade);
            this.Controls.Add(this.btn顯示);
            this.Controls.Add(this.btn儲存);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormList";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn儲存;
        private System.Windows.Forms.Button btn顯示;
        private System.Windows.Forms.Label lbl_grade;
        private System.Windows.Forms.Label lbl成績欄;
        private System.Windows.Forms.Label lbl顯示;
        private System.Windows.Forms.Button btn最高低;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}

