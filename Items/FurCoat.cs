using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Body)]
	public class FurCoat:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 30;
			Item.height = 34;
			Item.value = 600;
			Item.rare = 1;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Fur Coat");
			// Tooltip.SetDefault("");
		}

	}
}
