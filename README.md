# HelloLogging


Some Simple Logging examples.

## Serialog is a modern simple logging framework.

1. Install the nuget packages.
2. Add the following code to the main method.
```C#
var log = new LoggerConfiguration()
            .WriteTo.Console()
            .WriteTo.File("log/log.txt", rollingInterval: RollingInterval.Day)
            .MinimumLevel.Verbose()
            .CreateLogger();

            var userId = "mgasrs";

            log.Fatal("this is fatal");             // Highest
            log.Error("this is error");
            log.Warning("this is warning");
            log.Information("this is info");
            log.Debug($"debug from : {userId}");
            log.Verbose("this is verbose");         // Lowest
```


## Log4Net
I made it as easier to understand documentation

For the most basic logging you need 5 ingredients.

1. Add the framework 
2. Setup the configuration
3. Reference the assembly
4. Create a log object
5. Log something

After creating a new .net framework console application.

1. In Visual studio, add the Log4Net package using nuget by running install-package log4net. You can also use the package manager interface
2. Add the following code to the App.config

```xml
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
    <configSections>
        <section name="log4net" type="log4net.Config.Log4NetConfigurationSectionHandler, log4net"/>
    </configSections>
 
    <log4net>
        <appender name="FileAppender" type="log4net.Appender.FileAppender">
            <file value="log.txt" />
            <appendToFile value="true" />
            <layout type="log4net.Layout.PatternLayout">
                <conversionPattern value="%date %-level %message%newline" />
            </layout>
        </appender>
        <root>
            <level value="all" />
            <appender-ref ref="FileAppender" />
        </root>
    </log4net>
    <startup>
        <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.6.1" />
    </startup>
</configuration>
```
3. Reference the assembly in the program.cs by adding this line right after the using statements. 
```c#
[assembly: log4net.Config.XmlConfigurator(Watch = true)]
```
4. Insert the following code just inside the Class Program to create a log4net object you can use throughout the class. 
```
private static readonly log4net.ILog log = log4net.LogManager.GetLogger("Program.cs");
```


5. Insert the following code in the main method, it will create an entry in the log file. 
```
log.Debug("log a message");
```
When you run the program, you should have a log file called log.txt in the debug folder with your program.


