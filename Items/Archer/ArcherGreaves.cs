using Terraria.ModLoader;

namespace Tremor.Items.Archer
{
	[AutoloadEquip(EquipType.Legs)]
	public class ArcherGreaves:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 22;
			Item.height = 18;
			Item.value = 1000;
			Item.rare = 2;
			Item.vanity = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Archer Greaves");
			// Tooltip.SetDefault("");
		}

	}
}
