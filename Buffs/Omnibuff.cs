using Terraria;
using Terraria.ModLoader;

namespace Tremor.Buffs
{
	public class Omnibuff:TremorModBuff
	{
		int MinionType = -1;
		int MinionID = -1;

		public override void SetStaticDefaults()
		{
			Main.buffNoTimeDisplay[Type] = true;
			// DisplayName.SetDefault("Omnibuff");
			// Description.SetDefault("Summons a monster that destroys your enemies");
		}

		public override void Update(Player player, ref int buffIndex)
		{
			if (MinionType == -1)
				MinionType = ModContent.ProjectileType<Projectiles.OmnikronBeast>();
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
