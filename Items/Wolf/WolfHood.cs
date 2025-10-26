using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items.Wolf
{
	[AutoloadEquip(EquipType.Head)]
	public class WolfHood:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 28;
			Item.height = 22;
			Item.rare = 1;

			Item.value = 100;
			Item.defense = 2;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Wolf Hood");
			// Tooltip.SetDefault("6% increased minion damage");
		}

		public override void UpdateEquip(Player player)
		{
			player.GetDamage(DamageClass.Summon) += 0.06f;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<WolfJerkin>() && legs.type == ModContent.ItemType<WolfLeggings>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Increases your max number of minions";
			player.maxMinions += 1;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<WolfPelt>(), 8);
			recipe.AddIngredient(ModContent.ItemType<AlphaClaw>(), 1);
			recipe.SetResult(this);
			recipe.AddTile(18);
			recipe.AddRecipe();
		}
	}
}
