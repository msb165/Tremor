using Terraria;
using Terraria.ModLoader;
using Tremor.Projectiles;

namespace Tremor.Buffs
{
	public class BallnChainBuff:TremorModBuff
	{
		int MinionType = -1;
		int MinionID = -1;

		const int Damage = 30;
		const float KB = 1;

		public override void SetDefaults()
		{
			Main.buffNoTimeDisplay[Type] = true;
			DisplayName.SetDefault("Ball n' Chain");
		}

		public override void Update(Player player, ref int buffIndex)
		{
			if (MinionType == -1)
				MinionType = ModContent.ProjectileType<BallChainPro>();
			if (MinionID == -1 || Main.projectile[MinionID].type != MinionType || !Main.projectile[MinionID].active || Main.projectile[MinionID].owner != player.whoAmI)
				MinionID = Projectile.NewProjectile(null, player.Center.X, player.Center.Y, 0, 0, MinionType, (int)player.GetTotalDamage(DamageClass.Melee).ApplyTo(Damage), KB, player.whoAmI);
			else
				Main.projectile[MinionID].timeLeft = 6;
		}
	}
}