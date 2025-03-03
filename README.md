Simulator For Robot Movement

Overview

The Robot Movement Simulator is a C# console application that allows a robot to navigate a 5x5 grid based on user commands. The robot can be placed at a specific position, moved forward, rotated, and report its current position.

Features

PLACE X,Y,FACING - Places the robot on the grid at (X, Y) facing NORTH, SOUTH, EAST, or WEST.

MOVE - Moves the robot one step forward in the direction it is facing.

LEFT / RIGHT - Rotates the robot 90 degrees in the specified direction.

REPORT - Outputs the robot's current position and facing direction.

EXIT - Ends the simulation.

How It Works

When you run the program, it will prompt you to enter the PLACE command.

Once placed, you can use MOVE, LEFT, RIGHT, and REPORT commands.

The robot will not fall off the grid; invalid moves are prevented.

You can exit the simulation by typing EXIT.

Project Structure

📁 InsuranceWAAssignment
├── 📄 Program.cs         # Main entry point
├── 📄 CommandProcessor.cs # Processes user commands
├── 📄 Robot.cs           # Handles robot movements and rotations
├── 📄 Table.cs           # Defines the 5x5 grid for the robot
├── 📄 Validate.cs        # Validates user input and robot state
├── 📄 Directions.cs      # Enum for possible directions

 Installation & Usage
 rerequisites

.NET SDK installed on your machine.

A terminal or command prompt.

Running the Program

Clone the repository:

git clone https://github.com/your-repo/robot-movement-simulator.git

Navigate to the project directory:

cd InsuranceWAAssignment

Compile and run the program:

dotnet run

 Example Commands & Output

--------------------------------------------------------------- Program Launched ----------------------------------------------------------------------------------------------
Please enter a PLACE command
(FORMAT: PLACE X,Y,FACING):

> PLACE 0,0,NORTH

<============ Robot successfully placed!!! ===================>

Now enter one of the following commands: MOVE, LEFT, RIGHT, REPORT
OR type EXIT to quit.

> MOVE
Robot moved to (0, 1)

> RIGHT
ROBOT turned Right ===> Now facing EAST

> MOVE
Robot moved to (1, 1)

> REPORT
ROBOT is at (1,1) and Facing EAST

> EXIT
>>>>>>>>>>>>>>> PROGRAM EXITED >>>>>>>>>>>>>>>

 Rules & Validations

The PLACE command is mandatory before any other command.

The robot cannot move outside the 5x5 grid.

Invalid commands will prompt an error message.
