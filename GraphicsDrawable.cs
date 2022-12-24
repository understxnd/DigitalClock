using Microsoft.Maui.Graphics;
using System;

namespace DigitalClock
{
    public class GraphicsDrawable : IDrawable
    {
        public int distance = 2;

        public void Draw(ICanvas canvas, RectF dirtyRect)
        {

            canvas.StrokeSize = 3;

            Number(canvas, 0, DateTime.Now.Hour / 10);
            Number(canvas, 1, DateTime.Now.Hour % 10);
            canvas.DrawLine(20 + distance * 2, 25, 20 + distance * 2, 35);
            canvas.DrawLine(20 + distance * 2, 45, 20 + distance * 2, 55);
            Number(canvas, 2, DateTime.Now.Minute / 10);
            Number(canvas, 3, DateTime.Now.Minute % 10);
            canvas.DrawLine(20 + distance * 4 + 20, 25, 20 + distance * 4 + 20, 35);
            canvas.DrawLine(20 + distance * 4 + 20, 45, 20 + distance * 4 + 20, 55);
            Number(canvas, 4, DateTime.Now.Second / 10);
            Number(canvas, 5, DateTime.Now.Second % 10);

        }

        public void Number(ICanvas canvas, int n, int time)
        {
            int pointOffset = 0;

            if (n > 1) pointOffset = 20;
            if (n > 3) pointOffset = 40;

            switch (time)
            {
                case 0:
                    canvas.DrawLine(15 + distance * n + pointOffset, 0, 55 + distance * n + pointOffset, 0);
                    canvas.DrawLine(55 + distance * n + pointOffset, 0, 55 + distance * n + pointOffset, 70);
                    canvas.DrawLine(15 + distance * n + pointOffset, 70, 55 + distance * n + pointOffset, 70);
                    canvas.DrawLine(15 + distance * n + pointOffset, 0, 15 + distance * n + pointOffset, 70);
                    break;
                case 1:
                    canvas.DrawLine(55 + distance * n + pointOffset, 0, 55 + distance * n + pointOffset, 70);
                    break;
                case 2:
                    canvas.DrawLine(15 + distance * n + pointOffset, 0, 55 + distance * n + pointOffset, 0);
                    canvas.DrawLine(55 + distance * n + pointOffset, 0, 55 + distance * n + pointOffset, 35);
                    canvas.DrawLine(15 + distance * n + pointOffset, 35, 55 + distance * n + pointOffset, 35);
                    canvas.DrawLine(15 + distance * n + pointOffset, 35, 15 + distance * n + pointOffset, 70);
                    canvas.DrawLine(15 + distance * n + pointOffset, 70, 55 + distance * n + pointOffset, 70);
                    break;
                case 3:
                    canvas.DrawLine(15 + distance * n + pointOffset, 0, 55 + distance * n + pointOffset, 0);
                    canvas.DrawLine(55 + distance * n + pointOffset, 0, 55 + distance * n + pointOffset, 70);
                    canvas.DrawLine(15 + distance * n + pointOffset, 70, 55 + distance * n + pointOffset, 70);
                    canvas.DrawLine(15 + distance * n + pointOffset, 35, 55 + distance * n + pointOffset, 35);
                    break;
                case 4:
                    canvas.DrawLine(55 + distance * n + pointOffset, 0, 55 + distance * n + pointOffset, 70);
                    canvas.DrawLine(15 + distance * n + pointOffset, 35, 55 + distance * n + pointOffset, 35);
                    canvas.DrawLine(15 + distance * n + pointOffset, 0, 15 + distance * n + pointOffset, 35);
                    break;
                case 5:
                    canvas.DrawLine(15 + distance * n + pointOffset, 0, 55 + distance * n + pointOffset, 0);
                    canvas.DrawLine(15 + distance * n + pointOffset, 0, 15 + distance * n + pointOffset, 35);
                    canvas.DrawLine(15 + distance * n + pointOffset, 35, 55 + distance * n + pointOffset, 35);
                    canvas.DrawLine(55 + distance * n + pointOffset, 35, 55 + distance * n + pointOffset, 70);
                    canvas.DrawLine(15 + distance * n + pointOffset, 70, 55 + distance * n + pointOffset, 70);
                    break;
                case 6:
                    canvas.DrawLine(15 + distance * n + pointOffset, 0, 55 + distance * n + pointOffset, 0);
                    canvas.DrawLine(15 + distance * n + pointOffset, 0, 15 + distance * n + pointOffset, 70);
                    canvas.DrawLine(15 + distance * n + pointOffset, 35, 55 + distance * n + pointOffset, 35);
                    canvas.DrawLine(55 + distance * n + pointOffset, 35, 55 + distance * n + pointOffset, 70);
                    canvas.DrawLine(15 + distance * n + pointOffset, 70, 55 + distance * n + pointOffset, 70);
                    break;
                case 7:
                    canvas.DrawLine(15 + distance * n + pointOffset, 0, 55 + distance * n + pointOffset, 0);
                    canvas.DrawLine(55 + distance * n + pointOffset, 0, 55 + distance * n + pointOffset, 72);
                    break;
                case 8:
                    canvas.DrawLine(15 + distance * n + pointOffset, 0, 55 + distance * n + pointOffset, 0);
                    canvas.DrawLine(55 + distance * n + pointOffset, 0, 55 + distance * n + pointOffset, 70);
                    canvas.DrawLine(15 + distance * n + pointOffset, 70, 55 + distance * n + pointOffset, 70);
                    canvas.DrawLine(15 + distance * n + pointOffset, 0, 15 + distance * n + pointOffset, 70);
                    canvas.DrawLine(15 + distance * n + pointOffset, 35, 55 + distance * n + pointOffset, 35);
                    break;
                case 9:
                    canvas.DrawLine(15 + distance * n + pointOffset, 0, 55 + distance * n + pointOffset, 0);
                    canvas.DrawLine(55 + distance * n + pointOffset, 0, 55 + distance * n + pointOffset, 70);
                    canvas.DrawLine(15 + distance * n + pointOffset, 70, 55 + distance * n + pointOffset, 70);
                    canvas.DrawLine(15 + distance * n + pointOffset, 0, 15 + distance * n + pointOffset, 35);
                    canvas.DrawLine(15 + distance * n + pointOffset, 35, 55 + distance * n + pointOffset, 35);
                    break;
            }
        }
    }
}