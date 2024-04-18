using EEGApplication.enums;
using System;
using System.Runtime.InteropServices;

namespace EEGApplication
{
    internal class Program
    {
        [DllImport("AlgoSdkDll.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        static extern eNSK_ALGO_RET NSK_ALGO_Init(eNSK_ALGO_TYPE algo, string datapath);

        [DllImport("AlgoSdkDll.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        static extern eNSK_ALGO_RET NSK_ALGO_Start(byte bBaseLine);

        [DllImport("AlgoSdkDll.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        static extern eNSK_ALGO_RET NSK_ALGO_RegisterCallback(NskAlgo_Callback callback, IntPtr userData);

        [DllImport("AlgoSdkDll.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        static extern string NSK_ALGO_SdkVersion();

        // Callbacks
        private delegate void NskAlgo_Callback();

        static void Main(string[] args)
        {
            Console.WriteLine(NSK_ALGO_Init(eNSK_ALGO_TYPE.NSK_ALGO_TYPE_ATT, "D:\\Projects\\NET\\EEGApplication\\EEGApplication\\bin\\Debug\\"));
            Console.WriteLine(NSK_ALGO_RegisterCallback(new NskAlgo_Callback(() => { }), IntPtr.Zero));
            Console.WriteLine(NSK_ALGO_Start(0));
            //Console.WriteLine(NSK_ALGO_SdkVersion());

            Console.ReadKey();
        }
    }
}
