using EEGApplication.enums;
using EEGApplication.structs;
using System;
using System.Runtime.InteropServices;

namespace EEGApplication
{
    internal class Program
    {
        [DllImport("AlgoSdkDll.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        static extern eNSK_ALGO_RET NSK_ALGO_RegisterCallback(NskAlgo_Callback callback, IntPtr userData);

        [DllImport("AlgoSdkDll.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        static extern eNSK_ALGO_RET NSK_ALGO_Init(eNSK_ALGO_TYPE algo, string datapath);

        [DllImport("AlgoSdkDll.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        static extern eNSK_ALGO_RET NSK_ALGO_Start(byte bBaseLine);


        [DllImport("AlgoSdkDll.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        static extern eNSK_ALGO_RET NSK_ALGO_Pause();


        [DllImport("AlgoSdkDll.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        static extern eNSK_ALGO_RET NSK_ALGO_Stop();

        [DllImport("AlgoSdkDll.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        static extern string NSK_ALGO_SdkVersion();

        [DllImport("AlgoSdkDll.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        static extern string NSK_ALGO_AlgoVersion(eNSK_ALGO_TYPE algo);

        [DllImport("AlgoSdkDll.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        static extern eNSK_ALGO_RET NSK_ALGO_DataStream(eNSK_ALGO_DATA_TYPE type, ref short data, int dataLenglth);

        // Callbacks
        private delegate void NskAlgo_Callback(sNSK_ALGO_CB_PARAM param);

        static void Main(string[] args)
        {
            // Register callback function
            Console.WriteLine(NSK_ALGO_RegisterCallback(new NskAlgo_Callback((param) => {
                if (param.cbType == eNSK_ALGO_CB_TYPE.NSK_ALGO_CB_TYPE_STATE)
                {
                    // Update the GUI components and application state accordingly
                    Console.WriteLine("Update the GUI components and application state accordingly");
                }
                else if (param.cbType == eNSK_ALGO_CB_TYPE.NSK_ALGO_CB_TYPE_SIGNAL_LEVEL)
                {
                    switch (param.param.sq)
                    {
                        case eNSK_ALGO_SIGNAL_QUALITY.NSK_ALGO_SQ_GOOD:
                            Console.WriteLine("QUALITY IS GOOD");
                        break;

                        case eNSK_ALGO_SIGNAL_QUALITY.NSK_ALGO_SQ_MEDIUM:
                            Console.WriteLine("QUALITY IS MEDIUM");
                        break;

                        case eNSK_ALGO_SIGNAL_QUALITY.NSK_ALGO_SQ_POOR:
                            Console.WriteLine("QUALITY IS POOR");
                        break;

                        case eNSK_ALGO_SIGNAL_QUALITY.NSK_ALGO_SQ_NOT_DETECTED:
                            Console.WriteLine("Device is not detected!");
                        break;
                    }
                }

            }), IntPtr.Zero));

            // Initialize EEG Algo SDK
            Console.WriteLine(NSK_ALGO_Init(eNSK_ALGO_TYPE.NSK_ALGO_TYPE_ATT, "D:\\Projects\\NET\\EEGApplication\\EEGApplication\\bin\\Debug\\"));
            Console.WriteLine(NSK_ALGO_AlgoVersion(eNSK_ALGO_TYPE.NSK_ALGO_TYPE_ATT));

            //Console.WriteLine(NSK_ALGO_Start(0));
            //Console.WriteLine(NSK_ALGO_SdkVersion());

            Console.ReadKey();
        }
    }
}
