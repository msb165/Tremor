using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class Chemikaze:TremorModItem
	{

		public override bool CanEquipAccessory(Player player, int slot, bool modded)
		{
			for (int i = 0; i < player.armor.Length; i++)
			{
				MPlayer modPlayer = player.GetModPlayer<MPlayer>();
				if (modPlayer.pyro)
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

			item.value = 300000;
			item.rare = 6;
			item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The Chemikaze");
			Tooltip.SetDefault("Alchemical flasks leave five explosions");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ExplosivePowder, 25);
			recipe.AddIngredient(ModContent.ItemType<Pyro>(), 1);
			recipe.AddIngredient(ModContent.ItemType<MoltenParts>(), 1);
			recipe.AddIngredient(ItemID.SoulofLight, 3);
			recipe.AddIngredient(ItemID.SoulofNight, 3);
			recipe.SetResult(this);
			recipe.AddTile(114);
			recipe.AddRecipe();
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			MPlayer modPlayer = player.GetModPlayer<MPlayer>();
			player.AddBuff(ModContent.BuffType<Buffs.ChemikazeBuff>(), 2);
			modPlayer.pyro = true;
		}
	}
}
