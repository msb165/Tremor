using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Adamantite
{
	public class AdamantiteWarhammer:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 49;
			Item.DamageType = DamageClass.Melee;
			Item.width = 48;
			Item.height = 48;
			Item.useTime = 35;
			Item.useAnimation = 35;
			Item.hammer = 86;
			Item.useStyle = 1;
			Item.knockBack = 7;
			Item.value = 27600;
			Item.rare = 4;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Adamantite Warhammer");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.AdamantiteBar, 12);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}
	}
}
