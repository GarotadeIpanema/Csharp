using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Xml;

namespace Weather
{
    public partial class Form1 : Form
    {
        string strURL = "http://www.kma.go.kr/weather/forecast/mid-term-xml.jsp";
        string strCity = "";

        public Form1()
        {
            InitializeComponent();
            cboCity.SelectedIndex = 10; lblToday.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void cboCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (XmlReader xr = XmlReader.Create(strURL))
                {
                    string strMsg = "";
                    XmlWriterSettings ws = new XmlWriterSettings();
                    ws.Indent = true;
                    bool bCheck = false;
                    int iCount = 0;
                    strCity = cboCity.Text;
                    while (xr.Read())
                    {

                        switch (xr.NodeType)
                        {
                            case XmlNodeType.CDATA:
                                {
                                    richTextBox1.Text = xr.Value.ToString().Replace("<br />", " ");
                                    break;
                                }
                            case XmlNodeType.Text:
                                {
                                    if (xr.Value.Equals(strCity)) { bCheck = true; }
                                    if (bCheck)
                                    {
                                        DateTime dt;
                                        bool b = DateTime.TryParse(xr.Value.ToString(), out dt);
                                        if (b) { strMsg += "/"; }
                                        strMsg += xr.Value + ",";
                                        iCount += 1;
                                        if (iCount > 36)
                                        {
                                            bCheck = false;
                                        }
                                    }
                                    break;
                                }
                        }
                    }
                   
                    string[] strTmp = strMsg.Split('/'); //요일별 데이터 string[] strWh1 = strTmp[1].Split(','); label3.Text = strWh1[0]; label5.Text = "최저: " + strWh1[2] + " ℃"; label6.Text = "최고: " + strWh1[3] + " ℃"; label7.Text = strWh1[1]; string[] strWh2 = strTmp[2].Split(','); label11.Text = strWh2[0]; label10.Text = "최저: " + strWh2[2] + " ℃"; label9.Text = "최고: " + strWh2[3] + " ℃"; label8.Text = strWh2[1]; string[] strWh3 = strTmp[3].Split(','); label15.Text = strWh3[0]; label14.Text = "최저: " + strWh3[2] + " ℃"; label13.Text = "최고: " + strWh3[3] + " ℃"; label12.Text = strWh3[1]; string[] strWh4 = strTmp[4].Split(','); label27.Text = strWh4[0]; label26.Text = "최저: " + strWh4[2] + " ℃"; label25.Text = "최고: " + strWh4[3] + " ℃"; label24.Text = strWh4[1]; string[] strWh5 = strTmp[5].Split(','); label23.Text = strWh5[0]; label22.Text = "최저: " + strWh5[2] + " ℃"; label21.Text = "최고: " + strWh5[3] + " ℃"; label20.Text = strWh5[1]; string[] strWh6 = strTmp[6].Split(','); label19.Text = strWh6[0]; label18.Text = "최저: " + strWh6[2] + " ℃"; label17.Text = "최고: " + strWh6[3] + " ℃"; label16.Text = strWh6[1]; } }
                    
                    string clothes = "";
                    string[] strWh1 = strTmp[1].Split(',');
                    string[] strWh2 = strTmp[2].Split(','); 
                    string[] strWh3 = strTmp[3].Split(','); 
                    string[] strWh4 = strTmp[4].Split(',');

                    Wt w1 = new Wt(strWh1[0], int.Parse(strWh1[2]), int.Parse(strWh1[3]), strWh1[1]);
                    Wt w2 = new Wt(strWh2[0], int.Parse(strWh2[2]), int.Parse(strWh2[3]), strWh2[1]);
                    Wt w3 = new Wt(strWh3[0], int.Parse(strWh3[2]), int.Parse(strWh3[3]), strWh3[1]);
                    Wt w4 = new Wt(strWh4[0], int.Parse(strWh4[2]), int.Parse(strWh4[3]), strWh4[1]);
                   
                   
                    label5.Text = w1.Date;
                    label6.Text = "최저: " + w1.MinTemp + "Cº";
                    label7.Text = "최고: " + w1.MaxTemp + "Cº";
                    label8.Text = w1.Dayday;
                    

                    label9.Text = w2.Date;
                    label10.Text = "최저: " + w2.MinTemp + "Cº";
                    label11.Text = "최고: " + w2.MaxTemp + "Cº";
                    label12.Text = w2.Dayday;

                    label13.Text = w3.Date;
                    label14.Text = "최저: " + w3.MinTemp + "Cº";
                    label15.Text = "최고: " + w3.MinTemp + "Cº";
                    label16.Text = w3.Dayday;
                    
                    label21.Text = w4.Date;
                    label22.Text = "최저: " + w4.MinTemp + "Cº";
                    label23.Text = "최고: " + w4.MaxTemp + "Cº";
                    label24.Text = w4.Dayday;

                    ClothesToday(w1);
       
                }
                }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

