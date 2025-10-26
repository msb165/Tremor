using Terraria.ModLoader;

namespace Tremor.Items
{
	public class RavenFeather:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 18;
			Item.height = 18;
			Item.rare = 4;
			Item.maxStack = 999;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Raven Feather");
			// Tooltip.SetDefault("");
		}

	}
}
