using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class HazardousChemicals:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.width = 22;
			Item.height = 44;

			Item.value = 10000;
			Item.rare = 3;
			Item.maxStack = 1;
			Item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Hazardous Chemicals");
			// Tooltip.SetDefault("5% increased alchemical damage");
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetModPlayer<MPlayer>().alchemicalDamage += 0.05f;
		}
	}
}
