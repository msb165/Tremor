using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Dark;

namespace Tremor.Items
{
	public class VoidBlade:TremorModItem
	{
		public override void SetDefaults()
		{

			item.damage = 72;
			item.DamageType = DamageClass.Melee;
			item.width = 46;
			item.height = 48;
			item.useTime = 44;
			item.useAnimation = 44;
			item.useStyle = 1;
			item.knockBack = 3;
			item.shoot = ModContent.ProjectileType<Projectiles.VoidBladePro>();
			item.shootSpeed = 12f;
			item.value = 12400;
			item.rare = 11;
			item.UseSound = SoundID.Item15;
			item.autoReuse = false;
			item.useTurn = false;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Void Blade");
			Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
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
