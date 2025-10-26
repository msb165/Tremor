using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Dark
{
	public class DarkMass:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 20;
			Item.height = 20;
			Item.value = 100000;
			Item.rare = 11;
			Item.maxStack = 99;
			ItemID.Sets.ItemNoGravity[Item.type] = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Dark Mass");
			// Tooltip.SetDefault("");
		}

	}
}
