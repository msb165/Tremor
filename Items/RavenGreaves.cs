using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Legs)]
	public class RavenGreaves:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 18;
			Item.height = 18;
			Item.value = 10000;

			Item.rare = 4;
			Item.defense = 9;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Raven Greaves");
			/* Tooltip.SetDefault("5% increased melee damage\n" +
"Increases melee critical strike chance by 5"); */
		}

		public override void UpdateEquip(Player player)
		{
			player.GetDamage(DamageClass.Melee) += 0.05f;
			player.GetCritChance(DamageClass.Melee) += 5;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.MoltenGreaves);
			recipe.AddIngredient(ItemID.IronBar, 7);
			recipe.AddIngredient(ModContent.ItemType<RavenFeather>(), 10);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();

			recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.MoltenGreaves);
			recipe.AddIngredient(ItemID.LeadBar, 7);
			recipe.AddIngredient(ModContent.ItemType<RavenFeather>(), 10);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();
		}

	}
}
