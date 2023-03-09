using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge.Video;
using AForge.Video.DirectShow;



namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        #region DECLARATIONS
        private Bitmap actualImage, capturedImage, lastImage, threshold;
        private FilterInfoCollection webcamList;
        private VideoCaptureDevice webcam;
        //ColorFiltering colorFilter;
        int iThreshold, iRadius;
        bool _Streaming;

        #endregion

        #region Initializations
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            _Streaming = false;
            webcam = new VideoCaptureDevice();
        }


        #endregion

        #region Methods
        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {

            capturedImage = (Bitmap)eventArgs.Frame.Clone();
            lastImage = capturedImage;


            using (var grayImage = Grayscale.CommonAlgorithms.BT709.Apply(capturedImage))
            {
                if (RbThreshold.Checked) {
                    threshold = new Threshold(iThreshold).Apply(grayImage);
                    lastImage = threshold;
                }

            }

            //if(RbRadius.Checked)
            //{
                
            //}
            
            PictureStream.Image = lastImage;
        }

        #endregion

        #region CONTROLS

        #region STREAM
        private void BtnStream_Click(object sender, EventArgs e)    {

            if (webcam == null) { return; }
            try
            {
                if (!_Streaming)
                {
                    webcamList = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                    webcam = new VideoCaptureDevice(webcamList[0].MonikerString);
                    webcam.NewFrame += FinalFrame_NewFrame;
                    webcam.Start();


                    BtnStream.Text = @"Stop";
                    BtnStream.ForeColor = Color.White;
                    BtnStream.BackColor = Color.Red;
                }
                else
                {
                    webcam.NewFrame -= FinalFrame_NewFrame;
                    webcam.WaitForStop();
                    webcam.SignalToStop();
                    BtnStream.Text = @"Start";
                    BtnStream.ForeColor = Color.White;
                    BtnStream.BackColor = Color.Red;
                }
                _Streaming = !_Streaming;
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
            
        }
        #endregion

        #region CAPTURE IMAGE
        private void BtnCAPTURE_Click(object sender, EventArgs e)
        {
            try
            {
                if (_Streaming)
                {
                    PictureCapture.Image = lastImage;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Start Camera");
            }
        }
        #endregion

        #region LOAD IMAGE
        private void BtnLoad_Click(object sender, EventArgs e)
        {
            //OpenFileDialog dlg = new OpenFileDialog
            //{
            //    Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG"
            //};

            //if (dlg.ShowDialog() == DialogResult.OK)
            //{
            //    actualImage = new Bitmap(dlg.FileName);
            //    PictureCompare.Image = actualImage;
            //}
            actualImage = new Bitmap(@"C:\Users\omkar\Downloads\Image Compare\1.jpg");
            PictureActual.Image = actualImage;
        }
        #endregion

        #region COMPARE IMAGE
        private void BtnCOMPARE_Click(object sender, EventArgs e)
        {
            if (actualImage == null)
            {
                MessageBox.Show("Please select an actual image first.");
                return;
            }
            if (capturedImage == null)
            {
                MessageBox.Show("Please capture an image first.");
                return;
            }

            ExhaustiveTemplateMatching tm = new(0.9f);
            TemplateMatch[] matches = tm.ProcessImage(actualImage, capturedImage);

            if (matches.Length == 0)
            {
                MessageBox.Show("Images do not match.");
            }
            else
            {
                MessageBox.Show("Images match!");
            }
        }
        #endregion

        #region ScrollBar
        private void HsbThreshold_Scroll(object sender, ScrollEventArgs e)
        {
            if (RbThreshold.Checked)
            {
                iThreshold = HsbThreshold.Value;
            }
        }

        private void HsbRadius_Scroll(object sender, ScrollEventArgs e)
        {
            if (RbThreshold.Checked)
            {
                iRadius = HsbRadius.Value;
            }
        }
        #endregion

        #endregion
    }
}