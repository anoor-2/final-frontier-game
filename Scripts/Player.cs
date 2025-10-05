using Godot;
using System;

//HOW do I get this to move?? 

public partial class Player : CharacterBody2D
{
  // Movement speed in pixels per second
	public int Speed = 200;

	public override void _PhysicsProcess(double delta)
	{
		Vector2 velocity = Velocity;

		// Reset horizontal velocity
		velocity.X = 0;

		// Check for input
		if (Input.IsActionPressed("ui_right"))
		{
			velocity.X += Speed;
		}
		if (Input.IsActionPressed("ui_left"))
		{
			velocity.X -= Speed;
		}

		// Apply movement
		Velocity = velocity;
		MoveAndSlide();
	}	
}
