using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class DimensionalTopHat:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 22;
			Item.height = 18;
			Item.value = 456600;
			Item.rare = 11;
			Item.defense = 12;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Dimensional Top Hat");
			/* Tooltip.SetDefault("Grants clairvoyance\n" +
"25% increased magic and minion damage\n" +
"Greatly increases mana regeneration"); */
		}

		public override void UpdateEquip(Player player)
		{
			player.GetDamage(DamageClass.Summon) += 0.25f;
			player.GetDamage(DamageClass.Magic) += 0.25f;
			player.AddBuff(29, 60, true);
			player.manaRegen += 25;
		}

	}
}
