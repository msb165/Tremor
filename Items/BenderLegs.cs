using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Legs)]
	public class BenderLegs:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 22;
			Item.height = 18;
			Item.value = 10000;
			Item.rare = 5;
			Item.vanity = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Bender Legs");
			// Tooltip.SetDefault("");
		}

	}
}
