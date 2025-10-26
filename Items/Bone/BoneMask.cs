using Terraria.ModLoader;

namespace Tremor.Items.Bone
{
	[AutoloadEquip(EquipType.Head)]
	public class BoneMask:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 26;
			Item.height = 24;
			Item.rare = 2;
			Item.vanity = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Bone Mask");
			// Tooltip.SetDefault("");
		}

	}
}
