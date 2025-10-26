using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class PlatinumKunai:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 19;
			Item.height = 32;
			Item.DamageType = DamageClass.Throwing;
			Item.width = 18;
			Item.noUseGraphic = true;
			Item.maxStack = 999;
			Item.consumable = true;
			Item.useTime = 17;
			Item.useAnimation = 17;
			Item.shoot = ModContent.ProjectileType<Projectiles.PlatinumKunai>();
			Item.shootSpeed = 17f;
			Item.useStyle = 1;
			Item.knockBack = 4;
			Item.value = 60;
			Item.rare = 1;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Platinum Kunai");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<Kunai>(), 50);
			recipe.AddIngredient(ItemID.PlatinumBar, 3);
			recipe.SetResult(this, 50);
			recipe.AddRecipe();
		}
	}
}
