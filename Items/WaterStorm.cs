using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Tremor.Items
{
	public class WaterStorm:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 22;
			Item.height = 44;

			Item.value = 15000;
			Item.rare = ItemRarityID.Orange;
			Item.defense = 3;
			Item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Water Storm");
			/* Tooltip.SetDefault("10% increased magic critical strike chance\n" +
"Increases maximum mana by 40"); */
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.statManaMax2 += 40;
			player.GetCritChance(DamageClass.Magic) += 10;
		}

	}
}
