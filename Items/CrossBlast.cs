using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Souls;

namespace Tremor.Items
{
	public class CrossBlast:TremorModItem
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

			Item.width = 22;
			Item.height = 44;

			Item.value = 300000;
			Item.rare = 6;
			Item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Cross Blast");
			// Tooltip.SetDefault("Alchemical projectiles leave explosions in the shape of cross");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.ExplosivePowder, 25);
			recipe.AddIngredient(ModContent.ItemType<Chemikaze>(), 1);
			recipe.AddIngredient(ItemID.HellstoneBar, 25);
			recipe.AddIngredient(ItemID.SoulofMight, 3);
			recipe.SetResult(this);
			recipe.AddTile(114);
			recipe.AddRecipe();

			recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.ExplosivePowder, 25);
			recipe.AddIngredient(ModContent.ItemType<Chemikaze>(), 1);
			recipe.AddIngredient(ItemID.HellstoneBar, 25);
			recipe.AddIngredient(ModContent.ItemType<SoulofMind>(), 3);
			recipe.SetResult(this);
			recipe.AddTile(114);
			recipe.AddRecipe();
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			MPlayer modPlayer = player.GetModPlayer<MPlayer>();
			player.AddBuff(ModContent.BuffType<Buffs.CrossBlastBuff>(), 2);
			modPlayer.pyro = true;
		}
	}
}
