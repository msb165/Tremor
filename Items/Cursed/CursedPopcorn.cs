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

			Item.width = 26;
			Item.height = 34;
			Item.maxStack = 20;

			Item.rare = 2;
			Item.value = 50000;
			Item.useAnimation = 45;
			Item.useTime = 45;
			Item.useStyle = 4;
			Item.consumable = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Cursed Popcorn");
			/* Tooltip.SetDefault("Summons the Evil Corn\n" +
"Requires night time"); */
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
