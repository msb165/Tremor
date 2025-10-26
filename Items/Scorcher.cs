using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Ancient;

namespace Tremor.Items
{
	public class Scorcher:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 178;
			Item.width = 14;
			Item.height = 84;
			Item.noUseGraphic = true;
			Item.DamageType = DamageClass.Melee;
			Item.useTime = 30;
			Item.shoot = ModContent.ProjectileType<Projectiles.ScorcherPro>();
			Item.shootSpeed = 4f;
			Item.useAnimation = 30;
			Item.useStyle = 5;
			Item.knockBack = 4;
			Item.value = 210000;
			Item.rare = 10;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = false;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Scorcher");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<AncientTechnology>(), 1);
			recipe.AddIngredient(3458, 30);
			recipe.AddIngredient(ModContent.ItemType<FireFragment>(), 25);
			recipe.SetResult(this);
			recipe.AddTile(412);
			recipe.AddRecipe();
		}
	}
}
