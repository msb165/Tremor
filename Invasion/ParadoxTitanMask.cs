using Terraria.ModLoader;

namespace Tremor.Invasion
{
	[AutoloadEquip(EquipType.Head)]
	public class ParadoxTitanMask:TremorModItem
	{
		public override void SetDefaults()
		{

			item.width = 20;
			item.height = 24;
			item.rare = 1;
			item.vanity = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Paradox Titan Mask");
			Tooltip.SetDefault("");
		}

	}
}
