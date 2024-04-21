using libStreamSDK;
using Microsoft.VisualBasic.Logging;

namespace NeuroSkySDKApp
{
    public partial class Form1 : Form
    {
        private static Form1 window;

        private static CarRemoteController remoteController = new CarRemoteController();
        private NativeThinkgear nativeThinkgear = new NativeThinkgear();
        private NativeAlgoSdk64 nativeAlgoSdk64 = new NativeAlgoSdk64();


        private int connectionId = -1;
        private bool isConnectedHeadset = false;

        public Form1()
        {
            InitializeComponent();

            connectionId = NativeThinkgear.TG_GetNewConnectionId();
            if (connectionId < 0)
            {
                MessageBox.Show("Не могу создать новое соединение. ConnectionId = " + connectionId);
            }

            window = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string tgVersion = NativeThinkgear.TG_GetVersion().ToString();
            string nsSdkVersion = NativeAlgoSdk64.NSK_ALGO_SdkVersion();
            sts_lbl_version.Text = "NativeThinkgear Version: " + tgVersion + " | NeuroSkySdkVersion:" + nsSdkVersion;
        }

        private void btn_connectComPort_Click(object sender, EventArgs e)
        {
            string comPort = input_comPort.Text;
            int errCode = NativeThinkgear.TG_Connect(connectionId, comPort, NativeThinkgear.Baudrate.TG_BAUD_57600, NativeThinkgear.SerialDataFormat.TG_STREAM_PACKETS);
            if (errCode < 0)
            {
                MessageBox.Show("Не могу подключиться к brainlink. Код = " + errCode);
            }
            else
            {
                isConnectedHeadset = true;
                Thread packetReadingThread = new Thread(packetReading);
                packetReadingThread.Start();
            }
        }

        private void packetReading(object o)
        {
            int rawCount = 0;
            char[] buffer = new char[100];
            short[] rawData = new short[512];
            int lastRawCount = 0;

            while (true)
            {
                int packageRead = NativeThinkgear.TG_ReadPackets(connectionId, 1);
                if (packageRead != 1) continue;

                if (NativeThinkgear.TG_GetValueStatus(connectionId, NativeThinkgear.DataType.TG_DATA_RAW) != 0)
                {
                    rawData[rawCount++] = (short)NativeThinkgear.TG_GetValue(connectionId, NativeThinkgear.DataType.TG_DATA_RAW);
                    lastRawCount = rawCount;
                    if (rawCount == 512)
                    {
                        //EEGApplication.enums.eNSK_ALGO_RET eNSK_ALGO_RET = NativeAlgoSdk64.NSK_ALGO_DataStream(EEGApplication.enums.eNSK_ALGO_DATA_TYPE.NSK_ALGO_DATA_TYPE_EEG, ref data, rawCount);
                        //log("Analyze package returned: " + eNSK_ALGO_RET.ToString());
                        rawCount = 0;
                    }
                }

                if (NativeThinkgear.TG_GetValueStatus(connectionId, NativeThinkgear.DataType.TG_DATA_POOR_SIGNAL) != 0)
                {
                    short pq = (short)NativeThinkgear.TG_GetValue(connectionId, NativeThinkgear.DataType.TG_DATA_POOR_SIGNAL);
                    //log("Got: NativeThinkgear.DataType.TG_DATA_POOR_SIGNAL. VAL = " + pq);
                    rawCount = 0;
                }

                if (NativeThinkgear.TG_GetValueStatus(connectionId, NativeThinkgear.DataType.TG_DATA_ATTENTION) != 0)
                {

                    short att = (short)NativeThinkgear.TG_GetValue(connectionId, NativeThinkgear.DataType.TG_DATA_ATTENTION);
                    //log("Got: NativeThinkgear.DataType.TG_DATA_ATTENTION. VAL: " + att);
                    NativeAlgoSdk64.NSK_ALGO_DataStream(EEGApplication.enums.eNSK_ALGO_DATA_TYPE.NSK_ALGO_DATA_TYPE_ATT, ref att, 1);
                }

                if (NativeThinkgear.TG_GetValueStatus(connectionId, NativeThinkgear.DataType.TG_DATA_MEDITATION) != 0)
                {
                    short med = (short)NativeThinkgear.TG_GetValue(connectionId, NativeThinkgear.DataType.TG_DATA_MEDITATION);
                    //log("Got: NativeThinkgear.DataType.TG_DATA_MEDITATION. VAL: " + med);
                    NativeAlgoSdk64.NSK_ALGO_DataStream(EEGApplication.enums.eNSK_ALGO_DATA_TYPE.NSK_ALGO_DATA_TYPE_MED, ref med, 1);
                }
            }
        }

