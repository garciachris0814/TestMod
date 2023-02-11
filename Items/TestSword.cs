using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TestMod.Projectiles;


namespace TestMod.Items
{
	public class TestSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tome of CHRISTIAN"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("This is a basic GOD Tome.");
		}

		public override void SetDefaults()
		{
			Item.damage = 85;
			Item.DamageType = DamageClass.Melee;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 25;
			Item.useAnimation = 25;
			Item.useStyle = 1;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 10f;
			Item.value = 100000;
			Item.rare = 5;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.shoot = ModContent.ProjectileType<TestProjectile>();
			Item.shootSpeed= 8f;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddIngredient(ItemID.Wood, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}