using System.Reflection;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Invar
{
	// for legacy loading
	//public class MeltedInvarSword:ModItem
	//{
	//	public override string Texture => typeof(BrokenInvarSword).FullNameToPath();

	//	public override void SetDefaults()
	//	{
	//		Item.CloneDefaults(ModContent.ItemType<BrokenInvarSword>());
	//		Item.type = ModContent.ItemType<BrokenInvarSword>();
	//		Item.netID = Item.type;
	//		typeof(Item).GetField("ModItem", BindingFlags.Instance | BindingFlags.NonPublic)?.SetValue(Item, new BrokenInvarSword());
	//		typeof(ModItem).GetField("Item", BindingFlags.Instance | BindingFlags.NonPublic)?.SetValue(Item.ModItem, item);
	//	}
	//}

	public class BrokenInvarSword:TremorModItem
	{
		//public override string Texture => $"{typeof(BrokenInvarSword).NamespaceToPath()}/BrokenInvarSword";

		//public override bool Autoload(ref string name)
		//{
		//	name = "MeltedInvarSword";
		//	return mod.Properties.Autoload;
		//}

		public override void SetDefaults()
		{
			item.width = 28;
			item.height = 30;
			item.maxStack = 990;
			item.value = Item.sellPrice(silver: 1);
			item.rare = 1;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Broken Invar Sword");
			Tooltip.SetDefault("Broken and useless... But its materials could be reused");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(this);
			recipe.SetResult(ModContent.ItemType<InvarBar>());
			recipe.AddTile(TileID.Furnaces);
			recipe.AddRecipe();
		}
	}
}
