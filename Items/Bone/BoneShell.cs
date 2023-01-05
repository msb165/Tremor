using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Souls;

namespace Tremor.Items.Bone
{
	[AutoloadEquip(EquipType.Body)]
	public class BoneShell:TremorModItem
	{

		public override void SetDefaults()
		{

			item.width = 22;
			item.height = 18;

			item.value = 25000;
			item.rare = 4;
			item.defense = 9;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bone Shell");
			Tooltip.SetDefault("25% increased thrown damage\n" +
"6% increased ranged damage");
		}

		public override void UpdateEquip(Player p)
		{
			p.GetDamage(DamageClass.Throwing) += 0.25f;
			p.GetDamage(DamageClass.Ranged) += 0.06f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(152, 1);
			recipe.AddIngredient(3375, 1);
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
