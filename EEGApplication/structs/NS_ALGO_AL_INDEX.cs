using EEGApplication.enums;
using System.Runtime.InteropServices;
using NS_ALGO_INDEX = System.Single;
using NS_INT8 = System.Char;

namespace EEGApplication.structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct NS_ALGO_AL_INDEX
    {
        public NS_ALGO_BCQ_VALID_TYPE al_index_type;
        public NS_ALGO_INDEX al_value;
        public NS_INT8 BCQ_valid;
    }
}
