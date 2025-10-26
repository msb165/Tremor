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
		//			if((Item.type == ModContent.ItemType<LesserManaFlask>() || Item.type == ModContent.ItemType<BurningFlask>() || Item.type == ModContent.ItemType<BoomFlask>() || Item.type == ModContent.ItemType<BigVenomFlask>() || Item.type == ModContent.ItemType<BigPoisonFlask>() || Item.type == ModContent.ItemType<BigManaFlask>() ||
		//						Item.type == ModContent.ItemType<BigHealingFlack>() || Item.type == ModContent.ItemType<BasicFlask>() || Item.type == ModContent.ItemType<FreezeFlask>() ||
		//						/*Item.type == ModContent.ItemType<DepressionFlask>() ||*/ Item.type == ModContent.ItemType<CrystalFlask>() || Item.type == ModContent.ItemType<ClusterFlask>() ||
		//						Item.type == ModContent.ItemType<GoldFlask>() || Item.type == ModContent.ItemType<ExtendedFreezeFlask>() || Item.type == ModContent.ItemType<ExtendedBurningFlask>() ||
		//						Item.type == ModContent.ItemType<ExtendedBoomFlask>() || Item.type == ModContent.ItemType<HealthSupportFlask>() || Item.type == ModContent.ItemType<ManaSupportFlask>() ||
		//						Item.type == ModContent.ItemType<LesserVenomFlask>() || Item.type == ModContent.ItemType<LesserPoisonFlask>() || Item.type == ModContent.ItemType<LesserHealingFlack>() ||
		//						Item.type == ModContent.ItemType<PlagueFlask>() || Item.type == ModContent.ItemType<PhantomFlask>() || Item.type == ModContent.ItemType<MoonDustFlask>() ||
		//						Item.type == ModContent.ItemType<SparkingFlask>() || Item.type == ModContent.ItemType<SuperManaFlask>() || Item.type == ModContent.ItemType<SuperHealingFlask>() || Item.type == ModContent.ItemType<NovaFlask>()) && Main.rand.NextFloat() < 0.65f)
		//			{
		//				return false;
		//			}
		//		}
		//		if(player.FindBuffIndex(ModContent.BuffType<SuperFlaskBig>()) != -1)
		//		{
		//			if((Item.type == ModContent.ItemType<LesserManaFlask>() || Item.type == ModContent.ItemType<BurningFlask>() || Item.type == ModContent.ItemType<BoomFlask>() || Item.type == ModContent.ItemType<BigVenomFlask>() || Item.type == ModContent.ItemType<BigPoisonFlask>() || Item.type == ModContent.ItemType<BigManaFlask>() ||
		//						Item.type == ModContent.ItemType<BigHealingFlack>() || Item.type == ModContent.ItemType<BasicFlask>() || Item.type == ModContent.ItemType<FreezeFlask>() ||
		//						/*Item.type == ModContent.ItemType<DepressionFlask>() ||*/ Item.type == ModContent.ItemType<CrystalFlask>() || Item.type == ModContent.ItemType<ClusterFlask>() ||
		//						Item.type == ModContent.ItemType<GoldFlask>() || Item.type == ModContent.ItemType<ExtendedFreezeFlask>() || Item.type == ModContent.ItemType<ExtendedBurningFlask>() ||
		//						Item.type == ModContent.ItemType<ExtendedBoomFlask>() || Item.type == ModContent.ItemType<HealthSupportFlask>() || Item.type == ModContent.ItemType<ManaSupportFlask>() ||
		//						Item.type == ModContent.ItemType<LesserVenomFlask>() || Item.type == ModContent.ItemType<LesserPoisonFlask>() || Item.type == ModContent.ItemType<LesserHealingFlack>() ||
		//						Item.type == ModContent.ItemType<PlagueFlask>() || Item.type == ModContent.ItemType<PhantomFlask>() || Item.type == ModContent.ItemType<MoonDustFlask>() ||
		//						Item.type == ModContent.ItemType<SparkingFlask>() || Item.type == ModContent.ItemType<SuperManaFlask>() || Item.type == ModContent.ItemType<SuperHealingFlask>() || Item.type == ModContent.ItemType<NovaFlask>()) && Main.rand.NextFloat() < 0.85f)
		//			{
		//				return false;
		//			}
		//		}
		//		if(player.FindBuffIndex(ModContent.BuffType<SuperFlaskBig>()) < 1 && player.FindBuffIndex(ModContent.BuffType<SuperFlaskBig>()) < 1)
		//		{
		//			if((Item.type == ModContent.ItemType<LesserManaFlask>() || Item.type == ModContent.ItemType<BurningFlask>() || Item.type == ModContent.ItemType<BoomFlask>() || Item.type == ModContent.ItemType<BigVenomFlask>() || Item.type == ModContent.ItemType<BigPoisonFlask>() || Item.type == ModContent.ItemType<BigManaFlask>() ||
		//						Item.type == ModContent.ItemType<BigHealingFlack>() || Item.type == ModContent.ItemType<BasicFlask>() || Item.type == ModContent.ItemType<FreezeFlask>() ||
		//						/*Item.type == ModContent.ItemType<DepressionFlask>() ||*/ Item.type == ModContent.ItemType<CrystalFlask>() || Item.type == ModContent.ItemType<ClusterFlask>() ||
		//						Item.type == ModContent.ItemType<GoldFlask>() || Item.type == ModContent.ItemType<ExtendedFreezeFlask>() || Item.type == ModContent.ItemType<ExtendedBurningFlask>() ||
		//						Item.type == ModContent.ItemType<ExtendedBoomFlask>() || Item.type == ModContent.ItemType<HealthSupportFlask>() || Item.type == ModContent.ItemType<ManaSupportFlask>() ||
		//						Item.type == ModContent.ItemType<LesserVenomFlask>() || Item.type == ModContent.ItemType<LesserPoisonFlask>() || Item.type == ModContent.ItemType<LesserHealingFlack>() ||
		//						Item.type == ModContent.ItemType<PlagueFlask>() || Item.type == ModContent.ItemType<PhantomFlask>() || Item.type == ModContent.ItemType<MoonDustFlask>() ||
		//						Item.type == ModContent.ItemType<SparkingFlask>() || Item.type == ModContent.ItemType<SuperManaFlask>() || Item.type == ModContent.ItemType<SuperHealingFlask>() || Item.type == ModContent.ItemType<NovaFlask>()) && Main.rand.NextFloat() < 0.4f)
		//			{
		//				return false;
		//			}
		//		}
		//	}
		//	if(player.FindBuffIndex(ModContent.BuffType<SuperFlask>()) != -1)
		//	{
		//		if((Item.type == ModContent.ItemType<LesserManaFlask>() || Item.type == ModContent.ItemType<BurningFlask>() || Item.type == ModContent.ItemType<BoomFlask>() || Item.type == ModContent.ItemType<BigVenomFlask>() || Item.type == ModContent.ItemType<BigPoisonFlask>() || Item.type == ModContent.ItemType<BigManaFlask>() ||
		//					Item.type == ModContent.ItemType<BigHealingFlack>() || Item.type == ModContent.ItemType<BasicFlask>() || Item.type == ModContent.ItemType<FreezeFlask>() ||
		//					/*Item.type == ModContent.ItemType<DepressionFlask>() ||*/ Item.type == ModContent.ItemType<CrystalFlask>() || Item.type == ModContent.ItemType<ClusterFlask>() ||
		//					Item.type == ModContent.ItemType<GoldFlask>() || Item.type == ModContent.ItemType<ExtendedFreezeFlask>() || Item.type == ModContent.ItemType<ExtendedBurningFlask>() ||
		//					Item.type == ModContent.ItemType<ExtendedBoomFlask>() || Item.type == ModContent.ItemType<HealthSupportFlask>() || Item.type == ModContent.ItemType<ManaSupportFlask>() ||
		//					Item.type == ModContent.ItemType<LesserVenomFlask>() || Item.type == ModContent.ItemType<LesserPoisonFlask>() || Item.type == ModContent.ItemType<LesserHealingFlack>() ||
		//					Item.type == ModContent.ItemType<PlagueFlask>() || Item.type == ModContent.ItemType<PhantomFlask>() || Item.type == ModContent.ItemType<MoonDustFlask>() ||
		//					Item.type == ModContent.ItemType<SparkingFlask>() || Item.type == ModContent.ItemType<SuperManaFlask>() || Item.type == ModContent.ItemType<SuperHealingFlask>() || Item.type == ModContent.ItemType<NovaFlask>()) && Main.rand.NextFloat() < 0.25f)
		//		{
		//			return false;
		//		}
		//	}
		//	if(player.FindBuffIndex(ModContent.BuffType<SuperFlaskBig>()) != -1 && modPlayer.novaAura)
		//	{
		//		if((Item.type == ModContent.ItemType<LesserManaFlask>() || Item.type == ModContent.ItemType<BurningFlask>() || Item.type == ModContent.ItemType<BoomFlask>() || Item.type == ModContent.ItemType<BigVenomFlask>() || Item.type == ModContent.ItemType<BigPoisonFlask>() || Item.type == ModContent.ItemType<BigManaFlask>() ||
		//					Item.type == ModContent.ItemType<BigHealingFlack>() || Item.type == ModContent.ItemType<BasicFlask>() || Item.type == ModContent.ItemType<FreezeFlask>() ||
		//					/*Item.type == ModContent.ItemType<DepressionFlask>() ||*/ Item.type == ModContent.ItemType<CrystalFlask>() || Item.type == ModContent.ItemType<ClusterFlask>() ||
		//					Item.type == ModContent.ItemType<GoldFlask>() || Item.type == ModContent.ItemType<ExtendedFreezeFlask>() || Item.type == ModContent.ItemType<ExtendedBurningFlask>() ||
		//					Item.type == ModContent.ItemType<ExtendedBoomFlask>() || Item.type == ModContent.ItemType<HealthSupportFlask>() || Item.type == ModContent.ItemType<ManaSupportFlask>() ||
		//					Item.type == ModContent.ItemType<LesserVenomFlask>() || Item.type == ModContent.ItemType<LesserPoisonFlask>() || Item.type == ModContent.ItemType<LesserHealingFlack>() ||
		//					Item.type == ModContent.ItemType<PlagueFlask>() || Item.type == ModContent.ItemType<PhantomFlask>() || Item.type == ModContent.ItemType<MoonDustFlask>() ||
		//					Item.type == ModContent.ItemType<SparkingFlask>() || Item.type == ModContent.ItemType<SuperManaFlask>() || Item.type == ModContent.ItemType<SuperHealingFlask>() || Item.type == ModContent.ItemType<NovaFlask>()) && Main.rand.NextFloat() < 0.45f)
		//		{
		//			return false;
		//		}
		//	}
		//	return base.ConsumeItem(item, player);
		//}
	}
}