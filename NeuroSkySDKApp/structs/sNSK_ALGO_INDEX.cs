using EEGApplication.enums;
using System.Runtime.InteropServices;

namespace EEGApplication.structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct sNSK_ALGO_INDEX
    {
        public eNSK_ALGO_TYPE type;
        public sNSK_ALGO_INDEX_GROUP value;
        public long timeSpent;
    }
}
