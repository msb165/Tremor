using Terraria.ModLoader;

namespace Tremor.Items.Brass
{
	public class BrassNugget:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 16;
			Item.height = 16;
			Item.maxStack = 99;
			Item.value = 300;
			Item.rare = 5;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Brass Nugget");
			// Tooltip.SetDefault("");
		}

	}
}
