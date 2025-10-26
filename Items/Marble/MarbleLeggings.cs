using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Marble
{
	[AutoloadEquip(EquipType.Legs)]
	public class MarbleLeggings:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.defense = 2;
			Item.width = 22;
			Item.height = 18;
			Item.value = 2500;
			Item.rare = 1;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Marble Leggings");
			// Tooltip.SetDefault("10% increased throwing critical strike chance");
		}

		public override void UpdateEquip(Player p)
		{
			p.GetCritChance(DamageClass.Throwing) += 10;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.MarbleBlock, 45);
			recipe.AddIngredient(ModContent.ItemType<StoneofLife>(), 1);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();
		}
	}
}
