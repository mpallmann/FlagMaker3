using FlagMaker3.Classes;
using FlagMaker3.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlagMaker3
{
    public partial class Form1 : Form
    {

        private FlagViewer vwFlag = new FlagViewer();
        private Level _cur_lvl = null;
        private bool _loading = false;

        public Form1()
        {
            InitializeComponent();
            vwFlag.Size = new Size(300, 200);
            splitContainer1.Panel2.Controls.Add(vwFlag);
            vwFlag.Visible = true;
            splitContainer1_Panel2_Resize(null, null);

            setupColors();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            displayLevels();

        }

        private void splitContainer1_Panel2_Resize(object sender, EventArgs e)
        {

            if (vwFlag != null)
            {
                int wid = (splitContainer1.Panel2.Width - vwFlag.Width) / 2;
                int hgt = (splitContainer1.Panel2.Height - vwFlag.Height) / 2;
                vwFlag.Location = new Point(wid,hgt);
            }


        }

        private void btnAddLayer_Click(object sender, EventArgs e)
        {
            _loading = true;

            Level lvl = new Level();
            lvl.Bounds = new Rectangle(0, 0, vwFlag.Width, vwFlag.Height);

            vwFlag.AddLevel(lvl);
            lstLayers.Items.Add("Layer");

            _loading = false;
        }

        private void btnRemoveLayer_Click(object sender, EventArgs e)
        {



        }

        private void displayLevels()
        {

            lstLayers.BeginUpdate();
            lstLayers.Items.Clear();
            for (int i = 0; i < vwFlag.LevelCount(); i++)
            {
                lstLayers.Items.Add("Layer");
            }
            lstLayers.EndUpdate();

        }

        private void lstLayers_SelectedIndexChanged(object sender, EventArgs e)
        {

            _loading = true;

            if (lstLayers.SelectedIndex > -1)
            {
                int index = lstLayers.SelectedIndex;
                _cur_lvl = vwFlag.GetLevel(index);
                numLeft.Value = _cur_lvl.Bounds.Left;
                numTop.Value = _cur_lvl.Bounds.Top;
                numWidth.Value = _cur_lvl.Bounds.Width;
                numHeight.Value = _cur_lvl.Bounds.Height;
            }

            _loading = false;

        }

        private void numLeft_ValueChanged(object sender, EventArgs e)
        {

            if (!_loading)
            {
                _loading = true;

                if (numLeft.Value + numWidth.Value > vwFlag.Width) numWidth.Value = vwFlag.Width - numLeft.Value;
                _cur_lvl.Bounds = new Rectangle((int)numLeft.Value, (int)numTop.Value,
                    (int)numWidth.Value, (int)numHeight.Value);

                _loading = false;

                vwFlag.Invalidate();
            }

        }

        private void numTop_ValueChanged(object sender, EventArgs e)
        {

            if (!_loading)
            {
                _loading = true;

                if (numTop.Value + numHeight.Value > vwFlag.Height) numHeight.Value = vwFlag.Height - numTop.Value;
                _cur_lvl.Bounds = new Rectangle((int)numLeft.Value, (int)numTop.Value,
                    (int)numWidth.Value, (int)numHeight.Value);

                _loading = false;
                vwFlag.Invalidate();
            }

        }

        private void numWidth_ValueChanged(object sender, EventArgs e)
        {

            if (!_loading)
            {
                _cur_lvl.Bounds = new Rectangle((int)numLeft.Value, (int)numTop.Value,
                    (int)numWidth.Value, (int)numHeight.Value);
                vwFlag.Invalidate();
            }

        }

        private void numHeight_ValueChanged(object sender, EventArgs e)
        {

            if (!_loading)
            {
                _cur_lvl.Bounds = new Rectangle((int)numLeft.Value, (int)numTop.Value,
                    (int)numWidth.Value, (int)numHeight.Value);
                vwFlag.Invalidate();
            }

        }

        private void setupColors()
        {
            Color[] colors = new Color[8]
            {
                Color.Black, Color.White, Color.Red, Color.Orange, Color.Yellow,
                Color.Green, Color.Blue, Color.Purple
            };

            int x = 0;
            int wid = (pnlColor.Width - 1) / colors.Length;
            foreach (Color clr in colors)
            {
                Button btn = new Button();
                btn.Location = new Point(x, 0);
                btn.Size = new Size(wid, pnlColor.Height-1);
                
                btn.BackColor = clr;
                btn.Name = "btn" + clr.Name;
                btn.Text = "";
                btn.Click += ColorButtonClick;
                pnlColor.Controls.Add(btn);

                x += wid;
            }

        }

        private void ColorButtonClick(Object sender, EventArgs e)
        {

            if (_cur_lvl != null)
            {
                Button btn = (Button)sender;
                _cur_lvl.Color = btn.BackColor;
                vwFlag.Invalidate();
            }

        }

    }
}
