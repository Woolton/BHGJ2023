using Godot;
using System;

public partial class Enemy : Node
{
	#region Variables
		[Export]
		public int Health{get;set;}=2;
		public int Speed{get;set;}=2;

		//guns (list)

		//firepattern

		//bullet

		//path
	#endregion
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	#region Methods
		void Attack()
		{
			//for each gun in Guns, fire(firepattern)
		}

		void Move()
		{
			//follow path
		}

		void Die()
		{
			//called from onHealthZero()
			//death procedure
		}

		//signals/observer shit
		void onHit()
		{
			//when a bullet enters the hitbox
			//subtract some health
		}

		void onHealthZero()
		{
			//when health = 0, Die()
			//or do something else cool
		}
	#endregion
}
