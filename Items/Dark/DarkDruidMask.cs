using Terraria.ModLoader;

namespace Tremor.Items.Dark
{
	[AutoloadEquip(EquipType.Head)]
	public class DarkDruidMask:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 36;
			Item.height = 26;
			Item.value = 2500;
			Item.rare = 1;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Dark Druid Mask");
			// Tooltip.SetDefault("");
		}

	}
}
