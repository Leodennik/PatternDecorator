using UnityEngine;

public class MoveBehavior : ShapeBehavior
{
    private readonly ShapeBehavior _behavior;
    private float _moveTime;
    private float _speedX;
    private float _speedY;
    private float timer;
    
    public MoveBehavior(float speedX, float speedY, float moveTime, ShapeBehavior shapeBehavior = null) : base(shapeBehavior)
    {
        _moveTime = moveTime;
        _speedX   = speedX;
        _speedY   = speedY;
    }

    public override void Behave(Transform transform)
    {
        base.Behave(transform);
        if (timer < _moveTime)
        {
            timer += Time.deltaTime;
            transform.Translate(_speedX * Time.deltaTime, _speedY * Time.deltaTime, 0);
        }
        else
        {
            timer = 0;
            _speedX = -_speedX;
            _speedY = -_speedY;
        }
    }
}
