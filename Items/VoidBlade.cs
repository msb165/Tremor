using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Dark;

namespace Tremor.Items
{
	public class VoidBlade:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 72;
			Item.DamageType = DamageClass.Melee;
			Item.width = 46;
			Item.height = 48;
			Item.useTime = 44;
			Item.useAnimation = 44;
			Item.useStyle = 1;
			Item.knockBack = 3;
			Item.shoot = ModContent.ProjectileType<Projectiles.VoidBladePro>();
			Item.shootSpeed = 12f;
			Item.value = 12400;
			Item.rare = 11;
			Item.UseSound = SoundID.Item15;
			Item.autoReuse = false;
			Item.useTurn = false;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Void Blade");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.BrokenHeroSword, 1);
			recipe.AddIngredient(ItemID.HallowedBar, 25);
			recipe.AddIngredient(ItemID.Ectoplasm, 15);
			recipe.AddIngredient(ModContent.ItemType<DarkMatter>(), 45);
			recipe.AddIngredient(ModContent.ItemType<AirFragment>(), 10);
			recipe.AddIngredient(ModContent.ItemType<FireFragment>(), 10);
			recipe.AddIngredient(ModContent.ItemType<MultidimensionalFragment>(), 8);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}
	}
}
