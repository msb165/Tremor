using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class ChefHat:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 26;
			Item.height = 24;
			Item.rare = 1;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Chef Hat");
			// Tooltip.SetDefault("");
		}

	}
}
