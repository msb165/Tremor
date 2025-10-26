using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Adamantite
{
	[AutoloadEquip(EquipType.Head)]
	public class AdamantiteVisage:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 22;
			Item.height = 24;

			Item.value = 400;
			Item.rare = 4;
			Item.defense = 8;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Adamantite Visage");
			// Tooltip.SetDefault("24% increased alchemical damage");
		}

		public override void UpdateEquip(Player player)
		{
			player.GetModPlayer<MPlayer>().alchemicalDamage += 0.24f;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == 403 && legs.type == 404;
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "20% increased alchemical critical strike chance";
			player.GetModPlayer<MPlayer>().alchemicalCrit += 20;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.AdamantiteBar, 10);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}
	}
}
