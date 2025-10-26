using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Crystal
{
	public class CrystalDagger:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 35;
			Item.DamageType = DamageClass.Throwing;
			Item.width = 18;
			Item.noUseGraphic = true;
			Item.maxStack = 999;
			Item.consumable = true;
			Item.height = 38;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.shoot = ModContent.ProjectileType<Projectiles.CrystalDagger>();
			Item.shootSpeed = 16f;
			Item.useStyle = 1;
			Item.knockBack = 4;
			Item.value = 60;
			Item.rare = 4;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = false;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Crystal Dagger");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.ThrowingKnife, 50);
			recipe.AddIngredient(ItemID.CrystalShard, 1);
			recipe.SetResult(this, 50);
			recipe.AddRecipe();
		}
	}
}
