using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace Tremor.Items.Sparks
{
	public class AdventurerSpark:TremorModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Adventurer Spark");
			// Tooltip.SetDefault("Can be enchanted only once!");
			Main.RegisterItemAnimation(Item.type, new DrawAnimationVertical(5, 4));
		}

		public override void SetDefaults()
		{
			Item.width = 22;
			Item.height = 22;
			Item.rare = 1;
			Item.value = Item.buyPrice(silver: 1);
		}
	}
}
