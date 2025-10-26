using Terraria.ModLoader;

namespace Tremor.Items
{
	public class MeatChunk:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.rare = 3;
			Item.maxStack = 30;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Meat Chunk");
			// Tooltip.SetDefault("");
		}

	}
}
