namespace CastBehaviors
{
    public static class Factory
    {
        public static SampleParent CreateParent(bool isBad)
        {
            if (isBad)
            {
                return new SampleBadChild("ITEMA", "ITEMC");
            }

            return new SampleGoodChild("ITEMA", "ITEMB");
        }
    }
}