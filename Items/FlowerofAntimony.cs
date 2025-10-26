using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class FlowerofAntimony:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 60;
			Item.DamageType = DamageClass.Magic;
			Item.mana = 11;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 18;
			Item.useAnimation = 18;
			Item.useStyle = 5;
			Item.noMelee = true;
			Item.knockBack = 3;
			Item.value = 13800;
			Item.rare = 4;
			Item.UseSound = SoundID.Item43;
			Item.autoReuse = false;
			Item.staff[Item.type] = true;
			Item.shoot = ModContent.ProjectileType<Projectiles.FlowerofAntimony>();
			Item.shootSpeed = 15f;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Flower of Antimony");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<RuneBar>(), 12);
			recipe.AddIngredient(ModContent.ItemType<Gloomstone>(), 15);
			recipe.AddIngredient(ModContent.ItemType<Jellyxir>(), 6);
			recipe.SetResult(this);
			recipe.AddTile(ModContent.TileType<Tiles.AlchematorTile>());
			recipe.AddRecipe();
		}
	}
}
