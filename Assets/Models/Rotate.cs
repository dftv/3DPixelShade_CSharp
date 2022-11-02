using Godot;
using System;

public class Rotate : KinematicBody
{
	public override void _Process(float delta)
	{
		RotateY(0.01f);
	}
}
