using Terraria;
using Terraria.ModLoader;
using Tremor.Items;
using Tremor.Items.Alchemist.Flasks;
using Tremor.NPCs.Bosses.NovaPillar.Items.Weapons;

namespace Tremor
{
	public class AlchemistGlobalItem:GlobalItem
	{
		//public override bool ConsumeItem(Item item, Player player)
		//{
		//	MPlayer modPlayer = MPlayer.GetModPlayer(player);
		//	if(modPlayer.novaChestplate)
		//	{
		//		if(player.FindBuffIndex(ModContent.BuffType<SuperFlask>()) != -1)
		//		{
		//			if((item.type == ModContent.ItemType<LesserManaFlask>() || item.type == ModContent.ItemType<BurningFlask>() || item.type == ModContent.ItemType<BoomFlask>() || item.type == ModContent.ItemType<BigVenomFlask>() || item.type == ModContent.ItemType<BigPoisonFlask>() || item.type == ModContent.ItemType<BigManaFlask>() ||
		//						item.type == ModContent.ItemType<BigHealingFlack>() || item.type == ModContent.ItemType<BasicFlask>() || item.type == ModContent.ItemType<FreezeFlask>() ||
		//						/*item.type == ModContent.ItemType<DepressionFlask>() ||*/ item.type == ModContent.ItemType<CrystalFlask>() || item.type == ModContent.ItemType<ClusterFlask>() ||
		//						item.type == ModContent.ItemType<GoldFlask>() || item.type == ModContent.ItemType<ExtendedFreezeFlask>() || item.type == ModContent.ItemType<ExtendedBurningFlask>() ||
		//						item.type == ModContent.ItemType<ExtendedBoomFlask>() || item.type == ModContent.ItemType<HealthSupportFlask>() || item.type == ModContent.ItemType<ManaSupportFlask>() ||
		//						item.type == ModContent.ItemType<LesserVenomFlask>() || item.type == ModContent.ItemType<LesserPoisonFlask>() || item.type == ModContent.ItemType<LesserHealingFlack>() ||
		//						item.type == ModContent.ItemType<PlagueFlask>() || item.type == ModContent.ItemType<PhantomFlask>() || item.type == ModContent.ItemType<MoonDustFlask>() ||
		//						item.type == ModContent.ItemType<SparkingFlask>() || item.type == ModContent.ItemType<SuperManaFlask>() || item.type == ModContent.ItemType<SuperHealingFlask>() || item.type == ModContent.ItemType<NovaFlask>()) && Main.rand.NextFloat() < 0.65f)
		//			{
		//				return false;
		//			}
		//		}
		//		if(player.FindBuffIndex(ModContent.BuffType<SuperFlaskBig>()) != -1)
		//		{
		//			if((item.type == ModContent.ItemType<LesserManaFlask>() || item.type == ModContent.ItemType<BurningFlask>() || item.type == ModContent.ItemType<BoomFlask>() || item.type == ModContent.ItemType<BigVenomFlask>() || item.type == ModContent.ItemType<BigPoisonFlask>() || item.type == ModContent.ItemType<BigManaFlask>() ||
		//						item.type == ModContent.ItemType<BigHealingFlack>() || item.type == ModContent.ItemType<BasicFlask>() || item.type == ModContent.ItemType<FreezeFlask>() ||
		//						/*item.type == ModContent.ItemType<DepressionFlask>() ||*/ item.type == ModContent.ItemType<CrystalFlask>() || item.type == ModContent.ItemType<ClusterFlask>() ||
		//						item.type == ModContent.ItemType<GoldFlask>() || item.type == ModContent.ItemType<ExtendedFreezeFlask>() || item.type == ModContent.ItemType<ExtendedBurningFlask>() ||
		//						item.type == ModContent.ItemType<ExtendedBoomFlask>() || item.type == ModContent.ItemType<HealthSupportFlask>() || item.type == ModContent.ItemType<ManaSupportFlask>() ||
		//						item.type == ModContent.ItemType<LesserVenomFlask>() || item.type == ModContent.ItemType<LesserPoisonFlask>() || item.type == ModContent.ItemType<LesserHealingFlack>() ||
		//						item.type == ModContent.ItemType<PlagueFlask>() || item.type == ModContent.ItemType<PhantomFlask>() || item.type == ModContent.ItemType<MoonDustFlask>() ||
		//						item.type == ModContent.ItemType<SparkingFlask>() || item.type == ModContent.ItemType<SuperManaFlask>() || item.type == ModContent.ItemType<SuperHealingFlask>() || item.type == ModContent.ItemType<NovaFlask>()) && Main.rand.NextFloat() < 0.85f)
		//			{
		//				return false;
		//			}
		//		}
		//		if(player.FindBuffIndex(ModContent.BuffType<SuperFlaskBig>()) < 1 && player.FindBuffIndex(ModContent.BuffType<SuperFlaskBig>()) < 1)
		//		{
		//			if((item.type == ModContent.ItemType<LesserManaFlask>() || item.type == ModContent.ItemType<BurningFlask>() || item.type == ModContent.ItemType<BoomFlask>() || item.type == ModContent.ItemType<BigVenomFlask>() || item.type == ModContent.ItemType<BigPoisonFlask>() || item.type == ModContent.ItemType<BigManaFlask>() ||
		//						item.type == ModContent.ItemType<BigHealingFlack>() || item.type == ModContent.ItemType<BasicFlask>() || item.type == ModContent.ItemType<FreezeFlask>() ||
		//						/*item.type == ModContent.ItemType<DepressionFlask>() ||*/ item.type == ModContent.ItemType<CrystalFlask>() || item.type == ModContent.ItemType<ClusterFlask>() ||
		//						item.type == ModContent.ItemType<GoldFlask>() || item.type == ModContent.ItemType<ExtendedFreezeFlask>() || item.type == ModContent.ItemType<ExtendedBurningFlask>() ||
		//						item.type == ModContent.ItemType<ExtendedBoomFlask>() || item.type == ModContent.ItemType<HealthSupportFlask>() || item.type == ModContent.ItemType<ManaSupportFlask>() ||
		//						item.type == ModContent.ItemType<LesserVenomFlask>() || item.type == ModContent.ItemType<LesserPoisonFlask>() || item.type == ModContent.ItemType<LesserHealingFlack>() ||
		//						item.type == ModContent.ItemType<PlagueFlask>() || item.type == ModContent.ItemType<PhantomFlask>() || item.type == ModContent.ItemType<MoonDustFlask>() ||
		//						item.type == ModContent.ItemType<SparkingFlask>() || item.type == ModContent.ItemType<SuperManaFlask>() || item.type == ModContent.ItemType<SuperHealingFlask>() || item.type == ModContent.ItemType<NovaFlask>()) && Main.rand.NextFloat() < 0.4f)
		//			{
		//				return false;
		//			}
		//		}
		//	}
		//	if(player.FindBuffIndex(ModContent.BuffType<SuperFlask>()) != -1)
		//	{
		//		if((item.type == ModContent.ItemType<LesserManaFlask>() || item.type == ModContent.ItemType<BurningFlask>() || item.type == ModContent.ItemType<BoomFlask>() || item.type == ModContent.ItemType<BigVenomFlask>() || item.type == ModContent.ItemType<BigPoisonFlask>() || item.type == ModContent.ItemType<BigManaFlask>() ||
		//					item.type == ModContent.ItemType<BigHealingFlack>() || item.type == ModContent.ItemType<BasicFlask>() || item.type == ModContent.ItemType<FreezeFlask>() ||
		//					/*item.type == ModContent.ItemType<DepressionFlask>() ||*/ item.type == ModContent.ItemType<CrystalFlask>() || item.type == ModContent.ItemType<ClusterFlask>() ||
		//					item.type == ModContent.ItemType<GoldFlask>() || item.type == ModContent.ItemType<ExtendedFreezeFlask>() || item.type == ModContent.ItemType<ExtendedBurningFlask>() ||
		//					item.type == ModContent.ItemType<ExtendedBoomFlask>() || item.type == ModContent.ItemType<HealthSupportFlask>() || item.type == ModContent.ItemType<ManaSupportFlask>() ||
		//					item.type == ModContent.ItemType<LesserVenomFlask>() || item.type == ModContent.ItemType<LesserPoisonFlask>() || item.type == ModContent.ItemType<LesserHealingFlack>() ||
		//					item.type == ModContent.ItemType<PlagueFlask>() || item.type == ModContent.ItemType<PhantomFlask>() || item.type == ModContent.ItemType<MoonDustFlask>() ||
		//					item.type == ModContent.ItemType<SparkingFlask>() || item.type == ModContent.ItemType<SuperManaFlask>() || item.type == ModContent.ItemType<SuperHealingFlask>() || item.type == ModContent.ItemType<NovaFlask>()) && Main.rand.NextFloat() < 0.25f)
		//		{
		//			return false;
		//		}
		//	}
		//	if(player.FindBuffIndex(ModContent.BuffType<SuperFlaskBig>()) != -1 && modPlayer.novaAura)
		//	{
		//		if((item.type == ModContent.ItemType<LesserManaFlask>() || item.type == ModContent.ItemType<BurningFlask>() || item.type == ModContent.ItemType<BoomFlask>() || item.type == ModContent.ItemType<BigVenomFlask>() || item.type == ModContent.ItemType<BigPoisonFlask>() || item.type == ModContent.ItemType<BigManaFlask>() ||
		//					item.type == ModContent.ItemType<BigHealingFlack>() || item.type == ModContent.ItemType<BasicFlask>() || item.type == ModContent.ItemType<FreezeFlask>() ||
		//					/*item.type == ModContent.ItemType<DepressionFlask>() ||*/ item.type == ModContent.ItemType<CrystalFlask>() || item.type == ModContent.ItemType<ClusterFlask>() ||
		//					item.type == ModContent.ItemType<GoldFlask>() || item.type == ModContent.ItemType<ExtendedFreezeFlask>() || item.type == ModContent.ItemType<ExtendedBurningFlask>() ||
		//					item.type == ModContent.ItemType<ExtendedBoomFlask>() || item.type == ModContent.ItemType<HealthSupportFlask>() || item.type == ModContent.ItemType<ManaSupportFlask>() ||
		//					item.type == ModContent.ItemType<LesserVenomFlask>() || item.type == ModContent.ItemType<LesserPoisonFlask>() || item.type == ModContent.ItemType<LesserHealingFlack>() ||
		//					item.type == ModContent.ItemType<PlagueFlask>() || item.type == ModContent.ItemType<PhantomFlask>() || item.type == ModContent.ItemType<MoonDustFlask>() ||
		//					item.type == ModContent.ItemType<SparkingFlask>() || item.type == ModContent.ItemType<SuperManaFlask>() || item.type == ModContent.ItemType<SuperHealingFlask>() || item.type == ModContent.ItemType<NovaFlask>()) && Main.rand.NextFloat() < 0.45f)
		//		{
		//			return false;
		//		}
		//	}
		//	return base.ConsumeItem(item, player);
		//}
	}
}