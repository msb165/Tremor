using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items.Sandstone
{
	public class SandstoneRing:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 28;
			Item.height = 20;
			Item.value = 10000;

			Item.rare = 1;
			Item.accessory = true;
			Item.defense = 3;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Sandstone Ring ");
			/* Tooltip.SetDefault("5% increased melee damage\n" +
"Increases melee critical strike chance by 5"); */
		}

		public override void UpdateAccessory(Player player, bool hideVisual)

		{
			player.GetDamage(DamageClass.Melee) += 0.05f;
			player.GetCritChance(DamageClass.Melee) += 5;
		}
	}
}
