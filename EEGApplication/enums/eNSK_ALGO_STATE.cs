namespace EEGApplication.enums
{
    public enum eNSK_ALGO_STATE
    {
        /* SDK state */
        NSK_ALGO_STATE_INITED = 0x0100, /* Algo SDK is initialized (Reason code is omitted), host application should never receive this state */
        NSK_ALGO_STATE_RUNNING = 0x0200,    /* Algo SDK is performing analysis.
															 */
        NSK_ALGO_STATE_COLLECTING_BASELINE_DATA = 0x0300,   /* Algo SDK is collecting baseline data (Reason code is omitted).
															 *
															 * When baseline data collection is done, SDK state should change 
															 * to NSK_ALGO_STATE_RUNNING and start data analysis
															 */
        NSK_ALGO_STATE_STOP = 0x0400,   /* Algo SDK stops data analysis/baseline collection.
															 * State will only change to stop if previous state is NSK_ALGO_STATE_RUNNING or
															 * NSK_ALGO_STATE_COLLECTING_BASELINE_DATA
															 */
        NSK_ALGO_STATE_PAUSE = 0x0500,   /* Algo SDK pauses data analysis due to poor signal quality or paused by user.
                                                             * State will only change to pause if previous state is NSK_ALGO_STATE_RUNNING
                                                             */
        NSK_ALGO_STATE_UNINTIED = 0x0600,   /* Algo SDK is uninitialized (Reason code is omitted) */
        NSK_ALGO_STATE_ANALYSING_BULK_DATA = 0x0800,   /* Algo SDK is analysing provided bulk data (i.e. NSK_ALGO_DataStream() is invoked with NSK_ALGO_DATA_TYPE_BULK_EEG.
                                                             * Note: SDK state will change to NSK_ALGO_STATE_STOP after analysing data
                                                             */
        NSK_ALGO_STATE_RUNNING_DEMO = 0x1000,   /* Algo SDK is now in demo mode. (Only occurs in Trial Build)
                                                             * SDK will return non-accurate algorithm index randomly.
                                                             */

        NSK_ALGO_STATE_MASK = 0xFF00,

        /* Reason for state change */
        NSK_ALGO_REASON_CONFIG_CHANGED = 0x0001,    /* RESERVED: SDK configuration changed (i.e. NSK_ALGO_Config() is invoked) */
        NSK_ALGO_REASON_USER_PROFILE_CHANGED = 0x0002,  /* RESERVED: Active user profile has been changed (i.e. NSK_ALGO_Profile() is invoked and active user profile is affected) */
        NSK_ALGO_REASON_CB_CHANGED = 0x0003,    /* RESERVED: Callback registration has been changed (i.e. NSK_ALGO_RegisterCallback() is invoked) */
        NSK_ALGO_REASON_BY_USER = 0x0004,   /* Stopped/Paused by user (i.e. NSK_ALGO_Stop()/NSK_ALGO_Pause() is invoked) */
        NSK_ALGO_REASON_BASELINE_EXPIRED = 0x0005,  /* RESERVED: Active user baseline data expired. */
        NSK_ALGO_REASON_NO_BASELINE = 0x0006,   /* RESERVED: There is no baseline data for current active user. */
        NSK_ALGO_REASON_SIGNAL_QUALITY = 0x0007,    /* SDK state changes due to signal quality changes.
															 *
															 * e.g. NSK_ALGO_STATE_PAUSE + NSK_ALGO_REASON_SIGNAL_QUALITY means SDK pauses data analysis due to poor signal quality
															 * e.g. NSK_ALGO_STATE_RUNNING + NSK_ALGO_REASON_SIGNAL_QUALITY means SDK resumes data analysis due to signal resuming
															 * from poor signal quality
															 */
        NSK_ALGO_REASON_MASK = 0x00FF
    }
}
