using Terraria;
using Terraria.ModLoader;
using Tremor.Projectiles;

namespace Tremor.Buffs
{
	public class AnnoyingDogBuff:TremorModBuff
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Annoying Dog");
			Description.SetDefault("It wants to absorb your artifact");
			Main.buffNoTimeDisplay[Type] = true;
			Main.vanityPet[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.buffTime[buffIndex] = 18000;
			TremorPlayer modPlayer = player.GetModPlayer<TremorPlayer>();
			modPlayer.AnnoyingDog = true;
			bool petProjectileNotSpawned = true;
			if (player.ownedProjectileCounts[ModContent.ProjectileType<AnnoyingDog>()] > 0)
			{
				petProjectileNotSpawned = false;
			}
			if (petProjectileNotSpawned && player.whoAmI == Main.myPlayer)
			{
				Projectile.NewProjectile(null, player.position.X + player.width / 2, player.position.Y + player.height / 2, 0f, 0f, ModContent.ProjectileType<AnnoyingDog>(), 0, 0f, player.whoAmI, 0f, 0f);
			}
		}
	}
}