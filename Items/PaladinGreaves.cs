using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Legs)]
	public class PaladinGreaves:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 22;
			Item.height = 18;
			Item.value = 500000;

			Item.rare = 10;
			Item.defense = 28;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Paladin Greaves");
			// Tooltip.SetDefault("22% increased melee damage");
		}

		public override void UpdateEquip(Player player)
		{
			player.GetDamage(DamageClass.Melee) += 0.22f;
		}
	}
}
