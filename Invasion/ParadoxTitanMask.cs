using Terraria.ModLoader;

namespace Tremor.Invasion
{
	[AutoloadEquip(EquipType.Head)]
	public class ParadoxTitanMask:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 20;
			Item.height = 24;
			Item.rare = 1;
			Item.vanity = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Paradox Titan Mask");
			// Tooltip.SetDefault("");
		}

	}
}
