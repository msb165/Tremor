using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class Murasamu:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 24;
			Item.DamageType = DamageClass.Melee;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = 1;
			Item.knockBack = 6;
			Item.value = 1000;
			Item.rare = 3;
			Item.shoot = 22;
			Item.shootSpeed = 16f;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Murasamu");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.Muramasa, 1);
			recipe.AddIngredient(ModContent.ItemType<SeaFragment>(), 16);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();
		}
	}
}
