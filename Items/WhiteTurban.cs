using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class WhiteTurban:TremorModItem
	{

		public override void SetDefaults()
		{

			item.width = 30;
			item.height = 28;

			item.value = 10000;
			item.rare = 2;
			item.vanity = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("White Turban");
			Tooltip.SetDefault("");
		}

	}
}
