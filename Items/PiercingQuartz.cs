using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class PiercingQuartz:TremorModItem
	{
		public override void SetDefaults()
		{

			item.width = 22;
			item.height = 44;

			item.value = 100;
			item.rare = 4;
			item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Piercing Quartz");
			Tooltip.SetDefault("5% increased critical strike chance");
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetCritChance(DamageClass.Generic) += 5;
		}
	}
}
