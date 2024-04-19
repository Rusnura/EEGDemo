using EEGApplication.enums;
using System;
using System.Runtime.InteropServices;

namespace EEGApplication.structs
{
    [StructLayout(LayoutKind.Explicit)]
    public struct sNSK_ALGO_CB_PARAM
    {
        [FieldOffset(0)]
        public eNSK_ALGO_CB_TYPE cbType;

        [FieldOffset(4)] // Assuming 32-bit system, adjust accordingly for 64-bit
        public ParamUnion param;

        [FieldOffset(8)] // Assuming 32-bit system, adjust accordingly for 64-bit
        public IntPtr userData; // void pointer marshaled as IntPtr
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ParamUnion
    {
        [FieldOffset(0)]
        public eNSK_ALGO_STATE state;

        [FieldOffset(0)]
        public eNSK_ALGO_SIGNAL_QUALITY sq;

        [FieldOffset(0)]
        public sNSK_ALGO_INDEX index;
    }
}
