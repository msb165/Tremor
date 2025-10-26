using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class Rockspear:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 30;
			Item.width = 14;
			Item.height = 84;
			Item.noUseGraphic = true;
			Item.DamageType = DamageClass.Melee;
			Item.useTime = 35;
			Item.shoot = ModContent.ProjectileType<Projectiles.RockspearPro>();
			Item.shootSpeed = 3f;
			Item.useAnimation = 35;
			Item.useStyle = 5;
			Item.knockBack = 4;
			Item.value = 900;
			Item.rare = 1;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = false;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Rockspear");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.Wood, 20);
			recipe.AddIngredient(ItemID.Rope, 20);
			recipe.AddIngredient(ItemID.StoneBlock, 5);
			recipe.AddIngredient(ModContent.ItemType<Gloomstone>(), 25);
			recipe.AddIngredient(ModContent.ItemType<RockHorn>(), 3);
			recipe.AddTile(16);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
