using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class Brainiac:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 17;
			Item.DamageType = DamageClass.Magic;
			Item.width = 68;
			Item.height = 28;
			Item.useTime = 30;
			Item.useAnimation = 30;
			Item.mana = 8;
			Item.shoot = ModContent.ProjectileType<Projectiles.BrainiacWavePro>();
			Item.shootSpeed = 5f;
			Item.useStyle = 5;
			Item.knockBack = 4;
			Item.value = 325000;

			Item.rare = 4;
			Item.UseSound = SoundID.Item114;
			Item.autoReuse = false;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Brainiac");
			// Tooltip.SetDefault("'Shoots mind waves'");
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-10, 0);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<TheBrain>(), 1);
			recipe.AddIngredient(ModContent.ItemType<AtisBlood>(), 15);
			recipe.AddIngredient(ModContent.ItemType<DrippingRoot>(), 20);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}

	}
}
