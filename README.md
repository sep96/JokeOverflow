# 🃏 Joke Overflow: The Ultimate Dad Joke Experience

Welcome to Joke Overflow, where software development meets dad humor! This project is a Stack Overflow parody focused entirely on serving, sharing, and celebrating the corniest jokes in the universe.

## 🚀 Features

- 👤 User profiles for aspiring comedians
- 📝 Post setups and punchlines
- 👍👎 Vote on jokes (or groan at them)
- 🏅 Earn badges for your "achievements"
- 🔍 Search for jokes by category or keyword
- 🎲 Random Joke Generator for instant laughs

## 🛠️ Tech Stack

- **.NET Core 8**: Because our jokes are cutting-edge
- **C# 12**: For coding puns with style
- **PostgreSQL**: Storing jokes for posterity
- **Yarn**: Weaving our frontend together
- **API Gateway**: The bouncer for our comedy club
- **RabbitMQ**: Hop to it with our message queue
- **CQRS**: Separating the setups from the punchlines
- **Clean Architecture**: Keeping our code as clean as our humor
- **Microservices**: Small services for big laughs
- **MassTransit**: Transporting jokes at the speed of dad
- **Docker**: Containerizing our comedy for easy deployment

## 🏗️ Architecture

Our microservices are like a well-orchestrated comedy routine:

1. 🙋 User Service
2. 😂 Joke Service
3. 💬 Comment Service
4. 👍 Voting Service
5. 🌟 Reputation Service
6. 🏅 Badge Service
7. 🔍 Search Service
8. 🎲 Random Joke Service
9. 🚪 API Gateway
10. 🖥️ Frontend Service

Each service is containerized with Docker for easy deployment and scaling.

## 🚀 Getting Started

1. Clone this repository
2. Ensure Docker is installed on your machine
3. Run `docker-compose up` to build and start all services
4. Navigate to `http://localhost:5000` to start groaning

## 🐳 Docker

We use Docker to containerize our services, ensuring consistent environments across development and production. Each microservice has its own Dockerfile, and we use docker-compose for orchestration.

To build and run all services:

```bash
docker-compose up --build

## 🤝 Contributing

Got a good (bad) joke? Know how to make our code funnier? Contributions are welcome! Please see our [CONTRIBUTING.md](CONTRIBUTING.md) for details.

## 🙏 Acknowledgments

- Stack Overflow, for inspiring us to overflow with jokes instead
- All the dads out there, keeping the art of the groan-worthy joke alive

Remember, in the world of Joke Overflow, the real bug is a joke that doesn't make you laugh!
