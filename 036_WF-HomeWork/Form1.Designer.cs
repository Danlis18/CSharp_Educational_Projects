namespace _036_WF_HomeWork
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
            Left_Clik = new Label();
            Right_Clik = new Label();
            Middle_Clik = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            left = new Label();
            Right = new Label();
            Middle = new Label();
            title_BD = new Label();
            seconds = new Label();
            timer2 = new System.Windows.Forms.Timer(components);
            close_title = new Label();
            timer_to_close = new Label();
            timer3 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            button_yes = new Button();
            button_No = new Button();
            SuspendLayout();
            // 
            // Left_Clik
            // 
            Left_Clik.AutoSize = true;
            Left_Clik.BackColor = Color.MediumSeaGreen;
            Left_Clik.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Left_Clik.ForeColor = SystemColors.ControlLightLight;
            Left_Clik.Location = new Point(323, 9);
            Left_Clik.Name = "Left_Clik";
            Left_Clik.Size = new Size(47, 54);
            Left_Clik.TabIndex = 0;
            Left_Clik.Text = "0";
            // 
            // Right_Clik
            // 
            Right_Clik.AutoSize = true;
            Right_Clik.BackColor = Color.MediumSeaGreen;
            Right_Clik.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Right_Clik.ForeColor = SystemColors.ControlLightLight;
            Right_Clik.Location = new Point(323, 77);
            Right_Clik.Name = "Right_Clik";
            Right_Clik.Size = new Size(47, 54);
            Right_Clik.TabIndex = 1;
            Right_Clik.Text = "0";
            // 
            // Middle_Clik
            // 
            Middle_Clik.AutoSize = true;
            Middle_Clik.BackColor = Color.MediumSeaGreen;
            Middle_Clik.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Middle_Clik.ForeColor = SystemColors.ControlLightLight;
            Middle_Clik.Location = new Point(323, 152);
            Middle_Clik.Name = "Middle_Clik";
            Middle_Clik.Size = new Size(47, 54);
            Middle_Clik.TabIndex = 2;
            Middle_Clik.Text = "0";
            // 
            // timer1
            // 
            timer1.Interval = 1;
            // 
            // left
            // 
            left.AutoSize = true;
            left.BackColor = Color.MediumSeaGreen;
            left.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 204);
            left.ForeColor = SystemColors.ControlLightLight;
            left.Location = new Point(12, 9);
            left.Name = "left";
            left.Size = new Size(243, 54);
            left.TabIndex = 3;
            left.Text = "Left_Clicks:";
            // 
            // Right
            // 
            Right.AutoSize = true;
            Right.BackColor = Color.MediumSeaGreen;
            Right.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Right.ForeColor = SystemColors.ControlLightLight;
            Right.Location = new Point(12, 77);
            Right.Name = "Right";
            Right.Size = new Size(272, 54);
            Right.TabIndex = 4;
            Right.Text = "Right_Clicks:";
            // 
            // Middle
            // 
            Middle.AutoSize = true;
            Middle.BackColor = Color.MediumSeaGreen;
            Middle.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Middle.ForeColor = SystemColors.ControlLightLight;
            Middle.Location = new Point(12, 152);
            Middle.Name = "Middle";
            Middle.Size = new Size(302, 54);
            Middle.TabIndex = 5;
            Middle.Text = "Middle_Clicks:";
            // 
            // title_BD
            // 
            title_BD.AutoSize = true;
            title_BD.BackColor = Color.LimeGreen;
            title_BD.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 204);
            title_BD.ForeColor = SystemColors.ControlLightLight;
            title_BD.Location = new Point(514, 9);
            title_BD.Name = "title_BD";
            title_BD.Size = new Size(503, 54);
            title_BD.TabIndex = 6;
            title_BD.Text = "Time to my Birthday (s):";
            // 
            // seconds
            // 
            seconds.AutoSize = true;
            seconds.BackColor = Color.LimeGreen;
            seconds.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 204);
            seconds.ForeColor = SystemColors.ControlLightLight;
            seconds.Location = new Point(1034, 9);
            seconds.Name = "seconds";
            seconds.Size = new Size(0, 54);
            seconds.TabIndex = 7;
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Interval = 1000;
            timer2.Tick += timer2_Tick;
            // 
            // close_title
            // 
            close_title.AutoSize = true;
            close_title.BackColor = Color.Red;
            close_title.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 204);
            close_title.ForeColor = SystemColors.ControlLightLight;
            close_title.Location = new Point(514, 152);
            close_title.Name = "close_title";
            close_title.Size = new Size(195, 54);
            close_title.TabIndex = 8;
            close_title.Text = "To close:";
            // 
            // timer_to_close
            // 
            timer_to_close.AutoSize = true;
            timer_to_close.BackColor = Color.Red;
            timer_to_close.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 204);
            timer_to_close.ForeColor = SystemColors.ControlLightLight;
            timer_to_close.Location = new Point(715, 152);
            timer_to_close.Name = "timer_to_close";
            timer_to_close.Size = new Size(0, 54);
            timer_to_close.TabIndex = 9;
            // 
            // timer3
            // 
            timer3.Enabled = true;
            timer3.Interval = 1000;
            timer3.Tick += timer3_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Blue;
            label1.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 360);
            label1.Name = "label1";
            label1.Size = new Size(616, 54);
            label1.TabIndex = 10;
            label1.Text = "Ви хочете натиснути кнопку?";
            // 
            // button_yes
            // 
            button_yes.BackColor = Color.LimeGreen;
            button_yes.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button_yes.Location = new Point(12, 445);
            button_yes.Name = "button_yes";
            button_yes.Size = new Size(167, 83);
            button_yes.TabIndex = 11;
            button_yes.Text = "ТАК";
            button_yes.UseVisualStyleBackColor = false;
            button_yes.Click += button_yes_Click;
            button_yes.MouseMove += button_yes_MouseMove;
            // 
            // button_No
            // 
            button_No.BackColor = Color.Red;
            button_No.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button_No.Location = new Point(461, 445);
            button_No.Name = "button_No";
            button_No.Size = new Size(167, 83);
            button_No.TabIndex = 12;
            button_No.Text = "НІ";
            button_No.UseVisualStyleBackColor = false;
            button_No.Click += button_No_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(1378, 844);
            Controls.Add(button_No);
            Controls.Add(button_yes);
            Controls.Add(label1);
            Controls.Add(timer_to_close);
            Controls.Add(close_title);
            Controls.Add(seconds);
            Controls.Add(title_BD);
            Controls.Add(Middle);
            Controls.Add(Right);
            Controls.Add(left);
            Controls.Add(Middle_Clik);
            Controls.Add(Right_Clik);
            Controls.Add(Left_Clik);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home Work";
            MouseClick += Form1_MouseClick;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Left_Clik;
        private Label Right_Clik;
        private Label Middle_Clik;
        private System.Windows.Forms.Timer timer1;
        private Label left;
        private Label Right;
        private Label Middle;
        private Label title_BD;
        private Label seconds;
        private System.Windows.Forms.Timer timer2;
        private Label close_title;
        private Label timer_to_close;
        private System.Windows.Forms.Timer timer3;
        private Label label1;
        private Button button_yes;
        private Button button_No;
    }
}
