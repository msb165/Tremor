using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Projectiles.Alchemic;

namespace Tremor.Items.Alchemist.Flasks
{
	public class BigVenomFlask : AlchemistItem
	{

		public override void SetDefaults()
		{
			Item.crit = 4;
			Item.damage = 60;
			//Item.DamageType = DamageClass.Throwing;
			Item.width = 26;
			Item.noUseGraphic = true;
			Item.maxStack = 999;
			Item.consumable = true;
			Item.height = 30;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.shoot = ModContent.ProjectileType<Projectiles.Alchemic.BigVenomFlaskPro>();
			Item.shootSpeed = 8f;
			Item.useStyle = 1;
			Item.knockBack = 1;
			Item.UseSound = SoundID.Item106;
			Item.value = 200;
			Item.rare = 4;
			Item.autoReuse = false;

			Item.ammo = ModContent.ItemType<BoomFlask>();
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Big Venom Flask");
			/* Tooltip.SetDefault("Throws a flask that explodes into venom clouds\n" +
"Clouds deal damage to enemies and poison them"); */
		}

		public override void PickAmmo(Item weapon, Player player, ref int type, ref float speed, ref StatModifier damage, ref float knockback)
		{
			type = ModContent.ProjectileType<PurpleCloudPro>();
		}

		public override void UpdateInventory(Player player)
		{
			MPlayer modPlayer = MPlayer.GetModPlayer(player);
			if (modPlayer.novaHelmet)
			{
				Item.autoReuse = true;
			}
			if (!modPlayer.novaHelmet)
			{
				Item.autoReuse = false;
			}

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
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<LesserVenomFlask>(), 40);
			recipe.AddIngredient(ItemID.Vine, 2);
			recipe.AddIngredient(ItemID.SoulofNight, 3);
			recipe.SetResult(this, 25);
			recipe.AddRecipe();
		}

	}
}
