using RimWorld;
using Verse;

namespace Autarky
{
	public class JobDriver_AnimalHarvest : JobDriver_GatherAnimalBodyResources
	{
		//
		// Properties
		//
		protected override float WorkTotal {
			get {
				return 1000f;
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
