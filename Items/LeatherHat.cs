using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class LeatherHat:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.width = 18;
			Item.height = 20;
			Item.value = 200;
			Item.rare = 1;
			Item.defense = 1;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Leather Hat");
			// Tooltip.SetDefault("");
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<LeatherShirt>() && legs.type == ModContent.ItemType<LeatherGreaves>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "You smell like leather...";
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.Leather, 15);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);

			recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.Leather, 15);
			recipe.AddTile(TileID.HeavyWorkBench);
			recipe.SetResult(this);
		}
	}
}
