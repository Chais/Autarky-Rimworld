using System;
using Verse;
using RimWorld;

namespace Autarky
{
	public class CompProperties_Explosive : CompProperties
	{
		//
		// Fields
		//
		public float explosiveRadius = 1.9f;

		public float explosiveExpandPerStackcount;

		public EffecterDef explosionEffect;

		public DamageDef startWickOnDamageTaken;

		public float startWickHitPointsPercent = 0.2f;

		public IntRange wickTicks = new IntRange (140, 150);

		public float wickScale = 1f;

		public float chanceNeverExplodeFromDamage;

		public int preExplosionSpawnThingCount = 1;

		public DamageDef explosiveDamageType = DamageDefOf.Bomb;

		public ThingDef postExplosionSpawnThingDef;

		public float postExplosionSpawnChance;

		public int postExplosionSpawnThingCount = 1;

		public bool applyDamageToExplosionCellsNeighbors;

		public ThingDef preExplosionSpawnThingDef;

		public float preExplosionSpawnChance;

		//
		// Constructors
		//
		public CompProperties_Explosive ()
		{
			this.compClass = typeof(CompExplosive);
		}
	}
}