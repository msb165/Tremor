//using Microsoft.Xna.Framework.Graphics;
//using ReLogic.Content;
//using Terraria;
//using Terraria.GameContent;
//using Terraria.ID;
//using Terraria.ModLoader;
//using Tremor.Ice.Items;

//namespace Tremor.Ice.Tree
//{
//	public class TremorTree : ModTree
//	{
//		//TODO: Tree Type


//		private Mod mod => Tremor.instance;

//		/* TODO: TreeCrash does not exist
//		public override int CreateDust()
//		{
//			return ModContent.DustType<TreeCrash>();
//		}
//		*/

//		//TODO: [1.4] These members are now required
//		public override TreePaintingSettings TreeShaderSettings{get;} = new TreePaintingSettings();
//		public override void SetStaticDefaults(){}
//		public override void SetTreeFoliageSettings(Tile tile, ref int xoffset, ref int treeFrame, ref int floorY, ref int topTextureFrameWidth, ref int topTextureFrameHeight){}

//		//TODO: Tree Gore
//		public /*override*/ int GrowthFXGore()
//		{
//			return Mod.GetGoreSlot("Ice/Tree/TremorTreeFX");
//		}

//		public override int DropWood()
//		{
//			return ModContent.ItemType<GlacierWood>();
//		}

//		public override Asset<Texture2D> GetTexture()
//		{
//			return mod.GetTextureAsset("Ice/Tree/TremorTree");
//		}
//		public override Asset<Texture2D> GetBranchTextures()
//		{
//			return mod.GetTextureAsset("Ice/Tree/TremorTree_Branches");
//		}

//		public override Asset<Texture2D> GetTopTextures()
//		{
//			return mod.GetTextureAsset("Ice/Tree/TremorTree_Tops");
//		}
//	}
//}