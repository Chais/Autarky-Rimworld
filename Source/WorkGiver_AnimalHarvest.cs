using Verse;
using RimWorld;

namespace Autarky
{
	public class WorkGiver_AnimalHarvest : WorkGiver_GatherAnimalBodyResources
	{
		//
		// Properties
		//
		protected override JobDef JobDef {
			get {
				return Autarky.JobDefOf.Autarky_AnimalHarvest;
			}
		}

		//
		// Methods
		//
		protected override CompHasGatherableBodyResource GetComp (Pawn animal)
		{
			return animal.TryGetComp<CompHarvestable> ();
		}
	}
}
