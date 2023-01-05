using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class Stigmata:TremorModItem
	{

		public override void SetDefaults()
		{

			item.width = 24;
			item.height = 28;

			item.value = 20000;
			item.rare = 2;
			item.accessory = true;
			item.defense = 1;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Stigmata");
			Tooltip.SetDefault("The less health, the more damage...");
		}

		public override void UpdateAccessory(Player player, bool hideVisual)

		{
			if (player.statLife < 50)
			{
				player.GetDamage(DamageClass.Generic) += 0.20f;
			}
			if (player.statLife < 100)
			{
				player.GetDamage(DamageClass.Generic) += 0.15f;
			}
			if (player.statLife < 200)
			{
				player.GetDamage(DamageClass.Generic) += 0.10f;
			}
			if (player.statLife < 300)
			{
				player.GetDamage(DamageClass.Generic) += 0.05f;
			}
		}
	}
}
