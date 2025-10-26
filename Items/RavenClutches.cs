using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class RavenClutches:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 29;
			Item.DamageType = DamageClass.Melee;
			Item.width = 28;
			Item.height = 18;
			Item.useTime = 9;
			Item.useAnimation = 9;
			Item.useStyle = 1;
			Item.knockBack = 3;
			Item.value = 6400;
			Item.rare = 4;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.useTurn = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Raven Clutches");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.SilverBar, 10);
			recipe.AddIngredient(ModContent.ItemType<Opal>(), 1);
			recipe.AddIngredient(ModContent.ItemType<RavenFeather>(), 13);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();

			recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.TungstenBar, 10);
			recipe.AddIngredient(ModContent.ItemType<Opal>(), 1);
			recipe.AddIngredient(ModContent.ItemType<RavenFeather>(), 13);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();
		}
	}
}
