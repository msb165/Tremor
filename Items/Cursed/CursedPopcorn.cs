using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.NPCs;

namespace Tremor.Items.Cursed
{

	public class CursedPopcorn:TremorModItem
	{

		public override void SetDefaults()
		{

			item.width = 26;
			item.height = 34;
			item.maxStack = 20;

			item.rare = 2;
			item.value = 50000;
			item.useAnimation = 45;
			item.useTime = 45;
			item.useStyle = 4;
			item.consumable = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cursed Popcorn");
			Tooltip.SetDefault("Summons the Evil Corn\n" +
"Requires night time");
		}

		public override bool CanUseItem(Player player)
		{
			return !Main.dayTime && !NPC.AnyNPCs(ModContent.NPCType<EvilCorn>());
		}

		public override bool? UseItem(Player player)
		{
			NPC.SpawnOnPlayer(player.whoAmI, ModContent.NPCType<EvilCorn>());
			Terraria.Audio.SoundEngine.PlaySound(SoundID.Roar, player.position);//Variant 0
			return true;
		}
	}
}
