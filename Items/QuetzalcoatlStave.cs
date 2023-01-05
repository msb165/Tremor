using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class QuetzalcoatlStave:TremorModItem
	{
		public override void SetDefaults()
		{

			item.damage = 80;
			item.DamageType = DamageClass.Summon;
			item.mana = 10;
			item.width = 26;
			item.height = 28;

			item.useTime = 36;
			item.useAnimation = 36;
			item.useStyle = 1;
			item.noMelee = true;
			item.knockBack = 3;
			item.value = 1000000;
			item.rare = 11;
			item.UseSound = SoundID.Item44;
			item.shoot = ModContent.ProjectileType<Projectiles.Minions.QuetzalcoatlPro>();
			item.shootSpeed = 2f;
			item.buffType = ModContent.BuffType<Buffs.QuetzalcoatlBuff>();
			item.buffTime = 3600;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Baby Quetzalcoatl Stave");
			Tooltip.SetDefault("Summons a baby quetzalcoatl to fight for you.");
		}

		public override bool AltFunctionUse(Player player)
		{
			return true;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			return player.altFunctionUse != 2;
		}

		public override bool? UseItem(Player player)
		{
			if (player.altFunctionUse == 2)
			{
				player.MinionNPCTargetAim(false);
			}
			return base.UseItem(player);
		}
	}
}
