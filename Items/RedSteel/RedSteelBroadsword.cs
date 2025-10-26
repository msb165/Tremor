using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.RedSteel
{
	public class RedSteelBroadsword:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.damage = 16;
			Item.DamageType = DamageClass.Melee;
			Item.width = 34;
			Item.height = 36;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = 1;
			Item.knockBack = 5;

			Item.value = 600;
			Item.rare = 1;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Red Steel Broadsword");
			// Tooltip.SetDefault("25% chance to confuse enemy");
		}

		public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
		{
			if (Main.rand.NextBool(4))
			{
				target.AddBuff(31, 600);
			}
		}

		public override void AddRecipes()
		{
			//ModRecipe recipe = new ModRecipe();
			//recipe.AddIngredient(ModContent.ItemType<ChippyRedSteelSword>(), 1);
			//recipe.AddIngredient(ModContent.ItemType<RedSteelBar>(), 11);
			//recipe.SetResult(this);
			//recipe.AddTile(16);
			//recipe.AddRecipe();
		}
	}
}
