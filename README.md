Unity Elevator Simulation

Unity Elevator Simulation is a 2D system that simulates multiple elevators responding to floor requests. The project demonstrates core Unity development concepts such as object-oriented programming, system logic design, UI interaction, and smooth object movement.

The system contains three elevators and four floors. When a user presses a floor button, the system determines the nearest elevator and assigns the request to that elevator. Each elevator maintains its own request queue and moves smoothly between floors while updating the current floor display.

Project Features

• Three independent elevators  
• Four floors with call buttons  
• Nearest elevator selection logic  
• Independent request queue for each elevator  
• Smooth elevator movement using Vector3.MoveTowards  
• Floor indicator display for each elevator  
• Modular and well-structured scripts  

System Workflow

1. A user presses a floor button.
2. The ElevatorManager receives the request.
3. The manager determines which elevator is closest to the requested floor.
4. The request is added to that elevator's queue.
5. The elevator moves toward the requested floor.
6. When the elevator reaches the floor, the display updates.

Script Overview

Elevator.cs  
Handles elevator movement, manages the request queue, tracks the current floor, and detects when the elevator reaches a floor.

ElevatorManager.cs  
Acts as the central controller that receives floor requests and assigns them to the nearest elevator.

FloorDisplay.cs  
Displays the current floor of each elevator in the UI.

Technologies Used

Unity Engine  
C#  
Unity UI  
Vector3 movement and queue-based request handling

How to Run the Project

1. Clone the repository from GitHub.
2. Open the project using Unity Hub.
3. Load the main scene in the Scenes folder.
4. Press the Play button in Unity.

Users can press the floor buttons and observe how elevators respond to the requests.

Live Demo

https://ayushb1704.itch.io/elevator-simulation

Author
Ayush Balpande