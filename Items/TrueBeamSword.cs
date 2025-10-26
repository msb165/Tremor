using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class TrueBeamSword:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 92;
			Item.DamageType = DamageClass.Melee;
			Item.width = 50;
			Item.height = 52;
			Item.useTime = 45;
			Item.useAnimation = 15;
			Item.useStyle = 1;
			Item.shoot = 116;
			Item.shootSpeed = 15f;
			Item.knockBack = 8;

			Item.value = 750000;
			Item.rare = 6;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = false;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("True Beam Sword");
			// Tooltip.SetDefault("Shoots a beam of light");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.EnchantedSword, 1);
			recipe.AddIngredient(ItemID.BeamSword, 1);
			recipe.AddIngredient(ModContent.ItemType<MagiumShard>(), 25);
			recipe.AddIngredient(ItemID.BrokenHeroSword, 1);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}
	}
}
