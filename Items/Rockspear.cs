using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class Rockspear:TremorModItem
	{
		public override void SetDefaults()
		{

			item.damage = 30;
			item.width = 14;
			item.height = 84;
			item.noUseGraphic = true;
			item.DamageType = DamageClass.Melee;
			item.useTime = 35;
			item.shoot = ModContent.ProjectileType<Projectiles.RockspearPro>();
			item.shootSpeed = 3f;
			item.useAnimation = 35;
			item.useStyle = 5;
			item.knockBack = 4;
			item.value = 900;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Rockspear");
			Tooltip.SetDefault("");
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
