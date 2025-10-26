using Terraria.ModLoader;

namespace Tremor.Items.Fungus
{
	[AutoloadEquip(EquipType.Head)]
	public class FungusBeetleMask:TremorModItem
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
			// DisplayName.SetDefault("Fungus Beetle Mask");
			// Tooltip.SetDefault("");
		}

	}
}
