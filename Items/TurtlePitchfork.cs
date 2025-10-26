using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class TurtlePitchfork:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 86;
			Item.width = 80;
			Item.height = 80;
			Item.noUseGraphic = true;
			Item.DamageType = DamageClass.Melee;
			Item.useTime = 30;
			Item.shoot = ModContent.ProjectileType<Projectiles.TurtlePitchfork>();
			Item.shootSpeed = 3f;
			Item.useAnimation = 30;
			Item.useStyle = 5;
			Item.knockBack = 4;
			Item.value = 30000;
			Item.rare = 8;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = false;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Turtle Pitchfork");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.TurtleShell);
			recipe.AddIngredient(ItemID.ChlorophyteBar, 15);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}
	}
}
