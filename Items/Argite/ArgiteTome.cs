using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Argite
{
	public class ArgiteTome:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.damage = 18;
			//Item.melee = false;
			Item.DamageType = DamageClass.Magic;
			Item.width = 50;
			Item.height = 55;
			Item.useTime = 30;
			Item.mana = 8;
			Item.useAnimation = 30;
			Item.useStyle = 5;
			Item.shoot = ModContent.ProjectileType<Projectiles.ArgiteSpherePro>();
			Item.shootSpeed = 12f;
			Item.knockBack = 4;
			Item.value = 32000;
			Item.rare = 3;
			Item.UseSound = SoundID.Item9;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Argite Tome");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.Book, 1);
			recipe.AddIngredient(ModContent.ItemType<ArgiteBar>(), 20);
			recipe.SetResult(this);
			recipe.AddTile(ModContent.TileType<Tiles.MagicWorkbenchTile>());
			recipe.AddRecipe();
		}
	}
}
