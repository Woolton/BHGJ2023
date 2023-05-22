using Godot;
using System;

public partial class Mob : Enemy
{
	PathFollow2D Follower;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Follower = GetParent<PathFollow2D>();

	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		Move(delta);

		OnShoot();
	}
	
	public override void Move(double delta)
	{
		Follower.Progress += Speed * (float)delta;

		//GD.Print(Follower.ProgressRatio);'
	}

	protected override void OnShoot()
	{
		//fixed shot sample
		/*
			wait x frames/seconds
			make gun face character position
			base.shoot
			repeat
		*/


		//aimed shot sample
		/*
			wait x frames/seconds
			base.shoot
		*/
	}

}
