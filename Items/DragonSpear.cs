using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class DragonSpear:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 278;
			Item.width = 44;
			Item.height = 44;
			Item.noUseGraphic = true;
			Item.DamageType = DamageClass.Melee;
			Item.useTime = 16;
			Item.shoot = ModContent.ProjectileType<Projectiles.DragonSpearPro>();
			Item.shootSpeed = 3f;
			Item.useAnimation = 30;
			Item.useStyle = 5;
			Item.knockBack = 4;
			Item.value = 30000;
			Item.rare = 11;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = false;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Dragon Spear");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<DragonCapsule>(), 10);
			recipe.AddIngredient(ModContent.ItemType<EarthFragment>(), 15);
			recipe.AddTile(412);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
