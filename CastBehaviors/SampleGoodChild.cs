namespace CastBehaviors
{
    public class SampleGoodChild : SampleParent
    {
        public SampleGoodChild(string itemA, string itemB) : base(itemA)
        {
            ItemB = itemB;
        }

        public string ItemB { get; private set; }
    }
}