using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Wolf;

namespace Tremor.Items
{
	public class HuntingSpear:TremorModItem
	{
		public override void SetDefaults()
		{

			item.damage = 18;
			item.width = 14;
			item.height = 84;
			item.noUseGraphic = true;
			item.DamageType = DamageClass.Melee;
			item.useTime = 30;
			item.shoot = ModContent.ProjectileType<Projectiles.HuntingSpearPro>();
			item.shootSpeed = 3f;
			item.useAnimation = 30;
			item.useStyle = 5;
			item.knockBack = 4;
			item.value = 900;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hunting Spear");
			Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<WolfPelt>(), 5);
			recipe.AddIngredient(ItemID.BorealWood, 20);
			recipe.AddIngredient(ModContent.ItemType<AlphaClaw>(), 2);
			recipe.AddTile(18);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
