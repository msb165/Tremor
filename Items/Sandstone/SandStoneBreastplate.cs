using Terraria;
using Terraria.ModLoader;
using Tremor.Items.Antlion;

namespace Tremor.Items.Sandstone
{
	[AutoloadEquip(EquipType.Body)]
	public class SandStoneBreastplate:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 26;
			Item.height = 18;

			Item.value = 600;
			Item.rare = 2;
			Item.defense = 4;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Dune Breastplate");
			// Tooltip.SetDefault("10% increased movement speed");
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed += 0.1f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<SandstoneBar>(), 12);
			recipe.AddIngredient(ModContent.ItemType<AntlionShell>(), 1);
			recipe.AddIngredient(ModContent.ItemType<PetrifiedSpike>(), 5);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();
		}
	}
}
