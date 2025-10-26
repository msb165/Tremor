using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Ancient
{
	public class AncientDagger:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 96;
			Item.DamageType = DamageClass.Throwing;
			Item.width = 26;
			Item.noUseGraphic = true;
			Item.maxStack = 999;
			Item.consumable = true;
			Item.height = 42;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.shoot = ModContent.ProjectileType<Projectiles.AncientDaggerPro>();
			Item.shootSpeed = 22f;
			Item.useStyle = 1;
			Item.knockBack = 4;
			Item.value = 7;
			Item.rare = 10;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = false;

		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Ancient Dagger");
			// Tooltip.SetDefault("Throws an exploding dagger");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<AncientTablet>());
			recipe.AddIngredient(ItemID.ThrowingKnife, 25);
			recipe.SetResult(this, 25);
			recipe.AddTile(412);
			recipe.AddRecipe();
		}
	}
}
