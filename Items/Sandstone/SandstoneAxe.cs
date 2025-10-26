using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Antlion;

namespace Tremor.Items.Sandstone
{
	public class SandstoneAxe:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.autoReuse = true;
			Item.useStyle = 1;
			Item.useAnimation = 30;
			Item.knockBack = 6f;
			Item.useTime = 15;
			Item.width = 24;
			Item.height = 28;
			Item.damage = 16;
			Item.axe = 15;
			Item.scale = 1.2f;
			Item.UseSound = SoundID.Item1;
			Item.rare = 1;
			Item.value = 13500;
			Item.DamageType = DamageClass.Melee;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Dune Axe");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<AntlionShell>(), 1);
			recipe.AddIngredient(ItemID.Topaz, 3);
			recipe.AddIngredient(ItemID.AntlionMandible, 5);
			recipe.AddTile(16);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
