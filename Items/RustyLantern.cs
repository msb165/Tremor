using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.NPCs;

namespace Tremor.Items
{
	public class RustyLantern:TremorModItem
	{

		const int XOffset = -400;
		const int YOffset = -400;

		public override void SetDefaults()
		{
			Item.width = 14;
			Item.height = 30;
			Item.maxStack = 1;

			Item.value = 3000;
			Item.rare = 2;
			Item.useTime = 40;
			Item.useAnimation = 40;
			Item.consumable = true;
			Item.maxStack = 20;
			Item.useStyle = 1;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Rusty Lantern");
			/* Tooltip.SetDefault("Summons Ancient Dragon\n" +
"Requires the Ruin Powers buff and a Ruin Altar nearby"); */
		}

		public override bool CanUseItem(Player player)
		{
			TremorPlayer modPlayer = player.GetModPlayer<TremorPlayer>();
			return modPlayer.ruinAltar && !NPC.AnyNPCs(ModContent.NPCType<Dragon_HeadB>());
		}

		public override bool? UseItem(Player player)
		{
			Main.NewText("Ancient Dragon has awoken!", 175, 75, 255);
			Terraria.Audio.SoundEngine.PlaySound(SoundID.SoundByIndex[15], player.position);//Variant 0
			//if(Main.netMode !=1)
			//{
			NPC.NewNPC(null, (int)player.Center.X + XOffset, (int)player.Center.Y + YOffset, Mod.NPCType(""), 0, NPC.NewNPC(null, (int)player.Center.X + XOffset, (int)player.Center.Y + YOffset, ModContent.NPCType<Dragon_HeadB>()));
			//}
			return true;
		}
	}
}
