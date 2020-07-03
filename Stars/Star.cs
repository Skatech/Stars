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
      float w = graphics.VisibleClipBounds.Width / 2f;
      float h =  graphics.VisibleClipBounds.Height / 2f;
      float s = 0.5f + 0.0002f * w / Z, ss = s * 2f;
      float x = w + w * X / Z;
      float y = h + h * Y / Z;
      graphics.FillEllipse(Brush, x - s, y - s, ss, ss);
    }
  }
}
