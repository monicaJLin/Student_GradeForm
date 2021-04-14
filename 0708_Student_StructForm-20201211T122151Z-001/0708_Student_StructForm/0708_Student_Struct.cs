using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0708_Student_StructForm
{
    public partial class FormList : Form
    {
        public FormList()
        {
            InitializeComponent();
        }
        class 成績
        {
           public string Result;
           public string 姓名 = "";
            public int 國文, 英文, 數學;
        }


        //這句沒有意義 FormList score = new FormList();

        成績 score = new 成績();

        private void btn_save_Click(object sender, EventArgs e)
        {
            save();
        }

        void save( )
        {
            score.姓名 = textBox1.Text;
            score.國文 =int.Parse( textBox2.Text);
            score.英文 = int.Parse(textBox3.Text);
            score.數學 = int.Parse(textBox4.Text);
            score.Result +=$"{ "姓名"+"國文"+"英文"+"數學"}";
        }
        
        private void btn顯示_Click(object sender, EventArgs e)
        {
            lbl成績欄.Text = $"{ ("姓名:" + (textBox1.Text) + "\n\r" + "國文:" + (textBox2.Text) + "\n\r" + "英文:" + (textBox3.Text) + "\n\r"+ "數學:" + (textBox4.Text) + "\n\r")}";
           //???? lbl成績欄.Size = 22;
        }

        int i;
        private void btn最高低_Click(object sender, EventArgs e)
        {
            
            //陣列起始化
            string[] subjects = { label2.Text, label3.Text, label4.Text };
            double[] scores = new double[3];
            scores[0] = Convert.ToDouble(textBox2.Text);
            scores[1] = Convert.ToDouble(textBox3.Text);
            scores[2] = Convert.ToDouble(textBox4.Text);

            double 最高分 = 0;     //sum = 0,
            double 最低分 = 0;
            string 最高分的科目 = "";
            string 最低分的科目 = "";

            for (int i = 0; i < subjects.Length; i++)
            {
                //um += scores[i]; 

                if (scores[i] > 最高分)
                {
                    最高分 = scores[i];
                    最高分的科目 = subjects[i];

                }
            }

           

            for (int i = 0; i < subjects.Length; i++)
            {
                if (scores[i] < 最低分)
                {
                    最低分 = scores[i];
                    最低分的科目 = subjects[i];

                }
            }

            lbl顯示.Text = "最高科目成績為:" + 最高分的科目 + 最高分 + "\r\n" + "最低科目成績為:" + 最低分的科目 + 最低分 + "\r\n";
            //高分的科目;   /// "最低科目成績:\r\n" + 最低分的科目;

        }



        //void plus()
        // {
        // lbl成績欄.Text =
        // "姓名:" + textBox1 + "\n"
        // + "國文:" + textBox2 + "\n"
        // + "英文:" + textBox3 + "\n"
        //  + "數學:" + textBox4 + "\n";
        //}
    }
} 
