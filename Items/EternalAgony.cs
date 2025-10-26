using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Dark;

namespace Tremor.Items
{
	public class EternalAgony:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 30;
			Item.height = 10;
			Item.value = Item.sellPrice(2, 0, 0, 0);

			Item.rare = 4;
			Item.noMelee = true;
			Item.useStyle = 5;
			Item.useAnimation = 40;
			Item.useTime = 40;
			Item.knockBack = 7.5F;
			Item.damage = 76;
			Item.scale = 1.1F;
			Item.noUseGraphic = true;
			Item.shoot = ModContent.ProjectileType<Projectiles.EternalAgonyPro>();
			Item.shootSpeed = 20.9F;
			Item.UseSound = SoundID.Item1;
			Item.DamageType = DamageClass.Melee;
			Item.channel = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Eternal Agony");
			// Tooltip.SetDefault("Inflicts Shadow Flames on foes");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<DarkMatter>(), 50);
			recipe.AddIngredient(ItemID.DarkShard, 1);
			recipe.AddIngredient(ItemID.LightShard, 1);
			recipe.SetResult(this);
			recipe.AddTile(26);
			recipe.AddRecipe();
		}
	}
}
