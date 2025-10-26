using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class EnchantedHelmet:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 24;
			Item.height = 24;

			Item.value = 10000;
			Item.rare = 2;
			Item.defense = 5;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Enchanted Helmet");
			/* Tooltip.SetDefault("Increases maximum mana by 20\n" +
"Increases maximum health by 15"); */
		}

		public override void UpdateEquip(Player player)
		{
			player.statManaMax2 += 20;
			player.statLifeMax2 += 15;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<EnchantedBreastplate>() && legs.type == ModContent.ItemType<EnchantedGreaves>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "8% increased magic damage, increases power of enchanted weapons";
			player.GetDamage(DamageClass.Magic) += 0.08f;
			player.AddBuff(ModContent.BuffType<Buffs.EnchantedBuff>(), 2);
		}

	}
}
