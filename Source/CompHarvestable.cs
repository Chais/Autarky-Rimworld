using RimWorld;
using Verse;

namespace Autarky
{
    public class CompHarvestable : CompHasGatherableBodyResource
    {
        //
        // Properties
        //
        protected override bool Active
        {
            get
            {
                if (!base.Active)
                {
                    return false;
                }
                Pawn pawn = this.parent as Pawn;
				Autarky.LifeStageDef curLifeStage = pawn.ageTracker.CurLifeStage as Autarky.LifeStageDef;
				bool harvestable = curLifeStage != null ? curLifeStage.harvestable : false;
                return (!this.Props.harvestFemaleOnly || pawn == null || pawn.gender == Gender.Female) &&
                       (pawn == null || harvestable);
            }
        }

        protected override int GatherResourcesIntervalDays => this.Props.harvestIntervalDays;

        public CompProperties_Harvestable Props => (CompProperties_Harvestable) this.props;

        protected override int ResourceAmount => this.Props.resourceAmount;

        protected override ThingDef ResourceDef => this.Props.resourceDef;

        protected override string SaveKey => this.Props.resourceDef.defName + "Production";

        //
        // Methods
        //
        public override string CompInspectStringExtra()
        {
            if (!this.Active)
            {
                return null;
            }
			return this.Props.fullnessKey.Translate() + ": " + base.Fullness.ToStringPercent();
        }
    }
}