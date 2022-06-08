using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Argite;

namespace Tremor.Items
{
	public class ReinforcedBurst : ModItem
	{
		public override bool CanEquipAccessory(Player player, int slot)
		{
			for (int i = 0; i < player.armor.Length; i++)
			{
				MPlayer modPlayer = player.GetModPlayer<MPlayer>();
				if (modPlayer.nitro)
				{
					return false;
				}
			}
			return true;
		}

		public override void SetDefaults()
		{

			item.width = 22;
			item.height = 44;

			item.value = 500000;
			item.rare = 6;
			item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Reinforced Burst");
			Tooltip.SetDefault("Alchemical flasks leave three death flames");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Obsidian, 10);
			recipe.AddIngredient(ModContent.ItemType<Nitro>(), 1);
			recipe.AddIngredient(ModContent.ItemType<ArgiteBar>(), 15);
			recipe.AddIngredient(ItemID.Hellstone);
			recipe.SetResult(this);
			recipe.AddTile(114);
			recipe.AddRecipe();
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			MPlayer modPlayer = player.GetModPlayer<MPlayer>();
			player.AddBuff(ModContent.BuffType<Buffs.ReinforcedBurstBuff>(), 2);
			modPlayer.nitro = true;
		}
	}
}
