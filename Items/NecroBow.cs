using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class NecroBow:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 36;
			Item.width = 16;
			Item.height = 32;
			Item.useTime = 38;
			Item.DamageType = DamageClass.Ranged;
			Item.shoot = 1;
			Item.shootSpeed = 22f;
			Item.useAnimation = 30;
			Item.useStyle = 5;
			Item.knockBack = 5;
			Item.value = 12540;
			Item.useAmmo = AmmoID.Arrow;
			Item.rare = 3;
			Item.UseSound = SoundID.Item5;
			Item.autoReuse = false;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Necro Bow");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.Bone, 25);
			recipe.AddIngredient(ItemID.Cobweb, 30);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();
		}
	}
}
