using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class ChaoticAmplifier:TremorModItem
	{

		public override void SetDefaults()
		{

			item.width = 24;
			item.height = 28;

			item.value = 120000;
			item.rare = 5;
			item.accessory = true;
			item.defense = 1;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Chaotic Amplifier");
			Tooltip.SetDefault("The less health, the more crit chance...");
		}

		public override void UpdateAccessory(Player player, bool hideVisual)

		{
			if (player.statLife < 50)
			{
				player.GetCritChance(DamageClass.Generic) += 20;
			}
			if (player.statLife < 100)
			{
				player.GetCritChance(DamageClass.Generic) += 15;
			}
			if (player.statLife < 200)
			{
				player.GetCritChance(DamageClass.Generic) += 10;
			}
			if (player.statLife < 300)
			{
				player.GetCritChance(DamageClass.Generic) += 5;
			}
		}
	}
}
