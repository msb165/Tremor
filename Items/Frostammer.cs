using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class Frostammer:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 100;
			Item.DamageType = DamageClass.Melee;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.hammer = 95;
			Item.useStyle = 1;
			Item.knockBack = 7;
			Item.value = 1040;
			Item.rare = 9;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Frostammer");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<FrostoneBar>(), 15);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
}

