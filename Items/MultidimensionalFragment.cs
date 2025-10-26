using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class MultidimensionalFragment:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 22;
			Item.height = 22;
			Item.rare = 11;
			Item.maxStack = 999;
			ItemID.Sets.ItemNoGravity[Item.type] = true;
			ItemID.Sets.ItemIconPulse[Item.type] = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Multidimensional Fragment");
			// Tooltip.SetDefault("");
			Main.RegisterItemAnimation(Item.type, new DrawAnimationVertical(6, 12));
		}

	}
}
