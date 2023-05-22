
using Godot;
using System;


public partial class Player : ACharacter
{
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		ShiftSpeed = Speed * 0.4f;
		ScreenSize = GetViewportRect().Size;

		Shoot += Test_OnShoot;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{	
		#region Input
		Move(delta);

		if(Input.IsActionJustPressed("a_shot"))
		{
			//tapfire
			GD.Print("shotgun blast");
			//
		}
		if(Input.IsActionPressed("a_shot"))
		{
			//streamfire
			GD.Print("machinegun");
			OnShoot();
		}
		if(Input.IsActionJustPressed("b_shot"))
		{
			//altfire
			GD.Print("alt weapon");
		}
		if(Input.IsActionJustPressed("bomb"))
		{
			//bomb
			GD.Print("bomb");
		}
		if(Input.IsActionPressed("shift"))
		{
			//shift movement
			GD.Print("shift movement");
		}
		#endregion	
	}

    public override void Move(double delta)
    {
		var velocity = Vector2.Zero;

        if(Input.IsActionPressed("move_up"))
		{
			velocity.Y -= 1;
			
		}
		if(Input.IsActionPressed("move_down"))
		{
			velocity.Y += 1;
		}
		if(Input.IsActionPressed("move_left"))
		{
			velocity.X -= 1;
		}
		if(Input.IsActionPressed("move_right"))
		{
			velocity.X += 1;
		}

		var sprite = GetNode<Sprite2D>("Sprite2D");

		if(velocity.Length()>0)
		{
			velocity = velocity.Normalized() * Speed;
			//animation
		}
		//else animation stop

		Position += velocity * (float)delta;
    }

    protected override void OnShoot()
    {
        base.OnShoot();
    }

    public override void Die()
    {
        throw new NotImplementedException();
    }

    public override void onHit()
    {
        throw new NotImplementedException();
    }

	private void Test_OnShoot(object sender, EventArgs e)
	{
		GD.Print("success");
	}
}
