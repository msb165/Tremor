using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Dark;
using Tremor.Items.Doom;

namespace Tremor.Items
{
	public class Squasher:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 88;
			Item.DamageType = DamageClass.Melee;
			Item.width = 56;
			Item.height = 56;
			Item.useTime = 36;
			Item.useAnimation = 36;
			Item.useStyle = 1;
			Item.knockBack = 6;
			Item.value = 122000;
			Item.rare = 3;
			Item.UseSound = SoundID.Item1;

			Item.hammer = 100;
			Item.autoReuse = false;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Squasher");
			// Tooltip.SetDefault("Strong enough to destroy Demon Altars");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.Pwnhammer, 1);
			recipe.AddIngredient(ModContent.ItemType<DarkBulb>(), 15);
			recipe.AddIngredient(ItemID.Bone, 100);
			recipe.SetResult(this, 1);
			recipe.AddTile(134);
			recipe.AddRecipe();

			recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<Doomhammer>(), 1);
			recipe.AddIngredient(ModContent.ItemType<DarkBulb>(), 15);
			recipe.AddIngredient(ItemID.Bone, 100);
			recipe.SetResult(this, 1);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}
	}
}
