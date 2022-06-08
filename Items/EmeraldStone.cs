using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Buffs;
using Tremor.Projectiles;

namespace Tremor.Items
{
	public class EmeraldStone : ModItem
	{
		public override void SetDefaults()
		{

			item.width = 20;
			item.height = 22;
			item.useTime = 19;
			item.useAnimation = 20;
			item.useStyle = 4;
			item.value = 50000;
			item.rare = 3;
			item.maxStack = 1;
			item.UseSound = SoundID.Item8;
			item.autoReuse = false;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Emerald Stone");
			Tooltip.SetDefault("Summons Emeraldy which lights the area");
		}

		public override bool UseItem(Player player)
		{
			player.AddBuff(ModContent.BuffType<EmeraldStoneBuff>(), 2);
			for (int i = 0; i < Main.projectile.Length; i++)
			{
				if (Main.projectile[i].type == ModContent.ProjectileType<Emeraldy>() && Main.projectile[i].owner == item.owner)
				{
					Main.projectile[i].Center = Main.player[item.owner].Center;
				}
			}
			return true;
		}
	}
}
