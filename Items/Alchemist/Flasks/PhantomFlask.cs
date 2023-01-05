using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Projectiles.Alchemic;

namespace Tremor.Items.Alchemist.Flasks
{
	public class PhantomFlask : AlchemistItem
	{

		public override void SetDefaults()
		{
			item.crit = 4;
			item.damage = 60;
			//item.DamageType = DamageClass.Throwing;
			item.width = 26;
			item.noUseGraphic = true;
			item.maxStack = 999;
			item.consumable = true;
			item.height = 30;
			item.useTime = 20;
			item.useAnimation = 20;
			item.shoot = ModContent.ProjectileType<Projectiles.Alchemic.PhantomFlaskPro>();
			item.shootSpeed = 8f;
			item.useStyle = 1;
			item.knockBack = 1;
			item.UseSound = SoundID.Item106;
			item.value = 120;
			item.rare = 1;
			item.autoReuse = false;

			item.ammo = ModContent.ItemType<BoomFlask>();
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Phantom Flask");
			Tooltip.SetDefault("Throws a flask that explodes into clouds\n" +
"Clouds deal damage to enemies and burn them with shadowflames");
		}

		public override void PickAmmo(Item weapon, Player player, ref int type, ref float speed, ref StatModifier damage, ref float knockback)
		{
			type = ModContent.ProjectileType<ShadowCloudPro>();
		}

		public override void UpdateInventory(Player player)
		{
			MPlayer modPlayer = MPlayer.GetModPlayer(player);
			if (modPlayer.novaHelmet)
			{
				item.autoReuse = true;
			}
			if (!modPlayer.novaHelmet)
			{
				item.autoReuse = false;
			}

			if (player.FindBuffIndex(ModContent.BuffType<Buffs.LongFuseBuff>()) != -1)
			{
				item.shootSpeed = 11f;
			}
			if (player.FindBuffIndex(ModContent.BuffType<Buffs.LongFuseBuff>()) < 1)
			{
				item.shootSpeed = 8f;
			}
			if (modPlayer.core)
			{
				item.autoReuse = true;
			}
			if (!modPlayer.core)
			{
				item.autoReuse = false;
			}
		}

	}
}
