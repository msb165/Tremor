using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class BlackCauldron:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 22;
			Item.height = 44;

			Item.value = 100000;
			Item.rare = 4;
			Item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Black Cauldron");
			/* Tooltip.SetDefault("Increased alchemical damage by 12%\n" +
"Alchemical weapons confuse your enemies"); */
			Main.RegisterItemAnimation(Item.type, new DrawAnimationVertical(8, 4));
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetModPlayer<MPlayer>().alchemicalDamage += 0.12f;
			player.AddBuff(ModContent.BuffType<Buffs.CursedCloudBuff>(), 2);
		}
	}
}
