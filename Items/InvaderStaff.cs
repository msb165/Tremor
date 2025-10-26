using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class InvaderStaff:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.damage = 85;
			Item.DamageType = DamageClass.Summon;
			Item.mana = 12;
			Item.width = 26;
			Item.height = 28;

			Item.useTime = 36;
			Item.useAnimation = 36;
			Item.useStyle = 1;
			Item.noMelee = true;
			Item.knockBack = 3;
			Item.value = Item.buyPrice(1, 30, 0, 0);
			Item.rare = 11;
			Item.UseSound = SoundID.Item44;
			//TODO: Missing projectile and buff
			//Item.shoot = ModContent.ProjectileType<SpaceInvader>();
			Item.shootSpeed = 1f;
			//Item.buffType = ModContent.BuffType<SpaceInvaderBuff>();
			Item.buffTime = 3600;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Invader Staff");
			// Tooltip.SetDefault("Summons a strange invader from space to fight for you.");
		}

	}
}
