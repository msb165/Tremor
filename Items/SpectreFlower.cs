using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class SpectreFlower:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 60;
			Item.DamageType = DamageClass.Magic;
			Item.width = 46;
			Item.height = 48;
			Item.mana = 15;
			Item.useTime = 30;
			Item.useAnimation = 30;
			Item.useStyle = 1;
			Item.noMelee = true;
			Item.knockBack = 6;
			Item.value = 30000;
			Item.rare = 8;
			Item.UseSound = SoundID.Item43;
			Item.autoReuse = true;
			Item.shoot = ModContent.ProjectileType<Projectiles.SpectreFlower>();
			Item.shootSpeed = 6f;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Spectre Flower");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.SpectreBar, 17);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}
	}
}
