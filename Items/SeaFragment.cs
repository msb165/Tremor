using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class SeaFragment:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 30;
			Item.height = 24;
			Item.maxStack = 99;
			Item.value = 100;
			Item.rare = 1;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Sea Fragment");
			// Tooltip.SetDefault("");
			Main.RegisterItemAnimation(Item.type, new DrawAnimationVertical(8, 4));
		}

	}
}
