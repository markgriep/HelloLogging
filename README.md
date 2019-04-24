# HelloLog4Net
Simple Hello World for log4net.
I made it as easier to understand documentation

For the most basic logging you need 6 ingredients.

1. Add the framework 
2. Add a reference to the framework
3. Setup the configuration
4. Reference the assembly
5. Create a log object
6. Log something


After creating a new .net framework console application.

* In Visual studio, add the Log4Net package using nuget by running install-package log4net. You can also use the package manager interface
* Add the following code to the App.config

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

* Reference the assembly in the program.cs by adding this line right after the using statements. 
    [assembly: log4net.Config.XmlConfigurator(Watch = true)]

* Insert the following code just inside the Class Program to create a log4net object you can use throughout the class. 
    private static readonly log4net.ILog log = log4net.LogManager.GetLogger("Program.cs");



* Insert the following code in the main method, it will create an entry in the log file. 
    log.Debug("log a message");




