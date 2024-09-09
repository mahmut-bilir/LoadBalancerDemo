using System.Net;
using System.Threading;

public class SimpleBackendServer
{
    private readonly int _port;
    private readonly string _name;

    public SimpleBackendServer(int port, string name)
    {
        _port = port;
        _name = name;
    }

    public void Start()
    {
        HttpListener listener = new HttpListener();
        listener.Prefixes.Add($"http://localhost:{_port}/");
        listener.Start();
        Console.WriteLine($"{_name} started on port {_port}");

        while (true)
        {
            var context = listener.GetContext();
            var response = context.Response;
            string responseString = $"{_name} - Handling request";
            var buffer = System.Text.Encoding.UTF8.GetBytes(responseString);
            response.ContentLength64 = buffer.Length;
            var output = response.OutputStream;
            output.Write(buffer, 0, buffer.Length);
            output.Close();
        }
    }
}
