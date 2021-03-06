﻿namespace DrawingToolkit
{
    partial class DrawingCanvas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrawingCanvas));
            this.LineTool = new System.Windows.Forms.Button();
            this.CircleTool = new System.Windows.Forms.Button();
            this.DrawingTools = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.RectangleTool = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DrawingTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // LineTool
            // 
            this.LineTool.BackColor = System.Drawing.Color.Snow;
            this.LineTool.Location = new System.Drawing.Point(11, 16);
            this.LineTool.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LineTool.Name = "LineTool";
            this.LineTool.Size = new System.Drawing.Size(31, 27);
            this.LineTool.TabIndex = 0;
            this.LineTool.Text = "/";
            this.LineTool.UseVisualStyleBackColor = false;
            this.LineTool.Click += new System.EventHandler(this.LineTool_Click);
            // 
            // CircleTool
            // 
            this.CircleTool.BackColor = System.Drawing.Color.Snow;
            this.CircleTool.Location = new System.Drawing.Point(47, 16);
            this.CircleTool.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CircleTool.Name = "CircleTool";
            this.CircleTool.Size = new System.Drawing.Size(31, 27);
            this.CircleTool.TabIndex = 1;
            this.CircleTool.Text = "O";
            this.CircleTool.UseVisualStyleBackColor = false;
            this.CircleTool.Click += new System.EventHandler(this.CircleTool_Click);
            // 
            // DrawingTools
            // 
            this.DrawingTools.BackColor = System.Drawing.Color.Red;
            this.DrawingTools.Controls.Add(this.button2);
            this.DrawingTools.Controls.Add(this.button1);
            this.DrawingTools.Controls.Add(this.RectangleTool);
            this.DrawingTools.Controls.Add(this.CircleTool);
            this.DrawingTools.Controls.Add(this.LineTool);
            this.DrawingTools.Location = new System.Drawing.Point(3, 4);
            this.DrawingTools.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DrawingTools.Name = "DrawingTools";
            this.DrawingTools.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DrawingTools.Size = new System.Drawing.Size(1149, 47);
            this.DrawingTools.TabIndex = 2;
            this.DrawingTools.TabStop = false;
            this.DrawingTools.Text = "Drawing Tools";
            this.DrawingTools.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Snow;
            this.button2.Location = new System.Drawing.Point(120, 16);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 27);
            this.button2.TabIndex = 6;
            this.button2.Text = "Drag and Drop";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(1035, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "ERASE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RectangleTool
            // 
            this.RectangleTool.BackColor = System.Drawing.Color.Snow;
            this.RectangleTool.Location = new System.Drawing.Point(84, 16);
            this.RectangleTool.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RectangleTool.Name = "RectangleTool";
            this.RectangleTool.Size = new System.Drawing.Size(31, 27);
            this.RectangleTool.TabIndex = 2;
            this.RectangleTool.Text = "[]";
            this.RectangleTool.UseVisualStyleBackColor = false;
            this.RectangleTool.Click += new System.EventHandler(this.RectangleTool_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(3, 57);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1149, 679);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // DrawingCanvas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1157, 741);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DrawingTools);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DrawingCanvas";
            this.Text = "DRAWING KIT";
            this.Load += new System.EventHandler(this.DrawingCanvas_Load);
            this.DrawingTools.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LineTool;
        private System.Windows.Forms.Button CircleTool;
        private System.Windows.Forms.GroupBox DrawingTools;
        private System.Windows.Forms.Button RectangleTool;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }

}

