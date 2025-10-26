using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Invar
{
	public class InvarPickaxe:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 6;
			Item.DamageType = DamageClass.Melee;
			Item.width = 36;
			Item.height = 36;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.pick = 45;
			Item.useStyle = 1;
			Item.knockBack = 3;
			Item.value = 100;
			Item.rare = 1;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Invar Pickaxe");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<InvarBar>(), 12);
			recipe.AddIngredient(ItemID.Wood, 3);
			recipe.AddTile(16);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
