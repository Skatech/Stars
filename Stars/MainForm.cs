using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Stars
{
  public partial class MainForm : Form
  {
    Graphics m_graphics;
    Star[] m_stars = new Star[1000];
    Brush[] m_brushes = new Brush[] { Brushes.LightYellow, Brushes.AliceBlue, Brushes.Bisque, Brushes.White };
    Random m_random = new Random(Guid.NewGuid().GetHashCode());
    Stopwatch m_stopwatch = new Stopwatch();
    string m_performance = "";
    
    public MainForm()
    {
      InitializeComponent();
    }
    
    void RebuildGraphics()
    {
      m_graphics?.Dispose();
      m_pictureBox.Image?.Dispose();
      m_graphics = Graphics.FromImage(m_pictureBox.Image = new Bitmap(m_pictureBox.Width, m_pictureBox.Height));
    }
    
    void OnFormShown(object sender, EventArgs e)
    {
      RebuildGraphics();
      m_timer.Start();
    }
    
    void OnFormResized(object sender, EventArgs e)
    {
      if (m_pictureBox.Width != m_pictureBox.Image.Width || m_pictureBox.Height != m_pictureBox.Image.Height) {
        RebuildGraphics();
      }
    }
    
    void OnFormKeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar == '\r') {
        if (WindowState == FormWindowState.Maximized) {
          FormBorderStyle = FormBorderStyle.Sizable;
          WindowState = FormWindowState.Normal;
        }
        else {
          FormBorderStyle = FormBorderStyle.None;
          WindowState = FormWindowState.Maximized;
        }
        RebuildGraphics();
      }
    }
    
    void OnTick(object sender, EventArgs e)
    {
      m_stopwatch.Restart();
      
      m_graphics.Clear(Color.Black);
      
      for (int n = 0; n < m_stars.Length; ++n) {
        m_stars[n].Move(m_random, m_brushes);
        m_stars[n].Draw(m_graphics);
      }
      
      m_graphics.DrawString(m_performance, Font, Brushes.Red, 10, 10);
      
      var beforeRefresh = m_stopwatch.ElapsedMilliseconds;
      m_pictureBox.Refresh();
      
      m_stopwatch.Stop();
      m_performance = String.Format("{0} / {1}", beforeRefresh, m_stopwatch.ElapsedMilliseconds);
    }
    
    [STAThread]
    static void Main(string[] args)
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new MainForm());
    }
  }
}
