using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class BurningFist:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 29;
			Item.DamageType = DamageClass.Magic;
			Item.width = 28;
			Item.height = 30;
			Item.useTime = 42;
			Item.useAnimation = 42;
			Item.shoot = ModContent.ProjectileType<Projectiles.BurningFist>();
			Item.shootSpeed = 15f;
			Item.mana = 16;
			Item.useStyle = 5;
			Item.knockBack = 3;
			Item.value = 30000;
			Item.noUseGraphic = true;
			Item.rare = 3;
			Item.UseSound = SoundID.Item116;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Burning Fist");
			// Tooltip.SetDefault("Shoots a burning fist that explodes on contact and erupts burning bolts");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.HellstoneBar, 12);
			recipe.AddIngredient(ItemID.MeteoriteBar, 12);
			recipe.AddIngredient(ModContent.ItemType<DemonBlood>(), 10);
			recipe.AddTile(ModContent.TileType<Tiles.DevilForge>());
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
