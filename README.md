# Team Task Tracker (or activities Tracker)
The Team Task Tracker allows multiple users to get access to a list of activity that needs to be completed. Member can assign task by simply typing their name (or coworker) and add the task to the task-list (SQL Server Implementation). This is implemented as a client-server architecture. The sever-backend is written in C#. Implement the .NET framework so that the architecture can handle multiple users without false, and save a lot of time of writing code. The architecture is fairly simple. Users get access to web clients through any web-browser(with the correct address). Users then can send REQUEST to the backend, or simply view what is in the task list. After the backend-sever receive HTTP request(insert, update, delete, view) from the clients, it processes the request and communicates with the Data Access Layer(SQL Server). SQL Server decides what to do with the request (read, write, search, view), complete and report to backend controller. controller confirms the clients' request is completed(satisfy) and sends the HTTP response back. Please refer to the UML Diagram for more details.

Note about client-server architecture: 7 years ago, I implement Servlet Apache and Java SE for an automotive System and wrote much code to implement my sever and Clients. The techniques in that project are way more complicated and the amount of code I wrote is 10 times more than this. I  don't use any framework for that application and simply wrote everything from scratch (I want to see if I can accomplish the same thing differently). You can take a look at my Java-automotiveCustomizationSystem project [here](https://github.com/jackyhuynh/automotiveCustomizationSystem-app). With .NET, Visual Studio, and Microsoft VIdeo Support I completed this project in 2 days, while it took me about 25 days for the other project. I wrote this simply because I want to show how powerful platform support and framework can help developers to code and deploy their application. Please note Java have their framework (EE., Spring), but for education (and try). I did not use any Java Framework to write that Java backend. I don't mean C#(.NET) is better than Java(Spring, SE., EE.). I believed each language has its beauty and strength. 

## Technology
- C ## Programming
- Visual Studio Comunity
- GitHub
- SQL Server
- JavaScript
- CSS
- HTML
- .NET framework
- Object-Oriented Design
- Encapsulation
- Polymorphism
- API
- web API



## Getting Started
These instructions will get you a copy of the project up and running on your local machine for development and testing purposes. See deployment for notes on how to deploy the project on a live system.

### Prerequisites
What things you need to install the software and how to install them
- Visual Studio: Visual Studio is need to install. If Visual Studio already install on your computer this will be nice
- Command-Prompt for Visual Studio: Same go here. For this particular project, I highly recommend using Command-Prompt instead of the IDE.
- Linux: Program can be run on Linux System (if you familiar with Linux command line). 
- Any C/C++ compiler: If you have any compiler that already install then I highly recommend use your own compiler with out installing anything (time consuming).
Give examples

### Installing

A step by step series of examples that tell you how to get a development env running

 Visual Studio & Command-Prompt for Visual Studio:

* [Install Visual Studio](https://docs.microsoft.com/en-us/cpp/build/vscpp-step-0-installation?view=msvc-160#:~:text=Visual%20Studio%202019%20Installation%201%20Make%20sure%20your,...%204%20Choose%20workloads.%20...%20More%20items...) - If you haven't downloaded and installed Visual Studio and the Microsoft C/C++ tools yet, here's how to get started.
* [Developer Command Prompt for Visual Studio](https://docs.microsoft.com/en-us/dotnet/framework/tools/developer-command-prompt-for-vs#:~:text=%20Developer%20Command%20Prompt%20for%20Visual%20Studio%20,from%20inside%20Visual%20Studio.%20For%20easier...%20More) - Developer Command Prompt for Visual Studio enables you to use .NET Framework tools more easily. It's a command prompt that automatically sets specific environment variables. After opening Developer Command Prompt, you can enter the commands for .NET Framework tools such as ildasm or clrver.

Linux Ubuntu 18.4 LTS
* [Linux Ubuntu 18.4 LTS](https://www.microsoft.com/en-us/p/ubuntu-1804-lts/9n9tngvndl3q?activetab=pivot:overviewtab) can be download at Microsoft Store

## Running the tests

Explain how to run the automated tests for this system:
* [Linux Compilers](https://askubuntu.com/questions/61408/what-is-a-command-to-compile-and-run-c-programs#:~:text=The%20simplest%20way%20to%20compile%20a%20C%2B%2B%20program,only%20compiler%20capable%20of%20compiling%20the%20Linux%20kernel.)- Locate the home folder that contain the program (by using the cd command). Call the g++ compiler and execute.
* [Visual Studio Command Line](https://docs.microsoft.com/en-us/cpp/build/walkthrough-compiling-a-native-cpp-program-on-the-command-line?view=msvc-160
)

## Deployment

Can be deploy to any embedded system without any problem. Can also make API or libary using this. 

## Built With

* [Microsoft Visual Studio](https://visualstudio.microsoft.com/downloads/) - The full-featured integrated development environment (IDE) for Android, iOS, Windows, web, and cloud 
* [.NET](https://dotnet.microsoft.com/download/dotnet-framework) -  Free. Cross-platform. Open source. A developer platform for building Internet of Thing(IOT), Microservices, Desktop, Cloud, Mobile, Machine Learning, Web, Game.

## Contributing

Please read [CONTRIBUTING.md](https://gist.github.com/PurpleBooth/b24679402957c63ec426) for details on our code of conduct, and the process for submitting pull requests to us.

## Versioning

We use [SemVer](http://semver.org/) for versioning. For the versions available, see the [tags on this repository](https://github.com/your/project/tags). 

## Authors

* **Truc Huynh** - *Initial work* - [TrucDev](https://github.com/jackyhuynh)
* **Yien Lin** - *Initial work* - [YienLin](https://www.linkedin.com/in/yienlin/)
* **Dmitry Sokolov** - *Initial work* - [DmitrySokolov](https://www.linkedin.com/in/dmitry-sokolov-726596a4/)

## Format
my README.md format was retrieved from
* **Billie Thompson** - *Initial work* - [PurpleBooth](https://github.com/PurpleBooth)
See also the list of [contributors](https://github.com/your/project/contributors) who participated in this project.

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details

## Acknowledgments

* Hat tip to anyone whose code was used
* Inspiration
* etc

