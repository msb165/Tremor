using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class ExtraterrestrialRubies:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.accessory = true;
			Item.width = 22;
			Item.height = 18;
			Item.value = 10000000;
			Item.rare = 11;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Extraterrestrial Rubies");
			/* Tooltip.SetDefault("Increases maximum life by 100\n" +
"Greatly increases life regeneration"); */
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.statLifeMax2 += 100;
			player.lifeRegen = +20;
		}

	}
}
