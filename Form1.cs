using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;

using Emgu.CV.OCR;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Image<Bgr, byte> sourceImg;
        List<Rectangle> rois = new List<Rectangle>();
        Tesseract ocr;

        private void Load_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            var result = ofd.ShowDialog(); 

            if (result == DialogResult.OK) 
            {
                string filename = ofd.FileName;
                sourceImg = new Image<Bgr, byte>(filename);
                OG.Image = sourceImg.Resize(OG.Width, OG.Height, Inter.Linear); 
            }

            if(Language.SelectedIndex == 0)
                ocr = new Tesseract("D:\\OCR\\", "eng", OcrEngineMode.TesseractLstmCombined);
            if (Language.SelectedIndex == 1)
                ocr = new Tesseract("D:\\OCR\\", "rus", OcrEngineMode.TesseractLstmCombined);
        }

        private void FindText_Click(object sender, EventArgs e)
        {
            var gray = sourceImg.Convert<Gray, byte>();
            gray._ThresholdBinaryInv(new Gray(100), new Gray(255));

            if(Language.SelectedIndex == 0)
                gray._Dilate(5);
            if (Language.SelectedIndex == 1)
                gray._Dilate(7);

            VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
            CvInvoke.FindContours(gray, contours, null, RetrType.List, ChainApproxMethod.ChainApproxSimple);

            var output = sourceImg.Copy();

            for(int i = 0; i < contours.Size; i++)
            {
                if(CvInvoke.ContourArea(contours[i], false) > 50)
                {
                    Rectangle rect = CvInvoke.BoundingRectangle(contours[i]);
                    rois.Add(rect);
                    output.Draw(rect, new Bgr(Color.LightBlue), 1);

                    sourceImg.ROI = rect;
                    var roisImg = sourceImg.Copy();
                    sourceImg.ROI = Rectangle.Empty;

                    ocr.SetImage(roisImg);
                    ocr.Recognize();
                    string text = ocr.GetUTF8Text();

                    TextFromImg.Items.Add(text);
                    Res.Image = output.Resize(Res.Width, Res.Height, Inter.Linear);
                }
            }
        }
    }
}
