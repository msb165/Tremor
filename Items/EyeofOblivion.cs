using Terraria.ModLoader;

namespace Tremor.Items
{
	public class EyeofOblivion:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 30;
			Item.height = 24;
			Item.maxStack = 99;
			Item.value = 16000;
			Item.rare = 11;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Eye of Oblivion");
			// Tooltip.SetDefault("");
		}

	}
}
