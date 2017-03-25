using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Dapper;
using Geometry2D;
namespace IntersectionLineRectangle
{
    public partial class TestForm : Form
    {

       
    

        private const int opacity = 250;
        private List<Tuple<PointF, PointF>> _lines = new List<Tuple<PointF, PointF>>();
        private PointF startPoint;
        private PointF endPoint;
        private RectangleF rectF;


        public TestForm()
        {
            InitializeComponent();
            CenterToScreen();
            SetStyle(ControlStyles.ResizeRedraw, true);
            // Initialize the SQLite Connection

            string DbPatch = System.Configuration.ConfigurationManager.ConnectionStrings["CountourPointDB_ConnectionString"].ConnectionString.ToString();
            IDbConnection cnn = new SQLiteConnection("Data Source=" + Directory.GetCurrentDirectory() + DbPatch + ";Version=3;");
            SimpleCRUD.SetDialect(SimpleCRUD.Dialect.SQLite);
            cnn.Open();
            IList pointList = cnn.GetList<ContourPoint>().ToList();
            ContoursGrid.DataSource = pointList;
            AddLine(cnn);
            pictBox.Invalidate(); //обновляем  pictBox

        }

        public void buttonLoadPointList_Click(object sender, EventArgs e)
        {

            // Initialize the SQLite Connection

            string DbPatch = System.Configuration.ConfigurationManager.ConnectionStrings["CountourPointDB_ConnectionString"].ConnectionString.ToString();
            IDbConnection cnn = new SQLiteConnection("Data Source=" + Directory.GetCurrentDirectory() + DbPatch + ";Version=3;");
            SimpleCRUD.SetDialect(SimpleCRUD.Dialect.SQLite);
            cnn.Open();
            IList pointList = cnn.GetList<ContourPoint>().ToList();
            ContoursGrid.DataSource = pointList;
            AddLine(cnn);
            pictBox.Invalidate(); //обновляем  pictBox
        }



        private void pictBox_Paint(object sender, PaintEventArgs e)

        {        

            // Задаем координаты прямоугольника 

            int rectLeft = Convert.ToInt32(txtLeft.Text);
            int rectRight = Convert.ToInt32(txtRight.Text);
            int rectTop = Convert.ToInt32(txtTop.Text);
            int rectBottom = Convert.ToInt32(txtBottom.Text);
            rectF = new RectangleF(rectLeft, rectTop, rectRight, rectBottom);

            var c = Color.FromArgb(opacity, Color.Red);// указываем цвет и прозрачность заливки
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.FillRectangle(new SolidBrush(c), rectF); //рисуем прямоугольник
            Pen pen = new Pen(Color.Green, 1); // указываем цвет пера
      
            if (flagTrimLine.Checked) // Если есть флаг выполняем алгоритм обрезки контуров
            {
                var newLines = new List<Tuple<PointF, PointF>>();
                foreach (var line in _lines)
                {
                    var p1 = line.Item1;
                    var p2 = line.Item2;
                    var clipped = Geometry2D.IntersectionLineRectangle.ClipSegment(rectF, p1, p2);
                    if (clipped != null)
                    {
                        newLines.Add(clipped);
                    }
                }
                _lines = newLines; // Коллекция  контуров
            }


            foreach (var line in _lines)
            {
                e.Graphics.DrawLine(pen, line.Item1, line.Item2); // рисуем контура
            }

  
            pictBox.Invalidate(); //обновляем  pictBox


        }

        public void AddLine(IDbConnection cnn)
        {
            // Вытаскиваем данные из базы данных в List

            var pointList = cnn.GetList<ContourPoint>("order by Contour").ToList(); //"where Contour=228"

            //Создаем инициализируем объект полилиния и устанавливаем начальные параметры

          //  gPath = new GraphicsPath();
          //  gPath.StartFigure();
            int lastContour = 0;
            int q = Convert.ToInt32(qText.Value); //коофициент маштабирования
            int sX = 0;
            int sY = 0;
            int eX = 0;
            int eY = 0;
            //Создаем коллекцию точек для полилилиний каждого контура
            foreach (var p in pointList)
            {
                // Проверяем на новый контур
                if (p.Contour != lastContour)
                {
                    sX = p.PointX / q;
                    sY = p.PointY / q;
                    startPoint = new PointF(sX, sY);
                }
                else
                {


                    // добавляем точки в кортеж и указываем стартовую точку для следующего отрезка полилинии
                    eX = p.PointX / q;
                    eY = p.PointY / q;
                    endPoint = new PointF(eX, eY);
                    var line = new Tuple<PointF, PointF>(startPoint, endPoint);
                     _lines.Add(line);

              }

                lastContour = p.Contour;

            }

            cnn.Close();

        }

        private void TestForm_Resize(object sender, EventArgs e)
        {
            pictBox.Invalidate();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://en.wikipedia.org/wiki/Cohen%E2%80%93Sutherland_algorithm");
            Process.Start(sInfo);
        }
    }

}




