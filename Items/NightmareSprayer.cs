using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Alchemist.Flasks;
using Tremor.Items.Steel;

namespace Tremor.Items
{
	public class NightmareSprayer : AlchemistItem
	{
		public override void SetDefaults()
		{
			Item.damage = 120;
			Item.width = 80;
			Item.height = 36;
			Item.useTime = 14;
			Item.useAnimation = 14;
			Item.useStyle = 5;
			Item.noMelee = true;
			Item.knockBack = 4;
			Item.value = 10000;
			Item.rare = 11;
			Item.UseSound = SoundID.Item20;
			Item.autoReuse = false;
			Item.shoot = 10;
			Item.shootSpeed = 6f;
			Item.crit = 4;
			Item.useAmmo = ModContent.ItemType<BoomFlask>();

		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Nightmare Sprayer");
			/* Tooltip.SetDefault("Uses flasks as ammo\n" +
"Sprays alchemical clouds"); */
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<BasicSprayer>(), 1);
			recipe.AddIngredient(ModContent.ItemType<BasicFlask>(), 8);
			recipe.AddIngredient(ModContent.ItemType<NightmareBar>(), 25);
			recipe.AddIngredient(ModContent.ItemType<SteelBar>(), 14);
			recipe.AddIngredient(ItemID.Wire, 15);
			recipe.AddIngredient(3467, 8);
			recipe.AddIngredient(ModContent.ItemType<VoidBar>(), 5);
			recipe.SetResult(this);
			recipe.AddTile(412);
			recipe.AddRecipe();
		}

		public override bool CanConsumeAmmo(Item ammo, Player player)
		{
			if (player.FindBuffIndex(ModContent.BuffType<Buffs.EnchantmentSolution>()) != -1)
			{
				if (Main.rand.Next(0, 100) <= 50)
					return false;
			}
			if (player.FindBuffIndex(ModContent.BuffType<Buffs.AmplifiedEnchantmentSolution>()) != -1)
			{
				if (Main.rand.Next(0, 100) <= 70)
					return false;
			}
			return true;
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-12, -4);
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
				Item.shootSpeed = 14f;
			}
			if (player.FindBuffIndex(ModContent.BuffType<Buffs.LongFuseBuff>()) < 1)
			{
				Item.shootSpeed = 6f;
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
	}
}
