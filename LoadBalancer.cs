using System.Net;

public class LoadBalancer
{
    private readonly List<string> _backendServers;
    private int _currentServerIndex = 0;

    public LoadBalancer(List<string> backendServers)
    {
        _backendServers = backendServers;
    }

    public string ForwardRequest()
    {
        var server = _backendServers[_currentServerIndex];
        _currentServerIndex = (_currentServerIndex + 1) % _backendServers.Count;

        Console.WriteLine($"Forwarding request to: {server}");

        return SendRequestToBackend(server);
    }

    private string SendRequestToBackend(string serverUrl)
    {
        using (var client = new WebClient())
        {
            return client.DownloadString(serverUrl);
        }
    }
}
