using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class RavenHeadgear:TremorModItem
	{

		public override void SetDefaults()
		{

			item.width = 18;
			item.height = 18;
			item.value = 10000;

			item.rare = 4;
			item.defense = 9;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Raven Headgear");
			Tooltip.SetDefault("5% increased melee damage\n" +
"Increases melee critical strike chance by 5");
		}

		public override void UpdateEquip(Player player)
		{
			player.GetDamage(DamageClass.Melee) += 0.05f;
			player.GetCritChance(DamageClass.Melee) += 5;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<RavenBreastplate>() && legs.type == ModContent.ItemType<RavenGreaves>();
		}

		public override void UpdateArmorSet(Player p)
		{
			p.setBonus = "Increases player defense by 3, 8% increased melee speed, increases melee critical strike chance by 6";
			p.statDefense += 3;
			p.GetCritChance(DamageClass.Melee) += 6;
			p.GetAttackSpeed(DamageClass.Melee) += 0.8f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.MoltenHelmet);
			recipe.AddIngredient(ItemID.IronBar, 8);
			recipe.AddIngredient(ModContent.ItemType<RavenFeather>(), 11);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();

			recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.MoltenHelmet);
			recipe.AddIngredient(ItemID.LeadBar, 8);
			recipe.AddIngredient(ModContent.ItemType<RavenFeather>(), 11);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();
		}

	}
}
