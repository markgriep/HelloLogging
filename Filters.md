# Filters

You can control what gets sent to the logs by creating a filter in the appender



```XML
<appender name="FooRollingFiltered" type="log4net.Appender.RollingFileAppender">          
    <file value="logs/rolling.filter.log" />                                              
    <filter type ="log4net.filter.LevelRangeFilter">              <!-- Starts here -->
        <LevelMin value="WARN" />                                 <!-- Will show warn,  -->                                  
        <LevelMax value="ERROR" />                                <!-- through error -->              
    </filter>
    <appendToFile value="true" />
    <rollingStyle value="Size" />                                                         
    <maxSizeRollBackups value="5" />                                                      
    <maximumFileSize value="15KB" />                                                      
    <staticLogFileName value="true" />
    <layout type="log4net.Layout.PatternLayout">
        <conversionPattern value="%date [%thread] %level %logger - %message%newline" />
    </layout>
</appender>
```


```XML
<appender name="FooRollingFilteredMatch" type="log4net.Appender.RollingFileAppender">     
    <file value="logs/rolling.filter.log" />                                              
    <filter type ="log4net.filter.StringMatchFilter">         <!-- Starts here-->                                   
      <stringToMatch value="foo" />                           <!-- Will look for and show only items with foo in them  -->                                              
    </filter>
    <filter type ="log4net.filter.DenyAllFilter">             <!-- Needed, in order to drop anything else -->                                      
    </filter>
    <appendToFile value="true" />
    <rollingStyle value="Size" />                                                         
    <maxSizeRollBackups value="5" />                                                      
    <maximumFileSize value="15KB" />                                                      
    <staticLogFileName value="true" />
    <layout type="log4net.Layout.PatternLayout">
        <conversionPattern value="%date [%thread] %level %logger - %message%newline" />
    </layout>
</appender>
```


```XML
 <appender name="FooRollingLevelMatch" type="log4net.Appender.RollingFileAppender">       
    <file value="logs/rolling.filter.log" />                                              
    <filter type ="log4net.Filter.LevelMatchFilter">           <!-- Starts here-->                                      
      <levelToMatch value="INFO" />                            <!-- Will show entries of INFO --> 
    </filter>
    <filter type ="log4net.Filter.LevelMatchFilter">                                      
      <levelToMatch value="FATAL" />                           <!-- Will show entries of FATAL --> 
    </filter>
    <filter type ="log4net.filter.DenyAllFilter">                    <!-- Needed, in order to drop anything else -->                                       
    </filter>
    <appendToFile value="true" />
    <rollingStyle value="Size" />                                                         
    <maxSizeRollBackups value="5" />                                                      
    <maximumFileSize value="15KB" />                                                      
    <staticLogFileName value="true" />
    <layout type="log4net.Layout.PatternLayout">
        <conversionPattern value="%date [%thread] %level %logger - %message%newline" />
    </layout>
</appender>
```
