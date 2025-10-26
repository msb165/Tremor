using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class VultureFeather:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 22;
			Item.height = 44;
			Item.value = 100;
			Item.rare = 2;
			Item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Vulture Feather");
			// Tooltip.SetDefault("15% increased movement speed");
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.moveSpeed += 0.15f;
			player.maxRunSpeed += 0.15f;
		}
	}
}
