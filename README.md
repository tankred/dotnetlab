# Dotnet lab

Using .NET 7 on Fedora Linux

### Samples

Create a new .NET 7 project in the C# language:

```
dotnet new console -o HelloWorldConsole
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


## Versioning

We use [SemVer](http://semver.org/) for versioning. For the versions available, see the [tags on this repository](https://github.com/tankred/dotnetlab/tags). 

## Authors

Tankred

## License

[GPL v3 license file](LICENSE.md)

## Acknowledgments

* Hat tip to anyone whose code was used
* [Using .NET 7 on Fedora Linux](https://fedoramagazine.org/using-dotnet-7-on-fedora/)

