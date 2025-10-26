using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Souls
{
	public class PhantomSoul:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 32;
			Item.height = 58;
			Item.maxStack = 99;
			Item.value = 100;
			Item.rare = 2;
			ItemID.Sets.ItemNoGravity[Item.type] = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Phantom Soul");
			// Tooltip.SetDefault("");
			Main.RegisterItemAnimation(Item.type, new DrawAnimationVertical(10, 4));
		}

	}
}
