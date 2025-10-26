using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class VampireDagger:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 48;
			Item.DamageType = DamageClass.Throwing;
			Item.width = 26;
			Item.noUseGraphic = true;
			Item.maxStack = 999;
			Item.consumable = true;
			Item.height = 30;
			Item.useTime = 15;
			Item.useAnimation = 20;
			Item.shoot = 304;
			Item.shootSpeed = 15f;
			Item.useStyle = 1;
			Item.knockBack = 4;
			Item.value = 7;
			Item.rare = 5;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = false;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Vampire Dagger");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<SkullTeeth>());
			recipe.SetResult(this, 100);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}
	}
}
