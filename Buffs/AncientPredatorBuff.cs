using Terraria;
using Terraria.ModLoader;

namespace Tremor.Buffs
{
	public class AncientPredatorBuff:TremorModBuff
	{
		int MinionType = -1;
		int MinionID = -1;

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The Ancient Predator");
			Description.SetDefault("The ancient predator defends you");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			if (MinionType == -1)
				MinionType = ModContent.ProjectileType<Projectiles.Minions.AncientPredator>();
			if (MinionID == -1 || Main.projectile[MinionID].type != MinionType || !Main.projectile[MinionID].active || Main.projectile[MinionID].owner != player.whoAmI)
			{
				Projectile proj = new Projectile();
				proj.SetDefaults(MinionType);
				MinionID = Projectile.NewProjectile(null, player.Center.X, player.Center.Y, 0, 0, MinionType, 300, 3, player.whoAmI);
			}
			else
			{
				Main.projectile[MinionID].timeLeft = 5;
			}
		}
	}
}