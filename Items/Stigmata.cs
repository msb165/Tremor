using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class Stigmata:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 24;
			Item.height = 28;

			Item.value = 20000;
			Item.rare = 2;
			Item.accessory = true;
			Item.defense = 1;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Stigmata");
			// Tooltip.SetDefault("The less health, the more damage...");
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
