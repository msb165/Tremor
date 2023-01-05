using Terraria;
using Terraria.ModLoader;
using Tremor.Projectiles;

namespace Tremor.Buffs
{
	public class WarkeeBuff:TremorModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Warkee");
			Description.SetDefault("A warkee is following you");
			Main.buffNoTimeDisplay[Type] = true;
			Main.vanityPet[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.buffTime[buffIndex] = 18000;
			TremorPlayer modPlayer = player.GetModPlayer<TremorPlayer>();
			modPlayer.warkee = true;
			bool petProjectileNotSpawned = true;
			if (player.ownedProjectileCounts[ModContent.ProjectileType<Warkee>()] > 0)
			{
				petProjectileNotSpawned = false;
			}
			if (petProjectileNotSpawned && player.whoAmI == Main.myPlayer)
			{
				Projectile.NewProjectile(null, player.position.X + player.width / 2, player.position.Y + player.height / 2, 0f, 0f, ModContent.ProjectileType<Warkee>(), 0, 0f, player.whoAmI, 0f, 0f);
			}
		}
	}
}