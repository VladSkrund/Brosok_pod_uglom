namespace Brosok_pod_uglom
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.VelocityTextBox = new System.Windows.Forms.TextBox();
            this.Mass_ = new System.Windows.Forms.TextBox();
            this.Angle_ = new System.Windows.Forms.TextBox();
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.InitialVelocity = new System.Windows.Forms.Label();
            this.MassLabel = new System.Windows.Forms.Label();
            this.AngleT = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.RefreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(12, 129);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1275, 636);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint_1);
            // 
            // VelocityTextBox
            // 
            this.VelocityTextBox.Location = new System.Drawing.Point(12, 12);
            this.VelocityTextBox.Name = "VelocityTextBox";
            this.VelocityTextBox.Size = new System.Drawing.Size(100, 20);
            this.VelocityTextBox.TabIndex = 1;
            // 
            // Mass_
            // 
            this.Mass_.Location = new System.Drawing.Point(12, 47);
            this.Mass_.Name = "Mass_";
            this.Mass_.Size = new System.Drawing.Size(100, 20);
            this.Mass_.TabIndex = 2;
            // 
            // Angle_
            // 
            this.Angle_.Location = new System.Drawing.Point(12, 85);
            this.Angle_.Name = "Angle_";
            this.Angle_.Size = new System.Drawing.Size(100, 20);
            this.Angle_.TabIndex = 3;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(248, 9);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 4;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Start_MouseClick);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(248, 48);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(75, 23);
            this.Stop.TabIndex = 5;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Stop_MouseClick);
            // 
            // InitialVelocity
            // 
            this.InitialVelocity.AutoSize = true;
            this.InitialVelocity.Location = new System.Drawing.Point(139, 19);
            this.InitialVelocity.Name = "InitialVelocity";
            this.InitialVelocity.Size = new System.Drawing.Size(71, 13);
            this.InitialVelocity.TabIndex = 6;
            this.InitialVelocity.Text = "Initial Velocity";
            // 
            // MassLabel
            // 
            this.MassLabel.AutoSize = true;
            this.MassLabel.Location = new System.Drawing.Point(142, 53);
            this.MassLabel.Name = "MassLabel";
            this.MassLabel.Size = new System.Drawing.Size(32, 13);
            this.MassLabel.TabIndex = 7;
            this.MassLabel.Text = "Mass";
            // 
            // AngleT
            // 
            this.AngleT.AutoSize = true;
            this.AngleT.Location = new System.Drawing.Point(142, 91);
            this.AngleT.Name = "AngleT";
            this.AngleT.Size = new System.Drawing.Size(34, 13);
            this.AngleT.TabIndex = 8;
            this.AngleT.Text = "Angle";
            this.AngleT.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(353, 8);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshButton.TabIndex = 9;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RefreshButton_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 777);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.AngleT);
            this.Controls.Add(this.MassLabel);
            this.Controls.Add(this.InitialVelocity);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Angle_);
            this.Controls.Add(this.Mass_);
            this.Controls.Add(this.VelocityTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox VelocityTextBox;
        private System.Windows.Forms.TextBox Mass_;
        private System.Windows.Forms.TextBox Angle_;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Label InitialVelocity;
        private System.Windows.Forms.Label MassLabel;
        private System.Windows.Forms.Label AngleT;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button RefreshButton;
    }
}

