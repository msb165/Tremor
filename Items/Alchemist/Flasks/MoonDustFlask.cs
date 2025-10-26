using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Alchemist.Flasks
{
	public class MoonDustFlask : AlchemistItem
	{

		public override void SetDefaults()
		{
			Item.crit = 4;
			Item.damage = 92;
			//Item.DamageType = DamageClass.Throwing;
			Item.width = 26;
			Item.noUseGraphic = true;
			Item.maxStack = 999;
			Item.consumable = true;
			Item.height = 30;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.shoot = ModContent.ProjectileType<Projectiles.Alchemic.MoonDustFlaskPro>();
			Item.shootSpeed = 8f;
			Item.useStyle = 1;
			Item.knockBack = 1;
			Item.UseSound = SoundID.Item106;
			Item.value = 30;
			Item.rare = 1;
			Item.autoReuse = false;

		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Moon Dust Flask");
			// Tooltip.SetDefault("Throws a flask that explodes into moon exlposions");
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
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.Bottle, 1);
			recipe.AddIngredient(3460, 3);
			recipe.AddIngredient(ModContent.ItemType<GelCube>(), 1);
			recipe.SetResult(this, 15);
			recipe.AddRecipe();
		}

	}
}
