using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Body)]
	public class JavaRobe:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 32;
			Item.height = 32;
			Item.value = 10000;
			Item.rare = 2;

			Item.vanity = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Java Robe");
			// Tooltip.SetDefault("");
		}

	}
}
