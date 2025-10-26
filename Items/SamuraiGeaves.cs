using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Legs)]
	public class SamuraiGeaves:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 22;
			Item.height = 18;

			Item.value = 100000;
			Item.rare = 5;
			Item.defense = 11;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Samurai Legguards");
			// Tooltip.SetDefault("50% increased movement speed");
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed += 0.5f;
			player.maxRunSpeed += 0.5f;
		}
	}
}
