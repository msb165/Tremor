using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Brass
{
	public class BrassChainRepeater:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.DamageType = DamageClass.Ranged;
			Item.width = 36;
			Item.height = 24;

			Item.useTime = 11;
			Item.useAnimation = 11;
			Item.shoot = 1;
			Item.useAmmo = AmmoID.Arrow;
			Item.shootSpeed = 30f;
			Item.useStyle = 5;
			Item.damage = 30;
			Item.knockBack = 4;
			Item.value = 30000;
			Item.rare = 5;
			Item.UseSound = SoundID.Item5;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Brass Chain Repeater");
			/* Tooltip.SetDefault("Quickly launches arrows\n" +
"25% to shoot a heat ray"); */
		}

		public override void UpdateInventory(Player player)
		{
			if (player.HasBuffSafe(ModContent.BuffType<Buffs.SteamRangerBuff>()))
			{
				Item.damage = 45;
			}
			else
			{
				Item.damage = 30;
			}
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			if (Main.rand.NextBool(4))
			{
				type = 260;
			}

			return base.Shoot(player, ref position, ref speedX, ref speedY, ref type, ref damage, ref knockBack);
		}
	}
}
