# driverApp
DriverApp for SafeAuto Application

This app was built for the SafeAuto Junior Front End Developer interview process. 

When I first considered this project, I started with the basics: get driver input to a text file. So, I began with a command: Driver. The file line would then be read by the project to record the name of the driver. I noticed that if the user added an extra space after their name, the program would throw an error, as the data should only be delimited by one space. To solve for this, I added an if block to catch any exceptions. I then thought about recieving the driver trip data. The data would have to come through as a string delimited by spaces, per the instructions and the limitations of command inputs. 

Once the data was collected, I needed to make them equal to properties of an object. Thus, I added the string input to a list of Lines and separated the datapoints by splitting each line by space delimitation into entries.  I then used the isolated properties to convert and calculate the necessary data including time interval, total time in hours, total miles, and miles per hour. Here, I have effectively isolated the data that will be needed to return the result. 

Next, I tried a myriad of ways to isolate the data by mph and sort the output lines. Unfortunately, I was unable to accomplish this final step. I included a block of code with an example of how to sort a simple array, to indicate the intended outcome of what I wanted to accomplish. Theoretically, you could add each array of entries into an array and sort and order with a loop targeting every x index. 

Lastly, I implemented a check for the 5 < mph < 100. By using boolean values, I filtered out the unnecessary items and wrote the applicable data to the console by using string interpolation. The final line of the program allows for a pause in the program's execution to help the reader review the resulting data. 
