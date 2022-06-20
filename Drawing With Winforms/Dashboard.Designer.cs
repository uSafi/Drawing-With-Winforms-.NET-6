using Drawing_With_Winforms.Controls;

namespace Drawing_With_Winforms
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnReset = new System.Windows.Forms.Button();
            this.Canvas = new Drawing_With_Winforms.Controls.CanvasControl();
            this.btnCanvasBackgroundColor = new System.Windows.Forms.Button();
            this.rbtnLine = new Drawing_With_Winforms.Controls.ShapeRadioButton();
            this.rbtnRectangle = new Drawing_With_Winforms.Controls.ShapeRadioButton();
            this.rbtnCircle = new Drawing_With_Winforms.Controls.ShapeRadioButton();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.btnRemoveCanvasBackgroundImage = new System.Windows.Forms.Button();
            this.pnlTaskbar = new System.Windows.Forms.Panel();
            this.lblResizeCanvas = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMousePosition = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlFigures = new System.Windows.Forms.Panel();
            this.flpFiguresContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.rbtnCurve = new Drawing_With_Winforms.Controls.ShapeRadioButton();
            this.tableLayoutPanel_Main = new System.Windows.Forms.TableLayoutPanel();
            this.pnlControls = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.splitter = new System.Windows.Forms.Splitter();
            this.btnStroke = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.chkCanUseFill = new System.Windows.Forms.CheckBox();
            this.btnFill = new System.Windows.Forms.Button();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.tbStrokeThickness = new System.Windows.Forms.TrackBar();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnRedo = new System.Windows.Forms.Button();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.chkContinuousDrawing = new System.Windows.Forms.CheckBox();
            this.chkReverseOrder = new System.Windows.Forms.CheckBox();
            this.chkInteractiveMode = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            this.pnlContainer.SuspendLayout();
            this.pnlTaskbar.SuspendLayout();
            this.pnlFigures.SuspendLayout();
            this.flpFiguresContainer.SuspendLayout();
            this.tableLayoutPanel_Main.SuspendLayout();
            this.pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbStrokeThickness)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(15, 172);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.toolTip1.SetToolTip(this.btnReset, "Clear all Drawing, Background Image will not be affected.");
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Canvas
            // 
            this.Canvas.BackColor = System.Drawing.Color.White;
            this.Canvas.Location = new System.Drawing.Point(4, 4);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(648, 484);
            this.Canvas.TabIndex = 3;
            this.Canvas.TabStop = false;
            this.Canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_Paint);
            this.Canvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseClick);
            this.Canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            this.Canvas.MouseLeave += new System.EventHandler(this.Canvas_MouseLeave);
            this.Canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            this.Canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
            this.Canvas.Resize += new System.EventHandler(this.Canvas_Resize);
            // 
            // btnCanvasBackgroundColor
            // 
            this.btnCanvasBackgroundColor.BackgroundImage = global::Drawing_With_Winforms.Properties.Resources.Color_Palette_24px;
            this.btnCanvasBackgroundColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCanvasBackgroundColor.FlatAppearance.BorderSize = 0;
            this.btnCanvasBackgroundColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCanvasBackgroundColor.ForeColor = System.Drawing.Color.Black;
            this.btnCanvasBackgroundColor.Location = new System.Drawing.Point(0, 2);
            this.btnCanvasBackgroundColor.Name = "btnCanvasBackgroundColor";
            this.btnCanvasBackgroundColor.Size = new System.Drawing.Size(24, 24);
            this.btnCanvasBackgroundColor.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnCanvasBackgroundColor, "Change Canvas Backcolor");
            this.btnCanvasBackgroundColor.UseVisualStyleBackColor = false;
            this.btnCanvasBackgroundColor.Visible = false;
            this.btnCanvasBackgroundColor.Click += new System.EventHandler(this.btnCanvasBackgroundColor_Click);
            // 
            // rbtnLine
            // 
            this.rbtnLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtnLine.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnLine.BackgroundImage = global::Drawing_With_Winforms.Properties.Resources.Line_24px;
            this.rbtnLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rbtnLine.Checked = true;
            this.rbtnLine.FlatAppearance.BorderSize = 0;
            this.rbtnLine.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.rbtnLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnLine.ForeColor = System.Drawing.Color.White;
            this.rbtnLine.Location = new System.Drawing.Point(3, 3);
            this.rbtnLine.Name = "rbtnLine";
            this.rbtnLine.ShapeType = Drawing_With_Winforms.Enums.ShapeType.Line;
            this.rbtnLine.Size = new System.Drawing.Size(24, 24);
            this.rbtnLine.TabIndex = 1;
            this.rbtnLine.TabStop = true;
            this.rbtnLine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.rbtnLine, "Line");
            this.rbtnLine.UseVisualStyleBackColor = true;
            this.rbtnLine.CheckedChanged += new System.EventHandler(this.SharedShapesButtons_CheckedChanged);
            // 
            // rbtnRectangle
            // 
            this.rbtnRectangle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtnRectangle.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnRectangle.BackgroundImage = global::Drawing_With_Winforms.Properties.Resources.Rectangular_24px;
            this.rbtnRectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rbtnRectangle.FlatAppearance.BorderSize = 0;
            this.rbtnRectangle.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.rbtnRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnRectangle.ForeColor = System.Drawing.Color.White;
            this.rbtnRectangle.Location = new System.Drawing.Point(33, 3);
            this.rbtnRectangle.Name = "rbtnRectangle";
            this.rbtnRectangle.ShapeType = Drawing_With_Winforms.Enums.ShapeType.Rectangle;
            this.rbtnRectangle.Size = new System.Drawing.Size(24, 24);
            this.rbtnRectangle.TabIndex = 2;
            this.rbtnRectangle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.rbtnRectangle, "Rectangle");
            this.rbtnRectangle.UseVisualStyleBackColor = true;
            this.rbtnRectangle.CheckedChanged += new System.EventHandler(this.SharedShapesButtons_CheckedChanged);
            // 
            // rbtnCircle
            // 
            this.rbtnCircle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtnCircle.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnCircle.BackgroundImage = global::Drawing_With_Winforms.Properties.Resources.Circle_24px;
            this.rbtnCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rbtnCircle.FlatAppearance.BorderSize = 0;
            this.rbtnCircle.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.rbtnCircle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnCircle.ForeColor = System.Drawing.Color.White;
            this.rbtnCircle.Location = new System.Drawing.Point(63, 3);
            this.rbtnCircle.Name = "rbtnCircle";
            this.rbtnCircle.ShapeType = Drawing_With_Winforms.Enums.ShapeType.Circle;
            this.rbtnCircle.Size = new System.Drawing.Size(24, 24);
            this.rbtnCircle.TabIndex = 3;
            this.rbtnCircle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.rbtnCircle, "Circle");
            this.rbtnCircle.UseVisualStyleBackColor = true;
            this.rbtnCircle.CheckedChanged += new System.EventHandler(this.SharedShapesButtons_CheckedChanged);
            // 
            // pnlContainer
            // 
            this.pnlContainer.AutoScroll = true;
            this.pnlContainer.AutoSize = true;
            this.pnlContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(229)))));
            this.pnlContainer.Controls.Add(this.btnRemoveCanvasBackgroundImage);
            this.pnlContainer.Controls.Add(this.btnCanvasBackgroundColor);
            this.pnlContainer.Controls.Add(this.Canvas);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(3, 29);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(708, 503);
            this.pnlContainer.TabIndex = 12;
            // 
            // btnRemoveCanvasBackgroundImage
            // 
            this.btnRemoveCanvasBackgroundImage.BackgroundImage = global::Drawing_With_Winforms.Properties.Resources.Remove_Image_24px;
            this.btnRemoveCanvasBackgroundImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRemoveCanvasBackgroundImage.FlatAppearance.BorderSize = 0;
            this.btnRemoveCanvasBackgroundImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemoveCanvasBackgroundImage.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveCanvasBackgroundImage.Location = new System.Drawing.Point(0, 26);
            this.btnRemoveCanvasBackgroundImage.Name = "btnRemoveCanvasBackgroundImage";
            this.btnRemoveCanvasBackgroundImage.Size = new System.Drawing.Size(24, 24);
            this.btnRemoveCanvasBackgroundImage.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnRemoveCanvasBackgroundImage, "Remove Canvas Backgroun Image");
            this.btnRemoveCanvasBackgroundImage.UseVisualStyleBackColor = false;
            this.btnRemoveCanvasBackgroundImage.Visible = false;
            this.btnRemoveCanvasBackgroundImage.Click += new System.EventHandler(this.btnRemoveCanvasBackgroundImage_Click);
            // 
            // pnlTaskbar
            // 
            this.pnlTaskbar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tableLayoutPanel_Main.SetColumnSpan(this.pnlTaskbar, 2);
            this.pnlTaskbar.Controls.Add(this.lblResizeCanvas);
            this.pnlTaskbar.Controls.Add(this.label2);
            this.pnlTaskbar.Controls.Add(this.lblMousePosition);
            this.pnlTaskbar.Controls.Add(this.label1);
            this.pnlTaskbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTaskbar.Location = new System.Drawing.Point(0, 535);
            this.pnlTaskbar.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTaskbar.Name = "pnlTaskbar";
            this.pnlTaskbar.Size = new System.Drawing.Size(824, 26);
            this.pnlTaskbar.TabIndex = 13;
            // 
            // lblResizeCanvas
            // 
            this.lblResizeCanvas.Location = new System.Drawing.Point(206, 0);
            this.lblResizeCanvas.Name = "lblResizeCanvas";
            this.lblResizeCanvas.Size = new System.Drawing.Size(94, 24);
            this.lblResizeCanvas.TabIndex = 0;
            this.lblResizeCanvas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Image = global::Drawing_With_Winforms.Properties.Resources.ResizeCanvas_16;
            this.label2.Location = new System.Drawing.Point(186, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 16);
            this.label2.TabIndex = 0;
            this.toolTip1.SetToolTip(this.label2, "Canvas Size");
            // 
            // lblMousePosition
            // 
            this.lblMousePosition.Location = new System.Drawing.Point(22, 0);
            this.lblMousePosition.Name = "lblMousePosition";
            this.lblMousePosition.Size = new System.Drawing.Size(94, 24);
            this.lblMousePosition.TabIndex = 0;
            this.lblMousePosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Image = global::Drawing_With_Winforms.Properties.Resources.abscissa_16;
            this.label1.Location = new System.Drawing.Point(2, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 16);
            this.label1.TabIndex = 0;
            this.toolTip1.SetToolTip(this.label1, "Mouse Position");
            // 
            // pnlFigures
            // 
            this.pnlFigures.Controls.Add(this.flpFiguresContainer);
            this.pnlFigures.Controls.Add(this.btnReset);
            this.pnlFigures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFigures.Location = new System.Drawing.Point(717, 29);
            this.pnlFigures.Name = "pnlFigures";
            this.pnlFigures.Size = new System.Drawing.Size(104, 503);
            this.pnlFigures.TabIndex = 14;
            // 
            // flpFiguresContainer
            // 
            this.flpFiguresContainer.Controls.Add(this.rbtnLine);
            this.flpFiguresContainer.Controls.Add(this.rbtnRectangle);
            this.flpFiguresContainer.Controls.Add(this.rbtnCircle);
            this.flpFiguresContainer.Controls.Add(this.rbtnCurve);
            this.flpFiguresContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpFiguresContainer.Location = new System.Drawing.Point(0, 0);
            this.flpFiguresContainer.Name = "flpFiguresContainer";
            this.flpFiguresContainer.Size = new System.Drawing.Size(104, 100);
            this.flpFiguresContainer.TabIndex = 5;
            // 
            // rbtnCurve
            // 
            this.rbtnCurve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtnCurve.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnCurve.BackgroundImage = global::Drawing_With_Winforms.Properties.Resources.Curve_24px;
            this.rbtnCurve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rbtnCurve.FlatAppearance.BorderSize = 0;
            this.rbtnCurve.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.rbtnCurve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnCurve.ForeColor = System.Drawing.Color.White;
            this.rbtnCurve.Location = new System.Drawing.Point(3, 33);
            this.rbtnCurve.Name = "rbtnCurve";
            this.rbtnCurve.ShapeType = Drawing_With_Winforms.Enums.ShapeType.Curve;
            this.rbtnCurve.Size = new System.Drawing.Size(24, 24);
            this.rbtnCurve.TabIndex = 3;
            this.rbtnCurve.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.rbtnCurve, "Curve");
            this.rbtnCurve.UseVisualStyleBackColor = true;
            this.rbtnCurve.CheckedChanged += new System.EventHandler(this.SharedShapesButtons_CheckedChanged);
            // 
            // tableLayoutPanel_Main
            // 
            this.tableLayoutPanel_Main.ColumnCount = 2;
            this.tableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel_Main.Controls.Add(this.pnlControls, 0, 0);
            this.tableLayoutPanel_Main.Controls.Add(this.pnlContainer, 0, 1);
            this.tableLayoutPanel_Main.Controls.Add(this.pnlTaskbar, 0, 2);
            this.tableLayoutPanel_Main.Controls.Add(this.pnlFigures, 1, 1);
            this.tableLayoutPanel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Main.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_Main.Name = "tableLayoutPanel_Main";
            this.tableLayoutPanel_Main.RowCount = 3;
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel_Main.Size = new System.Drawing.Size(824, 561);
            this.tableLayoutPanel_Main.TabIndex = 6;
            // 
            // pnlControls
            // 
            this.tableLayoutPanel_Main.SetColumnSpan(this.pnlControls, 2);
            this.pnlControls.Controls.Add(this.btnOpen);
            this.pnlControls.Controls.Add(this.btnSave);
            this.pnlControls.Controls.Add(this.splitter);
            this.pnlControls.Controls.Add(this.btnStroke);
            this.pnlControls.Controls.Add(this.splitter1);
            this.pnlControls.Controls.Add(this.chkCanUseFill);
            this.pnlControls.Controls.Add(this.btnFill);
            this.pnlControls.Controls.Add(this.splitter2);
            this.pnlControls.Controls.Add(this.tbStrokeThickness);
            this.pnlControls.Controls.Add(this.splitter3);
            this.pnlControls.Controls.Add(this.btnUndo);
            this.pnlControls.Controls.Add(this.btnRedo);
            this.pnlControls.Controls.Add(this.splitter4);
            this.pnlControls.Controls.Add(this.chkContinuousDrawing);
            this.pnlControls.Controls.Add(this.chkReverseOrder);
            this.pnlControls.Controls.Add(this.chkInteractiveMode);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControls.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlControls.Location = new System.Drawing.Point(0, 0);
            this.pnlControls.Margin = new System.Windows.Forms.Padding(0);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(824, 26);
            this.pnlControls.TabIndex = 0;
            // 
            // btnOpen
            // 
            this.btnOpen.BackgroundImage = global::Drawing_With_Winforms.Properties.Resources.Opened_Folder_24px;
            this.btnOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOpen.FlatAppearance.BorderSize = 0;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.ForeColor = System.Drawing.Color.White;
            this.btnOpen.Location = new System.Drawing.Point(6, 3);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(20, 20);
            this.btnOpen.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnOpen, "Load Image");
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::Drawing_With_Winforms.Properties.Resources.Save_24px;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(32, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(20, 20);
            this.btnSave.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnSave, "Save Drawing");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // splitter
            // 
            this.splitter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter.Enabled = false;
            this.splitter.Location = new System.Drawing.Point(58, 3);
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(3, 20);
            this.splitter.TabIndex = 7;
            this.splitter.TabStop = false;
            // 
            // btnStroke
            // 
            this.btnStroke.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStroke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnStroke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStroke.ForeColor = System.Drawing.Color.White;
            this.btnStroke.Location = new System.Drawing.Point(67, 3);
            this.btnStroke.Name = "btnStroke";
            this.btnStroke.Size = new System.Drawing.Size(20, 20);
            this.btnStroke.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnStroke, "Change Stroke Color");
            this.btnStroke.UseVisualStyleBackColor = false;
            this.btnStroke.Click += new System.EventHandler(this.btnStrokeColor_Click);
            // 
            // splitter1
            // 
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter1.Enabled = false;
            this.splitter1.Location = new System.Drawing.Point(93, 3);
            this.splitter1.Margin = new System.Windows.Forms.Padding(3, 3, 16, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 20);
            this.splitter1.TabIndex = 17;
            this.splitter1.TabStop = false;
            // 
            // chkCanUseFill
            // 
            this.chkCanUseFill.AutoSize = true;
            this.chkCanUseFill.ForeColor = System.Drawing.Color.White;
            this.chkCanUseFill.Location = new System.Drawing.Point(112, 6);
            this.chkCanUseFill.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.chkCanUseFill.Name = "chkCanUseFill";
            this.chkCanUseFill.Size = new System.Drawing.Size(15, 14);
            this.chkCanUseFill.TabIndex = 11;
            this.chkCanUseFill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.chkCanUseFill, "Draw Figures on Canvas in reverse order");
            this.chkCanUseFill.UseVisualStyleBackColor = true;
            this.chkCanUseFill.CheckedChanged += new System.EventHandler(this.chkCanUseFill_CheckedChanged);
            // 
            // btnFill
            // 
            this.btnFill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnFill.Enabled = false;
            this.btnFill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFill.ForeColor = System.Drawing.Color.White;
            this.btnFill.Location = new System.Drawing.Point(130, 3);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(20, 20);
            this.btnFill.TabIndex = 15;
            this.toolTip1.SetToolTip(this.btnFill, "Change Fill Color");
            this.btnFill.UseVisualStyleBackColor = false;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // splitter2
            // 
            this.splitter2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter2.Enabled = false;
            this.splitter2.Location = new System.Drawing.Point(156, 3);
            this.splitter2.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 20);
            this.splitter2.TabIndex = 18;
            this.splitter2.TabStop = false;
            // 
            // tbStrokeThickness
            // 
            this.tbStrokeThickness.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbStrokeThickness.AutoSize = false;
            this.tbStrokeThickness.LargeChange = 1;
            this.tbStrokeThickness.Location = new System.Drawing.Point(168, 3);
            this.tbStrokeThickness.Maximum = 16;
            this.tbStrokeThickness.Name = "tbStrokeThickness";
            this.tbStrokeThickness.Size = new System.Drawing.Size(145, 20);
            this.tbStrokeThickness.TabIndex = 9;
            this.toolTip1.SetToolTip(this.tbStrokeThickness, "Select Stroke Thickness");
            this.tbStrokeThickness.Value = 8;
            this.tbStrokeThickness.Scroll += new System.EventHandler(this.tbStrokeThickness_Scroll);
            // 
            // splitter3
            // 
            this.splitter3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter3.Enabled = false;
            this.splitter3.Location = new System.Drawing.Point(319, 3);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(3, 20);
            this.splitter3.TabIndex = 19;
            this.splitter3.TabStop = false;
            // 
            // btnUndo
            // 
            this.btnUndo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUndo.BackgroundImage = global::Drawing_With_Winforms.Properties.Resources.Undo_24px;
            this.btnUndo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUndo.Enabled = false;
            this.btnUndo.FlatAppearance.BorderSize = 0;
            this.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUndo.ForeColor = System.Drawing.Color.White;
            this.btnUndo.Location = new System.Drawing.Point(328, 3);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(20, 20);
            this.btnUndo.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnUndo, "Undo Drawn Figure");
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnRedo
            // 
            this.btnRedo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRedo.BackgroundImage = global::Drawing_With_Winforms.Properties.Resources.Redo_24px;
            this.btnRedo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRedo.Enabled = false;
            this.btnRedo.FlatAppearance.BorderSize = 0;
            this.btnRedo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRedo.ForeColor = System.Drawing.Color.White;
            this.btnRedo.Location = new System.Drawing.Point(354, 3);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(20, 20);
            this.btnRedo.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnRedo, "Redo Drawn Figure");
            this.btnRedo.UseVisualStyleBackColor = true;
            this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
            // 
            // splitter4
            // 
            this.splitter4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter4.Enabled = false;
            this.splitter4.Location = new System.Drawing.Point(380, 3);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(3, 20);
            this.splitter4.TabIndex = 20;
            this.splitter4.TabStop = false;
            // 
            // chkContinuousDrawing
            // 
            this.chkContinuousDrawing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkContinuousDrawing.AutoSize = true;
            this.chkContinuousDrawing.Enabled = false;
            this.chkContinuousDrawing.ForeColor = System.Drawing.Color.White;
            this.chkContinuousDrawing.Location = new System.Drawing.Point(389, 6);
            this.chkContinuousDrawing.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.chkContinuousDrawing.Name = "chkContinuousDrawing";
            this.chkContinuousDrawing.Size = new System.Drawing.Size(114, 16);
            this.chkContinuousDrawing.TabIndex = 11;
            this.chkContinuousDrawing.Text = "Continuous Drawing";
            this.toolTip1.SetToolTip(this.chkContinuousDrawing, "When interactive mode off, selecting this will Connect figures of same type.");
            this.chkContinuousDrawing.UseVisualStyleBackColor = true;
            // 
            // chkReverseOrder
            // 
            this.chkReverseOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkReverseOrder.AutoSize = true;
            this.chkReverseOrder.ForeColor = System.Drawing.Color.White;
            this.chkReverseOrder.Location = new System.Drawing.Point(509, 6);
            this.chkReverseOrder.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.chkReverseOrder.Name = "chkReverseOrder";
            this.chkReverseOrder.Size = new System.Drawing.Size(85, 16);
            this.chkReverseOrder.TabIndex = 10;
            this.chkReverseOrder.Text = "Reverse Order";
            this.toolTip1.SetToolTip(this.chkReverseOrder, "Draw Figures on Canvas in reverse order");
            this.chkReverseOrder.UseVisualStyleBackColor = true;
            this.chkReverseOrder.CheckedChanged += new System.EventHandler(this.chkReverseDrawing_CheckedChanged);
            // 
            // chkInteractiveMode
            // 
            this.chkInteractiveMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkInteractiveMode.AutoSize = true;
            this.chkInteractiveMode.Checked = true;
            this.chkInteractiveMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkInteractiveMode.ForeColor = System.Drawing.Color.White;
            this.chkInteractiveMode.Location = new System.Drawing.Point(600, 6);
            this.chkInteractiveMode.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.chkInteractiveMode.Name = "chkInteractiveMode";
            this.chkInteractiveMode.Size = new System.Drawing.Size(98, 16);
            this.chkInteractiveMode.TabIndex = 10;
            this.chkInteractiveMode.Text = "Interactive Mode";
            this.toolTip1.SetToolTip(this.chkInteractiveMode, "On: Draw Figures freely.\r\nOff: Set dots to drop a Figure on Canvas.");
            this.chkInteractiveMode.UseVisualStyleBackColor = true;
            this.chkInteractiveMode.CheckedChanged += new System.EventHandler(this.chkInteractiveMode_CheckedChanged);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(824, 561);
            this.Controls.Add(this.tableLayoutPanel_Main);
            this.DoubleBuffered = true;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drawing With Winforms";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            this.pnlContainer.ResumeLayout(false);
            this.pnlTaskbar.ResumeLayout(false);
            this.pnlFigures.ResumeLayout(false);
            this.flpFiguresContainer.ResumeLayout(false);
            this.tableLayoutPanel_Main.ResumeLayout(false);
            this.tableLayoutPanel_Main.PerformLayout();
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbStrokeThickness)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnReset;
        private CanvasControl Canvas;
        private Button btnCanvasBackgroundColor;
        private ShapeRadioButton rbtnLine;
        private ShapeRadioButton rbtnRectangle;
        private ShapeRadioButton rbtnCircle;
        private Panel pnlContainer;
        private Panel pnlTaskbar;
        private Panel pnlFigures;
        private TableLayoutPanel tableLayoutPanel_Main;
        private Label label1;
        private Label lblMousePosition;
        private Label lblResizeCanvas;
        private Label label2;
        private FlowLayoutPanel flpFiguresContainer;
        private ToolTip toolTip1;
        private ShapeRadioButton rbtnCurve;
        private Button btnRemoveCanvasBackgroundImage;
        private FlowLayoutPanel pnlControls;
        private Button btnOpen;
        private Button btnSave;
        private Splitter splitter;
        private Button btnStroke;
        private Splitter splitter1;
        private CheckBox chkCanUseFill;
        private Button btnFill;
        private Splitter splitter2;
        private TrackBar tbStrokeThickness;
        private Button btnUndo;
        private Button btnRedo;
        private CheckBox chkContinuousDrawing;
        private CheckBox chkReverseOrder;
        private CheckBox chkInteractiveMode;
        private Splitter splitter3;
        private Splitter splitter4;
    }
}