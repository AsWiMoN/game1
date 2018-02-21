namespace SimpleGame
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
            this.timerMario = new System.Windows.Forms.Timer(this.components);
            this.timerBob = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timerMario
            // 
            this.timerMario.Enabled = true;
            this.timerMario.Interval = 40;
            this.timerMario.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerBob
            // 
            this.timerBob.Enabled = true;
            this.timerBob.Tick += new System.EventHandler(this.timerBob_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerMario;
        private System.Windows.Forms.Timer timerBob;
    }
}

