using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class FieryKunai:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 18;
			Item.height = 32;

			Item.DamageType = DamageClass.Throwing;
			Item.width = 18;
			Item.noUseGraphic = true;
			Item.maxStack = 999;
			Item.consumable = true;
			Item.useTime = 18;
			Item.useAnimation = 18;
			Item.shoot = ModContent.ProjectileType<Projectiles.FieryKunai>();
			Item.shootSpeed = 16f;
			Item.useStyle = 1;
			Item.knockBack = 4;
			Item.value = 60;
			Item.rare = 1;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Fiery Kunai");
			// Tooltip.SetDefault("50% chance to set enemy on fire");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<Kunai>(), 50);
			recipe.AddIngredient(ModContent.ItemType<FireFragment>());
			recipe.SetResult(this, 50);
			recipe.AddRecipe();
		}
	}
}
