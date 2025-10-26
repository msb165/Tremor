using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Projectiles.Alchemic;

namespace Tremor.Items.Alchemist.Flasks
{
	public class SuperHealingFlask : AlchemistItem
	{
		public override void SetDefaults()
		{
			Item.crit = 4;
			Item.damage = 96;
			Item.DamageType = DamageClass.Throwing;
			Item.width = 26;
			Item.noUseGraphic = true;
			Item.maxStack = 999;
			Item.consumable = true;
			Item.height = 30;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.shoot = ModContent.ProjectileType<Projectiles.Alchemic.SuperHealingFlaskPro>();
			Item.shootSpeed = 8f;
			Item.useStyle = 1;
			Item.knockBack = 1;
			Item.UseSound = SoundID.Item106;
			Item.value = 7;

			Item.rare = 8;
			Item.autoReuse = false;
			Item.ammo = ModContent.ItemType<BoomFlask>();
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Super Healing Flask");
			/* Tooltip.SetDefault("Throws a flask that explodes into clouds\n" +
"Clouds deal damage to enemies and restore health"); */
		}

		public override void PickAmmo(Item weapon, Player player, ref int type, ref float speed, ref StatModifier damage, ref float knockback)
		{
			type = ModContent.ProjectileType<HealingCloudPro>();
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
			recipe.AddIngredient(ModContent.ItemType<BigHealingFlack>(), 20);
			recipe.AddIngredient(3456, 1);
			recipe.AddIngredient(ModContent.ItemType<AngryShard>(), 1);
			recipe.SetResult(this, 20);
			recipe.AddRecipe();

			recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<BigHealingFlack>(), 20);
			recipe.AddIngredient(3457, 1);
			recipe.AddIngredient(ModContent.ItemType<AngryShard>(), 1);
			recipe.SetResult(this, 20);
			recipe.AddRecipe();

			recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<BigHealingFlack>(), 20);
			recipe.AddIngredient(3458, 1);
			recipe.AddIngredient(ModContent.ItemType<AngryShard>(), 1);
			recipe.SetResult(this, 20);
			recipe.AddRecipe();

			recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<BigHealingFlack>(), 20);
			recipe.AddIngredient(3459, 1);
			recipe.AddIngredient(ModContent.ItemType<AngryShard>(), 1);
			recipe.SetResult(this, 20);
			recipe.AddRecipe();
		}

	}
}
