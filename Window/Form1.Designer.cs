namespace Window
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
            this.Container = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.numDensity = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numResolution = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Window = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Container)).BeginInit();
            this.Container.Panel1.SuspendLayout();
            this.Container.Panel2.SuspendLayout();
            this.Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numResolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Window)).BeginInit();
            this.SuspendLayout();
            // 
            // Container
            // 
            this.Container.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Container.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.Container.Location = new System.Drawing.Point(0, 0);
            this.Container.Name = "Container";
            // 
            // Container.Panel1
            // 
            this.Container.Panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.Container.Panel1.Controls.Add(this.label3);
            this.Container.Panel1.Controls.Add(this.button3);
            this.Container.Panel1.Controls.Add(this.button2);
            this.Container.Panel1.Controls.Add(this.button1);
            this.Container.Panel1.Controls.Add(this.numDensity);
            this.Container.Panel1.Controls.Add(this.label2);
            this.Container.Panel1.Controls.Add(this.numResolution);
            this.Container.Panel1.Controls.Add(this.label1);
            this.Container.Panel1MinSize = 30;
            // 
            // Container.Panel2
            // 
            this.Container.Panel2.BackColor = System.Drawing.Color.Gray;
            this.Container.Panel2.Controls.Add(this.Window);
            this.Container.Size = new System.Drawing.Size(912, 500);
            this.Container.SplitterDistance = 117;
            this.Container.SplitterWidth = 6;
            this.Container.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 477);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Generation: 0";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 192);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 32);
            this.button3.TabIndex = 6;
            this.button3.Text = "Пауза";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 32);
            this.button2.TabIndex = 5;
            this.button2.Text = "Стоп";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.button1.Location = new System.Drawing.Point(6, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Старт";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numDensity
            // 
            this.numDensity.Location = new System.Drawing.Point(6, 81);
            this.numDensity.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numDensity.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numDensity.Name = "numDensity";
            this.numDensity.Size = new System.Drawing.Size(98, 20);
            this.numDensity.TabIndex = 3;
            this.numDensity.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Кучность\r\n";
            // 
            // numResolution
            // 
            this.numResolution.Location = new System.Drawing.Point(6, 28);
            this.numResolution.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numResolution.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numResolution.Name = "numResolution";
            this.numResolution.Size = new System.Drawing.Size(98, 20);
            this.numResolution.TabIndex = 1;
            this.numResolution.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Разрешение\r\n";
            // 
            // Window
            // 
            this.Window.BackColor = System.Drawing.Color.Black;
            this.Window.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Window.Location = new System.Drawing.Point(0, 0);
            this.Window.Name = "Window";
            this.Window.Size = new System.Drawing.Size(787, 498);
            this.Window.TabIndex = 0;
            this.Window.TabStop = false;
            this.Window.Click += new System.EventHandler(this.Window_Click);
            this.Window.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Window_MouseMove);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 500);
            this.Controls.Add(this.Container);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Life";
            this.TransparencyKey = System.Drawing.Color.DarkSlateGray;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Container.Panel1.ResumeLayout(false);
            this.Container.Panel1.PerformLayout();
            this.Container.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Container)).EndInit();
            this.Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numDensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numResolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Window)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private new System.Windows.Forms.SplitContainer Container;
        private System.Windows.Forms.NumericUpDown numResolution;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numDensity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox Window;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
    }
}

