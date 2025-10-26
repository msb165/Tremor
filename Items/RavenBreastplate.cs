using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Body)]
	public class RavenBreastplate:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 18;
			Item.height = 18;
			Item.value = 10000;

			Item.rare = 4;
			Item.defense = 10;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Raven Breastplate");
			/* Tooltip.SetDefault("8% increased melee damage\n" +
"Increases melee critical strike chance by 5"); */
		}

		public override void UpdateEquip(Player player)
		{
			player.GetDamage(DamageClass.Melee) += 0.08f;
			player.GetCritChance(DamageClass.Melee) += 5;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.MoltenBreastplate);
			recipe.AddIngredient(ItemID.IronBar, 8);
			recipe.AddIngredient(ModContent.ItemType<RavenFeather>(), 12);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();

			recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.MoltenBreastplate);
			recipe.AddIngredient(ItemID.LeadBar, 8);
			recipe.AddIngredient(ModContent.ItemType<RavenFeather>(), 12);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();
		}
	}
}
