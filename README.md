
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
	- The concrete implementation of the api is in the following project:
		- Exercise.Api
	- The concrete application details are coded in the following projects
		- Exercise.ToConsole	 
		- Exercise.ToFile
		- Exercise.ToTrace
		- None of the these projects listed above reference the Exercise.Api project
	- The only projects that have direct references to concrete implementations of the app or api are
		- Exercise.Bindings
			- Define what concrete object to use at runtime
		- Exercise.Tests
			- NUnit & Moq unit tests


### 3. The program should support future enhancements for writing to a database, console application, etc.
    - Use common design patterns (inheritance, e.g.) to account for these future concerns.
    - Use configuration files or another industry standard mechanism for determining where to write the information to.

### 4. Write unit tests to support the API.

### 5. Feel free to use a github program to store the coding exercise as I know that’s typically easier to use.

