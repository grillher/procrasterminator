using System;
using System.Collections.Generic;
using System.Drawing;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Microsoft.DirectX.AudioVideoPlayback;

namespace Procrasterminator
{
	/// <summary>
	/// Summary description for FormPlayVideo.
	/// </summary>
	public class FormPlayVideo : Form
	{
		private IContainer components;
        private Timer timer1;
        private bool bShowVideo;

        private Panel panelVideo;
        private Video video;

	    private const int INITIAL_MOVIE_RECTANGLE_HEIGHT = 20;
	    private int movieRectangleTop;
        private int movieRectangleLeft;
	    private int movieRectangleHeight;
        private int movieRectangleWidth;

	    private bool bIsPlayingVideo = true;
	    private bool bHideVideo;

        private List<TextData> textDataList = new List<TextData>();
	    private bool bShowTasks = false;

	    public FormPlayVideo(String path, List<String> tasksList)
		{
			InitializeComponent();
            
            video = new Video(path);

            Width = Screen.PrimaryScreen.Bounds.Width;
            Height = Screen.PrimaryScreen.Bounds.Height;

            panelVideo.Visible = false;
            video.Owner = panelVideo;

            panelVideo.Top = Height / 2 - video.Size.Height / 2;
            panelVideo.Left = Width / 2 - video.Size.Width / 2;

            movieRectangleHeight = INITIAL_MOVIE_RECTANGLE_HEIGHT;
            movieRectangleTop = Height / 2 - movieRectangleHeight / 2;
            movieRectangleLeft = Width;
	        movieRectangleWidth = Width;

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);

            GenerateTextData(tasksList);

            video.Ending += CloseWindow;

	        Show();
		}

	    private void GenerateTextData(List<string> list)
	    {
	        int mode = 0;
	        int halfHeight = Height / 2;

            for(int i = 0; i < list.Count; i++)
            {
                switch(mode)
                {
                    case 0:
                        textDataList.Add(new TextData(list[i], new Point(10, halfHeight - 25), -45));
                        mode++;
                        break;
                    case 1:
                        textDataList.Add(new TextData(list[i], new Point(10, halfHeight + 175), -45));
                        mode++;
                        break;
                    case 2:
                        textDataList.Add(new TextData(list[i], new Point(Width - 250, halfHeight + 100), -45));
                        mode++;
                        break;
                    case 3:
                        textDataList.Add(new TextData(list[i], new Point(Width - 250, halfHeight - 100), -45));
                        mode = 0;
                        break;
                }
                    
            }
	    }

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelVideo = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelVideo
            // 
            this.panelVideo.Location = new System.Drawing.Point(12, 12);
            this.panelVideo.Name = "panelVideo";
            this.panelVideo.Size = new System.Drawing.Size(304, 350);
            this.panelVideo.TabIndex = 2;
            // 
            // FormPlayVideo
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(328, 400);
            this.ControlBox = false;
            this.Controls.Add(this.panelVideo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPlayVideo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Blue;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

		}
		#endregion

		protected override void OnPaint(PaintEventArgs e)
		{
            e.Graphics.FillRectangle(new SolidBrush(Color.Black), new Rectangle(movieRectangleLeft, movieRectangleTop, movieRectangleWidth, movieRectangleHeight));

            if (bShowTasks)
            {
                DrawTextData(e.Graphics, new TextData("Tasks!", new Point(50, 120), 0));
                DrawTextData(e.Graphics, new TextData("Tasks!", new Point(Width - 250, 120), 0));

                foreach (TextData data in textDataList)
                {
                    DrawTextData(e.Graphics, data);
                }
            }
		}

        private void DrawTextData(Graphics g, TextData data)
	    {

            FontFamily ff = new FontFamily("Times New Roman");
            Font font = new Font(ff, 23, FontStyle.Regular);
            Color color = Color.Red;

            StringFormat sf = new StringFormat();

            
            // Local rotation of vertcal text (sf):
            GraphicsPath gp = new GraphicsPath();
            gp.AddString(data.Text, ff, (int)FontStyle.Bold, 28, new Point(0,0), sf);
            Matrix m = new Matrix();
            m.Translate(data.Location.X, data.Location.Y);
            m.Rotate(data.Rotation);  // clockwise
            gp.Transform(m);
            g.DrawPath(Pens.Red, gp);  //g.FillPath(Brushes.Black, gp);
            
	    }


	    private void timer1_Tick(object sender, EventArgs e)
		{	

			Invalidate();

            if (bHideVideo && movieRectangleHeight > INITIAL_MOVIE_RECTANGLE_HEIGHT)
            {
                bShowTasks = false;
                movieRectangleTop += 5;
                movieRectangleHeight -= 10;
            }
            else if (bHideVideo && movieRectangleLeft < Width)
            {
                movieRectangleLeft += 20;
                movieRectangleWidth -= 40;
            }
            else if (bHideVideo)
            {
                bIsPlayingVideo = false;
                Close();
            }
            else if(movieRectangleLeft > 0)
                movieRectangleLeft -= 20;
            else if(movieRectangleTop > panelVideo.Top)
            {
                movieRectangleTop -= 5;
                movieRectangleHeight += 10;
            }
            else if(!bShowVideo)
            {
                panelVideo.Visible = true;
                video.Play();
                bShowVideo = true;
                bShowTasks = true;
            }
		}

	    private void CloseWindow(object sender, EventArgs e)
	    {
	        bHideVideo = true;
            panelVideo.Visible = false;
	    }

	    // Starting minimized is hacking crap done to get rid of the initial
		// flashing of garbage when the program first starts. We still see a
		// bit of a title bar zipping around, odd since this form border style is none.
		// ANYBODY KNOW HOW TO DO THIS CORRECTLY?
		private void Form1_Load(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Normal;
		}


	    public bool IsPlayingVideo()
	    {
	        return bIsPlayingVideo;
	    }

        class TextData
        {
            private String text;
            private Point location;
            private int rotation;

            public TextData(String text, Point location, int rotation)
            {
                this.location = location;
                this.text = text;
                this.rotation = rotation;
            }

            public string Text
            {
                get { return text; }
            }

            public Point Location
            {
                get { return location; }
            }

            public int Rotation
            {
                get { return rotation; }
            }
        }
	}
}
