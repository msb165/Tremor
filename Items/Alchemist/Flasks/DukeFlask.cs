using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Alchemist.Flasks
{
	public class DukeFlask : AlchemistItem
	{

		public override void SetDefaults()
		{
			Item.crit = 4;
			Item.damage = 74;
			Item.width = 30;
			Item.noUseGraphic = true;
			Item.height = 30;
			Item.useTime = 16;
			Item.useAnimation = 16;
			Item.shoot = ModContent.ProjectileType<Projectiles.Alchemic.DukeFlaskPro>();
			Item.shootSpeed = 9f;
			Item.useStyle = 1;
			Item.knockBack = 1;
			Item.UseSound = SoundID.Item106;
			Item.value = 20;
			Item.rare = 8;
			Item.maxStack = 999;
			Item.consumable = true;
			Item.autoReuse = false;

		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Duke Flask");
			/* Tooltip.SetDefault("Throws a flask that explodes into water tornados\n" +
"Tornados deal damage to enemies"); */
		}

		public override void UpdateInventory(Player player)
		{
			MPlayer modPlayer = MPlayer.GetModPlayer(player);
			if (player.FindBuffIndex(ModContent.BuffType<Buffs.LongFuseBuff>()) != -1)
			{
				Item.shootSpeed = 11f;
			}
			if (player.FindBuffIndex(ModContent.BuffType<Buffs.LongFuseBuff>()) < 1)
			{
				Item.shootSpeed = 8f;
			}
			if (modPlayer.core)
			{
				Item.autoReuse = true;
			}
			if (!modPlayer.core)
			{
				Item.autoReuse = false;
			}
		}
	}
}
