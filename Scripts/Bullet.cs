using Godot;
using System;

public partial class Bullet : Area2D
{
	[Export]
	public float Speed = 500;

	public override void _PhysicsProcess(double delta)
	{
	GlobalPosition += Vector2.Up * Speed * (float)delta;
	}
}
