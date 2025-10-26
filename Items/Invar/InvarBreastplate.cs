using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Invar
{
	public abstract class _InvarBreastPlate : TremorAbstractItem
	{
		public override string Texture => $"{typeof(_InvarBreastPlate).NamespaceToPath()}/InvarBreastplate";

		protected sealed override void Defaults()
		{
			Item.width = 26;
			Item.height = 18;
			Item.value = Item.sellPrice(silver: 19);
			Item.rare = 1;
			Item.defense = 3;
		}

		protected sealed override void StaticDefaults()
		{
			// DisplayName.SetDefault("Invar Breastplate");
		}
	}


	[AutoloadEquip(EquipType.Body)]
	public class InvarBreastplate : _InvarBreastPlate
	{
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<InvarBar>(), 18);
			recipe.SetResult(this);
			recipe.AddTile(TileID.Furnaces);
			recipe.AddRecipe();
		}
	}

	[AutoloadEquip(EquipType.Body)]
	public class ReinforcedInvarBreastplate : _InvarBreastPlate
	{
		public sealed override void SafeDefaults()
		{
			Item.defense += 1;
		}

		public sealed override void SafeStaticDefaults()
		{
			// DisplayName.SetDefault("Reinforced Invar Breastplate");
			// Tooltip.SetDefault("Reinforced to grant +1 defense");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<InvarBreastplate>());
			recipe.AddIngredient(ModContent.ItemType<InvarBar>(), 2);
			recipe.SetResult(this);
			recipe.AddTile(TileID.Anvils);
			recipe.AddRecipe();
		}
	}
}
