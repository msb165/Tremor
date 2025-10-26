using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class Kunai:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 14;
			Item.height = 32;
			Item.DamageType = DamageClass.Throwing;
			Item.width = 18;
			Item.noUseGraphic = true;
			Item.maxStack = 999;
			Item.consumable = true;
			Item.useTime = 19;
			Item.useAnimation = 19;
			Item.shoot = ModContent.ProjectileType<Projectiles.Kunai>();
			Item.shootSpeed = 15f;
			Item.useStyle = 1;
			Item.knockBack = 4;
			Item.value = 60;
			Item.rare = 1;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Kunai");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.Wood, 3);
			recipe.AddIngredient(ItemID.IronBar, 4);
			recipe.SetResult(this, 50);
			recipe.AddRecipe();

			recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.Wood, 3);
			recipe.AddIngredient(ItemID.LeadBar, 4);
			recipe.SetResult(this, 50);
			recipe.AddRecipe();
		}
	}
}
