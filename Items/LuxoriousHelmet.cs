using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class LuxoriousHelmet:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.defense = 15;
			Item.width = 26;
			Item.height = 32;
			Item.value = 2500;
			Item.rare = 8;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Luxorious Helmet");
			// Tooltip.SetDefault("12% increased mining speed");
		}

		public override void UpdateEquip(Player player)
		{
			player.pickSpeed -= 0.12f;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<LuxoriousBreastplate>() && legs.type == ModContent.ItemType<LuxoriousLeggings>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Allows to detect treasures, ores and traps";
			player.findTreasure = true;
			player.AddBuff(111, 2);
		}

		public override void ArmorSetShadows(Player player)
		{
			player.armorEffectDrawOutlines = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<EvershinyBar>(), 15);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}
	}
}
