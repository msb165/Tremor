using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class PurpleShelmet:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 18;
			Item.height = 22;
			Item.value = 5000;
			Item.rare = 2;
			Item.defense = 6;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Purple Shelmet");
			// Tooltip.SetDefault("");
		}

	}
}
