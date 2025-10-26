using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Projectiles.Minions;

namespace Tremor.Items.Ancient
{
	public class AncientVisionStaff:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 80;
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
			Item.rare = 10;
			Item.UseSound = SoundID.Item44;
			Item.shoot = ModContent.ProjectileType<AncientVisionPro>();
			Item.shootSpeed = 1f;
			Item.buffType = ModContent.BuffType<Buffs.AncientVisionBuff>();
			Item.buffTime = 3600;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Ancient Vision Staff");
			// Tooltip.SetDefault("Summons an ancient vision to fight for you.");
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
