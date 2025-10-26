using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Wolf;

namespace Tremor.Items
{
	public class HuntingSpear:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 18;
			Item.width = 14;
			Item.height = 84;
			Item.noUseGraphic = true;
			Item.DamageType = DamageClass.Melee;
			Item.useTime = 30;
			Item.shoot = ModContent.ProjectileType<Projectiles.HuntingSpearPro>();
			Item.shootSpeed = 3f;
			Item.useAnimation = 30;
			Item.useStyle = 5;
			Item.knockBack = 4;
			Item.value = 900;
			Item.rare = 1;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = false;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Hunting Spear");
			// Tooltip.SetDefault("");
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
