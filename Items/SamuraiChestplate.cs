using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Body)]
	public class SamuraiChestplate:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 30;
			Item.height = 18;

			Item.value = 100000;
			Item.rare = 5;
			Item.defense = 14;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Samurai Fullplate");
			// Tooltip.SetDefault("25% increased melee speed");
		}

		public override void UpdateEquip(Player player)
		{
			player.GetAttackSpeed(DamageClass.Melee) += 0.25f;
		}
	}
}
