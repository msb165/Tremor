using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Alchemist.Flasks
{
	public class BoomFlask : AlchemistItem
	{

		public override void SetDefaults()
		{
			Item.crit = 4;
			Item.damage = 18;
			//Item.DamageType = DamageClass.Throwing;
			Item.width = 26;
			Item.noUseGraphic = true;
			Item.maxStack = 999;
			Item.consumable = true;
			Item.height = 30;
			Item.useTime = 40;
			Item.useAnimation = 40;
			Item.shoot = ModContent.ProjectileType<Projectiles.Alchemic.BoomFlaskPro>();
			Item.shootSpeed = 10f;
			Item.useStyle = 1;
			Item.knockBack = 1;
			Item.UseSound = SoundID.Item106;
			Item.value = 145;
			Item.rare = 2;
			Item.autoReuse = false;

		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Boom Flask");
			// Tooltip.SetDefault("A vial of exploding chemicals");
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
