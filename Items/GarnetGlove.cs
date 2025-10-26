using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class GarnetGlove:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 26;
			Item.DamageType = DamageClass.Throwing;
			Item.width = 40;
			Item.height = 20;
			Item.noUseGraphic = true;
			Item.useTime = 30;

			Item.useAnimation = 20;
			Item.useStyle = 5;
			Item.noMelee = true;
			Item.knockBack = 6;
			Item.value = 10000;
			Item.rare = 3;
			Item.UseSound = SoundID.Item45;
			Item.autoReuse = false;
			Item.shoot = ModContent.ProjectileType<Projectiles.GarnetGlovePro>();
			Item.shootSpeed = 9f;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Garnet Glove");
			// Tooltip.SetDefault("'Made of love'");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.MeteoriteBar, 15);
			recipe.AddIngredient(ItemID.Ruby, 13);
			recipe.AddIngredient(ItemID.Sapphire, 13);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();
		}
	}
}