        private void ClothesToday(Wt w1)
        {
            double mid = (w1.MinTemp + w1.MaxTemp)/2;
            if (28 <= mid)
            {
                label4.Text = "민소매, 반팔, 반바지, 짧은 치마, 린넨 옷을 추천합니다.";
                pictureBox1.Image = getMovieImage("https://image.msscdn.net/images/codimap/detail/2882/detail_2882_1_500.jpg?202104231604");
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else if ((23 <= mid) && (mid < 28))
            {
                label4.Text = "반팔,얇은 셔츠, 반바지,면바지를 추천합니다.";
                pictureBox1.Image = getMovieImage("https://image.msscdn.net/images/codimap/detail/2246/detail_2246_1_500.jpg?202104231504");
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            }
            else if ((20 <= mid) && (mid < 23))
            {
                label4.Text = "블라우스, 긴팔티, 면바지, 슬랙스를 추천합니다.";
                pictureBox1.Image = getMovieImage("https://image.msscdn.net/images/codimap/detail/2653/detail_2653_1_500.jpg?202104231604");
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            }

            else if ((17 <= mid) && (mid < 23))
            {
                label4.Text = "얇은 가디건이나 니트, 맨투맨, 후드, 긴 바지를 추천합니다.";
                pictureBox1.Image = getMovieImage("https://image.msscdn.net/images/codimap/detail/2587/detail_2587_1_500.jpg?202104231504");
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            }
            else if ((12 <= mid) && (mid < 17))
            {
                label4.Text = "자켓, 가디건, 청자켓, 니트,스타킹, 청바지를 추천합니다.";
                pictureBox1.Image = getMovieImage("https://image.msscdn.net/images/codimap/list/l_3_2021041911323900000086780.jpg?202104231604");
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            }
            else if ((9 <= mid) && (mid < 12))
            {
                label4.Text = "트랜치 코트, 야상, 점퍼, 스타킹, 기모바지를 추천합니다.";
                pictureBox1.Image = getMovieImage("https://image.msscdn.net/images/codimap/detail/2041/detail_2041_1_500.jpg?202104231604");
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                label4.Text = "패딩, 두꺼운 코드, 누빔옷, 목도리, 히트텍을 추천합니다.";
                pictureBox1.Image = getMovieImage("https://image.msscdn.net/images/codimap/detail/617/detail_617_1_500.jpg?202104231504");
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            }
        }


        public static Bitmap getMovieImage(string imgAddr)
        {
            WebClient Downloader = new WebClient();
            Stream ImageStream = Downloader.OpenRead(imgAddr);
            Bitmap DownloadImage = Bitmap.FromStream(ImageStream) as Bitmap;
            return DownloadImage;
        }

    }

}


//while //요일별로 짜르기 string[] strTmp = strMsg.Split('/'); //요일별 데이터 string[] strWh1 = strTmp[1].Split(','); label3.Text = strWh1[0]; label5.Text = "최저: " + strWh1[2] + " ℃"; label6.Text = "최고: " + strWh1[3] + " ℃"; label7.Text = strWh1[1]; string[] strWh2 = strTmp[2].Split(','); label11.Text = strWh2[0]; label10.Text = "최저: " + strWh2[2] + " ℃"; label9.Text = "최고: " + strWh2[3] + " ℃"; label8.Text = strWh2[1]; string[] strWh3 = strTmp[3].Split(','); label15.Text = strWh3[0]; label14.Text = "최저: " + strWh3[2] + " ℃"; label13.Text = "최고: " + strWh3[3] + " ℃"; label12.Text = strWh3[1]; string[] strWh4 = strTmp[4].Split(','); label27.Text = strWh4[0]; label26.Text = "최저: " + strWh4[2] + " ℃"; label25.Text = "최고: " + strWh4[3] + " ℃"; label24.Text = strWh4[1]; string[] strWh5 = strTmp[5].Split(','); label23.Text = strWh5[0]; label22.Text = "최저: " + strWh5[2] + " ℃"; label21.Text = "최고: " + strWh5[3] + " ℃"; label20.Text = strWh5[1]; string[] strWh6 = strTmp[6].Split(','); label19.Text = strWh6[0]; label18.Text = "최저: " + strWh6[2] + " ℃"; label17.Text = "최고: " + strWh6[3] + " ℃"; label16.Text = strWh6[1]; } } catch (Exception ex) { Console.WriteLine(ex.Message.ToString()); } } } }









