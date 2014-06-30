using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Version1_0
{
    class DataGraph
    {
         public Image OutputFundBaseMsgGraph(FundQueryRT fq)
        {
            const int LEFT_X = 50;
            const int TOP_Y = 50;
            const int GRAPH_HEIGHT = 420;
            const int GRAPH_WIDTH = 650;
            const int BOTTOM_Y = GRAPH_HEIGHT - 30;
            const int RIGHT_X = GRAPH_WIDTH - 50;
            
             //基本信息行的高度
            const int ROW_FIRST_HEIGHT = 15;
            const int ROW_SECOND_HEIGHT = 50;
            const int ROW_THIRD_HEIGHT = 80;

            Image baseMsgImage = Bitmap.FromFile("基本信息.png");
            Graphics g1 = Graphics.FromImage(baseMsgImage);

            Font font1 = new Font("宋体", 11);
            Font font2 = new Font("宋体", 10);

             string baseMessage = "基金名称:  " + fq.FundName +  "基金净值:  " + fq.NetAssetValue + "\r\n\r\n" + "基金类型:  " + fq.FundType + "\r\n\r\n" +
                                  "成 立 日:  " + fq.InceptionDate + "\r\n\r\n" + "管 理 人:  " + fq.Custodian + "\r\n\r\n" +
                                  "规    模:  " + fq.Scale + "\r\n\r\n";

             g1.DrawString(fq.FundName, font1, Brushes.Red, 15, ROW_FIRST_HEIGHT);
             g1.DrawString("基金净值:  " + fq.NetAssetValue, font2, Brushes.Black, 15, ROW_SECOND_HEIGHT);
             g1.DrawString("基金类型:  " + fq.FundType, font2, Brushes.Black, 185, ROW_SECOND_HEIGHT);
             g1.DrawString("成 立 日:  " + fq.InceptionDate, font2, Brushes.Black, 375, ROW_SECOND_HEIGHT);
             g1.DrawString("管 理 人:  " + fq.Custodian, font2, Brushes.Black, 15, ROW_THIRD_HEIGHT);
             g1.DrawString("规    模:  " + fq.Scale, font2, Brushes.Black, 185, ROW_THIRD_HEIGHT);

             //折线图
             const int BROKEN_LINE_GRAPH_WIDTH = 650;
             const int BROKEN_LINE_GRAPH_HEIGHT = 300;
             const int BROKEN_LINE_GRAPH_LEFT_X = 50;
             const int BROKEN_LINE_GRAPH_RIGHT_X = BROKEN_LINE_GRAPH_WIDTH - 50;
             const int BROKEN_LINE_GRAPH_TOP_Y = 10;
             const int BROKEN_LINE_GRAPH_BOTTOM_Y = BROKEN_LINE_GRAPH_HEIGHT - 30;

             Image brokenLineGraph = new Bitmap(BROKEN_LINE_GRAPH_WIDTH, BROKEN_LINE_GRAPH_HEIGHT);
             Graphics g2 = Graphics.FromImage(brokenLineGraph);

             Pen linePen = new Pen(Brushes.LightGray, 1);

             Dictionary<string, string> netValues = fq.HistoricalNetValue;
             int interval_x = (BROKEN_LINE_GRAPH_RIGHT_X - BROKEN_LINE_GRAPH_LEFT_X) / netValues.Count;

             //画竖线
             int x = LEFT_X;
             for (int i = 0; i < netValues.Count + 1; i++)
             {
                 g2.DrawLine(linePen, x, BROKEN_LINE_GRAPH_TOP_Y, x, BROKEN_LINE_GRAPH_BOTTOM_Y);
                 x += interval_x;
             }

             //画横线
             int y = TOP_Y;
             int interval_y = (BROKEN_LINE_GRAPH_BOTTOM_Y - BROKEN_LINE_GRAPH_TOP_Y) / 15;
             for (int i = 0; i < 16; i++)
             {
                 g2.DrawLine(linePen, BROKEN_LINE_GRAPH_LEFT_X, y, BROKEN_LINE_GRAPH_RIGHT_X, y);
                 y += interval_y;
             }

             //统计最大值绘制纵坐标
             double max = 0.0d;
             foreach (KeyValuePair<string, string> time_value in netValues)
             {
                 if (double.Parse(time_value.Value) > max)
                 {
                     max = double.Parse(time_value.Value);
                 }
             }
             y = BOTTOM_Y - interval_y;
             for (int i = 0; i < 15; i++)
             {
             }

             //合并上下两张图
             Image image = new Bitmap(GRAPH_WIDTH, GRAPH_HEIGHT);
             Graphics g3 = Graphics.FromImage(image);
             g3.DrawImage(baseMsgImage, LEFT_X, TOP_Y);

             return image;
        }
    }
}
