namespace MyPaint
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btDrawPencil = new System.Windows.Forms.Button();
            this.btDrawLine = new System.Windows.Forms.Button();
            this.btDrawSquare = new System.Windows.Forms.Button();
            this.btDrawRectangle = new System.Windows.Forms.Button();
            this.btDrawCircle = new System.Windows.Forms.Button();
            this.btDrawEllipse = new System.Windows.Forms.Button();
            this.panelCanvas = new System.Windows.Forms.Panel();
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btThickness1 = new DevExpress.XtraEditors.SimpleButton();
            this.btThickness3 = new DevExpress.XtraEditors.SimpleButton();
            this.btThickness5 = new DevExpress.XtraEditors.SimpleButton();
            this.btThickness7 = new DevExpress.XtraEditors.SimpleButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorPickEdit1 = new DevExpress.XtraEditors.ColorPickEdit();
            this.colorPickEdit2 = new DevExpress.XtraEditors.ColorPickEdit();
            this.panelColor1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelColor2 = new System.Windows.Forms.Panel();
            this.cbPaintBuketState = new System.Windows.Forms.ComboBox();
            this.btPaintBucket = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btSelectRange = new DevExpress.XtraEditors.SimpleButton();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelCanvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorPickEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorPickEdit2.Properties)).BeginInit();
            this.panelColor1.SuspendLayout();
            this.panelColor2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(955, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.newToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 652);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(955, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btDrawPencil);
            this.panel1.Controls.Add(this.btDrawLine);
            this.panel1.Controls.Add(this.btDrawSquare);
            this.panel1.Controls.Add(this.btDrawRectangle);
            this.panel1.Controls.Add(this.btDrawCircle);
            this.panel1.Controls.Add(this.btDrawEllipse);
            this.panel1.Location = new System.Drawing.Point(5, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 99);
            this.panel1.TabIndex = 2;
            // 
            // btDrawPencil
            // 
            this.btDrawPencil.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btDrawPencil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btDrawPencil.Image = ((System.Drawing.Image)(resources.GetObject("btDrawPencil.Image")));
            this.btDrawPencil.Location = new System.Drawing.Point(3, 3);
            this.btDrawPencil.Name = "btDrawPencil";
            this.btDrawPencil.Size = new System.Drawing.Size(42, 42);
            this.btDrawPencil.TabIndex = 5;
            this.btDrawPencil.UseVisualStyleBackColor = false;
            // 
            // btDrawLine
            // 
            this.btDrawLine.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btDrawLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btDrawLine.Image = ((System.Drawing.Image)(resources.GetObject("btDrawLine.Image")));
            this.btDrawLine.Location = new System.Drawing.Point(51, 4);
            this.btDrawLine.Name = "btDrawLine";
            this.btDrawLine.Size = new System.Drawing.Size(42, 42);
            this.btDrawLine.TabIndex = 4;
            this.btDrawLine.UseVisualStyleBackColor = false;
            // 
            // btDrawSquare
            // 
            this.btDrawSquare.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btDrawSquare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btDrawSquare.Image = ((System.Drawing.Image)(resources.GetObject("btDrawSquare.Image")));
            this.btDrawSquare.Location = new System.Drawing.Point(51, 51);
            this.btDrawSquare.Name = "btDrawSquare";
            this.btDrawSquare.Size = new System.Drawing.Size(42, 42);
            this.btDrawSquare.TabIndex = 1;
            this.btDrawSquare.UseVisualStyleBackColor = false;
            // 
            // btDrawRectangle
            // 
            this.btDrawRectangle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btDrawRectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btDrawRectangle.Image = ((System.Drawing.Image)(resources.GetObject("btDrawRectangle.Image")));
            this.btDrawRectangle.Location = new System.Drawing.Point(3, 51);
            this.btDrawRectangle.Name = "btDrawRectangle";
            this.btDrawRectangle.Size = new System.Drawing.Size(42, 42);
            this.btDrawRectangle.TabIndex = 0;
            this.btDrawRectangle.UseVisualStyleBackColor = false;
            // 
            // btDrawCircle
            // 
            this.btDrawCircle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btDrawCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btDrawCircle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btDrawCircle.Image = ((System.Drawing.Image)(resources.GetObject("btDrawCircle.Image")));
            this.btDrawCircle.Location = new System.Drawing.Point(147, 51);
            this.btDrawCircle.Name = "btDrawCircle";
            this.btDrawCircle.Size = new System.Drawing.Size(42, 42);
            this.btDrawCircle.TabIndex = 3;
            this.btDrawCircle.UseVisualStyleBackColor = false;
            // 
            // btDrawEllipse
            // 
            this.btDrawEllipse.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btDrawEllipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btDrawEllipse.Image = ((System.Drawing.Image)(resources.GetObject("btDrawEllipse.Image")));
            this.btDrawEllipse.Location = new System.Drawing.Point(99, 51);
            this.btDrawEllipse.Name = "btDrawEllipse";
            this.btDrawEllipse.Size = new System.Drawing.Size(42, 42);
            this.btDrawEllipse.TabIndex = 2;
            this.btDrawEllipse.UseVisualStyleBackColor = false;
            // 
            // panelCanvas
            // 
            this.panelCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCanvas.Controls.Add(this.pbCanvas);
            this.panelCanvas.Location = new System.Drawing.Point(3, 3);
            this.panelCanvas.Name = "panelCanvas";
            this.panelCanvas.Size = new System.Drawing.Size(922, 510);
            this.panelCanvas.TabIndex = 4;
            // 
            // pbCanvas
            // 
            this.pbCanvas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCanvas.Location = new System.Drawing.Point(3, 3);
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.Size = new System.Drawing.Size(916, 507);
            this.pbCanvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCanvas.TabIndex = 3;
            this.pbCanvas.TabStop = false;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vScrollBar1.Location = new System.Drawing.Point(928, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 516);
            this.vScrollBar1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btThickness1);
            this.panel3.Controls.Add(this.btThickness3);
            this.panel3.Controls.Add(this.btThickness5);
            this.panel3.Controls.Add(this.btThickness7);
            this.panel3.Location = new System.Drawing.Point(379, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(127, 98);
            this.panel3.TabIndex = 4;
            // 
            // btThickness1
            // 
            this.btThickness1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btThickness1.Image = ((System.Drawing.Image)(resources.GetObject("btThickness1.Image")));
            this.btThickness1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btThickness1.Location = new System.Drawing.Point(4, 9);
            this.btThickness1.Name = "btThickness1";
            this.btThickness1.Size = new System.Drawing.Size(118, 13);
            this.btThickness1.TabIndex = 4;
            // 
            // btThickness3
            // 
            this.btThickness3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btThickness3.Image = ((System.Drawing.Image)(resources.GetObject("btThickness3.Image")));
            this.btThickness3.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btThickness3.Location = new System.Drawing.Point(3, 32);
            this.btThickness3.Name = "btThickness3";
            this.btThickness3.Size = new System.Drawing.Size(118, 13);
            this.btThickness3.TabIndex = 14;
            // 
            // btThickness5
            // 
            this.btThickness5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btThickness5.Image = ((System.Drawing.Image)(resources.GetObject("btThickness5.Image")));
            this.btThickness5.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btThickness5.Location = new System.Drawing.Point(3, 57);
            this.btThickness5.Name = "btThickness5";
            this.btThickness5.Size = new System.Drawing.Size(118, 13);
            this.btThickness5.TabIndex = 4;
            // 
            // btThickness7
            // 
            this.btThickness7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btThickness7.Image = ((System.Drawing.Image)(resources.GetObject("btThickness7.Image")));
            this.btThickness7.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btThickness7.Location = new System.Drawing.Point(3, 80);
            this.btThickness7.Name = "btThickness7";
            this.btThickness7.Size = new System.Drawing.Size(118, 13);
            this.btThickness7.TabIndex = 1;
            // 
            // colorPickEdit1
            // 
            this.colorPickEdit1.EditValue = System.Drawing.Color.Empty;
            this.colorPickEdit1.Location = new System.Drawing.Point(3, 3);
            this.colorPickEdit1.Name = "colorPickEdit1";
            this.colorPickEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.colorPickEdit1.Properties.ShowSystemColors = false;
            this.colorPickEdit1.Properties.ShowWebColors = false;
            this.colorPickEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.colorPickEdit1.Size = new System.Drawing.Size(48, 20);
            this.colorPickEdit1.TabIndex = 5;
            // 
            // colorPickEdit2
            // 
            this.colorPickEdit2.EditValue = System.Drawing.Color.Empty;
            this.colorPickEdit2.Location = new System.Drawing.Point(3, 4);
            this.colorPickEdit2.Name = "colorPickEdit2";
            this.colorPickEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.colorPickEdit2.Properties.ShowSystemColors = false;
            this.colorPickEdit2.Properties.ShowWebColors = false;
            this.colorPickEdit2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.colorPickEdit2.Size = new System.Drawing.Size(48, 20);
            this.colorPickEdit2.TabIndex = 6;
            // 
            // panelColor1
            // 
            this.panelColor1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelColor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColor1.Controls.Add(this.label1);
            this.panelColor1.Controls.Add(this.colorPickEdit1);
            this.panelColor1.Location = new System.Drawing.Point(23, 43);
            this.panelColor1.Name = "panelColor1";
            this.panelColor1.Size = new System.Drawing.Size(59, 51);
            this.panelColor1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Color 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Color 2";
            // 
            // panelColor2
            // 
            this.panelColor2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelColor2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColor2.Controls.Add(this.colorPickEdit2);
            this.panelColor2.Controls.Add(this.label2);
            this.panelColor2.Location = new System.Drawing.Point(88, 43);
            this.panelColor2.Name = "panelColor2";
            this.panelColor2.Size = new System.Drawing.Size(56, 51);
            this.panelColor2.TabIndex = 9;
            // 
            // cbPaintBuketState
            // 
            this.cbPaintBuketState.FormattingEnabled = true;
            this.cbPaintBuketState.Location = new System.Drawing.Point(45, 10);
            this.cbPaintBuketState.Name = "cbPaintBuketState";
            this.cbPaintBuketState.Size = new System.Drawing.Size(116, 21);
            this.cbPaintBuketState.TabIndex = 10;
            // 
            // btPaintBucket
            // 
            this.btPaintBucket.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btPaintBucket.Image = ((System.Drawing.Image)(resources.GetObject("btPaintBucket.Image")));
            this.btPaintBucket.Location = new System.Drawing.Point(3, 2);
            this.btPaintBucket.Name = "btPaintBucket";
            this.btPaintBucket.Size = new System.Drawing.Size(42, 40);
            this.btPaintBucket.TabIndex = 11;
            this.btPaintBucket.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.btPaintBucket);
            this.panel6.Controls.Add(this.panelColor1);
            this.panel6.Controls.Add(this.cbPaintBuketState);
            this.panel6.Controls.Add(this.panelColor2);
            this.panel6.Location = new System.Drawing.Point(207, 30);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(166, 99);
            this.panel6.TabIndex = 12;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.panelCanvas);
            this.panel7.Controls.Add(this.vScrollBar1);
            this.panel7.Location = new System.Drawing.Point(5, 134);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(950, 518);
            this.panel7.TabIndex = 5;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Dark Side";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btSelectRange);
            this.panel2.Location = new System.Drawing.Point(512, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(58, 99);
            this.panel2.TabIndex = 13;
            // 
            // btSelectRange
            // 
            this.btSelectRange.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btSelectRange.Appearance.Options.UseFont = true;
            this.btSelectRange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btSelectRange.Image = ((System.Drawing.Image)(resources.GetObject("btSelectRange.Image")));
            this.btSelectRange.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btSelectRange.Location = new System.Drawing.Point(3, 4);
            this.btSelectRange.Name = "btSelectRange";
            this.btSelectRange.Size = new System.Drawing.Size(50, 67);
            this.btSelectRange.TabIndex = 0;
            this.btSelectRange.Text = "Select";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(955, 674);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelCanvas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.colorPickEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorPickEdit2.Properties)).EndInit();
            this.panelColor1.ResumeLayout(false);
            this.panelColor1.PerformLayout();
            this.panelColor2.ResumeLayout(false);
            this.panelColor2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btDrawRectangle;
        private System.Windows.Forms.Button btDrawSquare;
        private System.Windows.Forms.Button btDrawEllipse;
        private System.Windows.Forms.Button btDrawCircle;
        private System.Windows.Forms.Panel panelCanvas;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btDrawLine;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private DevExpress.XtraEditors.ColorPickEdit colorPickEdit1;
        private System.Windows.Forms.Button btDrawPencil;
        private DevExpress.XtraEditors.ColorPickEdit colorPickEdit2;
        private System.Windows.Forms.Panel panelColor1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelColor2;
        private System.Windows.Forms.ComboBox cbPaintBuketState;
        private System.Windows.Forms.Button btPaintBucket;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbCanvas;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btSelectRange;
        private DevExpress.XtraEditors.SimpleButton btThickness7;
        private DevExpress.XtraEditors.SimpleButton btThickness5;
        private DevExpress.XtraEditors.SimpleButton btThickness3;
        private DevExpress.XtraEditors.SimpleButton btThickness1;
    }
}

