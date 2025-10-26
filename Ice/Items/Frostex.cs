using Terraria;
using Terraria.ModLoader;

namespace Tremor.Ice.Items
{
	public class Frostex:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 38;
			Item.height = 22;

			Item.value = 12000;
			Item.rare = 1;
			Item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Frostex");
			// Tooltip.SetDefault("10% increased melee and ranged damage");
		}

		public override void UpdateEquip(Player player)
		{
			player.GetDamage(DamageClass.Melee) += 0.1f;
			player.GetDamage(DamageClass.Ranged) += 0.1f;
		}
	}
}
