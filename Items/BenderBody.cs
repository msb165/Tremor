using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Body)]
	public class BenderBody:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 26;
			Item.height = 18;
			Item.value = 10000;
			Item.rare = 5;
			Item.vanity = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Bender Body");
			// Tooltip.SetDefault("");
		}

	}
}
