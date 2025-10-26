using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class TrueTerraBlade:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.rare = 10;
			Item.UseSound = SoundID.Item1;

			Item.useStyle = 1;
			Item.damage = 196;
			Item.useAnimation = 16;
			Item.useTime = 14;
			Item.width = 84;
			Item.height = 84;
			Item.shoot = 132;
			Item.scale = 1.1f;
			Item.shootSpeed = 15f;
			Item.knockBack = 6.5f;
			Item.DamageType = DamageClass.Melee;
			Item.value = Item.sellPrice(0, 20, 0, 0);
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("True Terra Blade");
			// Tooltip.SetDefault("'Shining, shimmering, splendid!'");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.TerraBlade, 1);
			recipe.AddIngredient(ModContent.ItemType<NightmareBar>(), 25);
			recipe.AddIngredient(ModContent.ItemType<SeaFragment>(), 30);
			recipe.AddIngredient(ModContent.ItemType<EarthFragment>(), 30);
			recipe.AddIngredient(ModContent.ItemType<FireFragment>(), 30);
			recipe.AddIngredient(ModContent.ItemType<AirFragment>(), 30);
			recipe.AddTile(412);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
