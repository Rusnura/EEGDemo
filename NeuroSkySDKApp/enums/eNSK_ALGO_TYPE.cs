namespace EEGApplication.enums
{
    public enum eNSK_ALGO_TYPE
    {
        NSK_ALGO_TYPE_ATT = 0x00000100, /* Attention */
        NSK_ALGO_TYPE_MED = 0x00000200, /* Meditation */
        NSK_ALGO_TYPE_BLINK = 0x00000400, /* Eye blink detection */
        NSK_ALGO_TYPE_BP = 0x00004000 /* EEG Bandpower */
    }
}
