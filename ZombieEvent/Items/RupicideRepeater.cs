using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items;

namespace Tremor.ZombieEvent.Items
{
	public class RupicideRepeater:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.DamageType = DamageClass.Ranged;
			Item.width = 36;
			Item.height = 24;

			Item.useTime = 15;
			Item.useAnimation = 15;
			Item.shoot = 1;
			Item.useAmmo = AmmoID.Arrow;
			Item.shootSpeed = 30f;
			Item.useStyle = 5;
			Item.damage = 26;
			Item.knockBack = 4;
			Item.value = 30000;
			Item.rare = 5;
			Item.UseSound = SoundID.Item5;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Rupicide Repeater");
			/* Tooltip.SetDefault("Quickly launches arrows\n" +
	  "20% to shoot a fiery burst"); */
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<BowBlueprint>(), 1);
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

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			type = 1;

			if (Main.rand.NextBool(5))
			{
				int proj = Projectile.NewProjectile(null, position.X, position.Y, speedX, speedY, 686, damage, knockBack, Main.myPlayer);
				Main.projectile[proj].hostile = false;
				Main.projectile[proj].friendly = true;
				return false;
			}

			return base.Shoot(player, ref position, ref speedX, ref speedY, ref type, ref damage, ref knockBack);
		}
	}
}
