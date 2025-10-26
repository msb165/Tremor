using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class JavaHood:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 30;
			Item.height = 28;

			Item.value = 10000;
			Item.rare = 2;
			Item.vanity = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Java Hood");
			// Tooltip.SetDefault("");
		}

	}
}
