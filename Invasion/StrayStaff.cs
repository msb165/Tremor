using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Invasion
{
	public class StrayStaff:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.damage = 120;
			Item.DamageType = DamageClass.Summon;
			Item.mana = 12;
			Item.width = 26;
			Item.height = 28;

			Item.useTime = 15;
			Item.useAnimation = 15;
			Item.useStyle = 1;
			Item.noMelee = true;
			Item.value = Item.buyPrice(0, 2, 0, 0);
			Item.rare = 11;
			Item.UseSound = SoundID.Item44;
			Item.shoot = ModContent.ProjectileType<Mini_Cyber>();
			Item.shootSpeed = 1f;
			Item.buffType = ModContent.BuffType<CyberBuff>();
			Item.buffTime = 3600;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Stray Staff");
			// Tooltip.SetDefault("Summons a cyber stray to fight for you");
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
