using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Souls;

namespace Tremor.Items.Bone
{
	[AutoloadEquip(EquipType.Legs)]
	public class BoneGreaves:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.defense = 8;
			Item.width = 22;
			Item.height = 18;
			Item.value = 25000;
			Item.rare = 4;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Bone Greaves");
			/* Tooltip.SetDefault("20% increased throwing critical strike chance\n" +
"6% increased ranged damage"); */
		}

		public override void UpdateEquip(Player p)
		{
			p.GetCritChance(DamageClass.Throwing) += 20;
			p.GetDamage(DamageClass.Ranged) += 0.06f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(153, 1);
			recipe.AddIngredient(3376, 1);
			recipe.AddIngredient(ModContent.ItemType<CursedSoul>(), 1);
			recipe.AddIngredient(ItemID.SoulofNight, 3);
			recipe.AddIngredient(ModContent.ItemType<SharpenedTooth>(), 3);
			recipe.AddIngredient(ModContent.ItemType<TheRib>(), 3);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();
		}
	}
}
