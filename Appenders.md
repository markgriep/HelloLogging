# Appenders
These are defined in the XML. I consider them equivalent to C# objects.


Here are some properties in a Key Value pair format




 Key						| Values are	|Comments
 ------------				|-------------	|-------------
 ConversionPattern			|```%date```	| none
 ConversionPattern			|```%level```	| This level 
 ConversionPattern			|```%thread```	| Thread number
 ConversionPattern			|```%newline```| Puts in a new line char
 rollingStyle				|```Size```		| none
 maxSizeRollBackups			|```10MB```		| ##MB or ##KB or ##GB
 maxSizeRollBackups			|```10KB```		| none
 maxSizeRollBackups			|```5```		| Any integer 
 
