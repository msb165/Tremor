using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class BenderHead:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 32;
			Item.height = 26;
			Item.value = 10000;
			Item.rare = 5;
			Item.vanity = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Bender Head");
			// Tooltip.SetDefault("");
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<BenderBody>() && legs.type == ModContent.ItemType<BenderLegs>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "'Bite my shiny metal ass!'";
		}
	}
}
