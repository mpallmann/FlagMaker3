namespace FlagMaker3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnAddLayer = new System.Windows.Forms.ToolStripButton();
            this.btnRemoveLayer = new System.Windows.Forms.ToolStripButton();
            this.lstLayers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numLeft = new System.Windows.Forms.NumericUpDown();
            this.numTop = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numHeight = new System.Windows.Forms.NumericUpDown();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            this.pnlColor = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddLayer,
            this.btnRemoveLayer});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(765, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pnlColor);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.numHeight);
            this.splitContainer1.Panel1.Controls.Add(this.numWidth);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.numTop);
            this.splitContainer1.Panel1.Controls.Add(this.numLeft);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.lstLayers);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Resize += new System.EventHandler(this.splitContainer1_Panel2_Resize);
            this.splitContainer1.Size = new System.Drawing.Size(765, 498);
            this.splitContainer1.SplitterDistance = 255;
            this.splitContainer1.TabIndex = 1;
            // 
            // btnAddLayer
            // 
            this.btnAddLayer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddLayer.Image = ((System.Drawing.Image)(resources.GetObject("btnAddLayer.Image")));
            this.btnAddLayer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddLayer.Name = "btnAddLayer";
            this.btnAddLayer.Size = new System.Drawing.Size(23, 22);
            this.btnAddLayer.Text = "toolStripButton1";
            this.btnAddLayer.Click += new System.EventHandler(this.btnAddLayer_Click);
            // 
            // btnRemoveLayer
            // 
            this.btnRemoveLayer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRemoveLayer.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveLayer.Image")));
            this.btnRemoveLayer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRemoveLayer.Name = "btnRemoveLayer";
            this.btnRemoveLayer.Size = new System.Drawing.Size(23, 22);
            this.btnRemoveLayer.Text = "toolStripButton2";
            this.btnRemoveLayer.Click += new System.EventHandler(this.btnRemoveLayer_Click);
            // 
            // lstLayers
            // 
            this.lstLayers.FormattingEnabled = true;
            this.lstLayers.IntegralHeight = false;
            this.lstLayers.Location = new System.Drawing.Point(3, 16);
            this.lstLayers.Name = "lstLayers";
            this.lstLayers.Size = new System.Drawing.Size(249, 120);
            this.lstLayers.TabIndex = 0;
            this.lstLayers.SelectedIndexChanged += new System.EventHandler(this.lstLayers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Layers";
            // 
            // numLeft
            // 
            this.numLeft.Location = new System.Drawing.Point(57, 142);
            this.numLeft.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numLeft.Name = "numLeft";
            this.numLeft.Size = new System.Drawing.Size(54, 20);
            this.numLeft.TabIndex = 2;
            this.numLeft.ValueChanged += new System.EventHandler(this.numLeft_ValueChanged);
            // 
            // numTop
            // 
            this.numTop.Location = new System.Drawing.Point(117, 142);
            this.numTop.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numTop.Name = "numTop";
            this.numTop.Size = new System.Drawing.Size(54, 20);
            this.numTop.TabIndex = 3;
            this.numTop.ValueChanged += new System.EventHandler(this.numTop_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Size";
            // 
            // numHeight
            // 
            this.numHeight.Location = new System.Drawing.Point(117, 168);
            this.numHeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numHeight.Name = "numHeight";
            this.numHeight.Size = new System.Drawing.Size(54, 20);
            this.numHeight.TabIndex = 7;
            this.numHeight.ValueChanged += new System.EventHandler(this.numHeight_ValueChanged);
            // 
            // numWidth
            // 
            this.numWidth.Location = new System.Drawing.Point(57, 168);
            this.numWidth.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(54, 20);
            this.numWidth.TabIndex = 6;
            this.numWidth.ValueChanged += new System.EventHandler(this.numWidth_ValueChanged);
            // 
            // pnlColor
            // 
            this.pnlColor.Location = new System.Drawing.Point(6, 194);
            this.pnlColor.Name = "pnlColor";
            this.pnlColor.Size = new System.Drawing.Size(200, 18);
            this.pnlColor.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 523);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripButton btnAddLayer;
        private System.Windows.Forms.ToolStripButton btnRemoveLayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstLayers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numTop;
        private System.Windows.Forms.NumericUpDown numLeft;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numHeight;
        private System.Windows.Forms.NumericUpDown numWidth;
        private System.Windows.Forms.Panel pnlColor;
    }
}

