using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class SamuraiHead:TremorModItem
	{

		public override bool AltFunctionUse(Player player)
		{
			return true;
		}

		public override void SetDefaults()
		{

			item.width = 20;
			item.height = 20;
			item.value = 100000;
			item.rare = 5;

			item.defense = 10;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Samurai Helmet");
			Tooltip.SetDefault("9% increased damage");
		}

		public override void UpdateEquip(Player player)
		{
			player.GetDamage(DamageClass.Generic) += 0.09f;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<SamuraiChestplate>() && legs.type == ModContent.ItemType<SamuraiGeaves>();
		}
		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Greatly increased life regeneration!";
			player.crimsonRegen = true;

		}

	}
}
