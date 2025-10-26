using Terraria.ModLoader;

namespace Tremor.Items
{
	public class TearsofDeath:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 40;
			Item.height = 28;
			Item.maxStack = 99;

			Item.value = 100;
			Item.rare = 3;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Tears of Death");
			// Tooltip.SetDefault("Unstable ingredient");
		}

	}
}
