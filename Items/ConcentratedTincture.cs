using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class ConcentratedTincture:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 22;
			Item.height = 44;

			Item.value = 450000;
			Item.rare = 5;
			Item.accessory = true;
			Item.defense = 1;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Concentrated Tincture");
			// Tooltip.SetDefault("Increases life regeneration from healing flasks");
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.AddBuff(ModContent.BuffType<Buffs.ConcentratedTinctureBuff>(), 2);
		}
	}
}
