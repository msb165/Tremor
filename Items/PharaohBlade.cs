using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class PharaohBlade:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 25;
			Item.DamageType = DamageClass.Melee;
			Item.width = 50;
			Item.height = 55;
			Item.useTime = 25;
			Item.useAnimation = 25;
			Item.useStyle = 1;

			Item.knockBack = 4;
			Item.value = 10000;
			Item.rare = 3;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = false;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Pharaoh Blade");
			/* Tooltip.SetDefault("Allows you to get more coins for killing enemies\n" +
"'More gold for God of gold!'"); */
		}

		public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
		{
			target.AddBuff(72, 1200);
		}

		public virtual void OnHitPvp(Item item, Player player, Player target, int damage, bool crit)
		{
			target.AddBuff(72, 1200);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(3380, 8);
			recipe.AddIngredient(ItemID.Topaz, 5);
			recipe.AddIngredient(ItemID.AntlionMandible, 2);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();
		}
	}
}
