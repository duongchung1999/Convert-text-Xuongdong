using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MerryTest.Entity;

namespace Xuong_dong
{
    public partial class Form1 : Form
    {
        private UIAdaptiveSize uias;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string a = rtbInput.Text.Replace(". ", ".");
            a = a.Replace("《", "「");
            a = a.Replace("》", "」");
            a = a.Replace("？", "?");
            a = a.Replace("◎ ", "");
            a = a.Replace("！", "!");
            a = a.Replace("。」", "」。");
            a = a.Replace("（981115早餐）", "\n");
            a = a.Replace("phật", "Phật");
            a = a.Replace("a di đà", "A Di Đà");
            a = a.Replace("như lai", "Như Lai");
            a = a.Replace("vô lượng thọ", "'Vô Lượng Thọ'");
            a = a.Replace("tổ sư đại đức", "Tổ sư Đại đức");
            a = a.Replace("duyến", "duyên");
            a = a.Replace("sa bà", "Sa bà");//dē 
            a = a.Replace("thụy tương", "thụy tướng");
            a = a.Replace("tăng trường", "tăng trưởng");
            a = a.Replace("năng cú", "năng câu");
            a = a.Replace("miễn nan", "miễn nạn");
            a = a.Replace(" thì ", " thời ");
            a = a.Replace("dung dịch", "dung dị");
            a = a.Replace("vu ", "ư ");
            a = a.Replace("ứng i ", "ứng cai ");
            a = a.Replace(" Một", " một");
            a = a.Replace("o độ", "cao độ");
            a = a.Replace(" ki ", " cơ ");
            a = a.Replace("bồ tát", "Bồ tát");
            a = a.Replace("gian đoạn", "gián đoạn"); 
            a = a.Replace("duyến", "duyên");
            a = a.Replace("đế nhàn", "Đế Nhàn");
            a = a.Replace("Đế nhàn", "Đế Nhàn");
            a = a.Replace("pháp sư", "Pháp sư");
            a = a.Replace("thập ma", "thậm ma");
            a = a.Replace("chích", "chỉ");
            a = a.Replace("(giá", "giá");
            a = a.Replace("(Giá", "giá");
            a = a.Replace("lục tổ huệ năng", "Lục tổ Huệ Năng");
            a = a.Replace("huệ năng", "Huệ Năng");
            a = a.Replace("đại sư", "Đại sư");
            a = a.Replace("Lục tổ huệ năng", "Lục tổ Huệ Năng");
            a = a.Replace("tịnh độ", "Tịnh Độ");
            a = a.Replace("vãng sanh truyện", "'Vãng sanh truyện'");
            a = a.Replace("cáp nễ tân", "Cáp Nhĩ Tân");
            a = a.Replace("cáp nhĩ tân", "Cáp Nhĩ Tân");
            a = a.Replace("trú trì", "trụ trì");
            a = a.Replace("trú trì", "trụ trì");
            a = a.Replace("Kim cương kinh", "“Kim Cương Kinh”");
            a = a.Replace("kim cương kinh", "“Kim Cương Kinh”");
            a = a.Replace("trứ ", "trước ");
            a = a.Replace("phạm võng kinh", "Phạm Võng Kinh");
            a = a.Replace("xác (thật ", "xác thật");
            a = a.Replace("Huệ năng", "Huệ Năng");
            a = a.Replace("thác", "thố");
            a = a.Replace("Phổ hiền", "Phổ Hiền");
            a = a.Replace("phổ hiền", "Phổ Hiền");
            a = a.Replace("Hoa nghiêm kinh", "'Hoa Nghiêm Kinh'");
            a = a.Replace("hoa nghiêm kinh", "'Hoa Nghiêm Kinh'");
            a = a.Replace("Lão tử", "Lão Tử");
            a = a.Replace("lão tử", "Lão Tử");
            a = a.Replace("bì lô già na", "Tỳ Lô Giá Na");
            a = a.Replace("liên mẫn", "lân mẫn");
            a = a.Replace("Giang vị nông", "Giang Vị Nông");
            a = a.Replace("giang vị nông", "Giang Vị Nông");
            a = a.Replace("lượng chu sa giới", "lượng châu sa giới");
            a = a.Replace("soa biệt", "sai biệt");
            a = a.Replace("chiêm hữu", "chiếm hữu");
            a = a.Replace("thì,", "thời,");
            a = a.Replace("thì.", "thời.");
            a = a.Replace("Phật đà", "Phật Đà");
            a = a.Replace("thụy", "thùy");
            a = a.Replace("thiện duyệt", "thiền duyệt");
            a = a.Replace("thiện định", "thiền định");
            a = a.Replace("bát nhã", "Bát Nhã");
            a = a.Replace("trọng phức", "trùng phức");
            a = a.Replace("phụ đam", "phụ đảm");
            a = a.Replace("khan tham", "san tham");
            a = a.Replace("kì hiện", "thị hiện");
            a = a.Replace("tai nan", "tai nạn");
            a = a.Replace("Phổ Hiền hành", "Phổn Hiền hạnh");
            a = a.Replace("tinh tiến", "tinh tấn");
            a = a.Replace("xứ sự", "xử sự");
            a = a.Replace("y lại", "ỷ lại");
            a = a.Replace("nhĩ", "nễ");
            a = a.Replace("Nhĩ", "Nễ");
            a = a.Replace(" thì ", " thời ");
            a = a.Replace("chích", "chỉ");
            a = a.Replace("yêu", "yếu");
            a = a.Replace("đại tàng", "đại tạng");
            a = a.Replace("nhạc", "lạc");
            a = a.Replace("trúng", "trung");
            a = a.Replace("yếu cầu", "yêu cầu");
            a = a.Replace("đại sĩ", "Đại sĩ");
            a = a.Replace("đại đức", "Đại đức");
            a = a.Replace("tiễn", "tiền");
            a = a.Replace("hập ma", "hậm ma");
            a = a.Replace("xá khí", "xả khí");
            a = a.Replace("xá kỷ", "xả kỷ");
            a = a.Replace("mĩ ", "mỹ ");
            a = a.Replace("chúc ư", "thuộc ư");
            a = a.Replace("nhập quan", "nhập quán");
            a = a.Replace("thụ dụng", "thọ dụng");
            a = a.Replace("yếu ma", "yêu ma");
            a = a.Replace("di lặc", "Di Lặc");
            a = a.Replace("gian thoại", "nhàn thoại");
            a = a.Replace("a tì", "A Tì");
            a = a.Replace("thiện tông", "Thiền tông");
            a = a.Replace("thánh nhất", "Thánh Nhất");
            a = a.Replace("thiện đường", "Thiền đường");
            a = a.Replace("Ấn quang", "Ấn Quang");
            a = a.Replace("ấn quang", "Ấn Quang");
            a = a.Replace("luy ", "lụy ");
            a = a.Replace("kiền nhiễu", "can nhiễu");
            a = a.Replace("tam bảo", "Tam Bảo");
            a = a.Replace("thiên thai", "Thiên Thai");
            a = a.Replace("viên giáo", "Viên giáo");
            a = a.Replace("thập tín vị", "Thập Tín Vị");
            a = a.Replace("duyên phân", "duyên phận");
            a = a.Replace("thai loan", "Đài Loan");
            a = a.Replace("đài bắc", "Đài Bắc");
            a = a.Replace("lí tể hoa", "Lí Tể Hoa");
            a = a.Replace("Hàn quán trường", "Hàn Quán Trưởng");
            a = a.Replace("hàn quán trường", "Hàn Quán Trưởng");
            a = a.Replace("lí bỉnh nam", "Lý Bỉnh Nam");
            a = a.Replace("lí lão", "Lý lão");
            a = a.Replace("liên thai", "Liên Đài");
            a = a.Replace("Liên thai", "Liên Đài");
            a = a.Replace("tao nan", "tao nạn");
            a = a.Replace("liễu phàm", "Liễu Phàm");
            a = a.Replace("viên Liễu Phàm", "Viên Liễu Phàm");
            a = a.Replace("lăng nghiêm", "Lăng Nghiêm");
            a = a.Replace("thượng hải", "Thượng Hải");
            a = a.Replace("đức quốc", "Đức quốc");
            // a = a1;
            //a.Replace("dē", "dē");
            string chuoi = "";

