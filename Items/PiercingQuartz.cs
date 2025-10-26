using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class PiercingQuartz:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 22;
			Item.height = 44;

			Item.value = 100;
			Item.rare = 4;
			Item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Piercing Quartz");
			// Tooltip.SetDefault("5% increased critical strike chance");
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetCritChance(DamageClass.Generic) += 5;
		}
	}
}
