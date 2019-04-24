# Root section of config

The root section is where you setup where/how the appenders will be invoked.

```XML
 <root>
      <level value="ALL" />
      <appender-ref ref="console" />
      <appender-ref ref="file" />
    </root>
```


Each ```appender-ref``` line indicates the appender that will get invoked when something is logged.

The ```level``` setting defines the lowest level that will get printed out.

Levels are:
```
FATAL
ERROR
WARN
INFO
DEBUG
```

```value="WARN"```will log ```WARN```, ```ERROR```, and ```FATAL```

```ALL``` is virtually the same as ```DEBUG```