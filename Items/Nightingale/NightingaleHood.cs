using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Souls;
using Tremor.Items.Steel;

namespace Tremor.Items.Nightingale
{
	[AutoloadEquip(EquipType.Head)]
	public class NightingaleHood:TremorModItem
	{

		public override void SetDefaults()
		{

			item.defense = 5;
			item.width = 26;
			item.height = 32;
			item.value = 2000;
			item.rare = 2;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Nightingale Hood");
			Tooltip.SetDefault("Increases life regeneration");
		}

		public override void UpdateEquip(Player player)
		{
			player.lifeRegen += 1;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<NightingaleChestplate>() && legs.type == ModContent.ItemType<NightingaleGreaves>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Reduced enemy aggression";
			player.AddBuff(106, 300, true);
		}

		public override void ArmorSetShadows(Player player)
		{
			player.armorEffectDrawShadowLokis = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<SteelBar>(), 5);
			recipe.AddIngredient(ItemID.Silk, 15);
			recipe.AddIngredient(ModContent.ItemType<PhantomSoul>(), 3);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();
		}
	}
}
