namespace JourneyThroughHoodFinal
{
    partial class JourneyHood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JourneyHood));
            this.SceneOut = new System.Windows.Forms.Label();
            this.qOutput = new System.Windows.Forms.Label();
            this.wOutput = new System.Windows.Forms.Label();
            this.wButt = new System.Windows.Forms.Label();
            this.qButt = new System.Windows.Forms.Label();
            this.imageout = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SceneOut
            // 
            this.SceneOut.BackColor = System.Drawing.Color.White;
            this.SceneOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SceneOut.ForeColor = System.Drawing.Color.Black;
            this.SceneOut.Location = new System.Drawing.Point(12, 18);
            this.SceneOut.Name = "SceneOut";
            this.SceneOut.Size = new System.Drawing.Size(776, 49);
            this.SceneOut.TabIndex = 0;
            this.SceneOut.Text = "You exit a party at 3 am and need to get home. You find a buspass and some shoes." +
    " Do you?";
            // 
            // qOutput
            // 
            this.qOutput.BackColor = System.Drawing.Color.White;
            this.qOutput.ForeColor = System.Drawing.Color.Black;
            this.qOutput.Location = new System.Drawing.Point(12, 336);
            this.qOutput.Name = "qOutput";
            this.qOutput.Size = new System.Drawing.Size(142, 13);
            this.qOutput.TabIndex = 1;
            this.qOutput.Text = "Take the ticket";
            // 
            // wOutput
            // 
            this.wOutput.BackColor = System.Drawing.Color.White;
            this.wOutput.ForeColor = System.Drawing.Color.Black;
            this.wOutput.Location = new System.Drawing.Point(12, 408);
            this.wOutput.Name = "wOutput";
            this.wOutput.Size = new System.Drawing.Size(142, 13);
            this.wOutput.TabIndex = 2;
            this.wOutput.Text = "Take the shoes";
            // 
            // wButt
            // 
            this.wButt.BackColor = System.Drawing.Color.Blue;
            this.wButt.ForeColor = System.Drawing.Color.White;
            this.wButt.Location = new System.Drawing.Point(160, 403);
            this.wButt.Name = "wButt";
            this.wButt.Size = new System.Drawing.Size(100, 23);
            this.wButt.TabIndex = 3;
            this.wButt.Text = "W";
            this.wButt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // qButt
            // 
            this.qButt.BackColor = System.Drawing.Color.Red;
            this.qButt.ForeColor = System.Drawing.Color.White;
            this.qButt.Location = new System.Drawing.Point(160, 331);
            this.qButt.Name = "qButt";
            this.qButt.Size = new System.Drawing.Size(100, 23);
            this.qButt.TabIndex = 4;
            this.qButt.Text = "Q";
            this.qButt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageout
            // 
            this.imageout.Location = new System.Drawing.Point(530, 298);
            this.imageout.Name = "imageout";
            this.imageout.Size = new System.Drawing.Size(100, 23);
            this.imageout.TabIndex = 5;
            this.imageout.Text = "label1";
            // 
            // label1
            // 
            this.label1.Image = global::JourneyThroughHoodFinal.Properties.Resources.party;
            this.label1.Location = new System.Drawing.Point(300, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(488, 355);
            this.label1.TabIndex = 6;
            // 
            // JourneyHood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imageout);
            this.Controls.Add(this.qButt);
            this.Controls.Add(this.wButt);
            this.Controls.Add(this.wOutput);
            this.Controls.Add(this.qOutput);
            this.Controls.Add(this.SceneOut);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JourneyHood";
            this.Text = "Journey Through the Hood";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.JourneyHood_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label SceneOut;
        private System.Windows.Forms.Label qOutput;
        private System.Windows.Forms.Label wOutput;
        private System.Windows.Forms.Label wButt;
        private System.Windows.Forms.Label qButt;
        private System.Windows.Forms.Label imageout;
        private System.Windows.Forms.Label label1;
    }
}

