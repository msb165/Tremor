using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class BirbStaff:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 7;
			Item.DamageType = DamageClass.Summon;
			Item.mana = 10;
			Item.width = 46;
			Item.height = 46;

			Item.useTime = 25;
			Item.useAnimation = 25;
			Item.useStyle = 1;
			Item.noMelee = true;
			Item.knockBack = 4;
			Item.value = 8000;
			Item.rare = 2;
			Item.UseSound = SoundID.Item44;
			Item.shoot = ModContent.ProjectileType<Projectiles.Minions.BirbStaffPro>();
			Item.shootSpeed = 1f;
			Item.buffType = ModContent.BuffType<Buffs.BirbStaffBuff>();
			Item.buffTime = 3600;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Birb Staff");
			// Tooltip.SetDefault("Summons a birb to fight for you.");
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
