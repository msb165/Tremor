using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Ancient;

namespace Tremor.Items
{
	public class StarNest:TremorModItem
	{
		public override void SetDefaults()
		{

			item.damage = 69;
			item.width = 14;
			item.height = 84;
			item.DamageType = DamageClass.Magic;
			item.mana = 4;
			item.useTime = 30;
			item.shoot = ModContent.ProjectileType<Projectiles.StarNestPro>();
			item.shootSpeed = 8f;
			item.useAnimation = 30;
			item.useStyle = 5;
			item.knockBack = 4;
			item.value = 210000;
			item.rare = 10;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Star Nest");
			Tooltip.SetDefault("");
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
