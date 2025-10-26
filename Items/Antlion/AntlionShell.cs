using Terraria.ModLoader;

namespace Tremor.Items.Antlion
{
	public class AntlionShell:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 30;
			Item.height = 24;
			Item.maxStack = 99;
			Item.value = 100;
			Item.rare = 2;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Antlion Shell");
			// Tooltip.SetDefault("");
		}

	}
}
