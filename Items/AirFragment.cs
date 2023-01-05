using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class AirFragment:TremorModItem
	{
		public override void SetDefaults()
		{

			item.width = 30;
			item.height = 24;
			item.maxStack = 99;
			item.value = 100;
			item.rare = 1;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Air Fragment");
			Tooltip.SetDefault("");
			Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(8, 4));
		}
	}
}
