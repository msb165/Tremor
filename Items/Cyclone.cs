using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Ancient;

namespace Tremor.Items
{
	public class Cyclone:TremorModItem
	{
		public override void SetDefaults()
		{

			item.damage = 84;
			item.width = 14;
			item.height = 84;
			item.DamageType = DamageClass.Magic;
			item.mana = 16;
			item.useTime = 12;
			item.useAnimation = 12;
			item.shoot = ModContent.ProjectileType<Projectiles.CyclonePro>();
			item.shootSpeed = 4f;
			item.useStyle = 5;
			item.knockBack = 4;
			item.value = 230000;
			item.rare = 10;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cyclone");
			Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<AncientTechnology>(), 1);
			recipe.AddIngredient(3457, 30);
			recipe.AddIngredient(ModContent.ItemType<SeaFragment>(), 25);
			recipe.SetResult(this);
			recipe.AddTile(412);
			recipe.AddRecipe();
		}
	}
}
