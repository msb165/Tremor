using Terraria;
using Terraria.ModLoader;
using Tremor.Projectiles;

namespace Tremor.Buffs
{
	public class LivingTombstoneBuff:TremorModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Living Tombstone");
			Description.SetDefault("Sadly, but it doesn't sing");
			Main.buffNoTimeDisplay[Type] = true;
			Main.vanityPet[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.buffTime[buffIndex] = 18000;
			TremorPlayer modPlayer = player.GetModPlayer<TremorPlayer>();
			modPlayer.LivingTombstone = true;
			bool petProjectileNotSpawned = true;
			if (player.ownedProjectileCounts[ModContent.ProjectileType<LivingTombstonePro>()] > 0)
			{
				petProjectileNotSpawned = false;
			}
			if (petProjectileNotSpawned && player.whoAmI == Main.myPlayer)
			{
				Projectile.NewProjectile(null, player.position.X + player.width / 2, player.position.Y + player.height / 2, 0f, 0f, ModContent.ProjectileType<Projectiles.LivingTombstonePro>(), 0, 0f, player.whoAmI, 0f, 0f);
			}
		}
	}
}