namespace WinFormsApp1
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
            btnClickMe = new Button();
            btLeftTop = new Button();
            btLeftBottom = new Button();
            btRightTop = new Button();
            btRightBottom = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnClickMe
            // 
            btnClickMe.Location = new Point(183, 142);
            btnClickMe.Name = "btnClickMe";
            btnClickMe.Size = new Size(340, 122);
            btnClickMe.TabIndex = 0;
            btnClickMe.Text = "Click Me";
            btnClickMe.UseVisualStyleBackColor = true;
            btnClickMe.MouseEnter += btnClickMe_MouseEnter;
            // 
            // btLeftTop
            // 
            btLeftTop.Location = new Point(22, 22);
            btLeftTop.Name = "btLeftTop";
            btLeftTop.Size = new Size(75, 23);
            btLeftTop.TabIndex = 1;
            btLeftTop.UseVisualStyleBackColor = true;
            btLeftTop.MouseEnter += btLeftTop_MouseEnter;
            // 
            // btLeftBottom
            // 
            btLeftBottom.Location = new Point(22, 404);
            btLeftBottom.Name = "btLeftBottom";
            btLeftBottom.Size = new Size(75, 23);
            btLeftBottom.TabIndex = 1;
            btLeftBottom.UseVisualStyleBackColor = true;
            btLeftBottom.MouseEnter += btLeftBottom_MouseEnter;
            // 
            // btRightTop
            // 
            btRightTop.Location = new Point(692, 22);
            btRightTop.Name = "btRightTop";
            btRightTop.Size = new Size(75, 23);
            btRightTop.TabIndex = 1;
            btRightTop.UseVisualStyleBackColor = true;
            btRightTop.MouseEnter += btRightTop_MouseEnter;
            // 
            // btRightBottom
            // 
            btRightBottom.Location = new Point(692, 404);
            btRightBottom.Name = "btRightBottom";
            btRightBottom.Size = new Size(75, 23);
            btRightBottom.TabIndex = 1;
            btRightBottom.UseVisualStyleBackColor = true;
            btRightBottom.MouseEnter += btRightBottom_MouseEnter;
            // 
            // button1
            // 
            button1.Location = new Point(134, 22);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Form 2";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btRightBottom);
            Controls.Add(btLeftBottom);
            Controls.Add(btRightTop);
            Controls.Add(btLeftTop);
            Controls.Add(btnClickMe);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnClickMe;
        private Button btLeftTop;
        private Button btLeftBottom;
        private Button btRightTop;
        private Button btRightBottom;
        private Button button1;
    }
}