using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Steel
{
	public class SteelSpear:TremorModItem
	{
		public override void SetDefaults()
		{

			item.damage = 16;
			item.width = 54;
			item.height = 54;
			item.noUseGraphic = true;
			item.DamageType = DamageClass.Melee;
			item.useTime = 30;
			item.shoot = ModContent.ProjectileType<Projectiles.SteelSpear>();
			item.shootSpeed = 3f;
			item.useAnimation = 30;
			item.useStyle = 5;
			item.knockBack = 4;
			item.value = 1000;
			item.rare = 0;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Steel Spear");
			Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<SteelBar>(), 13);
			recipe.AddIngredient(ItemID.Wood, 6);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();
		}
	}
}
