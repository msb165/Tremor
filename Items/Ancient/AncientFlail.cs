using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Ancient
{
	public class AncientFlail:TremorModItem
	{
		public override void SetDefaults()
		{

			item.width = 30;
			item.height = 10;
			item.rare = 10;
			item.noMelee = true;
			item.useStyle = 5;
			item.useAnimation = 40;
			item.useTime = 40;
			item.knockBack = 7.5F;
			item.damage = 106;
			item.scale = 1.1F;
			item.noUseGraphic = true;
			item.shoot = ModContent.ProjectileType<Projectiles.AncientFlailPro>();
			item.shootSpeed = 13f;
			item.UseSound = SoundID.Item1;
			item.DamageType = DamageClass.Melee;
			item.channel = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ancient Flail");
			Tooltip.SetDefault("");
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
