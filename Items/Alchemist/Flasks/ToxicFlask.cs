using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Projectiles.Alchemic;

namespace Tremor.Items.Alchemist.Flasks
{
	public class ToxicFlask : AlchemistItem
	{
		public override void SetDefaults()
		{
			Item.damage = 46;
			Item.width = 28;
			Item.noUseGraphic = true;
			Item.maxStack = 1;
			Item.consumable = false;
			Item.height = 28;
			Item.useTime = 28;
			Item.useAnimation = 28;
			Item.shoot = ModContent.ProjectileType<ToxicFlaskPro>();
			Item.shootSpeed = 9f;
			Item.useStyle = 1;
			Item.knockBack = 4;
			Item.noMelee = true;
			Item.UseSound = SoundID.Item106;
			Item.value = Item.sellPrice(0, 2, 0, 0);
			Item.rare = 8;
			Item.autoReuse = false;
			Item.crit = 4;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Toxic Flask");
			// Tooltip.SetDefault("Throws a flask that explodes into toxic clouds");
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
				Item.shootSpeed = 9f;
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
			var recipe = new ModRecipe();
			recipe.AddIngredient(this);
			recipe.SetResult(3105);
			recipe.AddRecipe();

			recipe = new ModRecipe();
			recipe.AddIngredient(3105);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
