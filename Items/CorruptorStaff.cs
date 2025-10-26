using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class CorruptorStaff:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 15;
			Item.DamageType = DamageClass.Summon;
			Item.mana = 12;
			Item.width = 26;
			Item.height = 28;

			Item.useTime = 36;
			Item.useAnimation = 36;
			Item.useStyle = 1;
			Item.noMelee = true;
			Item.knockBack = 3;
			Item.value = Item.buyPrice(0, 2, 0, 0);
			Item.rare = 3;
			Item.UseSound = SoundID.Item44;
			Item.shoot = ModContent.ProjectileType<Projectiles.Minions.CorruptorStaffPro>();
			Item.shootSpeed = 2f;
			Item.buffType = ModContent.BuffType<Buffs.CorruptorBuff>();
			Item.buffTime = 3600;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Corruptor Staff");
			// Tooltip.SetDefault("Summons a corruptor to fight for you.");
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
