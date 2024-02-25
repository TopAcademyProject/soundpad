namespace SoundPad_Project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Sound_List = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Test_Sound = new AxWMPLib.AxWindowsMediaPlayer();
            this.Select_video = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Test_Sound)).BeginInit();
            this.SuspendLayout();
            // 
            // Sound_List
            // 
            this.Sound_List.Location = new System.Drawing.Point(728, 12);
            this.Sound_List.Name = "Sound_List";
            this.Sound_List.Size = new System.Drawing.Size(60, 60);
            this.Sound_List.TabIndex = 0;
            this.Sound_List.Text = "Sounds";
            this.Sound_List.UseVisualStyleBackColor = true;
            this.Sound_List.Click += new System.EventHandler(this.Sound_List_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 60);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Test_Sound
            // 
            this.Test_Sound.Enabled = true;
            this.Test_Sound.Location = new System.Drawing.Point(110, 12);
            this.Test_Sound.Name = "Test_Sound";
            this.Test_Sound.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Test_Sound.OcxState")));
            this.Test_Sound.Size = new System.Drawing.Size(506, 344);
            this.Test_Sound.TabIndex = 2;
            this.Test_Sound.Visible = false;
            // 
            // Select_video
            // 
            this.Select_video.Location = new System.Drawing.Point(330, 365);
            this.Select_video.Name = "Select_video";
            this.Select_video.Size = new System.Drawing.Size(77, 73);
            this.Select_video.TabIndex = 3;
            this.Select_video.Text = "select_video";
            this.Select_video.UseVisualStyleBackColor = true;
            this.Select_video.Visible = false;
            this.Select_video.Click += new System.EventHandler(this.Select_video_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Select_video);
            this.Controls.Add(this.Test_Sound);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Sound_List);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Test_Sound)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Sound_List;
        private System.Windows.Forms.Button button2;
        private AxWMPLib.AxWindowsMediaPlayer Test_Sound;
        private System.Windows.Forms.Button Select_video;
    }
}

