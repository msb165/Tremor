using Terraria.ModLoader;

namespace Tremor.Items.RedSteel
{
	public class ChippyRedSteelSword:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.width = 20;
			Item.height = 20;
			Item.maxStack = 99;
			Item.value = 50;
			Item.rare = 1;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Chippy Red Steel Sword");
			// Tooltip.SetDefault("");
		}
	}
}
