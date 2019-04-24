# Appenders
These are defined in the XML. I consider them equivalent to C# objects.


Here are some properties in a Key Value pair format


 Key						| Values are   |       Comments|
 -------------------------	|:-------------:|
 ConversionPattern			|```%date```	|
							||```%level```	| This level 
							||```%thread```	| Thread number
							||```%newline```| Puts in a new line char
 rollingStyle				|```Size```		| 
 maxSizeRollBackups			|```10MB```		| ##MB or ##KB or ##GB
							||```10KB```		|
 maxSizeRollBackups			|```5```		| Any integer 
 
