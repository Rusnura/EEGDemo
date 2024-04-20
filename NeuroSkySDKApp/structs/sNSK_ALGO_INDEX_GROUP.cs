using System;
using System.Runtime.InteropServices;
using NS_ALGO_INDEX = System.Single;

namespace EEGApplication.structs
{

    [StructLayout(LayoutKind.Explicit)]
    public struct sNSK_ALGO_INDEX_GROUP
    {
        [FieldOffset(0)]
        public NS_ALGO_INDEX ap_index;

        [FieldOffset(0)]
        public NS_ALGO_ME_INDEX me_index;

        [FieldOffset(0)]
        public NS_ALGO_ME2_INDEX me2_index;

        [FieldOffset(0)]
        public NS_ALGO_F_INDEX f_index;

        [FieldOffset(0)]
        public NS_ALGO_F2_INDEX f2_index;

        [FieldOffset(0)]
        public NS_ALGO_INDEX att_index;

        [FieldOffset(0)]
        public NS_ALGO_INDEX med_index;

        [FieldOffset(0)]
        public NS_ALGO_INDEX eye_blink_strength;

        [FieldOffset(0)]
        public NS_ALGO_CR_INDEX cr_index;

        [FieldOffset(0)]
        public NS_ALGO_AL_INDEX al_index;

        [FieldOffset(0)]
        public NS_ALGO_CP_INDEX cp_index;

        [FieldOffset(0)]
        public NS_ALGO_BP_INDEX bp_index;
    }
}
