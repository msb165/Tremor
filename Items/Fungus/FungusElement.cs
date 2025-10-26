using Terraria.ModLoader;

namespace Tremor.Items.Fungus
{
	public class FungusElement:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 14;
			Item.height = 22;
			Item.rare = 3;
			Item.maxStack = 999;
			Item.value = 100;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Fungus Element");
			// Tooltip.SetDefault("");
		}

	}
}
