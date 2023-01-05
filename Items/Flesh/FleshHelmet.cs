using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items.Flesh
{
	[AutoloadEquip(EquipType.Head)]
	public class FleshHelmet:TremorModItem
	{

		public override void SetDefaults()
		{

			item.width = 38;
			item.height = 22;

			item.value = 18000;
			item.rare = 1;
			item.defense = 7;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Flesh Helmet");
			Tooltip.SetDefault("5% increased minion damage\n" +
"Increases your max number of minions");
		}

		public override void UpdateEquip(Player player)
		{
			player.maxMinions += 1;
			player.GetDamage(DamageClass.Summon) += 0.05f;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<FleshBreastplate>() && legs.type == ModContent.ItemType<FleshGreaves>();
		}

		public override void UpdateArmorSet(Player p)
		{
			p.setBonus = "Increases regeneration!";
			p.crimsonRegen = true;
		}

		public override void ArmorSetShadows(Player player)
		{
			player.armorEffectDrawShadow = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<PieceofFlesh>(), 4);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();
		}

	}
}
