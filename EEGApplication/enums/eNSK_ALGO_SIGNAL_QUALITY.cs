namespace EEGApplication.enums
{
    public enum eNSK_ALGO_SIGNAL_QUALITY
    {
        NSK_ALGO_SQ_GOOD = 0,       /* Good signal quality */
        NSK_ALGO_SQ_MEDIUM,         /* Medium signal quality */
        NSK_ALGO_SQ_POOR,           /* Poor signal quality */
        NSK_ALGO_SQ_NOT_DETECTED	/* No signal detected. It probably is caused by bad sensor contact */
    }
}
