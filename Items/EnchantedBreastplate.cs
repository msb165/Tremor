using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Body)]
	public class EnchantedBreastplate:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 30;
			Item.height = 20;
			Item.value = 10000;

			Item.rare = 2;
			Item.defense = 7;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Enchanted Breastplate");
			/* Tooltip.SetDefault("Increases maximum mana by 20\n" +
"Increases maximum health by 20"); */
		}

		public override void UpdateEquip(Player player)
		{
			player.statManaMax2 += 20;
			player.statLifeMax2 += 20;
		}
	}
}
