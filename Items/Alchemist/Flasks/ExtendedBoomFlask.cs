using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Alchemist.Flasks
{
	public class ExtendedBoomFlask : AlchemistItem
	{
		public override void SetDefaults()
		{
			Item.crit = 4;
			Item.damage = 54;
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
			// DisplayName.SetDefault("Extended Boom Flask");
			// Tooltip.SetDefault("A vial of exploding chemicals");
		}

		public override void UpdateInventory(Player player)
		{
			if (player.HasBuffSafe(ModContent.BuffType<Buffs.LongFuseBuff>()))
			{
				Item.shootSpeed = 11f;
			}
			else
			{
				Item.shootSpeed = 8f;
			}

			Item.autoReuse = MPlayer.GetModPlayer(player).core;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<BoomFlask>(), 25);
			recipe.AddIngredient(1347, 1);
			recipe.AddIngredient(ItemID.SoulofNight, 1);
			recipe.AddIngredient(ModContent.ItemType<GelCube>(), 1);
			recipe.SetResult(this, 20);
			recipe.AddRecipe();
		}
	}
}
