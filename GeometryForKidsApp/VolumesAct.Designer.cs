
namespace GeometryForKidsApp
{
    partial class VolumesAct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VolumesAct));
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.pctCone = new System.Windows.Forms.PictureBox();
            this.pctCylinder = new System.Windows.Forms.PictureBox();
            this.pctSphere = new System.Windows.Forms.PictureBox();
            this.pctCube = new System.Windows.Forms.PictureBox();
            this.lblPageNumber = new System.Windows.Forms.Label();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblVolume = new System.Windows.Forms.Label();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pctShape = new System.Windows.Forms.PictureBox();
            this.pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctCone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCylinder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSphere)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCube)).BeginInit();
            this.pnl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctShape)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(401, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Volumes Activity";
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(13, 558);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(146, 47);
            this.btnPrevious.TabIndex = 9;
            this.btnPrevious.Text = "Go Back";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(959, 558);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(140, 47);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = "Continue";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // pnl1
            // 
            this.pnl1.Controls.Add(this.label19);
            this.pnl1.Controls.Add(this.pctCone);
            this.pnl1.Controls.Add(this.pctCylinder);
            this.pnl1.Controls.Add(this.pctSphere);
            this.pnl1.Controls.Add(this.pctCube);
            this.pnl1.Location = new System.Drawing.Point(37, 67);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(1052, 456);
            this.pnl1.TabIndex = 11;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(56, 10);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(174, 30);
            this.label19.TabIndex = 14;
            this.label19.Text = "Choose a Shape";
            // 
            // pctCone
            // 
            this.pctCone.Image = global::GeometryForKidsApp.Properties.Resources.cone;
            this.pctCone.Location = new System.Drawing.Point(826, 220);
            this.pctCone.Name = "pctCone";
            this.pctCone.Size = new System.Drawing.Size(203, 213);
            this.pctCone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctCone.TabIndex = 3;
            this.pctCone.TabStop = false;
            this.pctCone.Click += new System.EventHandler(this.pctCone_Click);
            // 
            // pctCylinder
            // 
            this.pctCylinder.Image = global::GeometryForKidsApp.Properties.Resources.cylinder;
            this.pctCylinder.Location = new System.Drawing.Point(566, 60);
            this.pctCylinder.Name = "pctCylinder";
            this.pctCylinder.Size = new System.Drawing.Size(237, 215);
            this.pctCylinder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctCylinder.TabIndex = 2;
            this.pctCylinder.TabStop = false;
            this.pctCylinder.Click += new System.EventHandler(this.pctCylinder_Click);
            // 
            // pctSphere
            // 
            this.pctSphere.Image = global::GeometryForKidsApp.Properties.Resources.sphere;
            this.pctSphere.Location = new System.Drawing.Point(294, 220);
            this.pctSphere.Name = "pctSphere";
            this.pctSphere.Size = new System.Drawing.Size(256, 213);
            this.pctSphere.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctSphere.TabIndex = 1;
            this.pctSphere.TabStop = false;
            this.pctSphere.Click += new System.EventHandler(this.pctSphere_Click);
            // 
            // pctCube
            // 
            this.pctCube.Image = global::GeometryForKidsApp.Properties.Resources.cube;
            this.pctCube.Location = new System.Drawing.Point(21, 60);
            this.pctCube.Name = "pctCube";
            this.pctCube.Size = new System.Drawing.Size(255, 215);
            this.pctCube.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctCube.TabIndex = 0;
            this.pctCube.TabStop = false;
            this.pctCube.Click += new System.EventHandler(this.pctCube_Click);
            // 
            // lblPageNumber
            // 
            this.lblPageNumber.AutoSize = true;
            this.lblPageNumber.Location = new System.Drawing.Point(546, 558);
            this.lblPageNumber.Name = "lblPageNumber";
            this.lblPageNumber.Size = new System.Drawing.Size(24, 26);
            this.lblPageNumber.TabIndex = 11;
            this.lblPageNumber.Text = "5";
            // 
            // pnl2
            // 
            this.pnl2.Controls.Add(this.btnCheck);
            this.pnl2.Controls.Add(this.lblVolume);
            this.pnl2.Controls.Add(this.txtVolume);
            this.pnl2.Controls.Add(this.lblWidth);
            this.pnl2.Controls.Add(this.lblLength);
            this.pnl2.Controls.Add(this.lblHeight);
            this.pnl2.Controls.Add(this.label2);
            this.pnl2.Controls.Add(this.pctShape);
            this.pnl2.Location = new System.Drawing.Point(36, 67);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(1052, 456);
            this.pnl2.TabIndex = 12;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(743, 342);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(93, 34);
            this.btnCheck.TabIndex = 7;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(486, 345);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(80, 26);
            this.lblVolume.TabIndex = 6;
            this.lblVolume.Text = "Volume:";
            // 
            // txtVolume
            // 
            this.txtVolume.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtVolume.Location = new System.Drawing.Point(567, 342);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(100, 34);
            this.txtVolume.TabIndex = 5;
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(486, 273);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(0, 26);
            this.lblWidth.TabIndex = 4;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(486, 199);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(0, 26);
            this.lblLength.TabIndex = 3;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(486, 130);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(0, 26);
            this.lblHeight.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(478, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Solve the volume of the shape with the following data";
            // 
            // pctShape
            // 
            this.pctShape.Location = new System.Drawing.Point(81, 104);
            this.pctShape.Name = "pctShape";
            this.pctShape.Size = new System.Drawing.Size(333, 267);
            this.pctShape.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctShape.TabIndex = 0;
            this.pctShape.TabStop = false;
            // 
            // VolumesAct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(1112, 617);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.lblPageNumber);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "VolumesAct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Volumes Activity";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VolumesAct_FormClosed);
            this.Load += new System.EventHandler(this.VolumesAct_Load);
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctCone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCylinder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSphere)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCube)).EndInit();
            this.pnl2.ResumeLayout(false);
            this.pnl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctShape)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Label lblPageNumber;
        private System.Windows.Forms.PictureBox pctCone;
        private System.Windows.Forms.PictureBox pctCylinder;
        private System.Windows.Forms.PictureBox pctSphere;
        private System.Windows.Forms.PictureBox pctCube;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.PictureBox pctShape;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label label2;
    }
}