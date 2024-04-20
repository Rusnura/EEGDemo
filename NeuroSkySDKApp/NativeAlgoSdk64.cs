using EEGApplication.enums;
using EEGApplication.structs;
using System.Runtime.InteropServices;

namespace NeuroSkySDKApp
{
    public class NativeAlgoSdk64
    {
        [DllImport("AlgoSdkDll64.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern eNSK_ALGO_RET NSK_ALGO_RegisterCallback(NskAlgo_Callback callback, IntPtr userData);

        [DllImport("AlgoSdkDll64.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern eNSK_ALGO_RET NSK_ALGO_Init(eNSK_ALGO_TYPE algo, string datapath);

        [DllImport("AlgoSdkDll64.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern eNSK_ALGO_RET NSK_ALGO_Uninit();

        [DllImport("AlgoSdkDll64.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern eNSK_ALGO_RET NSK_ALGO_Start(byte bBaseLine);


        [DllImport("AlgoSdkDll64.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern eNSK_ALGO_RET NSK_ALGO_Pause();


        [DllImport("AlgoSdkDll64.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern eNSK_ALGO_RET NSK_ALGO_Stop();

        [DllImport("AlgoSdkDll64.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern string NSK_ALGO_SdkVersion();

        [DllImport("AlgoSdkDll64.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern string NSK_ALGO_AlgoVersion(eNSK_ALGO_TYPE algo);

        [DllImport("AlgoSdkDll64.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern eNSK_ALGO_RET NSK_ALGO_DataStream(eNSK_ALGO_DATA_TYPE type, ref short data, int dataLenglth);

        // Callbacks
        public delegate void NskAlgo_Callback(sNSK_ALGO_CB_PARAM param);
    }
}
