using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class HummerHelmet:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 24;

			Item.height = 26;
			Item.rare = 9;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Hummer's Helmet");
			// Tooltip.SetDefault("'Great for impersonating devs!'");
		}

	}
}
