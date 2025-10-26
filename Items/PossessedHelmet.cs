using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class PossessedHelmet:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 20;
			Item.height = 18;
			Item.value = 100;
			Item.rare = 1;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Possessed Helmet");
			// Tooltip.SetDefault("");
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<PossessedChestplate>() && legs.type == ModContent.ItemType<PossessedGreaves>();
		}
	}
}
