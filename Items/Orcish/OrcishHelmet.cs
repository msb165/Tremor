using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items.Orcish
{
	[AutoloadEquip(EquipType.Head)]
	public class OrcishHelmet:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 32;
			Item.height = 26;

			Item.value = 400;
			Item.rare = 1;
			Item.defense = 3;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Orcish Helmet");
			// Tooltip.SetDefault("7% increased melee damage");
		}

		public override void UpdateEquip(Player player)
		{
			player.GetDamage(DamageClass.Melee) += 0.07f;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<OrcishBreastplate>() && legs.type == ModContent.ItemType<OrcishGreaves>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Increased maximum defense by 2";
			player.statDefense += 2;
		}

	}
}
