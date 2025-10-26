using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Fungus
{
	public class FungusHamaxe:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 16;
			Item.DamageType = DamageClass.Melee;
			Item.width = 32;
			Item.height = 32;
			Item.useTime = 22;
			Item.useAnimation = 18;
			Item.axe = 13;
			Item.hammer = 75;
			Item.useStyle = 1;
			Item.knockBack = 2;
			Item.value = 1000;
			Item.rare = 3;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Fungus Hamaxe");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<FungusElement>(), 11);
			recipe.AddIngredient(ItemID.GlowingMushroom, 8);
			recipe.AddIngredient(ItemID.GoldAxe, 1);
			recipe.AddIngredient(ItemID.GoldHammer, 1);
			recipe.AddTile(16);
			recipe.SetResult(this);
			recipe.AddRecipe();

			recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<FungusElement>(), 11);
			recipe.AddIngredient(ItemID.GlowingMushroom, 8);
			recipe.AddIngredient(ItemID.PlatinumAxe, 1);
			recipe.AddIngredient(ItemID.PlatinumHammer, 1);
			recipe.AddTile(16);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