        private NativeAlgoSdk64.NskAlgo_Callback callback = new NativeAlgoSdk64.NskAlgo_Callback((param) =>
        {
            if (param.cbType == EEGApplication.enums.eNSK_ALGO_CB_TYPE.NSK_ALGO_CB_TYPE_STATE)
            {
                // Update the GUI components and application state accordingly
            }
            else if (param.cbType == EEGApplication.enums.eNSK_ALGO_CB_TYPE.NSK_ALGO_CB_TYPE_SIGNAL_LEVEL)
            {
                switch (param.param.sq)
                {
                    case EEGApplication.enums.eNSK_ALGO_SIGNAL_QUALITY.NSK_ALGO_SQ_GOOD:
                        // Good signal quality
                        if (1 == 1) { }
                        break;
                    case EEGApplication.enums.eNSK_ALGO_SIGNAL_QUALITY.NSK_ALGO_SQ_MEDIUM:
                        // Medium signal quality
                        if (1 == 1) { }
                        break;
                    case EEGApplication.enums.eNSK_ALGO_SIGNAL_QUALITY.NSK_ALGO_SQ_POOR:
                        // Poor signal quality
                        if (1 == 1) { }
                        break;
                    case EEGApplication.enums.eNSK_ALGO_SIGNAL_QUALITY.NSK_ALGO_SQ_NOT_DETECTED:
                        // Sensor 
                        if (1 == 1) { }
                        break;
                }
            }
            else if (param.cbType == EEGApplication.enums.eNSK_ALGO_CB_TYPE.NSK_ALGO_CB_TYPE_ALGO)
            {
                if (param.param.index.type == EEGApplication.enums.eNSK_ALGO_TYPE.NSK_ALGO_TYPE_ATT)
                {
                    float att = param.param.index.value.att_index;
                    //window.log("Attention level is: " + att);
                    window.tbar_att_level.Invoke(() => window.tbar_att_level.Value = (int)att);

                    if (att >= 50)
                    {
                        remoteController.go(window.txt_server_url.Text);
                        Thread.Sleep(200);
                        remoteController.stop(window.txt_server_url.Text);
                    }
                }
                else if (param.param.index.type == EEGApplication.enums.eNSK_ALGO_TYPE.NSK_ALGO_TYPE_MED)
                {
                    float med = param.param.index.value.med_index;
                    //window.log("Meditation level is: " + med);
                    window.tb_med_level.Invoke(() => window.tb_med_level.Value = (int)med);
                }
                else if (param.param.index.type == EEGApplication.enums.eNSK_ALGO_TYPE.NSK_ALGO_TYPE_BLINK)
                {
                    float blinkStretch = param.param.index.value.eye_blink_strength;
                    window.log("Eye blink stretch level is: " + blinkStretch);
                }
            }
        });

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (NativeAlgoSdk64.NSK_ALGO_Start(0) == EEGApplication.enums.eNSK_ALGO_RET.NSK_ALGO_RET_SUCCESS)
            {
                txt_log.Text = txt_log.Text + "\r\n" + "Algo SDK started successfully";
            }
            else
            {
                txt_log.Text = txt_log.Text + "\r\n" + "Algo SDK start failure!";
            }
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            if (NativeAlgoSdk64.NSK_ALGO_Pause() == EEGApplication.enums.eNSK_ALGO_RET.NSK_ALGO_RET_SUCCESS)
            {
                txt_log.Text = txt_log.Text + "\r\n" + "Algo SDK paused successfully";
            }
            else
            {
                txt_log.Text = txt_log.Text + "\r\n" + "Algo SDK pause failure!";
            }
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            if (NativeAlgoSdk64.NSK_ALGO_Stop() == EEGApplication.enums.eNSK_ALGO_RET.NSK_ALGO_RET_SUCCESS)
            {
                txt_log.Text = txt_log.Text + "\r\n" + "Algo SDK stopped successfully";
            }
            else
            {
                txt_log.Text = txt_log.Text + "\r\n" + "Algo SDK stop failure!";
            }
        }

        private void log(string msg)
        {
            txt_log.Text = txt_log.Invoke(() => txt_log.Text = msg + "\r\n" + txt_log.Text);
        }

        private void btn_algo_init_Click(object sender, EventArgs e)
        {
            NativeAlgoSdk64.NSK_ALGO_Init(EEGApplication.enums.eNSK_ALGO_TYPE.NSK_ALGO_TYPE_ATT | EEGApplication.enums.eNSK_ALGO_TYPE.NSK_ALGO_TYPE_MED | EEGApplication.enums.eNSK_ALGO_TYPE.NSK_ALGO_TYPE_BLINK, "D:\\Projects\\NET\\NeuroSkySDKApp\\NeuroSkySDKApp\\bin\\Debug\\net8.0-windows\\");
            NativeAlgoSdk64.NSK_ALGO_RegisterCallback(callback, IntPtr.Zero);
        }

        private void btn_car_up_Click(object sender, EventArgs e)
        {
            remoteController.go(window.txt_server_url.Text);
        }

        private void btn_car_down_Click(object sender, EventArgs e)
        {
            remoteController.stop(window.txt_server_url.Text);
        }

        private void btn_car_right_Click(object sender, EventArgs e)
        {
            remoteController.right(window.txt_server_url.Text);
        }

        private void btn_car_left_Click(object sender, EventArgs e)
        {
            remoteController.left(window.txt_server_url.Text);
        }

        private void tbar_att_level_ValueChanged(object sender, EventArgs e)
        {
            lbl_att_level_per.Text = tbar_att_level.Value + "%";
        }

        private void tb_med_level_ValueChanged(object sender, EventArgs e)
        {
            lbl_med_level_per.Text = tb_med_level.Value + "%";
        }
    }
}