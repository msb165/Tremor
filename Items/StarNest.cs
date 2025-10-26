using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Ancient;

namespace Tremor.Items
{
	public class StarNest:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 69;
			Item.width = 14;
			Item.height = 84;
			Item.DamageType = DamageClass.Magic;
			Item.mana = 4;
			Item.useTime = 30;
			Item.shoot = ModContent.ProjectileType<Projectiles.StarNestPro>();
			Item.shootSpeed = 8f;
			Item.useAnimation = 30;
			Item.useStyle = 5;
			Item.knockBack = 4;
			Item.value = 210000;
			Item.rare = 10;
			Item.UseSound = SoundID.Item11;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Star Nest");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<AncientTechnology>(), 1);
			recipe.AddIngredient(3459, 30);
			recipe.AddIngredient(ModContent.ItemType<EarthFragment>(), 25);
			recipe.SetResult(this);
			recipe.AddTile(412);
			recipe.AddRecipe();
		}
	}
}
