using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Steel
{
	public class SteelPickaxe:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 6;
			Item.DamageType = DamageClass.Melee;
			Item.width = 32;
			Item.height = 32;
			Item.useTime = 16;
			Item.useAnimation = 20;
			Item.pick = 55;
			Item.useStyle = 1;
			Item.knockBack = 2;
			Item.value = 1000;
			Item.rare = 1;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Steel Pickaxe");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<SteelBar>(), 14);
			recipe.AddIngredient(ItemID.Wood, 3);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();
		}
	}
}
