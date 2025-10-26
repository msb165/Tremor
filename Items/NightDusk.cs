using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class NightDusk:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 9;
			Item.DamageType = DamageClass.Melee;
			Item.width = 46;
			Item.height = 46;
			Item.useTime = 12;
			Item.useAnimation = 22;
			Item.pick = 100;
			Item.useStyle = 1;
			Item.knockBack = 5;
			Item.value = 600;
			Item.useTurn = true;
			Item.rare = 3;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Night Dusk");
			// Tooltip.SetDefault("");
		}

		public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.NextBool(5))
			{
				int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 27);
			}
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.MoltenPickaxe, 1);
			recipe.AddIngredient(ItemID.BonePickaxe, 1);
			recipe.AddIngredient(ModContent.ItemType<PickaxeofBloom>(), 1);
			recipe.AddIngredient(ItemID.NightmarePickaxe, 1);
			recipe.AddTile(26);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
