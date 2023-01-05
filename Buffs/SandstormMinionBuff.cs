using Terraria;
using Terraria.ModLoader;

namespace Tremor.Buffs
{
	public class SandstormMinionBuff:TremorModBuff
	{
		int MinionType = -1;
		int MinionID = -1;

		public override void SetDefaults()
		{
			Main.buffNoTimeDisplay[Type] = true;
			DisplayName.SetDefault("Sandstorm Minion");
		}

		public override void Update(Player player, ref int buffIndex)
		{
			if (MinionType == -1)
				MinionType = ModContent.ProjectileType<Projectiles.SandstormMinion>();
			if (MinionID == -1 || Main.projectile[MinionID].type != MinionType || !Main.projectile[MinionID].active || Main.projectile[MinionID].owner != player.whoAmI)
			{
				Projectile proj = new Projectile();
				proj.SetDefaults(MinionType);
				MinionID = Projectile.NewProjectile(null, player.Center.X, player.Center.Y, 0, 0, MinionType, proj.damage, proj.knockBack, player.whoAmI);
			}
			else
			{
				Main.projectile[MinionID].timeLeft = 5;
			}
		}
	}
}
