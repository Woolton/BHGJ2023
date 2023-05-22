using Godot;
using System;

public abstract partial class ACharacter : Node2D
{
	#region vars
	[Export]
	public int Health{get;set;} = 1;

	[Export]
	public int Speed{get; set;} = 400;
	
	[Export]
	public PackedScene Gun{get;set;}//scene that shoots bullets

	[Export]
	public int GunCount{get;set;}//amount of guns the character has
	protected float ShiftSpeed;
	public Vector2 ScreenSize;

	public event EventHandler Shoot;

	#endregion
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	#region Abstract methods
		public abstract void Move(double delta);//return position on button press

		public abstract void Die();//return some die mesage

		//TODO: update with parameter type
		public abstract void onHit();//when a bullet enters the colliderS
	#endregion

	public void onHealthZero()
	{
		if(Health==0)
		{
			Die();
		}
	}
	protected virtual void OnShoot()
		{
			Shoot?.Invoke(this,EventArgs.Empty);
		}//return "shot" on button press

}
