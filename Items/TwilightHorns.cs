using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class TwilightHorns:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 24;
			Item.height = 28;
			Item.value = 125000;

			Item.rare = 1;
			Item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Twilight Horns");
			// Tooltip.SetDefault("You gain more power during night");
		}

		public override void UpdateAccessory(Player player, bool hideVisual)

		{
			if (!Main.dayTime)
			{
				player.GetDamage(DamageClass.Generic) += 0.1f;
			}
		}
	}
}
