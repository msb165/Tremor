using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class PoisonJavelin:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 23;
			Item.DamageType = DamageClass.Throwing;
			Item.width = 18;
			Item.noUseGraphic = true;
			Item.maxStack = 999;
			Item.consumable = true;
			Item.height = 38;
			Item.useTime = 32;
			Item.useAnimation = 32;
			Item.shoot = ModContent.ProjectileType<Projectiles.PoisonJavelinPro>();
			Item.shootSpeed = 16f;
			Item.useStyle = 1;
			Item.knockBack = 4;
			Item.value = 60;
			Item.rare = 3;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Poison Javelin");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<JungleAlloy>(), 1);
			recipe.AddIngredient(ItemID.Stinger, 1);
			recipe.AddIngredient(ItemID.Vine, 1);
			recipe.SetResult(this, 50);
			recipe.AddTile(ModContent.TileType<Tiles.GreatAnvilTile>());
			recipe.AddRecipe();
		}
	}
}
