using UnityEngine;

public class ShapeDiamond : Shape
{
    protected override void Start()
    {
        base.Start();
        behavior = new RotateBehavior(-100.0f);
    }
}
