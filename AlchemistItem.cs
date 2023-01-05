using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;
using Tremor.Items;

namespace Tremor
{
	public abstract class AlchemistProjectile:TremorModProjectile
	{
		// todo: this can PROBABLY be removed when tmodloader updates
		public override void ModifyHitNPC(NPC target, ref int damage, ref float knockback, ref bool crit, ref int hitDirection)
		{
			Player owner = null;
			if (projectile.owner != -1)
			{
				owner = Main.player[projectile.owner];
			}
			else if (projectile.owner == 255)
			{
				owner = Main.LocalPlayer;
			}

			ModItem mItem = owner?.HeldItem.ModItem;
			if (mItem != null)
			{
				float cc = owner.HeldItem.crit;

				(mItem as AlchemistItem)?.ModifyWeaponCrit(owner, ref cc);
				crit = crit || Main.rand.Next(1, 101) <= cc;
			}
		}
	}

	public abstract class AlchemistItem:TremorModItem
	{
		// make-safe
		public override void SetDefaults()
		{
			Item.DamageType = DamageClass.Generic;
			//item.melee = false;
			//item.ranged = false;
			//item.magic = false;
			//item.thrown = false;
			//item.summon = false;
			item.crit = 4;
		}

		public override void ModifyWeaponKnockback(Player player, ref StatModifier knockback)
		{
			MPlayer modPlayer = MPlayer.GetModPlayer(player);
			knockback += modPlayer.alchemicalKbAddition;
			knockback *= modPlayer.alchemicalKbMult;
		}

		// todo: borked, tml requires update, manual work still needed
		public override void ModifyWeaponCrit(Player player, ref float crit)
		{
			MPlayer modPlayer = MPlayer.GetModPlayer(player);
			crit += modPlayer.alchemicalCrit;
		}

		public override void ModifyWeaponDamage(Player player, ref StatModifier damage)
		{
			MPlayer modPlayer = MPlayer.GetModPlayer(player);
			// We want to multiply the damage we do by our alchemicalDamage modifier.
			// todo: ? do we want magic damage to also have effect here?
			damage += modPlayer.alchemicalDamage - 1f;//damage = (int)(damage * modPlayer.alchemicalDamage + 5E-06f);
		}

		// todo: this can be removed when tmodloader updates
		public override void ModifyHitNPC(Player player, NPC target, ref int damage, ref float knockBack, ref bool crit)
		{
			float cc = item.crit;
			ModifyWeaponCrit(player, ref cc);
			crit = crit || Main.rand.Next(1, 101) <= cc;
		}

		public override void ModifyTooltips(List<TooltipLine> tooltips)
		{
			var tt = tooltips.FirstOrDefault(x => x.Name == "Damage" && x.Mod == "Terraria");
			if (tt != null)
			{
				// take reverse for 'damage',  grab translation
				string[] split = tt.Text.Split(' ');
				// todo: translation alchemical
				tt.Text = split.First() + " alchemical " + split.Last();
			}
			
			// todo: this can be removed when tmodloader updates
			if (item.crit > 0)
			{
				float crit = item.crit;
				ModifyWeaponCrit(Main.LocalPlayer, ref crit);
				tt = tooltips.FirstOrDefault(x => x.Name == "CritChance" && x.Mod == "Terraria");
				if (tt != null)
				{
					tt.Text = crit + "% " + string.Join(" ", tt.Text.Split(' ').Skip(1).ToArray());
				}
				else
				{
					TooltipLine ttl = new TooltipLine(Mod, "CritChance", crit + "% critical strike chance");
					int index = tooltips.FindIndex(x => x.Name == "Damage" && x.Mod == "Terraria");
					if (index != -1)
					{
						tooltips.Insert(index + 1, ttl);
					}
				}
			}
		}

		public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 speed, int type, int damage, float knockBack)
		{
			MPlayer modPlayer = MPlayer.GetModPlayer(player);
			if (modPlayer.glove)
			{
				for (int i = 0; i < 1; ++i)
				{
					if (player.FindBuffIndex(ModContent.BuffType<Buffs.BottledSpirit>()) != -1)
					{
						Projectile.NewProjectile(source, position.X, position.Y, speed.X + 2, speed.Y + 2, 297, damage, knockBack, Main.myPlayer);
						Projectile.NewProjectile(source, position.X, position.Y, speed.X - 1, speed.Y - 1, 297, damage, knockBack, Main.myPlayer);
					}
					if (player.FindBuffIndex(ModContent.BuffType<Buffs.BigBottledSpirit>()) != -1)
					{
						Projectile.NewProjectile(source, position.X, position.Y, speed.X + 3, speed.Y + 3, 297, damage, knockBack, Main.myPlayer);
						Projectile.NewProjectile(source, position.X, position.Y, speed.X + 2, speed.Y + 2, 297, damage, knockBack, Main.myPlayer);
						Projectile.NewProjectile(source, position.X, position.Y, speed.X - 1, speed.Y - 1, 297, damage, knockBack, Main.myPlayer);
						Projectile.NewProjectile(source, position.X, position.Y, speed.X - 2, speed.Y - 2, 297, damage, knockBack, Main.myPlayer);
					}
					Projectile.NewProjectile(source, position.X, position.Y, speed.X + 1, speed.Y + 1, type, damage, knockBack, Main.myPlayer);
					int k = Projectile.NewProjectile(source, position, speed, type, damage, knockBack, Main.myPlayer);
					Main.projectile[k].friendly = true;
				}
				return false;
			}
			if (player.FindBuffIndex(ModContent.BuffType<Buffs.BottledSpirit>()) != -1 && !modPlayer.glove)
			{
				for (int i = 0; i < 1; ++i)
				{
					Projectile.NewProjectile(source, position.X, position.Y, speed.X + 1, speed.Y + 1, 297, damage, knockBack, Main.myPlayer);
					int k = Projectile.NewProjectile(source, position, speed, type, damage, knockBack, Main.myPlayer);
					Projectile.NewProjectile(source, position.X, position.Y, speed.X - 1, speed.Y - 1, 297, damage, knockBack, Main.myPlayer);
					Main.projectile[k].friendly = true;
				}
				return false;
			}
			if (player.FindBuffIndex(ModContent.BuffType<Buffs.BigBottledSpirit>()) != -1 && !modPlayer.glove)
			{
				for (int i = 0; i < 1; ++i)
				{
					Projectile.NewProjectile(source, position.X, position.Y, speed.X + 2, speed.Y + 2, 297, damage, knockBack, Main.myPlayer);
					Projectile.NewProjectile(source, position.X, position.Y, speed.X + 1, speed.Y + 1, 297, damage, knockBack, Main.myPlayer);
					int k = Projectile.NewProjectile(source, position, speed, type, damage, knockBack, Main.myPlayer);
					Projectile.NewProjectile(source, position.X, position.Y, speed.X - 1, speed.Y - 1, 297, damage, knockBack, Main.myPlayer);
					Projectile.NewProjectile(source, position.X, position.Y, speed.X - 2, speed.Y - 2, 297, damage, knockBack, Main.myPlayer);
					Main.projectile[k].friendly = true;
				}
				return false;
			}
			return true;
		}
	}
}
