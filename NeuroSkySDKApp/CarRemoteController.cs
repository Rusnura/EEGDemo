using System.Net;

#pragma warning disable SYSLIB0014
namespace NeuroSkySDKApp
{
    public class CarRemoteController
    {
        private WebClient client = new();
        private bool isBusy = false;

        public CarRemoteController()
        {
            client.DownloadStringCompleted += Client_DownloadStringCompleted;
        }

        private void Client_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            isBusy = false;
        }

        public void go(string baseUrl)
        {
            doSendRequest(baseUrl, "/go");
        }

        public void stop(string baseUrl)
        {
            doSendRequest(baseUrl, "/stop");
        }

        public void right(string baseUrl)
        {
            doSendRequest(baseUrl, "/right");
        }

        public void left(string baseUrl)
        {
            doSendRequest(baseUrl, "/left");
        }

        private void doSendRequest(string baseUrl, string additionalUrl)
        {
            if (string.IsNullOrWhiteSpace(baseUrl) || isBusy)
                return;

            isBusy = true;
            client.DownloadStringAsync(new Uri(baseUrl + additionalUrl));
        }
    }
}
#pragma warning restore SYSLIB0014