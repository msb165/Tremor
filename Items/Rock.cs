using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class Rock:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 9;
			Item.DamageType = DamageClass.Throwing;
			Item.width = 18;
			Item.height = 18;
			Item.useTime = 14;
			Item.useAnimation = 14;
			Item.useStyle = 1;
			Item.knockBack = 5;
			Item.rare = 0;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = false;
			Item.shoot = ModContent.ProjectileType<Projectiles.Rock>();
			Item.shootSpeed = 10f;
			Item.maxStack = 999;
			Item.consumable = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Rock");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.StoneBlock, 1);
			recipe.SetResult(this, 15);
			recipe.AddRecipe();
		}
	}
}
