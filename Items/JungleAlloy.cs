using Terraria.ModLoader;

namespace Tremor.Items
{
	public class JungleAlloy:TremorModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Jungle Alloy");
			/* Tooltip.SetDefault("''Forge Master will be interested in this''\n" +
"Allows Forge Master to move in"); */
		}

		public override void SetDefaults()
		{
			Item.width = 28;
			Item.height = 30;
			Item.maxStack = 99;
			Item.value = 2500;
			Item.rare = 3;
		}

	}
}
