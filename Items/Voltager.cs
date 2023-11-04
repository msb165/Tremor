using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Doom;

namespace Tremor.Items
{
	public class Voltager:TremorModItem
	{
		public override void SetDefaults()
		{

			item.damage = 212;
			item.DamageType = DamageClass.Magic;
			item.width = 28;
			item.height = 30;
			item.useTime = 30;
			item.useAnimation = 14;
			item.shoot = ModContent.ProjectileType<Projectiles.LightningBoltPro>();
			item.shootSpeed = 7f;
			item.mana = 6;
			item.useStyle = 5;
			item.knockBack = 3;
			item.value = 122355;
			item.rare = 5;
			item.UseSound = SoundID.Item117;
			item.autoReuse = false;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Voltager");
			Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<NightmareBar>(), 10);
			recipe.AddIngredient(3467, 10);
			recipe.AddIngredient(ModContent.ItemType<Doomstone>(), 9);
			recipe.AddIngredient(ModContent.ItemType<Phantaplasm>(), 12);
			recipe.AddIngredient(ModContent.ItemType<ConcentratedEther>(), 8);
			recipe.AddTile(412);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
