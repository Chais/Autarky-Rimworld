using Verse;

namespace Autarky
{
    public class CompProperties_Harvestable : CompProperties
    {
        //
        // Fields
        //
        public int harvestIntervalDays;

        public int resourceAmount = 1;

        public ThingDef resourceDef;

        public bool harvestFemaleOnly = true;

        public string fullnessKey;

        //
        // Constructors
        //
        public CompProperties_Harvestable()
        {
            this.compClass = typeof(CompHarvestable);
        }
    }
}