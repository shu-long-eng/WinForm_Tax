using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //public class TotalResult
        //{
        //    public string ResultDateFrom { get; set; }
        //    public string ResultDateTo { get; set; }
        //    public int ResultDays { get; set; }
        //    public string Emissions { get; set; }
        //    public string Type { get; set; }
        //    public string Formula { get; set; }
        //    public decimal Tax { get; set; }
        //}

        private int _base;
        private string _emissions;
        private string _type;
        private int _thisyear = Convert.ToInt32(DateTime.Now.ToString("yyyy"));
        private DateTime _dateFrom;
        private DateTime _dateTo;
        private int _d;
        private decimal _tax;
        private int _thisyeardays;
        private int _minusyear;
        private int _fromyear;
        private int _toyear;

        string[] Output;

        Form2 form = new Form2();
        DateTime starDate;
        DateTime endDate;
        private void ResetInput()
        {
            this.radioButton1.Checked = true;
            this.truckComboBox.Visible = false;
            this.BigCar.Visible = false;
            this.smCar.Visible = false;
            this.BusinessCar.Visible = false;
            this.comboBox1.SelectedIndex = 0;
            this.BikeComboBox.SelectedIndex = 0;
            this.dateTimePicker1.Value = new DateTime(_thisyear, 01, 01);
            this.dateTimePicker2.Value = new DateTime(_thisyear, 12, 31);
            this.result.Text = "";
            this.label9.Text = "";
            _base = 0; 

        }
        //private string OutputString(List<TotalResult> list,int index)
        //{
        //  string result =  $"使用期間: {list[index].ResultDateFrom} ~ {list[index].ResultDateTo}" + Environment.NewLine +
        //                   $"計算天數:{list[index].ResultDays}" + Environment.NewLine +
        //                   $"汽缸CC數:{list[index].Emissions}" + Environment.NewLine +
        //                   $"用途:{list[index].Type}" + Environment.NewLine +
        //                   $"計算公式:{list[index].Formula}" + Environment.NewLine +
        //                   $"應納稅額:{list[index].Tax}" + Environment.NewLine + Environment.NewLine;
        //    return result;
        //}
        private int yeardays(int _thisyear)
        {
            if (_thisyear % 4 == 0)
            {
             return    366;
            }
            else
            {
             return  365;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ResetInput();
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.DatePanel.Visible = false;
        }
        
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //this.DatePanel.Visible = true;
            if (radioButton2.Checked)
            {
                
                form.Show();
                
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.comboBox1.SelectedIndex;
            _type = this.comboBox1.SelectedItem.ToString();
            switch (index)
            {
                case 0:
                    this.BikeComboBox.Visible = true;
                    this.truckComboBox.Visible = false;
                    this.BigCar.Visible = false;
                    this.smCar.Visible = false;
                    this.BusinessCar.Visible = false;
                    this.BikeComboBox.SelectedIndex = 0;
                    break;
                case 1:
                    this.BikeComboBox.Visible = false;
                    this.truckComboBox.Visible = true;
                    this.BigCar.Visible = false;
                    this.smCar.Visible = false;
                    this.BusinessCar.Visible = false;
                    this.truckComboBox.SelectedIndex = 0;
                    break;
                case 2:
                    this.BikeComboBox.Visible = false;
                    this.truckComboBox.Visible = false;
                    this.BigCar.Visible = true;
                    this.smCar.Visible = false;
                    this.BusinessCar.Visible = false;
                    this.BigCar.SelectedIndex = 0;
                    break;
                case 3:
                    this.BikeComboBox.Visible = false;
                    this.truckComboBox.Visible = false;
                    this.BigCar.Visible = false;
                    this.smCar.Visible = true;
                    this.BusinessCar.Visible = false;
                    this.smCar.SelectedIndex = 0;
                    break;
                case 4:
                    this.BikeComboBox.Visible = false;
                    this.truckComboBox.Visible = false;
                    this.BigCar.Visible = false;
                    this.smCar.Visible = false;
                    this.BusinessCar.Visible = true;
                    this.BusinessCar.SelectedIndex = 0;
                    break;
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://law-out.mof.gov.tw/LawContent.aspx?id=FL006130");
        }

        private void BikeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.BikeComboBox.SelectedIndex;
            _emissions = this.BikeComboBox.SelectedItem.ToString();
            switch (index)
            {
                case 0:
                    _base = 0; break;
                case 1:
                    _base = 800; break;
                case 2:
                    _base = 1620; break;
                case 3:
                    _base = 2160; break;
                case 4:
                    _base = 4320; break;
                case 5:
                    _base = 7120; break;
                case 6:
                    _base = 11230; break;
            }
        }

        private void truckComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.truckComboBox.SelectedIndex;
            _emissions = this.truckComboBox.SelectedItem.ToString();
            switch (index)
            {
                case 0:
                    _base = 900; break;
                case 1:
                    _base = 1080; break;
                case 2:
                    _base = 1800; break;
                case 3:
                    _base = 2700; break;
                case 4:
                    _base = 3600; break;
                case 5:
                    _base = 4500; break;
                case 6:
                    _base = 5400; break;
                case 7:
                    _base = 6300; break;
                case 8:
                    _base = 7200; break;
                case 9:
                    _base = 8100; break;
                case 10:
                    _base = 9000; break;
                case 11:
                    _base = 9900; break;
                case 12:
                    _base = 10800; break;
                case 13:
                    _base = 11700; break;
                case 14:
                    _base = 12600; break;
                case 15:
                    _base = 13500; break;
                case 16:
                    _base = 14400; break;
                case 17:
                    _base = 15300; break;
                case 18:
                    _base = 16200; break;
            }
        }

        private void BigCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.BigCar.SelectedIndex;
            _emissions = this.BigCar.SelectedItem.ToString();
            switch (index)
            {
                case 0:
                    _base = 1080; break;
                case 1:
                    _base = 1800; break;
                case 2:
                    _base = 2700; break;
                case 3:
                    _base = 3600; break;
                case 4:
                    _base = 4500; break;
                case 5:
                    _base = 5400; break;
                case 6:
                    _base = 6300; break;
                case 7:
                    _base = 7200; break;
                case 8:
                    _base = 8100; break;
                case 9:
                    _base = 9000; break;
                case 10:
                    _base = 9900; break;
                case 11:
                    _base = 10800; break;
                case 12:
                    _base = 11700; break;
                case 13:
                    _base = 12600; break;
                case 14:
                    _base = 13500; break;
                case 15:
                    _base = 14400; break;
                case 16:
                    _base = 15300; break;
                case 17:
                    _base = 16200; break;
                
            }
        }

        private void smCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.smCar.SelectedIndex;
            _emissions = this.smCar.SelectedItem.ToString();
            switch (index)
            {
                case 0:
                    _base = 1620; break;
                case 1:
                    _base = 2160; break;
                case 2:
                    _base = 4320; break;
                case 3:
                    _base = 7120; break;
                case 4:
                    _base = 11230; break;
                case 5:
                    _base = 15210; break;
                case 6:
                    _base = 28220; break;
                case 7:
                    _base = 46170; break;
                case 8:
                    _base = 69690; break;
                case 9:
                    _base = 117000; break;
                case 10:
                    _base = 151200; break;
            }
        }

        private void BusinessCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.BusinessCar.SelectedIndex;
            _emissions = this.BusinessCar.SelectedItem.ToString();
            switch (index)
            {
                case 0:
                    _base = 900; break;
                case 1:
                    _base = 1260; break;
                case 2:
                    _base = 2160; break;
                case 3:
                    _base = 3060; break;
                case 4:
                    _base = 6480; break;
                case 5:
                    _base = 9900; break;
                case 6:
                    _base = 16380; break;
                case 7:
                    _base = 24300; break;
                case 8:
                    _base = 33660; break;
                case 9:
                    _base = 44460; break;
                case 10:
                    _base = 56700; break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResetInput();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           


            


            this.result.Text = "";
            this.label9.Text = "";





            //_thisyeardays = yeardays(_thisyear);
            //if (radioButton1.Checked)
            //{

            //    _dateFrom = Convert.ToDateTime(_thisyear + " - 01 - 01");
            //    _dateTo = Convert.ToDateTime(_thisyear + " - 12 - 31");
            //    _minusyear = 0;
            //    _d = (_dateTo.AddDays(1) - _dateFrom).Days;

            //}
            //else if (radioButton2.Checked)
            //{

            //    _dateFrom = this.dateTimePicker1.Value;
            //    _dateTo = this.dateTimePicker2.Value;
            //    if (_dateFrom > _dateTo)
            //    {
            //        var temp = _dateTo;
            //        _dateTo = _dateFrom;
            //        _dateFrom = temp;
            //    }

            //    _fromyear = Convert.ToInt32(_dateFrom.ToString("yyyy"));
            //    _toyear = Convert.ToInt32(_dateTo.ToString("yyyy"));
            //    _minusyear = _toyear - _fromyear;

            //    if (_fromyear < (_thisyear-10) || _toyear > (_thisyear+10)) { MessageBox.Show("請輸入最近10年內的日期"); return; }

            //    _d = (_dateTo.AddDays(1) - _dateFrom).Days;

            //}
            //List<TotalResult> list = new List<TotalResult>();


            //if (_minusyear > 0)
            //{
            //    int index = 0;
            //    for (var i = _fromyear; i <= _toyear; i++)
            //    {

            //        if(i!=_fromyear && i != _toyear)
            //        {

            //            _thisyeardays = yeardays(i);


            //        list.Add(
            //        new TotalResult()
            //        {
            //            ResultDateFrom = i.ToString() + "-01-01",
            //            ResultDateTo = i.ToString() + "-12-31",
            //            ResultDays = Convert.ToInt32(_thisyeardays),
            //            Emissions = _emissions,
            //            Type = _type,
            //            Formula = $"{_base} * {_thisyeardays} / {_thisyeardays} = {_base * _thisyeardays / _thisyeardays} 元",
            //            Tax = _base * _thisyeardays / _thisyeardays
            //        }
            //        );

            //        }
            //        else if (i == _fromyear)
            //        {
            //         _thisyeardays = yeardays(_fromyear);
            //         _dateTo = Convert.ToDateTime(i + " - 12 - 31");
            //        _d = (_dateTo.AddDays(1) - _dateFrom).Days;

            //        list.Add(
            //        new TotalResult()
            //        {
            //            ResultDateFrom = _dateFrom.ToString("yyyy-MM-dd"),
            //            ResultDateTo = _dateTo.ToString("yyyy-MM-dd"),
            //            ResultDays = Convert.ToInt32(_d),
            //            Emissions = _emissions,
            //            Type = _type,
            //            Formula = $"{_base} * {_d} / {_thisyeardays} = {_base * _d / _thisyeardays} 元",
            //            Tax = _base * _d / _thisyeardays
            //        }
            //        );
            //        }else if(i == _toyear)
            //        {

            //            _dateFrom = Convert.ToDateTime(i + " - 01 - 01");
            //            _dateTo = this.dateTimePicker2.Value;
            //            if (_dateFrom > _dateTo)
            //            {
            //                _dateTo = this.dateTimePicker1.Value;
            //            }
            //            _thisyeardays = yeardays(_toyear);
            //            _d = (_dateTo.AddDays(1) - _dateFrom).Days;

            //            list.Add(
            //       new TotalResult()
            //       {
            //           ResultDateFrom = i.ToString() + "-01-01",
            //           ResultDateTo = _dateTo.ToString("yyyy-MM-dd"),
            //           ResultDays = Convert.ToInt32(_d),
            //           Emissions = _emissions,
            //           Type = _type,
            //           Formula = $"{_base} * {_d} / {_thisyeardays} = {_base * _d / _thisyeardays} 元",
            //           Tax = _base * _d / _thisyeardays
            //       }
            //       );
            //        }




            //        this.result.Text += OutputString(list, index);

            //        index++;


            //    }

            //    decimal totalTax = 0;

            //    for (int i = 0; i <= _minusyear; i++)
            //    {
            //        totalTax = totalTax + list[i].Tax;
            //    }

            //    this.label9.Text = $"全部應納稅額: 共 {totalTax} 元";

            //}
            //else if(_minusyear == 0)
            //{

            //    _tax = Convert.ToDecimal(_base * _d / _thisyeardays);


            //    list.Add(
            //        new TotalResult()
            //        {
            //            ResultDateFrom = _dateFrom.ToString("yyyy-MM-dd"),
            //            ResultDateTo = _dateTo.ToString("yyyy-MM-dd"),
            //            ResultDays = Convert.ToInt32(_d),
            //            Emissions = _emissions,
            //            Type = _type,
            //            Formula = $"{_base} * {_d} / {_thisyeardays} = {_base * _d / _thisyeardays} 元",
            //            Tax = _tax
            //        }
            //        );




            //    this.result.Text = OutputString(list, 0);
            //}

            //var starDate = this.dateTimePicker1.Value;
            //var endDate = this.dateTimePicker2.Value;

            if (this.radioButton1.Checked)
            {
               starDate = new DateTime(_thisyear, 01, 01);
               endDate =  new DateTime(_thisyear, 12, 31);
            }
            else {

            starDate = form.startTime;
            endDate = form.endTime;
            }
            if (starDate > endDate)
            {
                var temp = endDate;
                endDate = starDate;
                starDate = temp;
            }
            var total = 0;
            if(starDate.Year< (DateTime.Now.Year - 10) || endDate.Year > (DateTime.Now.Year + 10))
            {
                MessageBox.Show("僅能試算近10年內的稅額");
                return;
            }
            for (var i = starDate.Year; i <= endDate.Year; i++)
            {
                var thisYearStar = new DateTime(i, 1, 1);
                var thisYearEnd = new DateTime(i, 12, 31);

                var periorStar = (starDate > thisYearStar) ? starDate : thisYearStar;
                var periorEnd = (endDate < thisYearEnd) ? endDate : thisYearEnd;

                _d = (periorEnd.AddDays(1) - periorStar).Days;

                _thisyeardays = yeardays(i);



                this.result.Text += $"使用期間: {periorStar.ToString("yyyy-MM-dd")} ~ {periorEnd.ToString("yyyy-MM-dd")}" + Environment.NewLine +
                                    $"計算天數:{_d}" + Environment.NewLine +
                                    $"汽缸CC數:{_emissions}" + Environment.NewLine +
                                    $"用途:{_type}" + Environment.NewLine +
                                    $"計算公式:{_base} * {_d} / {_thisyeardays} = {_base * _d / _thisyeardays} 元" + Environment.NewLine +
                                    $"應納稅額:{_base * _d / _thisyeardays}" + Environment.NewLine + Environment.NewLine;
                total = total + (_base * _d / _thisyeardays);

                Output = new string[6] { periorStar.ToString("yyyy-MM-dd"), periorEnd.ToString("yyyy-MM-dd") , _emissions , _type, this.result.Text,DateTime.Now.ToString()};
            }
            
            

            if(endDate.Year-starDate.Year > 0)
                this.label9.Text = $"全部應納稅額: 共 {total} 元";


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            
            this.saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter =
            "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            var result = this.saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filePath = this.saveFileDialog1.FileName;
                string content = string.Join(",", Output);
                System.IO.File.WriteAllText(filePath, content);
                MessageBox.Show("存檔完成");
            }
            
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            var result = this.openFileDialog1.ShowDialog();

            if(result == DialogResult.OK)
            {

                string fileOpen = this.openFileDialog1.FileName;
                string content = System.IO.File.ReadAllText(fileOpen);
                string[] myArr = content.Split(',');
                comboBox1.SelectedItem = myArr[3];
                this.result.Text = myArr[4];
                MessageBox.Show("讀取完成");

            }
        }
    }
}
