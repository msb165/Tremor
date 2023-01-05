using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Alchemist.Flasks;

namespace Tremor.Items
{
	public class MechaSprayer : AlchemistItem
	{

		public override void SetDefaults()
		{

			item.damage = 28;
			item.width = 80;
			item.height = 30;
			item.useTime = 16;
			item.useAnimation = 16;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 4;
			item.value = 30000;
			item.rare = 5;
			item.UseSound = SoundID.Item20;
			item.autoReuse = false;
			item.shoot = 10;
			item.shootSpeed = 6f;
			item.crit = 4;
			item.useAmmo = ModContent.ItemType<BoomFlask>();

		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Mecha Sprayer");
			Tooltip.SetDefault("Uses flasks as ammo\n" +
"Sprays alchemical clouds");
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
			return new Vector2(-18, -4);
		}

		public override void UpdateInventory(Player player)
		{
			MPlayer modPlayer = MPlayer.GetModPlayer(player);
			if (modPlayer.core)
			{
				item.autoReuse = true;
			}
			if (!modPlayer.core)
			{
				item.autoReuse = false;
			}
			if (player.FindBuffIndex(ModContent.BuffType<Buffs.LongFuseBuff>()) != -1)
			{
				item.shootSpeed = 14f;
			}
			if (player.FindBuffIndex(ModContent.BuffType<Buffs.LongFuseBuff>()) < 1)
			{
				item.shootSpeed = 6f;
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
