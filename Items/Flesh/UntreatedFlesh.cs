using Terraria.ModLoader;

namespace Tremor.Items.Flesh
{
	public class UntreatedFlesh:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 22;
			Item.height = 22;
			Item.maxStack = 99;
			Item.value = 80;
			Item.rare = 1;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Untreated Flesh");
			// Tooltip.SetDefault("");
		}

	}
}
