using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class HeavyNecklace:TremorModItem
	{
		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 34;
			item.value = 100000;
			item.rare = 2;

			item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Heavy Necklace");
			Tooltip.SetDefault("5% increased damage");
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetDamage(DamageClass.Generic) += 0.05f;
		}
	}
}
