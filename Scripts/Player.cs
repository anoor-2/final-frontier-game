using Godot;
using System;

//"partial" lets allows the thing to be split across different files and "player" is the name of the script/class

public partial class Player : CharacterBody2D 
{
	public int Speed = 350; //movement speed in pixels per sec I think
	public override void _PhysicsProcess(double delta) 
	
	// _PhsyicsProcess is every physics frame, usually 60 per minute and delta is the time since the LAST frame - Why double???? 

	{
		Vector2 velocity = Velocity; //Velocity2 is BUILT IN, storing it in a VARIABLE

		// ship isn't gonna move unitl someone presses something
		velocity.X = 0;

		//Checking for input, positive speed 
		if (Input.IsActionPressed("ui_right"))
		{
			velocity.X += Speed;
		}
		if (Input.IsActionPressed("ui_left")) //Same thing, this is just negative 
		{
			velocity.X -= Speed;
		}

		// Applying movements
		Velocity = velocity;
		MoveAndSlide(); //What does this do??
	}	
}
