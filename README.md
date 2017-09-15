
# Write a Hello World program

### 1. The program has 1 current business requirement write Hello World to the console/screen.
	
	- To Run
		- Set the startup project to 'Exercise'
			- This is a common console applicatiton project 
      - This is the default behavior of the app 
      - Run the app and it will display 'Hello World' in a console app
      - The following line will appear above 'Hello World'
          - Loading: ToConsoleModule
              - This is the injection bindings module that is being used
              - I am using AutoFac for the IoC/Dependency Injection pattern (more details below)

### 2. The program should have an API that is separated from the program logic to eventually support mobile applications, web applications, console applications or windows services.
	
	- All abstract details of the app and api (interfaces) are located in 'Exercise.Domain'
		- These interfaces define the behavior of the application and api
		- Any concrete implementation of these interfaces do so by implementing the interfaces explicitly
			- This ensures complete adherence and testability 
			- https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/interfaces/explicit-interface-implementation
	- The concrete implementation of the api is in the following project:
		- Exercise.Api
	- The concrete application details are coded in the following projects
		- Exercise.ToConsole	 
		- Exercise.ToFile
		- Exercise.ToTrace
		- Each one of these define a different way to write 'Hello World'
		- None of the these projects reference the Exercise.Api project
			- The api to use is determined at runtime (although there is only one api definition) 
	- The only projects that have direct references to concrete implementations of the app or api are:
		- Exercise.Bindings
			- Define what concrete object to use at runtime
		- Exercise.Tests
			- NUnit & Moq unit tests
    


### 3. The program should support future enhancements for writing to a database, console application, etc.

###### Use common design patterns (inheritance, e.g.) to account for these future concerns.
	
	- I chose to use IoC/Dependency injection to support future changes
	- Everything is defined first as an interface and I used AutoFac as the IoC Container to assign concrete classes at runtime

###### Use configuration files or another industry standard mechanism for determining where to write the information to.

	- Use the 'App.config' in Exercise project to do the following
		- Decide what variation of the application to run by uncommenting the module you want (see autofac-> modules xml element)
			- Exercise.App.ToConsoleModule (default)
				- Writes 'Hello World' from api to Console
			- Exercise.App.ToFile
				- Writes 'Hello World' from api to file in bin directory 'Exercise.txt'
				- You will see additional information in the console app when running this variation 	 	  
			- Exercise.App.ToTrace
				- Writes 'Hello World' from api to System.Diagnostics.Trace.WriteLine("") 
				- There are 2 trace listeners setup in the App.config you can use with this app choice
					- ConsoleTraceListener (default)
					- TextWriterTracelistener
						- This one was setup to write to file in bin directory: 'Exercise.log' 	  	 	               


### 4. Write unit tests to support the API.

	- I'm using NUnit and Moq for unit testing
    	- https://www.nuget.org/packages/NUnit/
    	- https://www.nuget.org/packages/Moq/	 
	- I wrote complete unit tests for the following
		- Exercise.Api
		- Exercise.App.Console 

### 5. Feel free to use a github program to store the coding exercise as I know that’s typically easier to use.

