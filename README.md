# Dotnet lab

Using .NET 7 on Fedora Linux

```
dotnet --version
```

### Samples

Create a new .NET 7 project in the C# language:

```
dotnet new console -o HelloWorldConsole
cd HelloWorldConsole
dotnet run Program.cs
```

Run a container

```
podman run -it -p 8080:8080 hello-container
```
```
podman run node ls
```

Run container and keep console open inside container
(Apply :Z flag to label correctly for SELinux)

```
podman run -ti --rm -v $(pwd):/app:Z node bash
podman run -ti -v $(pwd):/app:Z node bash
```

Run node inside container
```
➜  src git:(dock) ✗ podman run -ti -v $(pwd):/app:Z node bash
root@6f2ce81bdff7:/# cd app/
root@6f2ce81bdff7:/app# ls
helloWorld.js
root@6f2ce81bdff7:/app# node helloWorld.js 
Hello, world
root@6f2ce81bdff7:/app#
```

Run node inside container with library
-w /app to define working directory where npm add will be executed

```
➜  podman run -ti -v $(pwd):/app:Z -w /app node npm add underscore 
```

### ClosedXML

```
dotnet add package ClosedXML
```

## Versioning

We use [SemVer](http://semver.org/) for versioning. For the versions available, see the [tags on this repository](https://github.com/tankred/dotnetlab/tags). 

## Authors

Tankred

## License

[GPL v3 license file](LICENSE.md)

## Acknowledgments

* Hat tip to anyone whose code was used
* [Using .NET 7 on Fedora Linux](https://fedoramagazine.org/using-dotnet-7-on-fedora/)
* [Co-authoring git commit msg](https://dev.to/cassidoo/co-authoring-git-commits-3gin)
* [ClosedXML package](https://docs.closedxml.io/en/latest/)
* [More info on new console template](https://aka.ms/new-console-template)

