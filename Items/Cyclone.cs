using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Ancient;

namespace Tremor.Items
{
	public class Cyclone:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 84;
			Item.width = 14;
			Item.height = 84;
			Item.DamageType = DamageClass.Magic;
			Item.mana = 16;
			Item.useTime = 12;
			Item.useAnimation = 12;
			Item.shoot = ModContent.ProjectileType<Projectiles.CyclonePro>();
			Item.shootSpeed = 4f;
			Item.useStyle = 5;
			Item.knockBack = 4;
			Item.value = 230000;
			Item.rare = 10;
			Item.UseSound = SoundID.Item20;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Cyclone");
			// Tooltip.SetDefault("");
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
