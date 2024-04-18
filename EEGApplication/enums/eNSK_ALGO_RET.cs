namespace EEGApplication.enums
{
    public enum eNSK_ALGO_RET
    {
        NSK_ALGO_RET_SUCCESS, /* Operation performed successfully */
        NSK_ALGO_RET_FAIL, /* Operation performed with error */
        NSK_ALGO_RET_ALREADY_INITED, /* Already inited */
        NSK_ALGO_RET_ALREADY_STARTED, /* SDK has already started */
        NSK_ALGO_RET_ALREADY_STOPPED, /* SDK has already been stopped */
        NSK_ALGO_RET_NOT_INITED, /* SDK hasn't been inited */
        NSK_ALGO_RET_NO_MEM, /* Not enough of memory */
        NSK_ALGO_RET_INVALID_PARAM, /* Invalid input parameter */
        NSK_ALGO_RET_NOT_STARTED, /* SDK hasn't been started yet */
        NSK_ALGO_RET_NOT_SUPPORTED, /* Unsupported algorithm */
        NSK_ALGO_RET_NOT_SELECTED, /* Unselected algorithm */
        NSK_ALGO_RET_NO_CALLBACK, /* No callback registered */
    }
}
