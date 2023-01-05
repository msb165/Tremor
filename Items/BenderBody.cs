using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Body)]
	public class BenderBody:TremorModItem
	{
		public override void SetDefaults()
		{

			item.width = 26;
			item.height = 18;
			item.value = 10000;
			item.rare = 5;
			item.vanity = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bender Body");
			Tooltip.SetDefault("");
		}

	}
}
