using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class TurtleSickle:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 85;
			Item.DamageType = DamageClass.Melee;
			Item.width = 68;
			Item.height = 68;
			Item.useTime = 25;
			Item.useAnimation = 25;
			Item.useStyle = 1;
			Item.knockBack = 4;
			Item.value = 30000;
			Item.rare = 8;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.useTurn = true;
			//Item.shoot = ModContent.ProjectileType<Projectiles.TurtleSicklePro>();
			Item.shootSpeed = 6f;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Turtle Sickle");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.TurtleShell);
			recipe.AddIngredient(ItemID.ChlorophyteBar, 17);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}
	}
}
