using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items;

namespace Tremor.ZombieEvent.Items
{
	public class RupicideCannon:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 45;
			Item.width = 40;
			Item.height = 20;
			Item.useTime = 15;
			Item.useAnimation = 15;
			Item.useStyle = 5;
			Item.DamageType = DamageClass.Magic;
			Item.mana = 7;
			Item.noMelee = true;

			Item.knockBack = 6;
			Item.value = 10000;
			Item.rare = 5;
			Item.UseSound = SoundID.Item11;
			Item.autoReuse = true;
			Item.shoot = 10;
			Item.shootSpeed = 12f;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Rupicide Cannon");
			// Tooltip.SetDefault("Shoots magical blasts");
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int proj = Projectile.NewProjectile(null, position.X, position.Y, speedX, speedY, 675, damage, knockBack, Main.myPlayer);
			Main.projectile[proj].hostile = false;
			Main.projectile[proj].friendly = true;
			return false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<GunBlueprint>(), 1);
			recipe.AddIngredient(ModContent.ItemType<RupicideBar>(), 8);
			recipe.AddIngredient(ModContent.ItemType<RuneBar>(), 8);
			recipe.AddIngredient(ModContent.ItemType<CryptStone>(), 3);
			recipe.AddTile(ModContent.TileType<Tiles.NecromaniacWorkbenchTile>());
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-18, -4);
		}
	}
}
