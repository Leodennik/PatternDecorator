public class ShapeCircle : Shape
{
    protected override void Start()
    {
        base.Start();
        behavior = new MoveBehavior(-2, 0, 2.0f);
    }
}
