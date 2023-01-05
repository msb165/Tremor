using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items;

namespace Tremor.ZombieEvent.Items
{
	public class RupicideClub:TremorModItem
	{
		public override void SetDefaults()
		{

			item.damage = 22;
			item.DamageType = DamageClass.Melee;
			item.width = 50;
			item.height = 50;
			item.useTime = 35;
			item.useAnimation = 35;
			item.useStyle = 1;
			item.knockBack = 2;
			item.value = 3000;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Rupicide Club");
			Tooltip.SetDefault("");
		}

		public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.NextBool(2))
			{
				int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 27);
			}
		}

		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			target.AddBuff(153, 600);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<StoneDice>(), 1);
			recipe.AddIngredient(ModContent.ItemType<RupicideBar>(), 5);
			recipe.AddIngredient(ModContent.ItemType<MinotaurHorn>(), 2);
			recipe.AddTile(ModContent.TileType<Tiles.NecromaniacWorkbenchTile>());
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
