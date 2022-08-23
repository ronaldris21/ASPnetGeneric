<a href="https://docs.microsoft.com/en-us/dotnet/core/tools/">More commands on</a>

- dotnet --version
- dotnet run
- dotnet watch run
- dotnet restore
- dotnet clean
- dotnet build
- dotnet build --configuration release
- dotnet new globaljson
- dotnet --info

- dotnet new --list
- dotnet new console --output AppName

When Debugging dotnet apps in VS CODE make sure to have something like this on .vscode/launch.json
"configurations": [
        {
            "name": ".NET Core Launch (console)",
            "type": "coreclr",
            "request": "launch",
            "preLaunchTask": "build",
            "program": "${workspaceFolder}/Dotnet/consoleApp/bin/Debug/net6.0/consoleApp.dll",
            "args": [],
            "cwd": "${workspaceFolder}/Dotnet/consoleApp",
            "stopAtEntry": false,
            "console": "internalConsole"
        },
        