using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class SniperHelmet:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 26;
			Item.height = 26;

			Item.value = 1000000;
			Item.rare = 1;
			Item.defense = 36;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Sniper Helmet");
			/* Tooltip.SetDefault("15% increased ranged damage\n" +
"20% decreased movement speed"); */
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<SniperBreastplate>() && legs.type == ModContent.ItemType<SniperBoots>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Increases projectile's speed twice";
			player.moveSpeed += 0.15f;
			player.AddBuff(ModContent.BuffType<Buffs.ShootSpeedBuff>(), 2);
			player.scope = true;
		}

		public override void ArmorSetShadows(Player player)
		{
			player.armorEffectDrawShadow = true;
		}

		public override void UpdateEquip(Player player)
		{
			player.GetDamage(DamageClass.Ranged) *= 1.15f;
			player.moveSpeed -= 0.20f;
		}

	}
}
