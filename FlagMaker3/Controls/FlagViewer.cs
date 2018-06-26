using FlagMaker3.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlagMaker3.Controls
{
    public class FlagViewer : Control
    {

        private List<Level> Layers = new List<Level>();

        public FlagViewer()
        {
            this.BackColor = System.Drawing.Color.White;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            foreach (Level lvl in Layers)
            {
                lvl.Draw(e.Graphics);
            }

        }

        public void AddLevel(Level lvl)
        {
            Layers.Add(lvl);
            this.Invalidate();
        }

        public void RemoveLevel(Level lvl)
        {
            Layers.Remove(lvl);
            this.Invalidate();
        }

        public int LevelCount()
        {
            return this.Layers.Count;
        }

        public Level GetLevel(int i)
        {
            if (i < 0 || i >= this.Layers.Count)
            {

            }

            return this.Layers[i];
        }

    }
}