            //string[] m = a.Split('.','。','?','!','？');
            ////foreach (string b in m)
            ////{
            ////    chuoi += b;
            ////}
            //for (int i = 0; i < m.Length; i++)
            //{
            //    if (!m[i].StartsWith("("))
            //    {
            //        chuoi = chuoi + m[i] + cbEnd.Text+"\n";
            //    }

            //}
            chuoi = AllConvert(a);
            chuoi.Replace("dē", "dē");

            rtbOutput.Text = chuoi;
        }
       
        private string AllConvert(string input)
        {
            char[] m = { '.', '。', '?', '!', '？' };
            string output = "";
            foreach (char c in m)
            {
                //output = "";
                input = ConvertText(input, c);
                //output += ConvertText(input, c);
            }
            string text = ReplaceText(input);
            return text;
        }
        private string ConvertText(string input, char x)
        {
            string[] m = input.Split(x);
            string output = "";
            for (int i = 0; i < m.Length; i++)
            {
                if(i == m.Length - 1)
                {
                    output = output + m[i];
                }
                else output = output + m[i] + x + "\n";
            }
            //output = Regex.Replace(output, @"\s+", " ");
            output = output.Replace("\n\n", "\n");
            return output;
        }
        private string ReplaceText(string input)
        {
            //string text = File.ReadAllText(input);
            string text = input.Replace("nguyễn văn a", "Nguyễn Văn A");
            input = text.Replace("123", "456");
            text = input.Replace("Giá", "giá");
            return text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            flag1 = true;
            uias = new UIAdaptiveSize
            {
                Width = Width,
                Height = Height,
                FormsName = this.Text,
                X = Width,
            };
            uias.SetInitSize(this);
            this.WindowState = FormWindowState.Maximized;
        }

