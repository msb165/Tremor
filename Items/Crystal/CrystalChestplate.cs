using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Crystal
{
	[AutoloadEquip(EquipType.Body)]
	public class CrystalChestplate:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 22;
			Item.height = 18;

			Item.value = 200;
			Item.rare = 4;
			Item.defense = 9;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Crystal Chestplate");
			// Tooltip.SetDefault("30% increased throwing velocity");
		}

		public override void UpdateEquip(Player p)
		{
			p.ThrownVelocity += 0.3f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.CrystalShard, 30);
			recipe.AddIngredient(ItemID.SoulofLight, 6);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}
	}
}
