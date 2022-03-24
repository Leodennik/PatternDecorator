using UnityEngine;

public class ShapeSquare : Shape
{
    protected override void Start()
    {
        base.Start();
        behavior = new RotateBehavior(50.0f, 
                                    new TeleportBehavior(5.0f, 1.0f));
    }
}
