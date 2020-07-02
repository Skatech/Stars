using System;
using System.Drawing;

namespace Stars
{
  struct Star
  {
    public float X, Y, Z;
    public Brush Brush;
    
    public void Move(Random random, Brush[] brushes)
    {
      if (Z < 0.1f) {
        X = (float)random.NextDouble() - 0.5f;
        Y = (float)random.NextDouble() - 0.5f;
        Z = (float)random.NextDouble() * 0.9f + 0.1f;
        Brush = brushes[random.Next(brushes.Length)];
      }
      else Z -= 0.02f;
    }
    
    public void Draw(Graphics graphics)
    {
      float w = graphics.VisibleClipBounds.Width, wh = w / 2;
      float h =  graphics.VisibleClipBounds.Height, hh = h / 2;
      float s = 0.5f + 0.0001f * w / Z, ss = s * 2f;
      float x = X / Z * wh + wh;
      float y = Y / Z * hh + hh;
      graphics.FillEllipse(Brush, x - s, y - s, ss, ss);
    }
  }
}
