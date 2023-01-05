using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class PurpleShelmet:TremorModItem
	{

		public override void SetDefaults()
		{

			item.width = 18;
			item.height = 22;
			item.value = 5000;
			item.rare = 2;
			item.defense = 6;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Purple Shelmet");
			Tooltip.SetDefault("");
		}

	}
}
