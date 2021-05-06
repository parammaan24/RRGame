namespace RRGame
{
    partial class PlayGame
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
            this.lblMsg = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.lblRemaining = new System.Windows.Forms.Label();
            this.pictureProcess = new System.Windows.Forms.PictureBox();
            this.pictureResult = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSpin = new System.Windows.Forms.Button();
            this.buttonPress = new System.Windows.Forms.Button();
            this.buttonshootaway = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProcess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureResult)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Tw Cen MT Condensed", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.Location = new System.Drawing.Point(47, 480);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(350, 51);
            this.lblMsg.TabIndex = 2;
            this.lblMsg.Text = "Click To Start The Game...";
            // 
            // buttonStart
            // 
            this.buttonStart.BackgroundImage = global::RRGame.Properties.Resources.start;
            this.buttonStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.buttonStart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonStart.Location = new System.Drawing.Point(55, 326);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(285, 80);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Start Game";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // lblRemaining
            // 
            this.lblRemaining.AutoSize = true;
            this.lblRemaining.Font = new System.Drawing.Font("Tempus Sans ITC", 20F, System.Drawing.FontStyle.Bold);
            this.lblRemaining.Location = new System.Drawing.Point(12, 214);
            this.lblRemaining.Name = "lblRemaining";
            this.lblRemaining.Size = new System.Drawing.Size(0, 45);
            this.lblRemaining.TabIndex = 7;
            // 
            // pictureProcess
            // 
            this.pictureProcess.Image = global::RRGame.Properties.Resources.emptychamber;
            this.pictureProcess.Location = new System.Drawing.Point(625, 10);
            this.pictureProcess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureProcess.Name = "pictureProcess";
            this.pictureProcess.Size = new System.Drawing.Size(300, 240);
            this.pictureProcess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureProcess.TabIndex = 1;
            this.pictureProcess.TabStop = false;
            // 
            // pictureResult
            // 
            this.pictureResult.Image = global::RRGame.Properties.Resources.menwithgun;
            this.pictureResult.Location = new System.Drawing.Point(12, 30);
            this.pictureResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureResult.Name = "pictureResult";
            this.pictureResult.Size = new System.Drawing.Size(400, 219);
            this.pictureResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureResult.TabIndex = 0;
            this.pictureResult.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 455);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Instructions:";
            // 
            // buttonLoad
            // 
            this.buttonLoad.BackgroundImage = global::RRGame.Properties.Resources.loadbtn;
            this.buttonLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoad.Location = new System.Drawing.Point(380, 311);
            this.buttonLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(187, 93);
            this.buttonLoad.TabIndex = 4;
            this.buttonLoad.Text = "Load Bullet";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonSpin
            // 
            this.buttonSpin.BackgroundImage = global::RRGame.Properties.Resources.spinbutton;
            this.buttonSpin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSpin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSpin.Location = new System.Drawing.Point(589, 311);
            this.buttonSpin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSpin.Name = "buttonSpin";
            this.buttonSpin.Size = new System.Drawing.Size(214, 98);
            this.buttonSpin.TabIndex = 5;
            this.buttonSpin.Text = "Spin Chamber";
            this.buttonSpin.UseVisualStyleBackColor = true;
            this.buttonSpin.Click += new System.EventHandler(this.buttonSpin_Click);
            // 
            // buttonPress
            // 
            this.buttonPress.BackColor = System.Drawing.Color.Transparent;
            this.buttonPress.BackgroundImage = global::RRGame.Properties.Resources.goShoot;
            this.buttonPress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPress.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPress.ForeColor = System.Drawing.Color.Black;
            this.buttonPress.Location = new System.Drawing.Point(811, 316);
            this.buttonPress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPress.Name = "buttonPress";
            this.buttonPress.Size = new System.Drawing.Size(201, 73);
            this.buttonPress.TabIndex = 6;
            this.buttonPress.Text = "Shoot";
            this.buttonPress.UseVisualStyleBackColor = false;
            this.buttonPress.Click += new System.EventHandler(this.buttonPress_Click);
            // 
            // buttonshootaway
            // 
            this.buttonshootaway.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonshootaway.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonshootaway.Location = new System.Drawing.Point(425, 446);
            this.buttonshootaway.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonshootaway.Name = "buttonshootaway";
            this.buttonshootaway.Size = new System.Drawing.Size(213, 95);
            this.buttonshootaway.TabIndex = 9;
            this.buttonshootaway.Text = "Shoot Away";
            this.buttonshootaway.UseVisualStyleBackColor = false;
            this.buttonshootaway.Click += new System.EventHandler(this.buttonshootaway_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(659, 446);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(213, 95);
            this.btn_Exit.TabIndex = 10;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // PlayGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RRGame.Properties.Resources.backCover;
            this.ClientSize = new System.Drawing.Size(1022, 585);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.buttonshootaway);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRemaining);
            this.Controls.Add(this.buttonPress);
            this.Controls.Add(this.buttonSpin);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.pictureProcess);
            this.Controls.Add(this.pictureResult);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PlayGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Play Russian Roulette";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainScreen_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureProcess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureResult;
        private System.Windows.Forms.PictureBox pictureProcess;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label lblRemaining;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSpin;
        private System.Windows.Forms.Button buttonPress;
        private System.Windows.Forms.Button buttonshootaway;
        private System.Windows.Forms.Button btn_Exit;
    }
}