using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Souls;

namespace Tremor.Items
{
	public class TheBooger:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 30;
			Item.height = 10;
			Item.value = Item.sellPrice(2, 0, 0, 0);
			Item.rare = 4;
			Item.noMelee = true;
			Item.useStyle = 5;
			Item.useAnimation = 40;
			Item.useTime = 40;
			Item.knockBack = 7.5F;
			Item.damage = 200;
			Item.scale = 1.1F;
			Item.noUseGraphic = true;
			Item.shoot = ModContent.ProjectileType<Projectiles.TheBoogerPro>();
			Item.shootSpeed = 15.9F;
			Item.UseSound = SoundID.Item1;
			Item.DamageType = DamageClass.Melee;
			Item.channel = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("The Booger");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<NightCore>(), 3);
			recipe.AddIngredient(ModContent.ItemType<CometiteBar>(), 15);
			recipe.AddIngredient(ModContent.ItemType<Squorb>(), 3);
			recipe.AddIngredient(ModContent.ItemType<LunarRoot>(), 18);
			recipe.AddIngredient(ModContent.ItemType<Catalyst>(), 3);
			recipe.AddIngredient(ModContent.ItemType<SoulofFight>(), 3);
			recipe.SetResult(this);
			recipe.AddTile(ModContent.TileType<Tiles.StarvilTile>());
			recipe.AddRecipe();
		}
	}
}
