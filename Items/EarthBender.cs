using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class EarthBender:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 42;
			Item.DamageType = DamageClass.Melee;
			Item.width = 56;
			Item.height = 56;
			Item.useTime = 25;
			Item.useAnimation = 30;
			Item.useStyle = 1;
			Item.knockBack = 3;
			Item.value = 12000;
			Item.rare = 4;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Earth Bender");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<ColossusSword>(), 1);
			recipe.AddIngredient(ModContent.ItemType<EarthFragment>(), 12);
			recipe.AddIngredient(ItemID.SoulofLight, 8);
			recipe.AddIngredient(ItemID.SoulofNight, 8);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();
		}
	}
}
