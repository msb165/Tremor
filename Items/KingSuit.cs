using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Body)]
	public class KingSuit:TremorModItem
	{

		public override void SetDefaults()
		{

			item.width = 30;
			item.height = 20;
			item.value = 20000;
			item.rare = 2;

			item.vanity = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("King Suit");
			Tooltip.SetDefault("");
		}

	}
}
