using Godot;
using System;

public partial class Gun : Node2D
{
	#region vars
		[Export]
		PackedScene _Bullet;
		
	#endregion
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	#region methods
		public void onShoot()
		{
			Bullet b = _Bullet.Instantiate<Bullet>();
			GetTree().Root.AddChild(b);
			b.Position = this.Position;
			b.Rotation = this.Rotation;
		}
	#endregion
}
