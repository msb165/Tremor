using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.ZombieEvent.Items
{
	public class IchorCleaver:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.CloneDefaults(ItemID.Arkhalis);

			Item.damage = 36;

		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Ichor Cleaver");
			// Tooltip.SetDefault("Inflicts Ichor on enemies");
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			type = ModContent.ProjectileType<IchorCleaverPro>();
			return base.Shoot(player, ref position, ref speedX, ref speedY, ref type, ref damage, ref knockBack);
		}

		public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
		{
			target.AddBuff(69, 120);
		}
	}
}
