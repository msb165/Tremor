﻿using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace Tremor.Buffs
{
	public class petGenie:TremorModBuff
	{
		public int MyDzhin = -1;

		public override void SetDefaults()
		{
			DisplayName.SetDefault("Genie");
			Description.SetDefault("A Genie follows you and shows location of enemies");
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			foreach (NPC npc in Main.npc)
			{
				if (npc.friendly || npc.lifeMax <= 5 || !npc.active || npc.Distance(player.position) > 750)
					continue;
				Lighting.AddLight(npc.Center, new Vector3(0, 0, 1));
			}
			if (MyDzhin == -1)
				MyDzhin = Projectile.NewProjectile(null, player.Center.X, player.Center.Y, 0, 0, ModContent.ProjectileType<Projectiles.projGenie>(), 0, 0, 0);
			if (!Main.projectile[MyDzhin].active || Main.projectile[MyDzhin].type != ModContent.ProjectileType<Projectiles.projGenie>())
				MyDzhin = Projectile.NewProjectile(null, player.Center.X, player.Center.Y, 0, 0, ModContent.ProjectileType<Projectiles.projGenie>(), 0, 0, 0);
			Main.projectile[MyDzhin].timeLeft = 2;
			player.buffTime[buffIndex] = 2;
		}
	}
}