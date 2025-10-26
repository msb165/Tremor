using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Body)]
	public class PossessedChestplate:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 30;
			Item.height = 18;
			Item.value = 100;
			Item.rare = 1;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Possessed Chestplate");
			// Tooltip.SetDefault("");
		}

	}
}
