using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class TwilightHorns:TremorModItem
	{

		public override void SetDefaults()
		{

			item.width = 24;
			item.height = 28;
			item.value = 125000;

			item.rare = 1;
			item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Twilight Horns");
			Tooltip.SetDefault("You gain more power during night");
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
