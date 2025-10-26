using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class FurHat:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 20;
			Item.height = 22;
			Item.value = 10000;
			Item.rare = 2;
			Item.vanity = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Fur Hat");
			// Tooltip.SetDefault("");
		}

	}
}
