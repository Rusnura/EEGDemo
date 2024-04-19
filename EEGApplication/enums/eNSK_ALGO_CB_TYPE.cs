namespace EEGApplication.enums
{
    public enum eNSK_ALGO_CB_TYPE
    {
        NSK_ALGO_CB_TYPE_STATE = 0x01000000,    /* Register callback for Algo SDK state change */
        NSK_ALGO_CB_TYPE_SIGNAL_LEVEL = 0x02000000, /* Register callback for Algo signal quality level */
        NSK_ALGO_CB_TYPE_ALGO = 0x04000000	/* Register callback for Algo analysis result. This flag must be bit-wise OR with eNSK_ALGO_TYPE */
    }
}
