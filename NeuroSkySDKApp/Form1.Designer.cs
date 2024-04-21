namespace NeuroSkySDKApp
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
            input_comPort = new TextBox();
            btn_connectComPort = new Button();
            statusStrip1 = new StatusStrip();
            sts_lbl_version = new ToolStripStatusLabel();
            btn_start = new Button();
            txt_log = new TextBox();
            btn_pause = new Button();
            btn_stop = new Button();
            btn_algo_init = new Button();
            tbar_att_level = new TrackBar();
            tb_med_level = new TrackBar();
            lbl_att_lebel = new Label();
            lbl_med_lebel = new Label();
            lbl_utl_server = new Label();
            txt_server_url = new TextBox();
            btn_car_up = new Button();
            btn_car_down = new Button();
            btn_car_right = new Button();
            btn_car_left = new Button();
            lbl_att_level_per = new Label();
            lbl_med_level_per = new Label();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbar_att_level).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tb_med_level).BeginInit();
            SuspendLayout();
            // 
            // input_comPort
            // 
            input_comPort.Location = new Point(12, 12);
            input_comPort.Name = "input_comPort";
            input_comPort.Size = new Size(221, 31);
            input_comPort.TabIndex = 0;
            input_comPort.Text = "COM6";
            // 
            // btn_connectComPort
            // 
            btn_connectComPort.Location = new Point(239, 10);
            btn_connectComPort.Name = "btn_connectComPort";
            btn_connectComPort.Size = new Size(192, 34);
            btn_connectComPort.TabIndex = 1;
            btn_connectComPort.Text = "Подключиться";
            btn_connectComPort.UseVisualStyleBackColor = true;
            btn_connectComPort.Click += btn_connectComPort_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { sts_lbl_version });
            statusStrip1.Location = new Point(0, 989);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1517, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // sts_lbl_version
            // 
            sts_lbl_version.Name = "sts_lbl_version";
            sts_lbl_version.Size = new Size(0, 15);
            // 
            // btn_start
            // 
            btn_start.Location = new Point(12, 59);
            btn_start.Name = "btn_start";
            btn_start.Size = new Size(112, 34);
            btn_start.TabIndex = 3;
            btn_start.Text = "Start";
            btn_start.UseVisualStyleBackColor = true;
            btn_start.Click += btn_start_Click;
            // 
            // txt_log
            // 
            txt_log.Location = new Point(12, 520);
            txt_log.Multiline = true;
            txt_log.Name = "txt_log";
            txt_log.Size = new Size(1493, 455);
            txt_log.TabIndex = 4;
            // 
            // btn_pause
            // 
            btn_pause.Location = new Point(130, 59);
            btn_pause.Name = "btn_pause";
            btn_pause.Size = new Size(112, 34);
            btn_pause.TabIndex = 5;
            btn_pause.Text = "Pause";
            btn_pause.UseVisualStyleBackColor = true;
            btn_pause.Click += btn_pause_Click;
            // 
            // btn_stop
            // 
            btn_stop.Location = new Point(248, 59);
            btn_stop.Name = "btn_stop";
            btn_stop.Size = new Size(112, 34);
            btn_stop.TabIndex = 6;
            btn_stop.Text = "Stop";
            btn_stop.UseVisualStyleBackColor = true;
            btn_stop.Click += btn_stop_Click;
            // 
            // btn_algo_init
            // 
            btn_algo_init.Location = new Point(12, 129);
            btn_algo_init.Name = "btn_algo_init";
            btn_algo_init.Size = new Size(112, 34);
            btn_algo_init.TabIndex = 7;
            btn_algo_init.Text = "Init";
            btn_algo_init.UseVisualStyleBackColor = true;
            btn_algo_init.Click += btn_algo_init_Click;
            // 
            // tbar_att_level
            // 
            tbar_att_level.Location = new Point(644, 43);
            tbar_att_level.Maximum = 100;
            tbar_att_level.Name = "tbar_att_level";
            tbar_att_level.Size = new Size(861, 69);
            tbar_att_level.TabIndex = 8;
            tbar_att_level.ValueChanged += tbar_att_level_ValueChanged;
            // 
            // tb_med_level
            // 
            tb_med_level.Location = new Point(644, 130);
            tb_med_level.Maximum = 100;
            tb_med_level.Name = "tb_med_level";
            tb_med_level.Size = new Size(861, 69);
            tb_med_level.TabIndex = 9;
            tb_med_level.ValueChanged += tb_med_level_ValueChanged;
            // 
            // lbl_att_lebel
            // 
            lbl_att_lebel.AutoSize = true;
            lbl_att_lebel.Location = new Point(526, 43);
            lbl_att_lebel.Name = "lbl_att_lebel";
            lbl_att_lebel.Size = new Size(97, 25);
            lbl_att_lebel.TabIndex = 10;
            lbl_att_lebel.Text = "Внимание:";
            // 
            // lbl_med_lebel
            // 
            lbl_med_lebel.AutoSize = true;
            lbl_med_lebel.Location = new Point(526, 130);
            lbl_med_lebel.Name = "lbl_med_lebel";
            lbl_med_lebel.Size = new Size(107, 25);
            lbl_med_lebel.TabIndex = 11;
            lbl_med_lebel.Text = "Медитация:";
            // 
            // lbl_utl_server
            // 
            lbl_utl_server.AutoSize = true;
            lbl_utl_server.Location = new Point(12, 216);
            lbl_utl_server.Name = "lbl_utl_server";
            lbl_utl_server.Size = new Size(246, 25);
            lbl_utl_server.TabIndex = 12;
            lbl_utl_server.Text = "URL до сервера управления:";
            // 
            // txt_server_url
            // 
            txt_server_url.Location = new Point(12, 244);
            txt_server_url.Name = "txt_server_url";
            txt_server_url.Size = new Size(419, 31);
            txt_server_url.TabIndex = 13;
            txt_server_url.Text = "http://192.168.1.222";
            // 
            // btn_car_up
            // 
            btn_car_up.Location = new Point(130, 281);
            btn_car_up.Name = "btn_car_up";
            btn_car_up.Size = new Size(112, 34);
            btn_car_up.TabIndex = 14;
            btn_car_up.Text = "Up";
            btn_car_up.UseVisualStyleBackColor = true;
            btn_car_up.Click += btn_car_up_Click;
            // 
            // btn_car_down
            // 
            btn_car_down.Location = new Point(130, 321);
            btn_car_down.Name = "btn_car_down";
            btn_car_down.Size = new Size(112, 34);
            btn_car_down.TabIndex = 15;
            btn_car_down.Text = "Down";
            btn_car_down.UseVisualStyleBackColor = true;
            btn_car_down.Click += btn_car_down_Click;
            // 
            // btn_car_right
            // 
            btn_car_right.Location = new Point(248, 300);
            btn_car_right.Name = "btn_car_right";
            btn_car_right.Size = new Size(112, 34);
            btn_car_right.TabIndex = 16;
            btn_car_right.Text = "Right";
            btn_car_right.UseVisualStyleBackColor = true;
            btn_car_right.Click += btn_car_right_Click;
            // 
            // btn_car_left
            // 
            btn_car_left.Location = new Point(12, 300);
            btn_car_left.Name = "btn_car_left";
            btn_car_left.Size = new Size(112, 34);
            btn_car_left.TabIndex = 17;
            btn_car_left.Text = "Left";
            btn_car_left.UseVisualStyleBackColor = true;
            btn_car_left.Click += btn_car_left_Click;
            // 
            // lbl_att_level_per
            // 
            lbl_att_level_per.AutoSize = true;
            lbl_att_level_per.Location = new Point(1446, 19);
            lbl_att_level_per.Name = "lbl_att_level_per";
            lbl_att_level_per.Size = new Size(37, 25);
            lbl_att_level_per.TabIndex = 18;
            lbl_att_level_per.Text = "0%";
            // 
            // lbl_med_level_per
            // 
            lbl_med_level_per.AutoSize = true;
            lbl_med_level_per.Location = new Point(1446, 102);
            lbl_med_level_per.Name = "lbl_med_level_per";
            lbl_med_level_per.Size = new Size(37, 25);
            lbl_med_level_per.TabIndex = 19;
            lbl_med_level_per.Text = "0%";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1517, 1011);
            Controls.Add(lbl_med_level_per);
            Controls.Add(lbl_att_level_per);
            Controls.Add(btn_car_left);
            Controls.Add(btn_car_right);
            Controls.Add(btn_car_down);
            Controls.Add(btn_car_up);
            Controls.Add(txt_server_url);
            Controls.Add(lbl_utl_server);
            Controls.Add(lbl_med_lebel);
            Controls.Add(lbl_att_lebel);
            Controls.Add(tb_med_level);
            Controls.Add(tbar_att_level);
            Controls.Add(btn_algo_init);
            Controls.Add(btn_stop);
            Controls.Add(btn_pause);
            Controls.Add(txt_log);
            Controls.Add(btn_start);
            Controls.Add(statusStrip1);
            Controls.Add(btn_connectComPort);
            Controls.Add(input_comPort);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbar_att_level).EndInit();
            ((System.ComponentModel.ISupportInitialize)tb_med_level).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox input_comPort;
        private Button btn_connectComPort;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel sts_lbl_version;
        private Button btn_start;
        private TextBox txt_log;
        private Button btn_pause;
        private Button btn_stop;
        private Button btn_algo_init;
        private TrackBar tbar_att_level;
        private TrackBar tb_med_level;
        private Label lbl_att_lebel;
        private Label lbl_med_lebel;
        private Label lbl_utl_server;
        private TextBox txt_server_url;
        private Button btn_car_up;
        private Button btn_car_down;
        private Button btn_car_right;
        private Button btn_car_left;
        private Label lbl_att_level_per;
        private Label lbl_med_level_per;
    }
}
