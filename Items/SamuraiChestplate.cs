using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Body)]
	public class SamuraiChestplate:TremorModItem
	{

		public override void SetDefaults()
		{

			item.width = 30;
			item.height = 18;

			item.value = 100000;
			item.rare = 5;
			item.defense = 14;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Samurai Fullplate");
			Tooltip.SetDefault("25% increased melee speed");
		}

		public override void UpdateEquip(Player player)
		{
			player.GetAttackSpeed(DamageClass.Melee) += 0.25f;
		}
	}
}
