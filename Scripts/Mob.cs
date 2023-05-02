using Godot;
using System;

public partial class Mob : Enemy
{
	PathFollow2D Follower;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Follower = GetParent<PathFollow2D>();
		Speed = 400;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		
		Follower.Progress += Speed * (float)delta;

		GD.Print(Follower.ProgressRatio);
	}
	

}
