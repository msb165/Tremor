using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Nano
{

	public class NanoDrill:TremorModItem
	{
		public override void SetDefaults()
		{

			item.damage = 18;
			item.DamageType = DamageClass.Melee;
			item.width = 20;
			item.height = 12;
			item.useTime = 8;
			item.useAnimation = 8;
			item.channel = true;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.pick = 200;
			item.tileBoost++;
			item.useStyle = 5;
			item.knockBack = 6;
			item.value = Item.buyPrice(0, 4, 50, 0);
			item.rare = 6;
			item.UseSound = SoundID.Item23;
			item.autoReuse = true;
			item.shoot = ModContent.ProjectileType<Projectiles.NanoDrillPro>();
			item.shootSpeed = 26f;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Nano Drill");
			Tooltip.SetDefault("");
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
