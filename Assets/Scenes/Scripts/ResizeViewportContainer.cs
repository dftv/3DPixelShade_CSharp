using Godot;
using System;

public class ResizeViewportContainer : ViewportContainer
{
    //Public

    //Private
    private Vector2 pixelShadeResolution;

    //External
    public Viewport _Viewport;

    public override void _Ready()
    {
        _Viewport = GetNode<Viewport>("Viewport");

        pixelShadeResolution = new Vector2(1920 / 5, 1080 / 5);

        _Viewport.Size = pixelShadeResolution;
    }
}
