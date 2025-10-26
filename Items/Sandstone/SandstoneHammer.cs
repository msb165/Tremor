using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Antlion;

namespace Tremor.Items.Sandstone
{
	public class SandstoneHammer:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.autoReuse = true;
			Item.useStyle = 1;
			Item.useAnimation = 45;
			Item.useTime = 19;
			Item.hammer = 55;
			Item.width = 24;
			Item.height = 28;
			Item.damage = 18;
			Item.knockBack = 6f;
			Item.scale = 1.3f;
			Item.UseSound = SoundID.Item1;
			Item.rare = 1;
			Item.value = 13500;
			Item.DamageType = DamageClass.Melee;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Dune Hammer");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<AntlionShell>(), 1);
			recipe.AddIngredient(ItemID.Topaz, 2);
			recipe.AddIngredient(ItemID.AntlionMandible, 4);
			recipe.AddTile(16);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
