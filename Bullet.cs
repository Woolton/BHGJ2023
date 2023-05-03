using Godot;
using System;

public partial class Bullet : Area2D
{
	float lifetime = 0;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		
		lifetime += (float)delta;
		var velocity = Vector2.Zero;
		velocity.Y -= 1;
		velocity.X += (float)Math.Cos(250 * lifetime);
		
		
		Position += velocity.Normalized() * (float)delta * 400;
	}
}
