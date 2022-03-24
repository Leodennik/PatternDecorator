using UnityEngine;

public class TeleportBehavior : ShapeBehavior
{
    private readonly ShapeBehavior _behavior;
    private float _radius;
    private float _teleportDelay;
    private float timer;
    
    public TeleportBehavior(float radius, float teleportDelay, ShapeBehavior shapeBehavior = null) : base(shapeBehavior)
    {
        _radius = radius;
        _teleportDelay   = teleportDelay;
    }

    public override void Behave(Transform transform)
    {
        base.Behave(transform);
        if (timer < _teleportDelay)
        {
            timer += Time.deltaTime;
        }
        else
        {
            transform.Translate(Random.insideUnitCircle*_radius);
            timer = 0;
        }
    }
}
