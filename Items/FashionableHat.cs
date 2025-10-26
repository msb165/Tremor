using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class FashionableHat:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 30;
			Item.height = 22;
			Item.value = 80000;
			Item.rare = 11;
			Item.vanity = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Fashionable Hat");
			// Tooltip.SetDefault("");
		}

	}
}
