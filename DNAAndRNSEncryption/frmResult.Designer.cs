namespace DNAAndRNSEncryption
{
    partial class frmResult
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
            this.components = new System.ComponentModel.Container();
            Janus.Windows.GridEX.GridEXLayout grdCordinateRGBAlpha_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResult));
            this.grdCordinateRGBAlpha = new Janus.Windows.GridEX.GridEX();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gridEXExporter1 = new Janus.Windows.GridEX.Export.GridEXExporter(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grdCordinateRGBAlpha)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdCordinateRGBAlpha
            // 
            this.grdCordinateRGBAlpha.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdCordinateRGBAlpha.ContextMenuStrip = this.contextMenuStrip1;
            grdCordinateRGBAlpha_DesignTimeLayout.LayoutString = resources.GetString("grdCordinateRGBAlpha_DesignTimeLayout.LayoutString");
            this.grdCordinateRGBAlpha.DesignTimeLayout = grdCordinateRGBAlpha_DesignTimeLayout;
            this.grdCordinateRGBAlpha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCordinateRGBAlpha.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.grdCordinateRGBAlpha.GroupByBoxVisible = false;
            this.grdCordinateRGBAlpha.Location = new System.Drawing.Point(0, 0);
            this.grdCordinateRGBAlpha.Name = "grdCordinateRGBAlpha";
            this.grdCordinateRGBAlpha.Size = new System.Drawing.Size(923, 649);
            this.grdCordinateRGBAlpha.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(102, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(101, 22);
            this.toolStripMenuItem1.Text = "ذخیره";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // gridEXExporter1
            // 
            this.gridEXExporter1.GridEX = this.grdCordinateRGBAlpha;
            // 
            // frmResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 649);
            this.Controls.Add(this.grdCordinateRGBAlpha);
            this.Name = "frmResult";
            this.Text = "frmResult";
            this.Load += new System.EventHandler(this.frmResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCordinateRGBAlpha)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.GridEX.GridEX grdCordinateRGBAlpha;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private Janus.Windows.GridEX.Export.GridEXExporter gridEXExporter1;
    }
}