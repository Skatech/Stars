
namespace Stars
{
  partial class MainForm
  {
    /// <summary>
    /// Designer variable used to keep track of non-visual components.
    /// </summary>
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.PictureBox m_pictureBox;
    private System.Windows.Forms.Timer m_timer;
    
    /// <summary>
    /// Disposes resources used by the form.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing) {
        if (components != null) {
          components.Dispose();
        }
      }
      base.Dispose(disposing);
    }
    
    /// <summary>
    /// This method is required for Windows Forms designer support.
    /// Do not change the method contents inside the source code editor. The Forms designer might
    /// not be able to load this method if it was changed manually.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.m_pictureBox = new System.Windows.Forms.PictureBox();
      this.m_timer = new System.Windows.Forms.Timer(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.m_pictureBox)).BeginInit();
      this.SuspendLayout();
      // 
      // m_pictureBox
      // 
      this.m_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.m_pictureBox.Location = new System.Drawing.Point(0, 0);
      this.m_pictureBox.Name = "m_pictureBox";
      this.m_pictureBox.Size = new System.Drawing.Size(884, 562);
      this.m_pictureBox.TabIndex = 0;
      this.m_pictureBox.TabStop = false;
      // 
      // m_timer
      // 
      this.m_timer.Interval = 33;
      this.m_timer.Tick += new System.EventHandler(this.OnTick);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(884, 562);
      this.Controls.Add(this.m_pictureBox);
      this.Name = "MainForm";
      this.Text = "Stars";
      this.Shown += new System.EventHandler(this.OnFormShown);
      this.ResizeEnd += new System.EventHandler(this.OnFormResized);
      this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnFormKeyPress);
      ((System.ComponentModel.ISupportInitialize)(this.m_pictureBox)).EndInit();
      this.ResumeLayout(false);

    }
  }
}
