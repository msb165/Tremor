using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class SaturatedDagger:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 57;
			Item.DamageType = DamageClass.Throwing;
			Item.width = 26;
			Item.noUseGraphic = true;
			Item.maxStack = 999;
			Item.consumable = true;
			Item.height = 30;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.shoot = ModContent.ProjectileType<Projectiles.SaturatedDaggerPro>();
			Item.shootSpeed = 22f;
			Item.useStyle = 1;
			Item.knockBack = 4;
			Item.value = 50;
			Item.rare = 5;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Saturated Dagger");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<ParaxydeShard>(), 1);
			recipe.SetResult(this, 75);
			recipe.AddTile(ModContent.TileType<Tiles.AlchematorTile>());
			recipe.AddRecipe();
		}
	}
}
