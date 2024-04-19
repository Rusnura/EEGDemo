using System.Runtime.InteropServices;
using NS_ALGO_INDEX = System.Single;

namespace EEGApplication.structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct NS_ALGO_F_INDEX
    {
        public NS_ALGO_INDEX abs_f;
        public NS_ALGO_INDEX diff_f;
        public NS_ALGO_INDEX max_f;
        public NS_ALGO_INDEX min_f;
    }
}
