namespace ScrumTable
{
    partial class frmMain
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.pnlNotStarted = new System.Windows.Forms.Panel();
            this.pnlInProgress = new System.Windows.Forms.Panel();
            this.pnlDone = new System.Windows.Forms.Panel();
            this.pnlStory = new System.Windows.Forms.Panel();
            this.btnStoryEkle = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnTaskEkle = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.AutoSize = true;
            this.panel5.Controls.Add(this.pnlNotStarted);
            this.panel5.Controls.Add(this.pnlInProgress);
            this.panel5.Controls.Add(this.pnlDone);
            this.panel5.Controls.Add(this.pnlStory);
            this.panel5.Location = new System.Drawing.Point(26, 141);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(824, 591);
            this.panel5.TabIndex = 1;
            // 
            // pnlNotStarted
            // 
            this.pnlNotStarted.AllowDrop = true;
            this.pnlNotStarted.AutoSize = true;
            this.pnlNotStarted.BackColor = System.Drawing.Color.Chocolate;
            this.pnlNotStarted.Location = new System.Drawing.Point(209, 3);
            this.pnlNotStarted.Name = "pnlNotStarted";
            this.pnlNotStarted.Size = new System.Drawing.Size(200, 585);
            this.pnlNotStarted.TabIndex = 3;
            this.pnlNotStarted.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_DragDrop);
            this.pnlNotStarted.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel_DragEnter);
            // 
            // pnlInProgress
            // 
            this.pnlInProgress.AllowDrop = true;
            this.pnlInProgress.AutoSize = true;
            this.pnlInProgress.BackColor = System.Drawing.Color.Goldenrod;
            this.pnlInProgress.Location = new System.Drawing.Point(415, 3);
            this.pnlInProgress.Name = "pnlInProgress";
            this.pnlInProgress.Size = new System.Drawing.Size(200, 585);
            this.pnlInProgress.TabIndex = 4;
            this.pnlInProgress.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_DragDrop);
            this.pnlInProgress.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel_DragEnter);
            // 
            // pnlDone
            // 
            this.pnlDone.AllowDrop = true;
            this.pnlDone.AutoSize = true;
            this.pnlDone.BackColor = System.Drawing.Color.GreenYellow;
            this.pnlDone.Location = new System.Drawing.Point(621, 3);
            this.pnlDone.Name = "pnlDone";
            this.pnlDone.Size = new System.Drawing.Size(200, 585);
            this.pnlDone.TabIndex = 5;
            this.pnlDone.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_DragDrop);
            this.pnlDone.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel_DragEnter);
            // 
            // pnlStory
            // 
            this.pnlStory.AutoSize = true;
            this.pnlStory.BackColor = System.Drawing.Color.Tomato;
            this.pnlStory.Location = new System.Drawing.Point(3, 3);
            this.pnlStory.Name = "pnlStory";
            this.pnlStory.Size = new System.Drawing.Size(200, 585);
            this.pnlStory.TabIndex = 2;
            // 
            // btnStoryEkle
            // 
            this.btnStoryEkle.Location = new System.Drawing.Point(29, 34);
            this.btnStoryEkle.Name = "btnStoryEkle";
            this.btnStoryEkle.Size = new System.Drawing.Size(200, 46);
            this.btnStoryEkle.TabIndex = 2;
            this.btnStoryEkle.Text = "Story Ekle";
            this.btnStoryEkle.UseVisualStyleBackColor = true;
            this.btnStoryEkle.Click += new System.EventHandler(this.btnStoryEkle_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Location = new System.Drawing.Point(26, 104);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(203, 34);
            this.button3.TabIndex = 4;
            this.button3.Text = "STORY";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Location = new System.Drawing.Point(235, 101);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 34);
            this.button4.TabIndex = 5;
            this.button4.Text = "NOT STARTED";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.Location = new System.Drawing.Point(441, 104);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 34);
            this.button5.TabIndex = 6;
            this.button5.Text = "IN PROGRESS";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button6.Location = new System.Drawing.Point(647, 104);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(200, 34);
            this.button6.TabIndex = 7;
            this.button6.Text = "DONE";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // btnTaskEkle
            // 
            this.btnTaskEkle.Location = new System.Drawing.Point(235, 34);
            this.btnTaskEkle.Name = "btnTaskEkle";
            this.btnTaskEkle.Size = new System.Drawing.Size(200, 46);
            this.btnTaskEkle.TabIndex = 8;
            this.btnTaskEkle.Text = "Task Ekle";
            this.btnTaskEkle.UseVisualStyleBackColor = true;
            this.btnTaskEkle.Click += new System.EventHandler(this.btnTaskEkle_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(883, 746);
            this.Controls.Add(this.btnTaskEkle);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnStoryEkle);
            this.Controls.Add(this.panel5);
            this.Name = "frmMain";
            this.Text = "SCRUM TABLE";
            this.Load += new System.EventHandler(this.frmMain_Load_1);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel pnlNotStarted;
        private System.Windows.Forms.Panel pnlInProgress;
        private System.Windows.Forms.Panel pnlDone;
        private System.Windows.Forms.Panel pnlStory;
        private System.Windows.Forms.Button btnStoryEkle;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnTaskEkle;
    }
}

