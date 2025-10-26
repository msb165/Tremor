using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Nano
{

	public class NanoDrill:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 18;
			Item.DamageType = DamageClass.Melee;
			Item.width = 20;
			Item.height = 12;
			Item.useTime = 8;
			Item.useAnimation = 8;
			Item.channel = true;
			Item.noUseGraphic = true;
			Item.noMelee = true;
			Item.pick = 200;
			Item.tileBoost++;
			Item.useStyle = 5;
			Item.knockBack = 6;
			Item.value = Item.buyPrice(0, 4, 50, 0);
			Item.rare = 6;
			Item.UseSound = SoundID.Item23;
			Item.autoReuse = true;
			Item.shoot = ModContent.ProjectileType<Projectiles.NanoDrillPro>();
			Item.shootSpeed = 26f;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Nano Drill");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<NanoBar>(), 16);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}
	}
}
