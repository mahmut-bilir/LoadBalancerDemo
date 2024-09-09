# LoadBalancerDemo

**LoadBalancerDemo** is a simple demonstration of a load balancing system implemented in C#. This project showcases how a load balancer can distribute incoming requests to multiple backend servers to balance the load and improve application reliability.

## Features

- **Load Balancer**: Distributes incoming requests to multiple backend servers using a round-robin approach.
- **Backend Servers**: Simple HTTP servers that respond with a message indicating which server handled the request.

## Requirements

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) or later.
- [Visual Studio Code](https://code.visualstudio.com/) or any other C# compatible IDE.

## Installation

1. Clone the repository:

    ```bash
    git clone https://github.com/mahmut-bilir/LoadBalancerDemo.git
    ```

2. Navigate to the project directory:

    ```bash
    cd LoadBalancerDemo
    ```

3. Restore the project dependencies:

    ```bash
    dotnet restore
    ```

## Usage

1. Open the project in your preferred IDE or editor.
2. Build the project:

    ```bash
    dotnet build
    ```

3. Run the project:

    ```bash
    dotnet run
    ```

   This will start the backend servers on ports 5001, 5002, and 5003, and the load balancer. The load balancer will distribute incoming requests to these backend servers and print the responses to the console.

4. To test the load balancer, observe the console output for responses from the backend servers. The load balancer will rotate through the servers in a round-robin manner.

## Contributing

Contributions are welcome! To contribute to this project:

1. Fork the repository.
2. Create a new branch for your feature or bug fix:

    ```bash
    git checkout -b feature/your-feature
    ```

3. Make your changes and commit them:

    ```bash
    git add .
    git commit -m "Describe your changes"
    ```

4. Push to your branch:

    ```bash
    git push origin feature/your-feature
    ```

5. Create a pull request to merge your changes into the main repository.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.
