using UnityEngine;

public class RotateBehavior : ShapeBehavior
{
    private readonly ShapeBehavior _behavior;
    private float _speed;
    public RotateBehavior(float speed, ShapeBehavior shapeBehavior = null) : base(shapeBehavior)
    {
        _speed = speed;
    }

    public override void Behave(Transform transform)
    {
        base.Behave(transform);
        transform.Rotate(0, 0, _speed*Time.deltaTime);
    }
}
