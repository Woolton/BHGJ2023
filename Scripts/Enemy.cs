using Godot;
using System;

public partial class Enemy : ACharacter
{

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
    #region Methods

    public override void Move(double delta)
    {
        throw new NotImplementedException();
    }

    public override void Shoot()
    {
        throw new NotImplementedException();
    }

    public override void Die()
    {
        throw new NotImplementedException();
    }

    public override void onHit()
    {
        throw new NotImplementedException();
    }

    #endregion
}
