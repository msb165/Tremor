using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class StoneHelmet:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.width = 22;
			Item.height = 26;
			Item.value = Item.sellPrice(silver: 1);
			Item.rare = 1;
			Item.defense = 2;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Stone Helmet");
			// Tooltip.SetDefault("`Your neck starts to ache`");
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<StoneChestplate>() && legs.type == ModContent.ItemType<StoneLeggings>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Increases maximum defense by 2";
			player.statDefense += 2;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.StoneBlock, 25);
			recipe.SetResult(this);
			recipe.AddTile(TileID.Anvils);
			recipe.AddRecipe();
		}
	}
}
