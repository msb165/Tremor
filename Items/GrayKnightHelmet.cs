using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class GrayKnightHelmet:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 18;
			Item.height = 22;

			Item.value = 10000;
			Item.rare = 2;
			Item.vanity = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Gray Knight Helmet");
			// Tooltip.SetDefault("Can be colored with gems");
		}

	}
}
