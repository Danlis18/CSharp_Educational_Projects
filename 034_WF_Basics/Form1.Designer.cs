namespace _034_WF_Basics
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textLabel = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            button2 = new Button();
            labelCount = new Label();
            button3 = new Button();
            labelTimer = new Label();
            timer2 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // textLabel
            // 
            textLabel.AutoSize = true;
            textLabel.BackColor = Color.FromArgb(128, 128, 255);
            textLabel.BorderStyle = BorderStyle.Fixed3D;
            textLabel.Font = new Font("Impact", 18F, FontStyle.Underline, GraphicsUnit.Point, 204);
            textLabel.ForeColor = Color.Yellow;
            textLabel.Location = new Point(44, 50);
            textLabel.Margin = new Padding(4, 0, 4, 0);
            textLabel.Name = "textLabel";
            textLabel.Size = new Size(107, 46);
            textLabel.TabIndex = 0;
            textLabel.Text = "Hello!";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // button1
            // 
            button1.Location = new Point(299, 15);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(182, 89);
            button1.TabIndex = 1;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(522, 15);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(198, 89);
            button2.TabIndex = 2;
            button2.Text = "Stop";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // labelCount
            // 
            labelCount.AutoSize = true;
            labelCount.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelCount.Location = new Point(470, 121);
            labelCount.Margin = new Padding(4, 0, 4, 0);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(79, 96);
            labelCount.TabIndex = 3;
            labelCount.Text = "0";
            labelCount.Click += labelCount_Click;
            // 
            // button3
            // 
            button3.Location = new Point(769, 15);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(198, 89);
            button3.TabIndex = 4;
            button3.Text = "Close";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // labelTimer
            // 
            labelTimer.AutoSize = true;
            labelTimer.Location = new Point(470, 315);
            labelTimer.Margin = new Padding(4, 0, 4, 0);
            labelTimer.Name = "labelTimer";
            labelTimer.Size = new Size(0, 25);
            labelTimer.TabIndex = 5;
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Interval = 1000;
            timer2.Tick += timer2_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            BackgroundImage = Properties.Resources._2___ROG_Wallpaper_Challenge___4K;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1245, 660);
            Controls.Add(labelTimer);
            Controls.Add(button3);
            Controls.Add(labelCount);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Моє вікно";
            MouseClick += Form1_MouseClick;
            MouseDoubleClick += Form1_MouseDoubleClick;
            MouseMove += Form1_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label textLabel;
        private System.Windows.Forms.Timer timer1;
        private Button button1;
        private Button button2;
        private Label labelCount;
        private Button button3;
        private Label labelTimer;
        private System.Windows.Forms.Timer timer2;
    }
}
