using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class IceQueenMask:TremorModItem
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
			// DisplayName.SetDefault("Ice Queen Mask");
			// Tooltip.SetDefault("");
		}

	}
}
