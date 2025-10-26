using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Coral
{
	public class CoralHamaxe:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 8;
			Item.DamageType = DamageClass.Melee;
			Item.width = 36;
			Item.height = 34;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.axe = 9;
			Item.hammer = 60;
			Item.useStyle = 1;
			Item.knockBack = 4;
			Item.value = 100;
			Item.rare = 1;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Coral Hamaxe");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.Coral, 10);
			recipe.SetResult(this);
			recipe.AddTile(18);
			recipe.AddRecipe();
		}
	}
}
