using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class RichMahoganySeed:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 38;
			Item.DamageType = DamageClass.Summon;
			Item.mana = 10;
			Item.width = 26;
			Item.height = 28;

			Item.useTime = 36;
			Item.channel = true;
			Item.useAnimation = 36;
			Item.useStyle = 4;
			Item.noMelee = true;
			Item.knockBack = 3;
			Item.value = Item.buyPrice(0, 3, 0, 0);
			Item.rare = 3;
			Item.UseSound = SoundID.Item44;
			Item.shoot = ModContent.ProjectileType<Projectiles.Minions.Hunter>();
			Item.shootSpeed = 2f;
			Item.buffType = ModContent.BuffType<Buffs.HunterBuff>();
			Item.buffTime = 3600;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Rich Mahogany Seed");
			// Tooltip.SetDefault("Summons a lil' snatcher to fight for you.");
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
