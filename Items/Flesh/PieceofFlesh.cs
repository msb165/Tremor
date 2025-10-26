using Terraria.ModLoader;

namespace Tremor.Items.Flesh
{
	public class PieceofFlesh:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 30;
			Item.height = 24;
			Item.maxStack = 99;
			Item.value = 100;
			Item.rare = 4;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Piece of Flesh");
			// Tooltip.SetDefault("");
		}

	}
}
