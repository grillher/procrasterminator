using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Microsoft.DirectX.AudioVideoPlayback;

namespace Procrasterminator
{
	/// <summary>
	/// Summary description for FormPlayVideo.
	/// </summary>
	public class FormPlayVideo : System.Windows.Forms.Form
	{
		private IContainer components;
        private Timer timer1;
        private bool bShowVideo;

        private Panel panelVideo;
        private Video video;

	    private int movieRectangleTop;
        private int movieRectangleLeft;
	    private int movieRectangleHeight;
	    private bool bIsPlayingVideo = false;

	    public FormPlayVideo(String path)
		{
			InitializeComponent();

            video = new Video(path);

            Width = Screen.PrimaryScreen.Bounds.Width;
            Height = Screen.PrimaryScreen.Bounds.Height;

            panelVideo.Visible = false;
            video.Owner = panelVideo;

            panelVideo.Top = Height / 2 - video.Size.Height / 2;
            panelVideo.Left = Width / 2 - video.Size.Width / 2;

            movieRectangleHeight = 20;
            movieRectangleTop = Height / 2 - movieRectangleHeight / 2; ;
            movieRectangleLeft = Width;

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);

            video.Ending += new EventHandler(CloseWindow);

	        Show();
		}
        
       
        public void PlayVideo()
        {
            
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
            e.Graphics.FillRectangle(new SolidBrush(Color.Black), new Rectangle(movieRectangleLeft, movieRectangleTop, Width, movieRectangleHeight));
		}


		private void timer1_Tick(object sender, System.EventArgs e)
		{	

			Invalidate();

            if(movieRectangleLeft > 0)
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
            }
		}

	    private void CloseWindow(object sender, EventArgs e)
	    {
	        bIsPlayingVideo = false;
	        Close();
	    }

	    // Starting minimized is hacking crap done to get rid of the initial
		// flashing of garbage when the program first starts. We still see a
		// bit of a title bar zipping around, odd since this form border style is none.
		// ANYBODY KNOW HOW TO DO THIS CORRECTLY?
		private void Form1_Load(object sender, System.EventArgs e)
		{
			this.WindowState = FormWindowState.Normal;
		}


	    public bool IsPlayingVideo()
	    {
	        return bIsPlayingVideo;
	    }
	}
}
