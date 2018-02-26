namespace Game1
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
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.mainLoopTimer = new System.Windows.Forms.Timer(this.components);
            this.exitButton = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.Label();
            this.emptyButton = new System.Windows.Forms.Button();
            this.sandButton = new System.Windows.Forms.Button();
            this.groundButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.generateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainLoopTimer
            // 
            this.mainLoopTimer.Enabled = true;
            this.mainLoopTimer.Interval = 41;
            this.mainLoopTimer.Tick += new System.EventHandler(this.mainLoopTimer_Tick);
            // 
            // exitButton
            // 
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Image = global::Game1.Resource1.exitButton;
            this.exitButton.Location = new System.Drawing.Point(754, -1);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(47, 45);
            this.exitButton.TabIndex = 0;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // log
            // 
            this.log.AutoSize = true;
            this.log.ForeColor = System.Drawing.Color.Lime;
            this.log.Location = new System.Drawing.Point(0, 0);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(25, 13);
            this.log.TabIndex = 1;
            this.log.Text = "Log";
            // 
            // emptyButton
            // 
            this.emptyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.emptyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emptyButton.FlatAppearance.BorderSize = 0;
            this.emptyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.emptyButton.Location = new System.Drawing.Point(109, 424);
            this.emptyButton.Name = "emptyButton";
            this.emptyButton.Size = new System.Drawing.Size(47, 45);
            this.emptyButton.TabIndex = 2;
            this.emptyButton.Tag = "empty";
            this.emptyButton.UseVisualStyleBackColor = true;
            this.emptyButton.Click += new System.EventHandler(this.CurrentPlacedBlock);
            // 
            // sandButton
            // 
            this.sandButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.sandButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sandButton.FlatAppearance.BorderSize = 0;
            this.sandButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sandButton.Image = global::Game1.Resource1.Ground2;
            this.sandButton.Location = new System.Drawing.Point(56, 424);
            this.sandButton.Name = "sandButton";
            this.sandButton.Size = new System.Drawing.Size(47, 45);
            this.sandButton.TabIndex = 3;
            this.sandButton.Tag = "sand";
            this.sandButton.UseVisualStyleBackColor = true;
            this.sandButton.Click += new System.EventHandler(this.CurrentPlacedBlock);
            // 
            // groundButton
            // 
            this.groundButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groundButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groundButton.FlatAppearance.BorderSize = 0;
            this.groundButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groundButton.Image = global::Game1.Resource1.Ground1;
            this.groundButton.Location = new System.Drawing.Point(3, 424);
            this.groundButton.Name = "groundButton";
            this.groundButton.Size = new System.Drawing.Size(47, 45);
            this.groundButton.TabIndex = 4;
            this.groundButton.Tag = "ground";
            this.groundButton.UseVisualStyleBackColor = true;
            this.groundButton.Click += new System.EventHandler(this.CurrentPlacedBlock);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(476, 12);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(557, 12);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 6;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(638, 12);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(94, 23);
            this.generateButton.TabIndex = 7;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.groundButton);
            this.Controls.Add(this.sandButton);
            this.Controls.Add(this.emptyButton);
            this.Controls.Add(this.log);
            this.Controls.Add(this.exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = " ";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Timer mainLoopTimer;
        private System.Windows.Forms.Label log;
        private System.Windows.Forms.Button emptyButton;
        private System.Windows.Forms.Button sandButton;
        private System.Windows.Forms.Button groundButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button generateButton;
    }
}

