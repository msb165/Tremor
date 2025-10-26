using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class MeatClub:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 52;
			Item.DamageType = DamageClass.Melee;
			Item.width = 44;
			Item.height = 44;
			Item.useTime = 26;
			Item.useAnimation = 26;
			Item.useStyle = 1;
			Item.knockBack = 9;
			Item.value = 60000;
			Item.rare = 3;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = false;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Meat Club");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.Wood, 5);
			recipe.AddIngredient(ItemID.Rope, 5);
			recipe.AddIngredient(ModContent.ItemType<MeatChunk>(), 15);
			recipe.SetResult(this);
			recipe.AddTile(14);
			recipe.AddRecipe();
		}
	}
}
