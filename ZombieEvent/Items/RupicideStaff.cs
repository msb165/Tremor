using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items;

namespace Tremor.ZombieEvent.Items
{
	public class RupicideStaff:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 18;
			Item.DamageType = DamageClass.Magic;
			Item.mana = 14;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 16;
			Item.useAnimation = 16;
			Item.useStyle = 5;
			Item.noMelee = true;
			Item.knockBack = 3;
			Item.value = 13800;
			Item.rare = 4;
			Item.UseSound = SoundID.Item43;
			Item.autoReuse = false;
			Item.staff[Item.type] = true;
			Item.shoot = 682;
			Item.shootSpeed = 15f;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Rupicide Staff");
			// Tooltip.SetDefault("");
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int proj = Projectile.NewProjectile(null, position.X, position.Y, speedX, speedY, type, damage, knockBack, Main.myPlayer);
			Main.projectile[proj].hostile = false;
			Main.projectile[proj].friendly = true;
			return false;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<Gloomstone>(), 5);
			recipe.AddIngredient(ModContent.ItemType<RupicideBar>(), 5);
			recipe.AddIngredient(ModContent.ItemType<WickedHeart>(), 1);
			recipe.AddTile(ModContent.TileType<Tiles.NecromaniacWorkbenchTile>());
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
