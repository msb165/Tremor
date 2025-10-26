using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class BrilliantBehemoth:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 70;
			Item.DamageType = DamageClass.Throwing;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 40;
			Item.useAnimation = 40;
			Item.useStyle = 5;
			Item.knockBack = 3;
			Item.value = 90000;
			Item.rare = 5;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.noUseGraphic = true;
			Item.shoot = ModContent.ProjectileType<Projectiles.BrilliantBehemothPro>();
			Item.shootSpeed = 8f;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Brilliant Behemoth");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<PerfectBehemoth>(), 1);
			recipe.AddIngredient(ItemID.SoulofLight, 7);
			recipe.AddIngredient(ItemID.SoulofNight, 7);
			recipe.AddIngredient(ModContent.ItemType<Opal>(), 3);
			recipe.AddIngredient(ItemID.Amethyst, 25);
			recipe.SetResult(this);
			recipe.AddTile(ModContent.TileType<Tiles.GreatAnvilTile>());
			recipe.AddRecipe();
		}
	}
}
