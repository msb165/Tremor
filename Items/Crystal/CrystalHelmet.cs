using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Crystal
{
	[AutoloadEquip(EquipType.Head)]
	public class CrystalHelmet:TremorModItem
	{

		public override void SetDefaults()
		{

			item.defense = 5;
			item.width = 26;
			item.height = 22;
			item.value = 2500;
			item.rare = 4;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Crystal Helmet");
			Tooltip.SetDefault("20% increased throwing damage");
		}

		public override void UpdateEquip(Player p)
		{
			p.GetDamage(DamageClass.Throwing) += 0.2f;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<CrystalChestplate>() && legs.type == ModContent.ItemType<CrystalGreaves>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Increases movement speed";
			player.moveSpeed += 0.25f;
		}

		public override void ArmorSetShadows(Player player)
		{
			player.armorEffectDrawShadow = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CrystalShard, 30);
			recipe.AddIngredient(ItemID.SoulofLight, 6);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}
	}
}
