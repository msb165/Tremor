using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{

	public class SpiderMeat:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 20;
			Item.height = 30;
			Item.maxStack = 20;

			Item.rare = 1;
			Item.useAnimation = 15;
			Item.useTime = 15;
			Item.useStyle = 2;
			Item.UseSound = SoundID.Item2;
			Item.consumable = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Spider Meat");
			// Tooltip.SetDefault("'I don't see anything wrong with it, eat it!'");
		}

		public override bool? UseItem(Player player)
		{
			player.AddBuff(22, 10000, true);
			player.AddBuff(32, 10000, true);
			player.AddBuff(31, 10000, true);
			return true;
		}
	}
}
