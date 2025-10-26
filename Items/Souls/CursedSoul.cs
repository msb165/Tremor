using Terraria.ModLoader;

namespace Tremor.Items.Souls
{
	public class CursedSoul:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 40;
			Item.height = 28;
			Item.maxStack = 99;
			Item.value = 1000;
			Item.rare = 4;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Cursed Soul");
			// Tooltip.SetDefault("");
		}

	}
}
