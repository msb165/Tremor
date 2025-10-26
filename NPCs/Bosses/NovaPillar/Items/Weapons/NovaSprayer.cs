using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.NPCs.Bosses.NovaPillar.Items.Weapons
{
	public class NovaSprayer : AlchemistItem
	{
		public override void SetDefaults()
		{

			Item.damage = 84;
			Item.width = 62;
			Item.height = 32;
			Item.useTime = 6;
			Item.useAnimation = 30;
			Item.useStyle = 5;
			Item.noMelee = true;
			Item.knockBack = 5;
			Item.value = 100000;
			Item.rare = 10;
			Item.UseSound = SoundID.Item11;
			Item.autoReuse = false;
			Item.shoot = ModContent.ProjectileType<Projectiles.NovaFlask_ProjBall>();
			Item.shootSpeed = 15f;
			Item.crit = 12;
			Item.reuseDelay = 60;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Nova Sprayer");
			/* Tooltip.SetDefault("Shoots a burst of nova balls which explode into flames when hit enemy or after some time,\n" +
" flames explode into damaging bursts when hit enemy or after some time."); */
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-15, 0);
		}

		public override Color? GetAlpha(Color lightColor)
		{
			return Color.White;
		}

		public override void UpdateInventory(Player player)
		{
			MPlayer modPlayer = MPlayer.GetModPlayer(player);
			if (modPlayer.core)
			{
				Item.autoReuse = true;
			}
			if (!modPlayer.core)
			{
				Item.autoReuse = false;
			}
			if (player.FindBuffIndex(ModContent.BuffType<Buffs.LongFuseBuff>()) != -1)
			{
				Item.shootSpeed = 21f;
			}
			if (player.FindBuffIndex(ModContent.BuffType<Buffs.LongFuseBuff>()) < 1)
			{
				Item.shootSpeed = 15f;
			}
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			MPlayer modPlayer = MPlayer.GetModPlayer(player);
			if (modPlayer.glove)
			{
				for (int i = 0; i < 1; ++i)
				{
					if (player.FindBuffIndex(ModContent.BuffType<Buffs.BottledSpirit>()) != -1)
					{
						Projectile.NewProjectile(null, position.X, position.Y, speedX + 2, speedY + 2, 297, damage, knockBack, Main.myPlayer);
					}
					if (player.FindBuffIndex(ModContent.BuffType<Buffs.BigBottledSpirit>()) != -1)
					{
						Projectile.NewProjectile(null, position.X, position.Y, speedX + 3, speedY + 3, 297, damage, knockBack, Main.myPlayer);
						Projectile.NewProjectile(null, position.X, position.Y, speedX + 2, speedY + 2, 297, damage, knockBack, Main.myPlayer);
					}
					Projectile.NewProjectile(null, position.X, position.Y, speedX + 1, speedY + 1, type, damage, knockBack, Main.myPlayer);
					Projectile.NewProjectile(null, position.X, position.Y, speedX + 1, speedY + 1, type, damage, knockBack, Main.myPlayer);
					int k = Projectile.NewProjectile(null, position.X, position.Y, speedX, speedY, type, damage, knockBack, Main.myPlayer);
					Main.projectile[k].friendly = true;
				}
				return false;
			}
			if (player.FindBuffIndex(ModContent.BuffType<Buffs.BottledSpirit>()) != -1 && !modPlayer.glove)
			{
				for (int i = 0; i < 1; ++i)
				{
					Projectile.NewProjectile(null, position.X, position.Y, speedX + 1, speedY + 1, 297, damage, knockBack, Main.myPlayer);
					int k = Projectile.NewProjectile(null, position.X, position.Y, speedX, speedY, type, damage, knockBack, Main.myPlayer);
					Main.projectile[k].friendly = true;
				}
				return false;
			}
			if (player.FindBuffIndex(ModContent.BuffType<Buffs.BigBottledSpirit>()) != -1 && !modPlayer.glove)
			{
				for (int i = 0; i < 1; ++i)
				{
					Projectile.NewProjectile(null, position.X, position.Y, speedX + 2, speedY + 2, 297, damage, knockBack, Main.myPlayer);
					Projectile.NewProjectile(null, position.X, position.Y, speedX + 1, speedY + 1, 297, damage, knockBack, Main.myPlayer);
					int k = Projectile.NewProjectile(null, position.X, position.Y, speedX, speedY, type, damage, knockBack, Main.myPlayer);
					Main.projectile[k].friendly = true;
				}
				return false;
			}
			return true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<NovaFragment>(), 18);
			recipe.SetResult(this);
			recipe.AddTile(412);
			recipe.AddRecipe();
		}
	}
}
