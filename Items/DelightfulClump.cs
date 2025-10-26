using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class DelightfulClump:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.accessory = true;
			Item.width = 22;
			Item.height = 18;
			Item.value = 250000;
			Item.rare = 11;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Delightful Clump");
			/* Tooltip.SetDefault("Increases maximum life by 100\n" +
"15% increased critical strike chance"); */
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.statLifeMax2 += 100;
			player.GetCritChance(DamageClass.Generic) += 5;
		}

	}
}
