using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Buffs;
using Tremor.Projectiles;

namespace Tremor.Items
{
	public class EmeraldStone:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 20;
			Item.height = 22;
			Item.useTime = 19;
			Item.useAnimation = 20;
			Item.useStyle = 4;
			Item.value = 50000;
			Item.rare = 3;
			Item.maxStack = 1;
			Item.UseSound = SoundID.Item8;
			Item.autoReuse = false;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Emerald Stone");
			// Tooltip.SetDefault("Summons Emeraldy which lights the area");
		}

		public override bool? UseItem(Player player)
		{
			player.AddBuff(ModContent.BuffType<EmeraldStoneBuff>(), 2);
			for (int i = 0; i < Main.projectile.Length; i++)
			{
				if (Main.projectile[i].type == ModContent.ProjectileType<Emeraldy>() && Main.projectile[i].owner == player.whoAmI)
				{
					Main.projectile[i].Center = Main.player[player.whoAmI].Center;
				}
			}
			return true;
		}
	}
}
