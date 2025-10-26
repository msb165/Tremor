using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Chaos;

namespace Tremor.Items
{
	public class RoundBlast:TremorModItem
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
			// DisplayName.SetDefault("Round Blast");
			// Tooltip.SetDefault("Alchemical projectiles leave explosions in the shape of round");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.ExplosivePowder, 25);
			recipe.AddIngredient(ModContent.ItemType<Chemikaze>(), 1);
			recipe.AddIngredient(ModContent.ItemType<ChaosBar>(), 25);
			recipe.AddIngredient(ItemID.SoulofSight, 3);
			recipe.SetResult(this);
			recipe.AddTile(114);
			recipe.AddRecipe();
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			MPlayer modPlayer = player.GetModPlayer<MPlayer>();
			player.AddBuff(ModContent.BuffType<Buffs.RoundBlastBuff>(), 2);
			modPlayer.pyro = true;
		}
	}
}
