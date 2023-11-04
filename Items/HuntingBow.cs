using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Wolf;

namespace Tremor.Items
{
	public class HuntingBow:TremorModItem
	{
		public override void SetDefaults()
		{

			item.damage = 16;
			item.width = 18;
			item.noMelee = true;
			item.height = 56;
			item.DamageType = DamageClass.Ranged;
			item.useTime = 30;
			item.shoot = 1;
			item.shootSpeed = 12f;
			item.useAnimation = 30;
			item.useStyle = 5;
			item.knockBack = 5;
			item.value = 2500;
			item.useAmmo = AmmoID.Arrow;
			item.rare = 1;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hunting Bow");
			Tooltip.SetDefault("");
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
