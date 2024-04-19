using EEGApplication.enums;
using System.Runtime.InteropServices;
using NS_ALGO_INDEX = System.Single;

namespace EEGApplication.structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct NS_ALGO_F2_INDEX
    {
        public eNSK_ALGO_F2_PROGRESS_LEVEL progress_level;
        public NS_ALGO_INDEX f_degree;
    }
}