        bool flag1 = false;
        private void Form1_Resize_1(object sender, EventArgs e)
        {
            if (!flag1) return;
            var newx = Width;
            uias.UpdateSize(Width, Height, this);
            uias.X = newx;
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            string input = rtbInput2.Text;
            input = input.Replace("dē ", "de ");
            input = input.Replace("bú ", "bù ");
            input = input.Replace("ā mí tuó fú", "ā mí tuó fó");//yī xīn xiàng fú
            input = input.Replace("yī xīn xiàng fú", "yī xīn xiàng fó");
            input = input.Replace("yǐ wèi", "yǐ wéi");
            input = input.Replace("kǔ nán", "kǔ nàn");
            input = input.Replace("fú hào", "fó hào");
            input = input.Replace("fú pú sà", "fó pú sà");
            input = input.Replace("xué fú", "xué fó");
            input = input.Replace("pí lú zhē nà fú", "pí lú zhē nà fó");
            input = input.Replace("fú shuō", "fó shuō");
            input = input.Replace("zhí zhe", "zhí zhuó");
            input = input.Replace("zhū fú", "zhū fó");
            input = input.Replace("chù shì", "Chǔ shì");
            input = input.Replace("fú gào sù", "fó gào sù");
            input = input.Replace("zhǎng shòu", "cháng shòu");
            input = input.Replace("zhǎng shòu", "cháng shòu");
            string output = input;
            rtbOutput2.Text = output;
        }
    }
}
