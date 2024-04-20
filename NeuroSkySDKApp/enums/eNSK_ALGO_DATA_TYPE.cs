namespace EEGApplication.enums
{
    public enum eNSK_ALGO_DATA_TYPE
    {
        NSK_ALGO_DATA_TYPE_EEG = 0x01,      /* Raw EEG data */
        NSK_ALGO_DATA_TYPE_ATT,                 /* Attention data */
        NSK_ALGO_DATA_TYPE_MED,                 /* Meditation data */
        NSK_ALGO_DATA_TYPE_PQ,                  /* Poor signal quality data */
        NSK_ALGO_DATA_TYPE_BULK_EEG,            /* Bulk of EEG data -- TRIAL */
        NSK_ALGO_DATA_TYPE_MAX
    }
}
