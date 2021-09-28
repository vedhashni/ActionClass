using NUnit.Framework;

namespace DemoForActionClass
{
    public class Tests:BaseClass
    {
        public static ActionClassOperations drag;
        [Test,Order(0)]
        public void TestMethodForDragandDrop()
        {
            drag = new ActionClassOperations();
            drag.DragandDropMethod();
            drag.ToScroll();
        }

        [Test, Order(1)]
        public void TestMethodForScroll()
        {
            drag = new ActionClassOperations();
            drag.ToScroll();
        }
    }
}