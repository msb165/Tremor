using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Ancient
{
	public class AncientFlail:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 30;
			Item.height = 10;
			Item.rare = 10;
			Item.noMelee = true;
			Item.useStyle = 5;
			Item.useAnimation = 40;
			Item.useTime = 40;
			Item.knockBack = 7.5F;
			Item.damage = 106;
			Item.scale = 1.1F;
			Item.noUseGraphic = true;
			Item.shoot = ModContent.ProjectileType<Projectiles.AncientFlailPro>();
			Item.shootSpeed = 13f;
			Item.UseSound = SoundID.Item1;
			Item.DamageType = DamageClass.Melee;
			Item.channel = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Ancient Flail");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<AncientTablet>(), 9);
			recipe.AddIngredient(ItemID.Chain, 8);
			recipe.SetResult(this);
			recipe.AddTile(412);
			recipe.AddRecipe();
		}
	}
}
