using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public abstract class Shape : MonoBehaviour
{
    private SpriteRenderer _sprite;
    protected IBehavior behavior;

    protected void Awake()
    {
        _sprite = GetComponent<SpriteRenderer>();
    }

    protected virtual void Start()
    {
        
    }

    protected void Update()
    {
        if (behavior != null)
        {
            behavior.Behave(transform);
        }
    }
}
