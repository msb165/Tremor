using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items.RedSteel
{
	[AutoloadEquip(EquipType.Body)]
	public class RedSteelChestplate:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.width = 22;
			Item.height = 18;
			Item.value = 200;

			Item.rare = 2;
			Item.defense = 8;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Red Steel Chestplate");
			// Tooltip.SetDefault("10% increased melee speed");
		}

		public override void UpdateEquip(Player player)
		{
			player.GetAttackSpeed(DamageClass.Melee) += 0.1f;
		}

		public override void AddRecipes()
		{
			//ModRecipe recipe = new ModRecipe();
			//recipe.AddIngredient(ModContent.ItemType<RedSteelArmorPiece>(), 5);
			//recipe.AddIngredient(ModContent.ItemType<RedSteelBar>(), 8);
			//recipe.SetResult(this);
			//recipe.AddTile(16);
			//recipe.AddRecipe();
		}
	}
}
