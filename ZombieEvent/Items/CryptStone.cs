using Terraria.ModLoader;

namespace Tremor.ZombieEvent.Items
{
	public class CryptStone:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 16;
			Item.height = 16;
			Item.maxStack = 99;
			Item.rare = 5;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Crypt Stone");
			// Tooltip.SetDefault("");
		}
	}
}
