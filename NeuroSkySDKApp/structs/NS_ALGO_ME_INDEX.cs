using System.Runtime.InteropServices;

using NS_ALGO_INDEX = System.Single;

namespace EEGApplication.structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct NS_ALGO_ME_INDEX
    {
        public NS_ALGO_INDEX abs_me;
        public NS_ALGO_INDEX diff_me;
        public NS_ALGO_INDEX max_me;
        public NS_ALGO_INDEX min_me;
    }
}
