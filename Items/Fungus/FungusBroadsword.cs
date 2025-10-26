using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Fungus
{
	public class FungusBroadsword:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.rare = 3;
			Item.UseSound = SoundID.Item1;

			Item.useStyle = 1;
			Item.damage = 26;
			Item.useAnimation = 19;
			Item.useTime = 19;
			Item.width = 84;
			Item.height = 84;
			Item.shoot = 131;
			Item.shootSpeed = 15f;
			Item.knockBack = 3f;
			Item.DamageType = DamageClass.Melee;
			Item.value = Item.sellPrice(0, 0, 5, 0);
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Fungus Broadsword");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<FungusElement>(), 12);
			recipe.AddIngredient(ItemID.GlowingMushroom, 9);
			recipe.AddIngredient(ItemID.GoldBroadsword, 1);
			recipe.AddTile(16);
			recipe.SetResult(this);
			recipe.AddRecipe();

			recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<FungusElement>(), 12);
			recipe.AddIngredient(ItemID.GlowingMushroom, 9);
			recipe.AddIngredient(ItemID.PlatinumBroadsword, 1);
			recipe.AddTile(16);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
