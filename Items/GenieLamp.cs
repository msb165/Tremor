using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class GenieLamp:TremorModItem
	{
		public override void SetDefaults()
		{

			item.width = 38;
			item.height = 20;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 4;
			item.value = 40000;
			item.rare = 2;
			item.UseSound = SoundID.Item8;
			item.autoReuse = false;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Genie Lamp");
			Tooltip.SetDefault("Summons a Genie");
		}

		public override bool? UseItem(Player player)
		{
			player.AddBuff(ModContent.BuffType<Buffs.petGenie>(), 2);
			for (int i = 0; i < Main.projectile.Length; i++)
				if (Main.projectile[i].type == ModContent.ProjectileType<Projectiles.projGenie>() && Main.projectile[i].owner == player.whoAmI)
					Main.projectile[i].Center = Main.player[player.whoAmI].Center;
			return true;
		}
	}
}
