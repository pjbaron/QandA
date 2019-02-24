namespace qanda
{
    partial class QandAForm
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
            this.loadButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.revealButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.qText = new System.Windows.Forms.TextBox();
            this.aText = new System.Windows.Forms.TextBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.prevButton = new System.Windows.Forms.Button();
            this.rndCheckBox = new System.Windows.Forms.CheckBox();
            this.statusText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(12, 12);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(111, 23);
            this.loadButton.TabIndex = 0;
            this.loadButton.Text = "Load Q && A\'s...";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // startButton
            // 
            this.startButton.Enabled = false;
            this.startButton.Location = new System.Drawing.Point(129, 12);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(111, 23);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start Q && A...";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // revealButton
            // 
            this.revealButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.revealButton.Enabled = false;
            this.revealButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.revealButton.Location = new System.Drawing.Point(317, 518);
            this.revealButton.Name = "revealButton";
            this.revealButton.Size = new System.Drawing.Size(129, 39);
            this.revealButton.TabIndex = 2;
            this.revealButton.Text = "Reveal Answer...";
            this.revealButton.UseVisualStyleBackColor = true;
            this.revealButton.Click += new System.EventHandler(this.revealButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(13, 85);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.qText);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.aText);
            this.splitContainer1.Size = new System.Drawing.Size(732, 427);
            this.splitContainer1.SplitterDistance = 202;
            this.splitContainer1.TabIndex = 3;
            // 
            // qText
            // 
            this.qText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.qText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qText.Location = new System.Drawing.Point(0, 0);
            this.qText.Multiline = true;
            this.qText.Name = "qText";
            this.qText.ReadOnly = true;
            this.qText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.qText.Size = new System.Drawing.Size(729, 199);
            this.qText.TabIndex = 0;
            this.qText.TabStop = false;
            this.qText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // aText
            // 
            this.aText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aText.Location = new System.Drawing.Point(0, 0);
            this.aText.Multiline = true;
            this.aText.Name = "aText";
            this.aText.ReadOnly = true;
            this.aText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.aText.Size = new System.Drawing.Size(729, 218);
            this.aText.TabIndex = 1;
            this.aText.TabStop = false;
            this.aText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nextButton
            // 
            this.nextButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nextButton.Enabled = false;
            this.nextButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.nextButton.Location = new System.Drawing.Point(452, 518);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(129, 39);
            this.nextButton.TabIndex = 4;
            this.nextButton.Text = "Next Question...";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // prevButton
            // 
            this.prevButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.prevButton.Enabled = false;
            this.prevButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.prevButton.Location = new System.Drawing.Point(182, 518);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(129, 39);
            this.prevButton.TabIndex = 5;
            this.prevButton.Text = "Previous Question...";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // rndCheckBox
            // 
            this.rndCheckBox.AutoSize = true;
            this.rndCheckBox.Location = new System.Drawing.Point(246, 16);
            this.rndCheckBox.Name = "rndCheckBox";
            this.rndCheckBox.Size = new System.Drawing.Size(95, 17);
            this.rndCheckBox.TabIndex = 6;
            this.rndCheckBox.Text = "Random Order";
            this.rndCheckBox.UseVisualStyleBackColor = true;
            this.rndCheckBox.CheckedChanged += new System.EventHandler(this.rndCheckBox_CheckedChanged);
            // 
            // statusText
            // 
            this.statusText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusText.Location = new System.Drawing.Point(12, 39);
            this.statusText.Multiline = true;
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(733, 40);
            this.statusText.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(595, 560);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Or press SPACE to advance...";
            // 
            // QandAForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 582);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusText);
            this.Controls.Add(this.rndCheckBox);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.revealButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.loadButton);
            this.Name = "QandAForm";
            this.Text = "Q and A";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QandAForm_KeyPress);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button revealButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.TextBox qText;
        private System.Windows.Forms.TextBox aText;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.CheckBox rndCheckBox;
        private System.Windows.Forms.TextBox statusText;
        private System.Windows.Forms.Label label1;
    }
}

