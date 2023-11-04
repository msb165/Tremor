using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class DragonSpear:TremorModItem
	{
		public override void SetDefaults()
		{

			item.damage = 278;
			item.width = 44;
			item.height = 44;
			item.noUseGraphic = true;
			item.DamageType = DamageClass.Melee;
			item.useTime = 16;
			item.shoot = ModContent.ProjectileType<Projectiles.DragonSpearPro>();
			item.shootSpeed = 3f;
			item.useAnimation = 30;
			item.useStyle = 5;
			item.knockBack = 4;
			item.value = 30000;
			item.rare = 11;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dragon Spear");
			Tooltip.SetDefault("");
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
