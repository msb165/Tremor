using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Wolf;

namespace Tremor.Items
{
	public class HuntingBow:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 16;
			Item.width = 18;
			Item.noMelee = true;
			Item.height = 56;
			Item.DamageType = DamageClass.Ranged;
			Item.useTime = 30;
			Item.shoot = 1;
			Item.shootSpeed = 12f;
			Item.useAnimation = 30;
			Item.useStyle = 5;
			Item.knockBack = 5;
			Item.value = 2500;
			Item.useAmmo = AmmoID.Arrow;
			Item.rare = 1;
			Item.UseSound = SoundID.Item5;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Hunting Bow");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<WolfPelt>(), 12);
			recipe.AddIngredient(ItemID.BorealWood, 30);
			recipe.AddIngredient(ModContent.ItemType<AlphaClaw>(), 1);
			recipe.AddTile(18);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
