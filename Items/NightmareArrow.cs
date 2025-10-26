using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class NightmareArrow:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 18;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 26;
			Item.maxStack = 999;
			Item.consumable = true;
			Item.height = 30;

			Item.shoot = ModContent.ProjectileType<Projectiles.NightmareArrowPro>();
			Item.shootSpeed = 22f;
			Item.knockBack = 4;
			Item.value = 10;
			Item.rare = 11;
			Item.ammo = AmmoID.Arrow;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Nightmare Arrow");
			// Tooltip.SetDefault("'Enemies die... from fear.'");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<NightmareBar>(), 1);
			recipe.AddIngredient(ItemID.WoodenArrow, 150);
			recipe.SetResult(this, 150);
			recipe.AddTile(412);
			recipe.AddRecipe();
		}
	}
}
