using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class Rockmine:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 26;
			Item.DamageType = DamageClass.Throwing;
			Item.width = 26;
			Item.noUseGraphic = true;
			Item.maxStack = 999;
			Item.consumable = true;
			Item.height = 30;
			Item.useTime = 25;
			Item.useAnimation = 25;
			Item.shoot = ModContent.ProjectileType<Projectiles.RockminePro>();
			Item.shootSpeed = 11f;
			Item.useStyle = 1;
			Item.knockBack = 4;
			Item.value = 7;
			Item.rare = 3;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Rockmine");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.StoneBlock, 15);
			recipe.AddIngredient(ModContent.ItemType<RockHorn>(), 3);
			recipe.SetResult(this, 25);
			recipe.AddTile(14);
			recipe.AddRecipe();
		}
	}
}
