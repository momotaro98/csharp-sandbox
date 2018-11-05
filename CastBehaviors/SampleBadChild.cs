namespace CastBehaviors
{
    public class SampleBadChild : SampleParent
    {
        public SampleBadChild(string itemA, string itemC) : base(itemA)
        {
            ItemC = itemC;
        }
        
        public string ItemC { get; set; }
    }
}