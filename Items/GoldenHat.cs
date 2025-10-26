using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class GoldenHat:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 26;
			Item.height = 22;

			Item.value = 30000;
			Item.rare = 2;
			Item.defense = 3;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Golden Hat");
			/* Tooltip.SetDefault("5% decreased magic damage\n" +
"6% increased magic critical strike chance"); */
		}

		public override void UpdateEquip(Player player)
		{
			player.GetDamage(DamageClass.Magic) -= 0.05f;
			player.GetCritChance(DamageClass.Magic) += 6;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<GoldenRobe>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Increases maximum mana by 40";
			player.statManaMax2 += 40;
		}

		public override void ArmorSetShadows(Player player)
		{
			player.armorEffectDrawOutlines = true;
		}

	}
}
