using System.Runtime.InteropServices;
using NS_ALGO_INDEX = System.Single;

namespace EEGApplication.structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct NS_ALGO_ME2_INDEX
    {
        public NS_ALGO_INDEX total_me;
        public NS_ALGO_INDEX me_rate;
        public NS_ALGO_INDEX changing_rate;
    }
}
