using UnityEngine;

public abstract class ShapeBehavior : IBehavior
{
    private readonly ShapeBehavior _behavior;

    protected ShapeBehavior(ShapeBehavior shapeBehavior = null)
    {
        _behavior = shapeBehavior;
    }

    public virtual void Behave(Transform transform)
    {
        if (_behavior != null)
        {
             _behavior.Behave(transform);
        }
    }
}
