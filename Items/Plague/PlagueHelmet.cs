using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Souls;

namespace Tremor.Items.Plague
{
	[AutoloadEquip(EquipType.Head)]
	public class PlagueHelmet:TremorModItem
	{

		public override void SetDefaults()
		{

			item.width = 38;
			item.height = 22;

			item.value = 25000;
			item.rare = 2;
			item.defense = 4;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Plague Helmet");
			Tooltip.SetDefault("10% increased alchemical damage");
		}

		public override void UpdateEquip(Player player)
		{
			player.GetModPlayer<MPlayer>().alchemicalDamage += 0.1f;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<PlagueBreastplate>() && legs.type == ModContent.ItemType<PlagueGreaves>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Increases size of alchemical clouds";
			player.AddBuff(ModContent.BuffType<Buffs.FlaskExpansionBuff>(), 2);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.Silk, 12);
			recipe.AddIngredient(ModContent.ItemType<PhantomSoul>(), 4);
			recipe.AddIngredient(ModContent.ItemType<TearsofDeath>(), 8);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();
		}

	}
}
