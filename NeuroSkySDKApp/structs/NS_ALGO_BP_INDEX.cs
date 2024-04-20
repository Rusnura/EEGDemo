using System.Runtime.InteropServices;

using NS_ALGO_INDEX = System.Single;

namespace EEGApplication.structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct NS_ALGO_BP_INDEX
    {
        public NS_ALGO_INDEX delta_power;
        public NS_ALGO_INDEX theta_power;
        public NS_ALGO_INDEX alpha_power;
        public NS_ALGO_INDEX beta_power;
        public NS_ALGO_INDEX gamma_power;
    }
}
