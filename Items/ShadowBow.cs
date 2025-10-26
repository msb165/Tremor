using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Souls;

namespace Tremor.Items
{
	public class ShadowBow:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 18;
			Item.width = 16;
			Item.height = 32;
			Item.useTime = 25;
			Item.DamageType = DamageClass.Ranged;
			Item.shoot = 1;
			Item.shootSpeed = 10f;
			Item.useAnimation = 25;
			Item.useStyle = 5;
			Item.knockBack = 5;
			Item.value = 5040;
			Item.useAmmo = AmmoID.Arrow;
			Item.rare = 3;
			Item.UseSound = SoundID.Item5;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Shadow Bow");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<LongBow>(), 1);
			recipe.AddIngredient(ModContent.ItemType<PhantomSoul>(), 5);
			recipe.AddTile(18);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
