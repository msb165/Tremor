using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Body)]
	public class PaladinBreastplate:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 26;
			Item.height = 18;

			Item.value = 600000;
			Item.rare = 10;
			Item.defense = 32;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Paladin Breastplate");
			// Tooltip.SetDefault("25% increased melee critical strike chance");
		}

		public override void UpdateEquip(Player player)
		{
			player.GetCritChance(DamageClass.Melee) += 25;
		}
	}
}
