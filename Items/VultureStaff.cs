using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class VultureStaff:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.damage = 14;
			Item.DamageType = DamageClass.Summon;
			Item.mana = 12;
			Item.width = 30;
			Item.height = 28;

			Item.useTime = 36;
			Item.useAnimation = 36;
			Item.useStyle = 1;
			Item.noMelee = true;
			Item.knockBack = 3;
			Item.value = Item.buyPrice(0, 1, 2, 0);
			Item.rare = 2;
			Item.UseSound = SoundID.Item44;
			//TODO: Idk, the projectile code is stolen so if we want to make this item, we need to rewrite it from scratch or get permission.
			//Item.shoot = ModContent.ProjectileType<Projectiles.Minions.VultureStaffPro>();
			//Item.shootSpeed = 1f;
			//Item.buffType = ModContent.BuffType<VultureBuff>();
			//Item.buffTime = 3600;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Vulture Staff");
			// Tooltip.SetDefault("Summons a vulture to fight for you.");
		}

	}
}
