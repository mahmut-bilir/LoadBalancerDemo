 // Backend sunucularını başlat
        var server1 = new SimpleBackendServer(5001, "Server 1");
        var server2 = new SimpleBackendServer(5002, "Server 2");
        var server3 = new SimpleBackendServer(5003, "Server 3");

        // Load Balancer oluştur
        var backendServers = new List<string>
        {
            "http://localhost:5001/",
            "http://localhost:5002/",
            "http://localhost:5003/"
        };
        var loadBalancer = new LoadBalancer(backendServers);

        // Backend sunucuları farklı thread'lerde başlat
        new Thread(server1.Start).Start();
        new Thread(server2.Start).Start();
        new Thread(server3.Start).Start();

        // Load balancer'a istek gönder
        for (int i = 0; i < 10; i++)
        {
            string response = loadBalancer.ForwardRequest();
            Console.WriteLine($"Response: {response}");
            Thread.Sleep(1000); // Bekleme süresi
        }