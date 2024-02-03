# Event-Organiser-v1.0
An Event/To-do list organiser with a Command line user interface. Written in C# and my second project using Object Oriented Programming.
Future versions will have a popup window, be downloadable as an executable file and have the events stored in a local database.

As this is Version 1.0, i will just upload the source code and continue to iteratively improve it until i can work my way up to creating executable files.
Each future Version will contain the feature of the previous ones but may be more efficient and contain more features.

Features of this programme:
- Add an event
- Search through stored events
- Display all stored events in closest date first
- Remove an event from the stored events

Currently all the events are stored in an array and will be lost when the programme is closed or the computer turns off.
However there is no limit to the number of events that can be stored. Each event contains: A Title, Description, Date & Time (Time is not always necessary)

<br>
Program.cs - Is what you should run when wanting to use this code, contains the main code that calls on the other classes. <br>

Menu.cs - Contains the ASCII menu and is the main branch of this software that brings everything together and calls upon other classes. <br>

eventOrganiser.cs - Contains all the properties such as AddEvent(), RemoveEvent(), etc... <br>

Event.cs - This is the class that defines the actual properties of each event. <br>
