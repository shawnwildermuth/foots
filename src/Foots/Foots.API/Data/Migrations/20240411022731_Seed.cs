using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Foots.API.Migrations
{
    /// <inheritdoc />
    public partial class Seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Flip Flops" },
                    { 2, "Sandals" },
                    { 3, "Shoes" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Color", "Gender", "ImageFile", "ImageUrl", "Price", "Title", "Type", "Usage" },
                values: new object[,]
                {
                    { 1636, 3, "White", "Men", "1636.jpg", "http://assets.myntassets.com/v1/images/style/properties/7c80fca789c5c1863a4080d7ed57acf0_images.jpg", 43.0m, "Nike Men Air Zoom Century Shoes", "Sports Shoes", "Sports" },
                    { 1637, 3, "White", "Men", "1637.jpg", "http://assets.myntassets.com/v1/images/style/properties/0ac13b20762f7542baadcb2472855437_images.jpg", 21.0m, "Nike Men White Cricket Shoes", "Sports Shoes", "Sports" },
                    { 1653, 3, "Brown", "Men", "1653.jpg", "http://assets.myntassets.com/v1/images/style/properties/349e9cdd07258c3f4254065dcad69c3e_images.jpg", 70.0m, "Reebok Men's Ventilator Ubiq Shoe", "Sports Shoes", "Sports" },
                    { 1654, 3, "White", "Men", "1654.jpg", "http://assets.myntassets.com/v1/images/style/properties/271493f761fcb4583542bad929fb3d99_images.jpg", 21.0m, "Reebok Men's Frisker LP Shoe", "Sports Shoes", "Sports" },
                    { 1806, 2, "Brown", "Men", "1806.jpg", "http://assets.myntassets.com/v1/images/style/properties/1e404f8311c96db483657b8ef4113d56_images.jpg", 36.5m, "Quechua Men Arpenaz Brown Sandal", "Sandals", "Casual" },
                    { 1831, 3, "Black", "Men", "1831.jpg", "http://assets.myntassets.com/v1/images/style/properties/2b7f6813cc0aebb2e517ddee5cf57830_images.jpg", 32.5m, "Nike Men's Air Impetus Shoe", "Sports Shoes", "Sports" },
                    { 1836, 3, "Silver", "Men", "1836.jpg", "http://assets.myntassets.com/v1/images/style/properties/cae015b083e7581db36c6df436b7ef80_images.jpg", 40.0m, "Nike Air Visi Sleek Shoes", "Sports Shoes", "Sports" },
                    { 2211, 2, "Navy Blue", "Men", "2211.jpg", "http://assets.myntassets.com/v1/images/style/properties/489285fce42ff6b4a5d6be37c26a971d_images.jpg", 29.0m, "Puma Men Trek Navy Blue Floater", "Sandals", "Casual" },
                    { 2218, 2, "Black", "Men", "2218.jpg", "http://assets.myntassets.com/v1/images/style/properties/c0d7bee21dcc124c3254cfda13193d7f_images.jpg", 40.5m, "Puma Men F1 Black Sandal", "Sandals", "Casual" },
                    { 2219, 3, "Black", "Men", "2219.jpg", "http://assets.myntassets.com/v1/images/style/properties/11638bf2032ce289f91e53f6696594ed_images.jpg", 25.0m, "ADIDAS Men's Black Shoe", "Casual Shoes", "Casual" },
                    { 2220, 2, "Black", "Men", "2220.jpg", "http://assets.myntassets.com/v1/images/style/properties/c7292fc1fcc934dd9a693a136640bd47_images.jpg", 31.5m, "Puma Men Carbon Black Sandal", "Sandals", "Sports" },
                    { 2227, 2, "Grey", "Men", "2227.jpg", "http://assets.myntassets.com/v1/images/style/properties/c691cbf2c611b9e0f9af6d11ef2046af_images.jpg", 66.5m, "Puma Men Gypsy Grey Sandal", "Sandals", "Sports" },
                    { 2399, 3, "Black", "Men", "2399.jpg", "http://assets.myntassets.com/v1/images/style/properties/0eac399dea02f88af3e4775f38a8924b_images.jpg", 35.5m, "Red Tape Black Men's Semi Casual Shoe", "Casual Shoes", "Casual" },
                    { 2477, 3, "Blue", "Men", "2477.jpg", "http://assets.myntassets.com/v1/images/style/properties/2aaec62ff9756dab42e78315b35505e5_images.jpg", 52.5m, "Nike Men's LunarFly Blue Shoe", "Sports Shoes", "Sports" },
                    { 2504, 3, "White", "Men", "2504.jpg", "http://assets.myntassets.com/v1/images/style/properties/0f7f710f647111940975e75aa0303fe8_images.jpg", 58.0m, "Numero Uno Men's Casual White Canvas Shoe", "Casual Shoes", "Casual" },
                    { 2642, 3, "Black", "Men", "2642.jpg", "http://assets.myntassets.com/v1/images/style/properties/e571426e3de987910f5bdd984338bd77_images.jpg", 39.0m, "Carlton London Men Semi Formal Black Shoe", "Formal Shoes", "Formal" },
                    { 2817, 3, "Black", "Men", "2817.jpg", "http://assets.myntassets.com/v1/images/style/properties/3236b8ebf59620600dab8e1fbe8fd01f_images.jpg", 58.5m, "Lee Cooper Men's Casual Leather Black Shoe", "Casual Shoes", "Casual" },
                    { 2820, 2, "Black", "Men", "2820.jpg", "http://assets.myntassets.com/v1/images/style/properties/3d1bbf550e8fe9db493fe79dc83d25ce_images.jpg", 53.5m, "Lee Cooper Men Formal Leather Black Sandal", "Sandals", "Formal" },
                    { 2821, 2, "Brown", "Men", "2821.jpg", "http://assets.myntassets.com/v1/images/style/properties/d7c47ca9f2381f2467cd89d19e70af3a_images.jpg", 59.5m, "Lee Cooper Men Formal Leather Brown Sandal", "Sandals", "Formal" },
                    { 2826, 3, "Brown", "Men", "2826.jpg", "http://assets.myntassets.com/v1/images/style/properties/af0944e686e90b5d9dbc5bc7e0be982f_images.jpg", 69.5m, "Lee Cooper Men Leather Semi Formal Brown Shoe", "Formal Shoes", "Formal" },
                    { 2827, 3, "Black", "Men", "2827.jpg", "http://assets.myntassets.com/v1/images/style/properties/b83e64858ee7aa7fc15ea781eebf1a4f_images.jpg", 59.0m, "Lee Cooper Men's Formal Simpleton Black Shoe", "Formal Shoes", "Formal" },
                    { 2828, 3, "Blue", "Men", "2828.jpg", "http://assets.myntassets.com/v1/images/style/properties/d8fbc6ec5c348077864f687febb98cca_images.jpg", 24.0m, "Lee Cooper Men's LC Casual Denim Blue Shoe", "Casual Shoes", "Casual" },
                    { 2963, 3, "White", "Men", "2963.jpg", "http://assets.myntassets.com/v1/images/style/properties/8fe5241611ac361fa7103caa71beed8f_images.jpg", 40.0m, "Puma Men's Basket Biz White & Blue Shoe", "Sports Shoes", "Sports" },
                    { 2964, 3, "White", "Men", "2964.jpg", "http://assets.myntassets.com/v1/images/style/properties/0ec80253c849cad29f12883f49dacb97_images.jpg", 26.5m, "Puma Men's Match Classic White & Green Shoe", "Casual Shoes", "Casual" },
                    { 3150, 3, "Black", "Men", "3150.jpg", "http://assets.myntassets.com/v1/images/style/properties/f23c4d59eb6ca3cd621c3db690e0c708_images.jpg", 75.5m, "Nike Men's Lunarswift Black Shoe", "Sports Shoes", "Sports" },
                    { 3151, 3, "Blue", "Men", "3151.jpg", "http://assets.myntassets.com/v1/images/style/properties/7ee77f6e00c30da7cd5a1b3d93fe5943_images.jpg", 56.0m, "Nike Men's Lunarswift Blue Shoe", "Sports Shoes", "Sports" },
                    { 3159, 3, "White", "Men", "3159.jpg", "http://assets.myntassets.com/v1/images/style/properties/538e095d6e2d1fe70731f5a14c154f2a_images.jpg", 46.5m, "Nike Men's Air Max Moto White Blue Shoe", "Sports Shoes", "Sports" },
                    { 3160, 3, "White", "Men", "3160.jpg", "http://assets.myntassets.com/v1/images/style/properties/2647d08362ed75f3d01e78bad9f0b98f_images.jpg", 79.0m, "Nike Men's Dual Fusion White Shoe", "Sports Shoes", "Sports" },
                    { 3161, 3, "White", "Men", "3161.jpg", "http://assets.myntassets.com/v1/images/style/properties/baffde85f36e72580d7246b0952ee688_images.jpg", 37.0m, "Nike Men's Air Citius MSL White Grey Shoe", "Sports Shoes", "Sports" },
                    { 3168, 3, "White", "Men", "3168.jpg", "http://assets.myntassets.com/v1/images/style/properties/4eff2353c62ec8b7bca9fbbaf5996bd2_images.jpg", 22.5m, "Nike Men's Incinerate MSL White Blue Shoe", "Sports Shoes", "Sports" },
                    { 3300, 3, "Black", "Men", "3300.jpg", "http://assets.myntassets.com/v1/images/style/properties/c57b44b0582da012445b913bf8d80be4_images.jpg", 33.0m, "Asics Men's Gel Cushioning Black Yellow Shoe", "Sports Shoes", "Sports" },
                    { 3306, 3, "White", "Men", "3306.jpg", "http://assets.myntassets.com/v1/images/style/properties/666ac16166295985a30aea57a1f75697_images.jpg", 56.5m, "Asics Men's Gel Phoenix 3 Running White Black Shoe", "Sports Shoes", "Sports" },
                    { 3307, 3, "Black", "Men", "3307.jpg", "http://assets.myntassets.com/v1/images/style/properties/998c282acd503d2c7185647017adbfc9_images.jpg", 56.0m, "Asics Men's Gel Phoenix 3 Black Silver Shoe", "Sports Shoes", "Sports" },
                    { 3308, 3, "White", "Men", "3308.jpg", "http://assets.myntassets.com/v1/images/style/properties/3ad2891fc7b6eb03276bae0a9b85d73d_images.jpg", 26.0m, "Asics Men's Gel Cushioning Running White Black Yellow Shoe", "Sports Shoes", "Sports" },
                    { 3309, 3, "White", "Men", "3309.jpg", "http://assets.myntassets.com/v1/images/style/properties/ce37a8630a47c6d3e9c2ec47c73cf003_images.jpg", 23.5m, "Asics Men's Gel Challenger 8 Tennis White Blue Shoe", "Sports Shoes", "Sports" },
                    { 3503, 2, "Navy Blue", "Men", "3503.jpg", "http://assets.myntassets.com/v1/images/style/properties/Adidas-Men-Spry-Navy-Yellow-Sandal_809772c91b008543bbf5b2976a750b92_images.jpg", 56.0m, "ADIDAS Men Navy Blue Sandals", "Sports Sandals", "Casual" },
                    { 3504, 2, "Brown", "Men", "3504.jpg", "http://assets.myntassets.com/v1/images/style/properties/92d20316dd7f9f71e57e03068a011d35_images.jpg", 62.0m, "ADIDAS Men Spry Wine Black Sandal", "Sandals", "Casual" },
                    { 3550, 3, "Brown", "Men", "3550.jpg", "http://assets.myntassets.com/v1/images/style/properties/ac06fde1d825f4d5d4587113da3bd205_images.jpg", 65.0m, "Skechers Men's Brown Lifestyle Shoe", "Casual Shoes", "Casual" },
                    { 3551, 3, "Brown", "Men", "3551.jpg", "http://assets.myntassets.com/v1/images/style/properties/cbfbb7dc1aee995012f8bc9cda960063_images.jpg", 74.0m, "Skechers Men's Charcoal Lifestyle Shoe", "Casual Shoes", "Casual" },
                    { 3556, 3, "Brown", "Men", "3556.jpg", "http://assets.myntassets.com/v1/images/style/properties/2053807e903d6257ecb31457c0187737_images.jpg", 76.0m, "Skechers Men Dark Brown Lifestyle Shoe", "Casual Shoes", "Casual" },
                    { 3557, 3, "Black", "Men", "3557.jpg", "http://assets.myntassets.com/v1/images/style/properties/b9c487b15356b9d36c0e803b43adad76_images.jpg", 58.0m, "Skechers Men Black Lifestyle Casual Shoes", "Casual Shoes", "Casual" },
                    { 3558, 3, "Brown", "Men", "3558.jpg", "http://assets.myntassets.com/v1/images/style/properties/3b05935a6cb549695767b9ad514af8b0_images.jpg", 33.0m, "Skechers Men's Brown Casual Lifestyle Shoe", "Casual Shoes", "Casual" },
                    { 3559, 3, "Brown", "Men", "3559.jpg", "http://assets.myntassets.com/v1/images/style/properties/6ee05bbf2e4fad44253b05372eb7753f_images.jpg", 42.5m, "Skechers Men's Casual Brown Lifestyle Shoe", "Casual Shoes", "Casual" },
                    { 3560, 3, "White", "Men", "3560.jpg", "http://assets.myntassets.com/v1/images/style/properties/e128f17c7a01b1478604f96915dc408b_images.jpg", 20.5m, "Skechers Men Off White Lifestyle Casual Shoe", "Casual Shoes", "Casual" },
                    { 3561, 3, "Black", "Men", "3561.jpg", "http://assets.myntassets.com/v1/images/style/properties/b1b0fa0e8afbed7dd74c1df7b42090c8_images.jpg", 68.5m, "Skechers Men's Zeta Black Lifestyle Casual Shoe", "Casual Shoes", "Casual" },
                    { 3566, 3, "White", "Men", "3566.jpg", "http://assets.myntassets.com/v1/images/style/properties/7dae540b7b309f050e1e1b635ceabf85_images.jpg", 61.0m, "ADIDAS Men's White Silver Running Shoe", "Sports Shoes", "Sports" },
                    { 3567, 3, "Silver", "Men", "3567.jpg", "http://assets.myntassets.com/v1/images/style/properties/7210fc2b108553e1603a5ba8d5dcf0e5_images.jpg", 30.0m, "ADIDAS Men's Silver White Running Shoe", "Sports Shoes", "Sports" },
                    { 3569, 2, "Brown", "Men", "3569.jpg", "http://assets.myntassets.com/v1/images/style/properties/dfc72752bea77607827945515d2d238c_images.jpg", 66.0m, "ADIDAS Mens Lightbone Brown Sandal", "Sandals", "Casual" },
                    { 3592, 3, "Blue", "Men", "3592.jpg", "http://assets.myntassets.com/v1/images/style/properties/9cec0bcd1bcd475d5adb1a0debf81a9b_images.jpg", 59.5m, "Converse Men's All Star Canvas Ox Navy Blue Shoe", "Casual Shoes", "Casual" },
                    { 3594, 3, "White", "Men", "3594.jpg", "http://assets.myntassets.com/v1/images/style/properties/894464418a042a27101effb0c4e5e17b_images.jpg", 32.5m, "Converse Men's Chuck Taylor Print OX White Canvas Shoe", "Casual Shoes", "Casual" },
                    { 3595, 3, "Red", "Men", "3595.jpg", "http://assets.myntassets.com/v1/images/style/properties/bdd2eed1b066a2e060bf864cbf8bfece_images.jpg", 27.0m, "Converse Men's Chuck Taylor Big Check Red Black Canvas Shoe", "Casual Shoes", "Casual" },
                    { 3790, 3, "Black", "Men", "3790.jpg", "http://assets.myntassets.com/v1/images/style/properties/2cbba1cd60b44011accb7c099a859ec4_images.jpg", 66.0m, "Converse Men's AS Canvas HI Black Shoe", "Casual Shoes", "Casual" },
                    { 3797, 3, "Black", "Men", "3797.jpg", "http://assets.myntassets.com/v1/image/style/properties/3797/Converse-Men-Black--Red-Shoes_1_fe02c8391327729cd4b739c4bc555a7a.jpg", 77.0m, "Converse Men Black & Red Shoes", "Casual Shoes", "Casual" },
                    { 3798, 3, "Navy Blue", "Men", "3798.jpg", "http://assets.myntassets.com/v1/images/style/properties/88d4ecab35d6c2fa4c23a2423deabf27_images.jpg", 67.0m, "Converse Men's As Canvas Ox Navy Blue Shoe", "Casual Shoes", "Casual" },
                    { 3996, 1, "Black", "Men", "3996.jpg", "http://assets.myntassets.com/v1/images/style/properties/e14ffb8ceff3534250d7ae11401dfe81_images.jpg", 27.5m, "Spalding Men Black Flip Flops", "Flip Flops", "Casual" },
                    { 3997, 1, "Grey", "Men", "3997.jpg", "http://assets.myntassets.com/v1/images/style/properties/Spalding-Mens-Grey-Orange-Flip-Flop_141aff465eecd916173f9e1dcafdddc2_images.jpg", 62.0m, "Spalding Men Grey & Orange Flip Flops", "Flip Flops", "Casual" },
                    { 3998, 1, "Black", "Men", "3998.jpg", "http://assets.myntassets.com/v1/images/style/properties/91352b9549b9c0d570180dd1be12738d_images.jpg", 31.5m, "Spalding Men's Black and White Graphic Flip Flop", "Flip Flops", "Casual" },
                    { 4112, 2, "Green", "Men", "4112.jpg", "http://assets.myntassets.com/v1/images/style/properties/a35fc6de28c54581cca294e2907237ba_images.jpg", 41.5m, "Fila Men Motor Sports Olive Black Sandals", "Sandals", "Casual" },
                    { 4113, 3, "White", "Men", "4113.jpg", "http://assets.myntassets.com/v1/images/style/properties/7f46e61a64650eab8464bdbb5f8349a9_images.jpg", 68.5m, "Fila Men's Bruno White Shoe", "Casual Shoes", "Casual" },
                    { 4114, 2, "Black", "Men", "4114.jpg", "http://assets.myntassets.com/v1/images/style/properties/899733c446d42173fdb9ade7481ddb5e_images.jpg", 69.5m, "Fila Men Obsidian Black Sandal", "Sandals", "Casual" },
                    { 4141, 3, "White", "Men", "4141.jpg", "http://assets.myntassets.com/v1/images/style/properties/2b324f99796b96c6e18d6128a1784163_images.jpg", 79.5m, "Fila Men's Breath White Red Shoe", "Casual Shoes", "Casual" },
                    { 4171, 3, "White", "Men", "4171.jpg", "http://assets.myntassets.com/v1/images/style/properties/461d2320504d9d9f1cbe2ebfd6ac7aae_images.jpg", 40.0m, "Reebok Men's Easytone Inspire White Shoe", "Sports Shoes", "Sports" },
                    { 4179, 3, "Black", "Men", "4179.jpg", "http://assets.myntassets.com/v1/images/style/properties/3b94b896182e9eb5cb6cc4aa5be6801a_images.jpg", 51.5m, "Rockport Men's Tyson Black Shoe", "Formal Shoes", "Formal" },
                    { 4183, 3, "Brown", "Men", "4183.jpg", "http://assets.myntassets.com/v1/images/style/properties/Rockport-Men-Brown-Leather-Casual-Shoes_9c5fb81fa80950693ae635413df4f5c0_images.jpg", 42.5m, "Rockport Men Brown Leather Casual Shoes", "Casual Shoes", "Casual" },
                    { 4184, 3, "Brown", "Men", "4184.jpg", "http://assets.myntassets.com/v1/images/style/properties/41463f5979dca81447ed51fbe146ead7_images.jpg", 51.0m, "Rockport Men D2N Desert Boot Dark Brown Shoe", "Casual Shoes", "Casual" },
                    { 4342, 3, "Black", "Men", "4342.jpg", "http://assets.myntassets.com/v1/images/style/properties/e768f4ef962232b52ad4c1b2ac7331fe_images.jpg", 47.5m, "Fila Men's Phoenix Black White Shoe", "Sports Shoes", "Sports" },
                    { 4343, 3, "Red", "Men", "4343.jpg", "http://assets.myntassets.com/v1/images/style/properties/6c47906c4ede8ac1c9142bdba8e6fd63_images.jpg", 70.5m, "Fila Men Leonard Red Shoes", "Casual Shoes", "Casual" },
                    { 4344, 3, "White", "Men", "4344.jpg", "http://assets.myntassets.com/v1/images/style/properties/05258b3aab19101a69bf27340d1f6aa1_images.jpg", 70.0m, "Fila Men's Abascuss White Blue Shoe", "Sports Shoes", "Sports" },
                    { 4345, 3, "White", "Men", "4345.jpg", "http://assets.myntassets.com/v1/images/style/properties/2a9aba279ac9fbeea32962d5ec9f0d76_images.jpg", 48.0m, "Fila Men's Mythos White Navy Shoe", "Sports Shoes", "Sports" },
                    { 4514, 3, "White", "Men", "4514.jpg", "http://assets.myntassets.com/v1/images/style/properties/a2fdddec353fbe8c390b0bcb09105c33_images.jpg", 35.0m, "Puma Men's Tarun White Navy Silver Red Shoe", "Sports Shoes", "Sports" },
                    { 4515, 3, "White", "Men", "4515.jpg", "http://assets.myntassets.com/v1/images/style/properties/25cffc1cddbfbc2ae8c8a98ee2431665_images.jpg", 61.5m, "Puma Men's Tarun White Silver Red Shoe", "Sports Shoes", "Sports" },
                    { 4522, 3, "Grey", "Men", "4522.jpg", "http://assets.myntassets.com/v1/images/style/properties/437ba16eb3cd98b8f0766a1f7be7ba2a_images.jpg", 53.5m, "Puma Men's Faas Grey Shoes", "Sports Shoes", "Sports" },
                    { 4523, 3, "Blue", "Men", "4523.jpg", "http://assets.myntassets.com/v1/images/style/properties/0411da3a022ade1d11dfb7affdc6f536_images.jpg", 75.0m, "Puma Men's Faas Blue White Silver Red Shoe", "Sports Shoes", "Sports" },
                    { 4524, 3, "Black", "Men", "4524.jpg", "http://assets.myntassets.com/v1/images/style/properties/fae0ae76d008674551fbdbb64988ea51_images.jpg", 61.0m, "Puma Men's YugoRun Black White Shoe", "Sports Shoes", "Sports" },
                    { 4525, 3, "White", "Men", "4525.jpg", "http://assets.myntassets.com/v1/images/style/properties/238b3b400213329e4cd1b554140b23f8_images.jpg", 49.0m, "Puma Men's YugoRun White Red Shoe", "Sports Shoes", "Sports" },
                    { 4546, 3, "Black", "Men", "4546.jpg", "http://assets.myntassets.com/v1/images/style/properties/6d489d04b2840d450005883d5605c311_images.jpg", 42.0m, "Nike Men's Air Max Black Shoe", "Sports Shoes", "Sports" },
                    { 4547, 3, "White", "Men", "4547.jpg", "http://assets.myntassets.com/v1/images/style/properties/1a90672c4e274285787269ba20bd524f_images.jpg", 55.0m, "Nike Men's Egoli White Black Shoe", "Sports Shoes", "Sports" },
                    { 4549, 3, "White", "Men", "4549.jpg", "http://assets.myntassets.com/v1/images/style/properties/5849b0dd76fe003fa112666be7b2850c_images.jpg", 36.5m, "Nike Men's Air Dictate White Shoe", "Sports Shoes", "Sports" },
                    { 4576, 3, "Grey", "Men", "4576.jpg", "http://assets.myntassets.com/v1/images/style/properties/33d5b86f0a0c396c4be6f05ea82e7a23_images.jpg", 31.0m, "Nike Men's Incinera Grey Shoe", "Sports Shoes", "Sports" },
                    { 4577, 3, "Red", "Men", "4577.jpg", "http://assets.myntassets.com/v1/images/style/properties/02e75f751ca7d599f0187051c4fde10e_images.jpg", 62.0m, "Nike Men's Mercurial Vic Pink Shoe", "Sports Shoes", "Sports" },
                    { 4578, 3, "Red", "Men", "4578.jpg", "http://assets.myntassets.com/v1/images/style/properties/ff09be074c8f743051aa1694007e1555_images.jpg", 75.0m, "Nike Men's Mercurial Gli Red Pink Shoe", "Sports Shoes", "Sports" },
                    { 5050, 3, "Black", "Men", "5050.jpg", "http://assets.myntassets.com/v1/images/style/properties/2f4267ce2de8d98c8ecbd46ca5d75f4a_images.jpg", 43.5m, "Fila Men's Passion Black red Canvas Shoe", "Casual Shoes", "Casual" },
                    { 5238, 1, "Brown", "Men", "5238.jpg", "http://assets.myntassets.com/v1/images/style/properties/973dc13e58cef052ab4e9d1036c9081a_images.jpg", 24.0m, "Reebok Men's Lazor Brown Flip Flop", "Flip Flops", "Casual" },
                    { 5239, 3, "White", "Men", "5239.jpg", "http://assets.myntassets.com/v1/images/style/properties/c8a72a981c15936a083c6382f05e72ef_images.jpg", 57.5m, "Reebok Men's Zigfuel White Shoe", "Sports Shoes", "Sports" },
                    { 5290, 3, "Black", "Men", "5290.jpg", "http://assets.myntassets.com/v1/images/style/properties/30826a489f3fb44e19fac8f68a5fdcbf_images.jpg", 20.5m, "Lee Cooper Men Black Shoe", "Formal Shoes", "Formal" },
                    { 5291, 3, "Black", "Men", "5291.jpg", "http://assets.myntassets.com/v1/images/style/properties/f9e6c0170eadb83b2f0c082b457548a2_images.jpg", 47.5m, "Lee Cooper Men Black Semi Formal Shoe", "Formal Shoes", "Formal" },
                    { 5296, 2, "Black", "Men", "5296.jpg", "http://assets.myntassets.com/v1/images/style/properties/f5591109328d6f69462df128965a8258_images.jpg", 50.0m, "Puma Men Black Floater", "Sandals", "Casual" },
                    { 5345, 3, "Black", "Men", "5345.jpg", "http://assets.myntassets.com/v1/images/style/properties/92796112246863dfc584ecef49418a3b_images.jpg", 79.5m, "Btwin Sport 5 Shoes", "Sports Shoes", "Sports" },
                    { 5404, 3, "White", "Men", "5404.jpg", "http://assets.myntassets.com/v1/images/style/properties/fa523afb4c2f1ee300b0b0267e0e0dd9_images.jpg", 37.5m, "Kalenji Kiprun 1000 Whi/ Blue 2011", "Sports Shoes", "Sports" },
                    { 5405, 3, "White", "Men", "5405.jpg", "http://assets.myntassets.com/v1/images/style/properties/07932c2277eda49d29639f0fe3c4e4c6_images.jpg", 31.0m, "Kalenji Ekiden Comfort Prime 2011", "Sports Shoes", "Sports" },
                    { 5459, 3, "Grey", "Men", "5459.jpg", "http://assets.myntassets.com/v1/images/style/properties/579c1cbc0dae16a3e6ec209f2e1e1ac1_images.jpg", 45.5m, "Nike Men's Dual Fusion Grey Shoe", "Sports Shoes", "Sports" },
                    { 5461, 3, "Black", "Men", "5461.jpg", "http://assets.myntassets.com/v1/images/style/properties/0fe9f1a6f85a5c4703716ac28cff358f_images.jpg", 49.0m, "Nike Men's Downshifter Lea Black Shoe", "Sports Shoes", "Sports" },
                    { 5467, 3, "Black", "Men", "5467.jpg", "http://assets.myntassets.com/v1/images/style/properties/2647f07a41cd23ee046ffad2d5d4a520_images.jpg", 41.5m, "Nike Men's Elite Black Shoe", "Sports Shoes", "Sports" },
                    { 5468, 3, "White", "Men", "5468.jpg", "http://assets.myntassets.com/v1/images/style/properties/be5106fa146a771fdb128833b4ab9b8b_images.jpg", 59.0m, "Nike Men's Lunareclipse White Shoe", "Sports Shoes", "Sports" },
                    { 5469, 3, "Black", "Men", "5469.jpg", "http://assets.myntassets.com/v1/images/style/properties/57c85d90712fff84d799ecd09d4bc898_images.jpg", 75.5m, "Nike Men's Nike Streetgato Black Shoe", "Sports Shoes", "Sports" },
                    { 5600, 3, "Blue", "Men", "5600.jpg", "http://assets.myntassets.com/v1/images/style/properties/c56c66b0cc2eb62cb34bfa06e3196154_images.jpg", 29.0m, "Reebok Men's Trail Mud Slinger Black Blue Shoe", "Sports Shoes", "Sports" },
                    { 5601, 1, "Brown", "Men", "5601.jpg", "http://assets.myntassets.com/v1/images/style/properties/31cec799c74c62b9785cc809953ae766_images.jpg", 48.5m, "Nike Men's Splash Thong Yellow Black Flip Flop", "Flip Flops", "Casual" },
                    { 5606, 2, "Black", "Men", "5606.jpg", "http://assets.myntassets.com/v1/images/style/properties/a2910180f57f2557139decd881dd66b1_images.jpg", 32.5m, "ADIDAS Men Kendall Black Floater", "Sandals", "Casual" },
                    { 5608, 2, "Black", "Men", "5608.jpg", "http://assets.myntassets.com/v1/images/style/properties/f12bab8f2514a0656f81aa863dd966c3_images.jpg", 20.5m, "ADIDAS Men Kendall Black Navy Floater", "Sandals", "Casual" },
                    { 5609, 2, "Navy Blue", "Men", "5609.jpg", "http://assets.myntassets.com/v1/images/style/properties/Adidas-Men-Receptor-Navy-Sports-Sandals_c52fff61c336160cdbfbe954cb1d12ed_images.jpg", 44.5m, "ADIDAS Men Receptor Navy Sports Sandals", "Sports Sandals", "Casual" },
                    { 5638, 1, "Brown", "Men", "5638.jpg", "http://assets.myntassets.com/v1/images/style/properties/77faada48a82a4805451fe6d1350bedf_images.jpg", 31.0m, "ADIDAS Men's Adi Liner Brown Flip Flop", "Flip Flops", "Casual" },
                    { 5654, 3, "White", "Men", "5654.jpg", "http://assets.myntassets.com/v1/images/style/properties/85fc66a2cdec98335e142d8a30ca8347_images.jpg", 28.0m, "Reebok Men's Winning Stride White Shoe", "Sports Shoes", "Sports" },
                    { 5665, 1, "Grey", "Men", "5665.jpg", "http://assets.myntassets.com/v1/images/style/properties/5d4748a6ae5fecb41977d8c4fe7ac09e_images.jpg", 41.0m, "ADIDAS Men's Slide Grey Orange Flip Flop", "Flip Flops", "Casual" },
                    { 5690, 3, "Black", "Men", "5690.jpg", "http://assets.myntassets.com/v1/images/style/properties/7bcc64e12b3d947664ca4bb7782cd52f_images.jpg", 58.5m, "Skechers Men Valence Envoy Black Shoe", "Casual Shoes", "Casual" },
                    { 5691, 3, "White", "Men", "5691.jpg", "http://assets.myntassets.com/v1/images/style/properties/e508e488636ba30755268cd5b917f465_images.jpg", 33.0m, "Skechers Men's Regions Off White Shoe", "Casual Shoes", "Casual" },
                    { 5696, 3, "Brown", "Men", "5696.jpg", "http://assets.myntassets.com/v1/images/style/properties/c72fec8d51ffe8aee9e80316ced621ff_images.jpg", 39.0m, "Skechers Men Genesis Brown Shoe", "Casual Shoes", "Casual" },
                    { 5697, 3, "Black", "Men", "5697.jpg", "http://assets.myntassets.com/v1/images/style/properties/Skechers-Mens-Midnight-Choco-Shoe_04bfd375a9dc8a3ddcf8d4a61604681d_images.jpg", 54.0m, "Skechers Men Black Casual Shoes", "Casual Shoes", "Casual" },
                    { 5698, 3, "Brown", "Men", "5698.jpg", "http://assets.myntassets.com/v1/images/style/properties/5227614b9cc520f8f655397aaa39b6e4_images.jpg", 28.0m, "Skechers Men's Liquid Roggers Brown Shoe", "Casual Shoes", "Casual" },
                    { 5699, 3, "Black", "Men", "5699.jpg", "http://assets.myntassets.com/v1/images/style/properties/7ab6c782cf6156d10037f737cc34e1f0_images.jpg", 73.0m, "Skechers Men's Striking Black Shoe", "Casual Shoes", "Casual" },
                    { 5896, 3, "Black", "Men", "5896.jpg", "http://assets.myntassets.com/v1/images/style/properties/57601ed1977aecafecafbfb1fe49a424_images.jpg", 64.0m, "Puma Men Cavallino Black Shoe", "Casual Shoes", "Casual" },
                    { 5898, 3, "Blue", "Men", "5898.jpg", "http://assets.myntassets.com/v1/images/style/properties/c315458173ac7727678f8e37f90bb259_images.jpg", 71.0m, "Puma Men Tekkies Jam Blue Shoe", "Casual Shoes", "Casual" },
                    { 5899, 3, "Black", "Men", "5899.jpg", "http://assets.myntassets.com/v1/images/style/properties/59c96d42203b9c8683b7135026adb936_images.jpg", 56.0m, "Puma Men's Mid Spill Black Shoe", "Casual Shoes", "Casual" },
                    { 6362, 3, "Blue", "Men", "6362.jpg", "http://assets.myntassets.com/v1/images/style/properties/09c2188ab7a57021af4056c2746a036e_images.jpg", 37.5m, "Numero Uno Men's Dark Blue Shoe", "Casual Shoes", "Casual" },
                    { 6396, 2, "Beige", "Men", "6396.jpg", "http://assets.myntassets.com/v1/images/style/properties/65c36a0bb5b2807cd13cd31c3fc39ce5_images.jpg", 20.5m, "Lotto Men Revenge 02 Beige Grey Floater", "Sandals", "Casual" },
                    { 6414, 1, "Grey", "Men", "6414.jpg", "http://assets.myntassets.com/v1/images/style/properties/b2f98fd8aeb72ad2dd8b76cd7468bc55_images.jpg", 68.0m, "Lotto Men's Thong Blue White Flip Flop", "Flip Flops", "Casual" },
                    { 6423, 1, "Black", "Men", "6423.jpg", "http://assets.myntassets.com/v1/images/style/properties/8e32c33844c56ea0eab61b9e3631795e_images.jpg", 54.5m, "Lotto Men's Bavarian Black Yellow Flip Flop", "Flip Flops", "Casual" },
                    { 6424, 1, "Navy Blue", "Men", "6424.jpg", "http://assets.myntassets.com/v1/images/style/properties/d009623b103d388d2b799d03752746aa_images.jpg", 78.0m, "Lotto Men's Tennis Mule Navy Blue Flip Flop", "Flip Flops", "Casual" },
                    { 6440, 3, "Black", "Men", "6440.jpg", "http://assets.myntassets.com/v1/images/style/properties/5b54a388987f652667b258f4480b2a13_images.jpg", 39.5m, "Lotto Men's Calcetto Black Brown Shoe", "Casual Shoes", "Casual" },
                    { 6441, 3, "White", "Men", "6441.jpg", "http://assets.myntassets.com/v1/images/style/properties/4a43030e45772b341104718c994b5148_images.jpg", 34.5m, "Lotto Men's Calcetto White Red Shoe", "Casual Shoes", "Casual" },
                    { 6446, 3, "Grey", "Men", "6446.jpg", "http://assets.myntassets.com/v1/images/style/properties/e6e6d7fee7b7aa20fb5bf93e9f340890_images.jpg", 37.5m, "Lotto Men's Calcetto Grey Shoe", "Casual Shoes", "Casual" },
                    { 6448, 3, "Brown", "Men", "6448.jpg", "http://assets.myntassets.com/v1/images/style/properties/1596f48c3390726499fc364df52a4d91_images.jpg", 43.5m, "Lotto Men's Calcetto Brown Shoe", "Casual Shoes", "Casual" },
                    { 6470, 3, "Brown", "Men", "6470.jpg", "http://assets.myntassets.com/v1/images/style/properties/2ed17831fbdb5f6c663203b0e601293b_images.jpg", 47.0m, "Numero Uno Men's Beige Brown Casual Shoe", "Casual Shoes", "Casual" },
                    { 6483, 3, "Black", "Men", "6483.jpg", "http://assets.myntassets.com/v1/images/style/properties/d795c0c5c2019110f3e2d94dde1d1543_images.jpg", 66.5m, "Red Tape Men's Formal Lace Black Shoe", "Formal Shoes", "Formal" },
                    { 6619, 3, "White", "Men", "6619.jpg", "http://assets.myntassets.com/v1/images/style/properties/2aacd81da075c8d9cb891276bd9dbc9e_images.jpg", 44.0m, "ADIDAS Men's Boris White Shoe", "Sports Shoes", "Sports" },
                    { 6620, 3, "White", "Men", "6620.jpg", "http://assets.myntassets.com/v1/images/style/properties/2c9af30263273a80ebe9e75c0098edc2_images.jpg", 62.5m, "ADIDAS Men's Ridley White Silver Shoe", "Sports Shoes", "Sports" },
                    { 6621, 3, "Black", "Men", "6621.jpg", "http://assets.myntassets.com/v1/images/style/properties/2e0f915b21422d3685efaaaca1248707_images.jpg", 68.5m, "ADIDAS Men's Boris Black Shoe", "Sports Shoes", "Sports" },
                    { 6626, 3, "Blue", "Men", "6626.jpg", "http://assets.myntassets.com/v1/images/style/properties/b8d8c3d8ce77c3ffbeac1bd5ab06b450_images.jpg", 42.5m, "ADIDAS Men's Canon Dialect Blue Yellow Shoe", "Sports Shoes", "Sports" },
                    { 6627, 3, "Black", "Men", "6627.jpg", "http://assets.myntassets.com/v1/images/style/properties/d4a5a7db2b73ce5edd246dd2a7f5e70f_images.jpg", 33.0m, "ADIDAS Men's Morin Black Shoe", "Sports Shoes", "Sports" },
                    { 6628, 3, "White", "Men", "6628.jpg", "http://assets.myntassets.com/v1/images/style/properties/0707b75d2d44e9cec9d27c944294ddbe_images.jpg", 33.0m, "ADIDAS Men's Lowell White Silver Shoe", "Sports Shoes", "Sports" },
                    { 6629, 3, "White", "Men", "6629.jpg", "http://assets.myntassets.com/v1/images/style/properties/3d67098ff0b7461cd8c4d35ed605695c_images.jpg", 21.0m, "ADIDAS Men's Galvin White Silver Black Shoe", "Sports Shoes", "Sports" },
                    { 6642, 3, "White", "Men", "6642.jpg", "http://assets.myntassets.com/v1/images/style/properties/3ccc31f0b88b7a4c070286cbd0c4d14e_images.jpg", 41.5m, "Nike Men's Air Max Lte White Blue Shoe", "Sports Shoes", "Sports" },
                    { 6673, 3, "White", "Men", "6673.jpg", "http://assets.myntassets.com/v1/images/style/properties/f3d3b086f3e895f2662b09549e5ac12e_images.jpg", 41.5m, "Nike Men's Air Pegasus 27 White Grey Shoe", "Sports Shoes", "Sports" },
                    { 6675, 3, "White", "Men", "6675.jpg", "http://assets.myntassets.com/v1/images/style/properties/d5ee8454b30de9e73365020686fc8f30_images.jpg", 52.5m, "Nike Men's Free White Grey Shoe", "Sports Shoes", "Sports" },
                    { 6680, 3, "Grey", "Men", "6680.jpg", "http://assets.myntassets.com/v1/images/style/properties/237040c834f4e9bb32dcb003a9d70687_images.jpg", 56.0m, "Nike Men's Zoom Vomero 5 Grey Blue Shoe", "Sports Shoes", "Sports" },
                    { 6810, 3, "Brown", "Men", "6810.jpg", "http://assets.myntassets.com/v1/images/style/properties/6f4d09d306689ec90049dad74570e5c7_images.jpg", 29.0m, "Timberland Men Earthkeeper Burnsh Medium Brown Shoe", "Casual Shoes", "Casual" },
                    { 6811, 3, "Red", "Men", "6811.jpg", "http://assets.myntassets.com/v1/images/style/properties/a3fc5944d6fbe2b7f705c72ce9a6beb9_images.jpg", 46.5m, "Timberland Men's Ox Maroon Red Shoe", "Casual Shoes", "Casual" },
                    { 6816, 3, "Brown", "Men", "6816.jpg", "http://assets.myntassets.com/v1/images/style/properties/b17cd3ff530b6f1250dfb0abda96c998_images.jpg", 31.0m, "Timberland Men's Desert Walnut Brown Shoe", "Casual Shoes", "Casual" },
                    { 6817, 1, "Blue", "Men", "6817.jpg", "http://assets.myntassets.com/v1/images/style/properties/Timberland-Men-Blue-Thong-Flip-Flops_02bb5f9ccf76c9ff75ff8289dcc34aec_images.jpg", 22.5m, "Timberland Men Blue Thong Flip Flops", "Flip Flops", "Casual" },
                    { 6818, 1, "Red", "Men", "6818.jpg", "http://assets.myntassets.com/v1/images/style/properties/699a744978514f56207a916e8f51dcc1_images.jpg", 61.5m, "Timberland Men's Grn Thng Red Flip Flop", "Flip Flops", "Casual" },
                    { 6821, 2, "Brown", "Men", "6821.jpg", "http://assets.myntassets.com/v1/images/style/properties/402ce454f57316b103826e998e799dc2_images.jpg", 76.0m, "Timberland Men City Brown Floater", "Sandals", "Casual" },
                    { 6826, 2, "Grey", "Men", "6826.jpg", "http://assets.myntassets.com/v1/images/style/properties/b13129b0120d04e589292b936e5a0fe7_images.jpg", 57.5m, "Timberland Men Nekkol Grey Black Floater", "Sandals", "Casual" },
                    { 7244, 3, "Black", "Men", "7244.jpg", "http://assets.myntassets.com/v1/images/style/properties/fb55d69868be24b540b4f40f9b0ca979_images.jpg", 78.5m, "Rockport Men's Allander Black Shoe", "Formal Shoes", "Formal" },
                    { 7330, 2, "Black", "Men", "7330.jpg", "http://assets.myntassets.com/v1/images/style/properties/ee45b8fcfca7d478d7ff4a08132c9cc2_images.jpg", 28.0m, "Red Tape Men Strappy Black Floater", "Sandals", "Casual" },
                    { 7331, 3, "Brown", "Men", "7331.jpg", "http://assets.myntassets.com/v1/images/style/properties/067ed592a5c26be0a4b6a6adbb4f9feb_images.jpg", 32.0m, "Red Tape Men's Formal Light Brown Shoe", "Formal Shoes", "Formal" },
                    { 7363, 3, "Black", "Men", "7363.jpg", "http://assets.myntassets.com/v1/images/style/properties/Red-Tape-Men-Black-Semi-Formal-Shoes_6d0e438208cfddf1a1c0423a04a3cc21_images.jpg", 20.0m, "Red Tape Men Black Semi Formal Shoes", "Formal Shoes", "Formal" },
                    { 7364, 3, "Brown", "Men", "7364.jpg", "http://assets.myntassets.com/v1/images/style/properties/e1f82da932e688fe0f59740369c59b97_images.jpg", 75.0m, "Red Tape Men's Brown casual Shoe", "Casual Shoes", "Casual" },
                    { 7365, 3, "Black", "Men", "7365.jpg", "http://assets.myntassets.com/v1/images/style/properties/d648df96e206c445198d2cb32d27b8a4_images.jpg", 25.0m, "Red Tape Men's Black Casual Shoe", "Casual Shoes", "Casual" },
                    { 7390, 3, "Brown", "Men", "7390.jpg", "http://assets.myntassets.com/v1/images/style/properties/e7ca97d7b2f468e63a1f84cc988c72ca_images.jpg", 67.5m, "Red Tape Men Brown Shoes", "Formal Shoes", "Formal" },
                    { 7391, 3, "Black", "Men", "7391.jpg", "http://assets.myntassets.com/v1/images/style/properties/296ac470d429413d69d62e8105a8d6cb_images.jpg", 62.5m, "Red Tape Men's Black Slip-On Formal Shoe", "Formal Shoes", "Formal" },
                    { 7396, 3, "Grey", "Men", "7396.jpg", "http://assets.myntassets.com/v1/images/style/properties/fbcff46874a80f4e8fcc2fad9642bf6e_images.jpg", 26.5m, "Red Tape Men Grey Casual Shoes", "Casual Shoes", "Casual" },
                    { 7397, 3, "Black", "Men", "7397.jpg", "http://assets.myntassets.com/v1/images/style/properties/3824fbb868e03010753ee203cac2efc5_images.jpg", 42.5m, "Red Tape Men's Black Formal Shoe", "Formal Shoes", "Formal" },
                    { 7398, 3, "Brown", "Men", "7398.jpg", "http://assets.myntassets.com/v1/images/style/properties/3de65566d817f454427054e97487d2c5_images.jpg", 34.5m, "Red Tape Men Brown Shoes", "Formal Shoes", "Formal" },
                    { 7399, 3, "Black", "Men", "7399.jpg", "http://assets.myntassets.com/v1/images/style/properties/f100c2c689ac3bf1ecbf643b1921c001_images.jpg", 46.5m, "Red Tape Men's Black Formal Shoe", "Formal Shoes", "Formal" },
                    { 7592, 3, "Blue", "Men", "7592.jpg", "http://assets.myntassets.com/v1/images/style/properties/0bbe0e10638aa98ff6f42fbffd30c1a2_images.jpg", 41.0m, "Nike Men's Dunk Low Blue Shoe", "Sports Shoes", "Sports" },
                    { 7593, 3, "White", "Men", "7593.jpg", "http://assets.myntassets.com/v1/images/style/properties/c63680ffe70accf50ca213d461f39703_images.jpg", 24.5m, "Nike Men Zoom Vapor 8 White Red Shoe", "Sports Shoes", "Sports" },
                    { 7730, 2, "Black", "Men", "7730.jpg", "http://assets.myntassets.com/v1/images/style/properties/f525e99cbf1f5b6c4ab775e569d6beb6_images.jpg", 48.0m, "Puma Men Apex Black Olive Sandal", "Sandals", "Casual" },
                    { 7731, 1, "Grey", "Men", "7731.jpg", "http://assets.myntassets.com/v1/images/style/properties/9473ae18face7603f7bdb4b6fda3d8e2_images.jpg", 75.5m, "Puma Men's Winglet II Grey Yellow White Flip Flop", "Flip Flops", "Casual" },
                    { 7753, 3, "Black", "Men", "7753.jpg", "http://assets.myntassets.com/v1/images/style/properties/3090de677a92eb346719f0632e939062_images.jpg", 30.0m, "Fila Men's Victory Black Shoe", "Sports Shoes", "Sports" },
                    { 7754, 3, "Black", "Men", "7754.jpg", "http://assets.myntassets.com/v1/images/style/properties/07396560af065725a85a392318d02103_images.jpg", 67.0m, "Fila Men's Agony Black Red Shoe", "Casual Shoes", "Casual" },
                    { 7797, 3, "Black", "Men", "7797.jpg", "http://assets.myntassets.com/v1/images/style/properties/098fd7c7895c5c2cb80d0eba4224c102_images.jpg", 36.5m, "Puma Men's First Round Takeahike Black Yellow Shoe", "Casual Shoes", "Casual" },
                    { 7799, 3, "White", "Men", "7799.jpg", "http://assets.myntassets.com/v1/images/style/properties/ef1f0c1dbcf7004c4495b431c986d81a_images.jpg", 45.5m, "Puma Men's Manilla Hi White Shoe", "Casual Shoes", "Casual" },
                    { 7881, 3, "Black", "Men", "7881.jpg", "http://assets.myntassets.com/v1/images/style/properties/592207233cfa424f4579f5f9d25720b7_images.jpg", 26.0m, "Provogue Men's Formal Black Shoe", "Formal Shoes", "Formal" },
                    { 8346, 3, "White", "Men", "8346.jpg", "http://assets.myntassets.com/v1/images/style/properties/93d7b862df153aa53d2e1c8816879f56_images.jpg", 53.5m, "ADIDAS Men Slimsoll White Sports Shoes", "Sports Shoes", "Sports" },
                    { 8527, 2, "Black", "Men", "8527.jpg", "http://assets.myntassets.com/v1/images/style/properties/06a3443ee9b68ccb63036dd65b797852_images.jpg", 28.0m, "Nike Men Nike air embark Black Sandals", "Sandals", "Casual" },
                    { 8528, 3, "Black", "Men", "8528.jpg", "http://assets.myntassets.com/v1/images/style/properties/47ef33226d005cc077c3bd62dff9fdf7_images.jpg", 50.0m, "Nike Men Nike air max limitless Black Sports Shoes", "Sports Shoes", "Sports" },
                    { 8529, 3, "Navy Blue", "Men", "8529.jpg", "http://assets.myntassets.com/v1/images/style/properties/707710871b57d10fd1b1275c184750a6_images.jpg", 67.5m, "Nike Men Nike Lunarfly+  2 Navy Blue Sports Shoes", "Sports Shoes", "Sports" },
                    { 8912, 3, "White", "Men", "8912.jpg", "http://assets.myntassets.com/v1/images/style/properties/043071beb363cc49b9be54743ddf8ff6_images.jpg", 44.0m, "Puma Men Cabana Racer Sketch White Sports Shoes", "Sports Shoes", "Sports" },
                    { 8913, 3, "White", "Men", "8913.jpg", "http://assets.myntassets.com/v1/images/style/properties/c7a70ae4f57ca4c605f4fabb82c735fc_images.jpg", 59.5m, "Puma Men Cabana Racer Sketch White Sports Shoes", "Sports Shoes", "Sports" },
                    { 8914, 3, "White", "Men", "8914.jpg", "http://assets.myntassets.com/v1/images/style/properties/b1d9e4498de202e29570bd08090f26a9_images.jpg", 78.5m, "Puma Men Future Cat Remix SF White Sports Shoes", "Sports Shoes", "Sports" },
                    { 8970, 3, "Red", "Men", "8970.jpg", "http://assets.myntassets.com/v1/images/style/properties/900150bcb99d5bbb451d4037d7545ba8_images.jpg", 21.0m, "Puma Men 65cc Ducati Red Sports Shoes", "Sports Shoes", "Sports" },
                    { 8971, 3, "Black", "Men", "8971.jpg", "http://assets.myntassets.com/v1/images/style/properties/b0f6e40ac38b85e949721b079891659f_images.jpg", 49.5m, "Puma Men Drift Cat III CF Black Sports Shoes", "Sports Shoes", "Sports" },
                    { 8976, 3, "White", "Men", "8976.jpg", "http://assets.myntassets.com/v1/images/style/properties/7923a91c983c0f5b59b5269f2cd4898d_images.jpg", 30.5m, "Puma Men SL Tech Lo SF White Sports Shoes", "Sports Shoes", "Sports" },
                    { 8979, 3, "Black", "Men", "8979.jpg", "http://assets.myntassets.com/v1/images/style/properties/f70c7516c24b084f37404cf3bca4614f_images.jpg", 43.0m, "Puma Men Driving Power Lo SF Black Sports Shoes", "Sports Shoes", "Sports" },
                    { 8982, 3, "White", "Men", "8982.jpg", "http://assets.myntassets.com/v1/images/style/properties/7bb4c08f6dcc4fd9192f71741e898ef8_images.jpg", 51.0m, "Puma Men Evo Ducati Lo White Casual Shoes", "Casual Shoes", "Casual" },
                    { 8983, 3, "Black", "Men", "8983.jpg", "http://assets.myntassets.com/v1/images/style/properties/875c715ba32791dc0425a005ccda98f6_images.jpg", 67.0m, "Puma Men Evo Ducati Lo Black Casual Shoes", "Casual Shoes", "Casual" },
                    { 8984, 3, "Green", "Men", "8984.jpg", "http://assets.myntassets.com/v1/images/style/properties/8002a8c76c3bc5a7337fbca8c28ae2d9_images.jpg", 39.0m, "Puma Men TX-3 Green Casual Shoes", "Casual Shoes", "Casual" },
                    { 9000, 3, "Brown", "Men", "9000.jpg", "http://assets.myntassets.com/v1/images/style/properties/541e84bced1067d6ef4e59508561a303_images.jpg", 76.0m, "Puma Men Archive Boot WTR Brown Casual Shoes", "Casual Shoes", "Casual" },
                    { 9001, 3, "Grey", "Men", "9001.jpg", "http://assets.myntassets.com/v1/images/style/properties/ad70631a51062e68f3c07f156904f6cd_images.jpg", 59.0m, "Puma Men El rey Riddim 50s OC Grey Casual Shoes", "Casual Shoes", "Casual" },
                    { 9030, 3, "Brown", "Men", "9030.jpg", "http://assets.myntassets.com/v1/images/style/properties/71a4e1fa5abfa2146a0ebea59b723d5d_images.jpg", 50.5m, "Buckaroo Men loma Brown Casual Shoes", "Casual Shoes", "Casual" },
                    { 9031, 3, "Tan", "Men", "9031.jpg", "http://assets.myntassets.com/v1/images/style/properties/c42e34c84003a87f8fc0d5694e82d4c3_images.jpg", 37.5m, "Buckaroo Men loma Tan Casual Shoes", "Casual Shoes", "Casual" },
                    { 9036, 3, "Black", "Men", "9036.jpg", "http://assets.myntassets.com/v1/images/style/properties/06edc2da9c6d103d299e5e8dafc5b6b9_images.jpg", 50.5m, "Buckaroo Men Flores Black Formal Shoes", "Formal Shoes", "Formal" },
                    { 9037, 3, "Black", "Men", "9037.jpg", "http://assets.myntassets.com/v1/images/style/properties/a8ac7df8dc72daebf55abfb65c363671_images.jpg", 72.5m, "Buckaroo Men Medina Black Formal Shoes", "Formal Shoes", "Formal" },
                    { 9038, 3, "Brown", "Men", "9038.jpg", "http://assets.myntassets.com/v1/images/style/properties/72da3d057e90841278201ab75c993aff_images.jpg", 69.5m, "Buckaroo Men Medina Brown Formal Shoes", "Formal Shoes", "Formal" },
                    { 9039, 3, "Black", "Men", "9039.jpg", "http://assets.myntassets.com/v1/images/style/properties/a6b18114bdf93ad684db5ceff4207821_images.jpg", 48.5m, "Buckaroo Men Victor Black Formal Shoes", "Formal Shoes", "Formal" },
                    { 9052, 3, "White", "Men", "9052.jpg", "http://assets.myntassets.com/v1/images/style/properties/d6a1803ef3e7d36bb596537978d541e4_images.jpg", 37.0m, "ADIDAS Men Duramo 3 M White Sports Shoes", "Sports Shoes", "Sports" },
                    { 9053, 3, "Grey", "Men", "9053.jpg", "http://assets.myntassets.com/v1/images/style/properties/0ebc15dcb00d4f2315f8341ee05b19a7_images.jpg", 47.0m, "ADIDAS Men Duramo 3 M Grey Sports Shoes", "Sports Shoes", "Sports" },
                    { 9055, 3, "White", "Men", "9055.jpg", "http://assets.myntassets.com/v1/images/style/properties/4bb5e5a5167ab8b31d0c128728752a05_images.jpg", 27.5m, "ADIDAS Men Adi Fiero M White Sports Shoes", "Sports Shoes", "Sports" },
                    { 9090, 3, "Black", "Men", "9090.jpg", "http://assets.myntassets.com/v1/images/style/properties/ca13b77121b5d3808d7ea020e0492d61_images.jpg", 30.0m, "Buckaroo Men Valle Black Casual Shoes", "Casual Shoes", "Casual" },
                    { 9091, 3, "Maroon", "Men", "9091.jpg", "http://assets.myntassets.com/v1/images/style/properties/f2b68e6b400d4610c64eea0c9fbacff0_images.jpg", 33.0m, "Buckaroo Men Amigo Maroon Casual Shoes", "Casual Shoes", "Casual" },
                    { 9202, 3, "Red", "Men", "9202.jpg", "http://assets.myntassets.com/v1/images/style/properties/6e70da257e2040ff7823c9e9da1b5a87_images.jpg", 79.0m, "Puma Men Yacht L Red Casual Shoes", "Casual Shoes", "Casual" },
                    { 9203, 3, "Black", "Men", "9203.jpg", "http://assets.myntassets.com/v1/images/style/properties/70ffebcb332030e98e65461076ac2fb0_images.jpg", 72.0m, "Puma Men Axis XT Black Shoes", "Sports Shoes", "Sports" },
                    { 9204, 3, "Black", "Men", "9204.jpg", "http://assets.myntassets.com/v1/images/style/properties/051d64772f1b38ff476fbf0a807f365a_images.jpg", 25.0m, "Puma Men Future Cat Remix SF Black Casual Shoes", "Casual Shoes", "Casual" },
                    { 9205, 3, "Black", "Men", "9205.jpg", "http://assets.myntassets.com/v1/images/style/properties/e4b0626410783b1adc96db55574959dc_images.jpg", 50.5m, "Puma Men SL Tech Lo NM Basic Black Casual Shoes", "Casual Shoes", "Casual" },
                    { 9400, 3, "Black", "Men", "9400.jpg", "http://assets.myntassets.com/v1/images/style/properties/3ba767d12d769d771e11ce55a121f5ac_images.jpg", 45.0m, "Nike Men Dual Fusion Black TR II Sports Shoes", "Sports Shoes", "Sports" },
                    { 9401, 3, "Blue", "Men", "9401.jpg", "http://assets.myntassets.com/v1/images/style/properties/e156531b242b0b2f63b6c9f3eaf3dfb5_images.jpg", 49.0m, "Nike Men Lunarswi + 2 Blue Sports Shoes", "Sports Shoes", "Sports" },
                    { 9407, 3, "White", "Men", "9407.jpg", "http://assets.myntassets.com/v1/images/style/properties/3b02ee079fbd884aa6ba20984e379fd6_images.jpg", 65.5m, "Nike Men Court White Shoe", "Sports Shoes", "Sports" },
                    { 9430, 3, "Black", "Men", "9430.jpg", "http://assets.myntassets.com/v1/images/style/properties/ef183787311e4d8e9f33dcf3ceff9102_images.jpg", 39.0m, "Lee Cooper Men Nnado Black Formal Shoes", "Formal Shoes", "Formal" },
                    { 9431, 3, "Grey", "Men", "9431.jpg", "http://assets.myntassets.com/v1/images/style/properties/fe2ec858a43a431e5422018f652d9b39_images.jpg", 38.0m, "Decathlon Men Quechua Grey Sports Shoes", "Sports Shoes", "Sports" },
                    { 9497, 2, "Black", "Men", "9497.jpg", "http://assets.myntassets.com/v1/images/style/properties/11371998e15f21cf032b30fdba5e972c_images.jpg", 69.0m, "Decathlon Men Arpenaz Black Sandals", "Sandals", "Casual" },
                    { 10037, 3, "Silver", "Men", "10037.jpg", "http://assets.myntassets.com/v1/images/style/properties/c876491b1ad3bbece863d5bf29408446_images.jpg", 78.5m, "Reebok Men Premier ultra 8 U-form Silver Sports Shoes", "Sports Shoes", "Sports" },
                    { 10039, 3, "White", "Men", "10039.jpg", "http://assets.myntassets.com/v1/images/style/properties/8c7024fc08196b33759515ff1d542899_images.jpg", 25.0m, "Reebok Men Raceon White Sports Shoes", "Sports Shoes", "Sports" },
                    { 10097, 3, "White", "Men", "10097.jpg", "http://assets.myntassets.com/v1/images/style/properties/a947ceec9e8c493229417e1a1390417e_images.jpg", 22.0m, "Reebok Men Reeflex Run White Sports Shoes", "Sports Shoes", "Sports" },
                    { 10174, 3, "Black", "Men", "10174.jpg", "http://assets.myntassets.com/v1/images/style/properties/fc4ea7a39f7b828bcf2fc6dfd81a1eb0_images.jpg", 21.0m, "United Colors Of Benetton Men Latnam Black Casual Shoes", "Casual Shoes", "Casual" },
                    { 10180, 1, "Yellow", "Men", "10180.jpg", "http://assets.myntassets.com/v1/images/style/properties/abf212122486259ba302c810103970e6_images.jpg", 58.5m, "United Colors of Benetton Men Speeder Yellow Flip Flops", "Flip Flops", "Casual" },
                    { 10266, 3, "Brown", "Men", "10266.jpg", "http://assets.myntassets.com/v1/images/style/properties/4269a355e474308b6e0f174cf6a9f6f0_images.jpg", 73.0m, "Clarks Men Goto Hi Cola Suede Brown Shoes", "Casual Shoes", "Casual" },
                    { 10267, 3, "Black", "Men", "10267.jpg", "http://assets.myntassets.com/v1/images/style/properties/5040e0c7e82dcc67e1c0a42ee04eb519_images.jpg", 73.0m, "Clarks Men Rocco Fuse Black Leather Black Casual Shoes", "Casual Shoes", "Casual" },
                    { 10268, 3, "Black", "Men", "10268.jpg", "http://assets.myntassets.com/v1/images/style/properties/2976e4095e7b3ae2de99df54d2adeaaa_images.jpg", 53.5m, "Clarks Men Hang Work Leather Black Formal Shoes", "Formal Shoes", "Formal" },
                    { 10293, 2, "Brown", "Men", "10293.jpg", "http://assets.myntassets.com/v1/images/style/properties/566b15c0f837887c3b42c3e1dae8605a_images.jpg", 78.5m, "Clarks Men Unstructured Leather Brown Sandals", "Sandals", "Casual" },
                    { 10294, 3, "Brown", "Men", "10294.jpg", "http://assets.myntassets.com/v1/images/style/properties/91b438e6f6ad7cf63571fdea86dc7f68_images.jpg", 28.0m, "Clarks Men Feeling Good Leather Brown Formal Shoes", "Formal Shoes", "Formal" },
                    { 10295, 3, "Brown", "Men", "10295.jpg", "http://assets.myntassets.com/v1/images/style/properties/83cd6db4f547e2ec582714b3592ba718_images.jpg", 27.0m, "Clarks Men Brown Leather Casual Shoes", "Casual Shoes", "Casual" },
                    { 10632, 3, "Brown", "Men", "10632.jpg", "http://assets.myntassets.com/v1/images/style/properties/Carlton-London-Men-CL-semi-cas-Brown-Casual-Shoes_a9d0af87aa3dcfaeee65b44432de7fea_images.jpg", 54.5m, "Carlton London Men Brown Shoes", "Casual Shoes", "Casual" },
                    { 10633, 3, "Brown", "Men", "10633.jpg", "http://assets.myntassets.com/v1/images/style/properties/b195b911f558c0232e22849d1ca73193_images.jpg", 20.0m, "Carlton London Men Formal Brown Formal Shoes", "Formal Shoes", "Formal" },
                    { 10634, 3, "Black", "Men", "10634.jpg", "http://assets.myntassets.com/v1/images/style/properties/f1d954cfacfc79f32325794d43b6c3a0_images.jpg", 79.5m, "Carlton London Men Black Oxford Wingtip Brogues", "Formal Shoes", "Formal" },
                    { 10635, 3, "Black", "Men", "10635.jpg", "http://assets.myntassets.com/v1/images/style/properties/412580b9038a38e27506054eac80a836_images.jpg", 47.0m, "Carlton London Men Semi oxfords Black Casual Shoes", "Casual Shoes", "Casual" },
                    { 11851, 1, "Grey", "Men", "11851.jpg", "http://assets.myntassets.com/v1/images/style/properties/5040d83690dbba913807b7c8d90f3a33_images.jpg", 73.0m, "Playboy Men Grey Flip Flops", "Flip Flops", "Casual" },
                    { 11856, 1, "Red", "Men", "11856.jpg", "http://assets.myntassets.com/v1/images/style/properties/cc4f2b8a0e217f2a9d73b30d822445e4_images.jpg", 54.0m, "Playboy Men Casual Red Slippers", "Flip Flops", "Casual" },
                    { 11912, 2, "Maroon", "Men", "11912.jpg", "http://assets.myntassets.com/v1/images/style/properties/e386e646f5472587a6b6044cde31a5bf_images.jpg", 69.5m, "Franco Leone Men Casual Maroon Sandals", "Sandals", "Casual" },
                    { 11913, 2, "Black", "Men", "11913.jpg", "http://assets.myntassets.com/v1/images/style/properties/0f2519ae8f147ea7406e11586c49a12b_images.jpg", 41.5m, "Franco Leone Men Casual Black Sandals", "Sandals", "Casual" },
                    { 11914, 2, "Black", "Men", "11914.jpg", "http://assets.myntassets.com/v1/images/style/properties/Franco-Leone-Men-Casual-Black-Sandals_64e305d58336526ca53af1df28ff7721_images.jpg", 24.0m, "Franco Leone Men Casual Black Sandals", "Sandals", "Casual" },
                    { 11915, 2, "Brown", "Men", "11915.jpg", "http://assets.myntassets.com/v1/images/style/properties/ff5f8a17b2ae517679a28ab5640c37de_images.jpg", 31.0m, "Franco Leone Men Casual Brown Sandals", "Sandals", "Casual" },
                    { 11922, 3, "Black", "Men", "11922.jpg", "http://assets.myntassets.com/v1/images/style/properties/262366467631b95873f546524b2444c9_images.jpg", 32.0m, "Franco Leone Men Formal Black Formal Shoes", "Formal Shoes", "Formal" },
                    { 11923, 3, "Brown", "Men", "11923.jpg", "http://assets.myntassets.com/v1/images/style/properties/9313abbf7f92dbb61e12acab6dd2ba39_images.jpg", 53.0m, "Franco Leone Men Formal Brown Formal Shoes", "Formal Shoes", "Formal" },
                    { 11924, 3, "Black", "Men", "11924.jpg", "http://assets.myntassets.com/v1/images/style/properties/Franco-Leone-Men-Black-Formal-Shoes_40042cda26f16556442dbb10af3e07ee_images.jpg", 79.0m, "Franco Leone Men Black Formal Shoes", "Formal Shoes", "Formal" },
                    { 11940, 2, "Black", "Men", "11940.jpg", "http://assets.myntassets.com/v1/images/style/properties/b23f1e70aec0102c360fb9dfdc476023_images.jpg", 40.5m, "Ganuchi Men Casual Black Sandals", "Sandals", "Casual" },
                    { 11941, 2, "Tan", "Men", "11941.jpg", "http://assets.myntassets.com/v1/images/style/properties/a595f061ad81d715cccb4cf4d6a5fe9d_images.jpg", 37.5m, "Ganuchi Men Casual Tan Sandals", "Sandals", "Casual" },
                    { 11946, 2, "Brown", "Men", "11946.jpg", "http://assets.myntassets.com/v1/images/style/properties/ecd25a12d12fee2264083bec8b7ed930_images.jpg", 72.5m, "Ganuchi Men Casual Brown Sandals", "Sandals", "Casual" },
                    { 11947, 2, "Olive", "Men", "11947.jpg", "http://assets.myntassets.com/v1/images/style/properties/464879391de4e1a7b881dad3b7bd83a8_images.jpg", 60.5m, "Ganuchi Men Casual Olive Sandals", "Sandals", "Casual" },
                    { 11948, 3, "Black", "Men", "11948.jpg", "http://assets.myntassets.com/v1/images/style/properties/3622942da5d2451489f5d16f4136b1c3_images.jpg", 44.0m, "Ganuchi Men Casual Black Casual Shoes", "Casual Shoes", "Casual" },
                    { 11949, 3, "Brown", "Men", "11949.jpg", "http://assets.myntassets.com/v1/images/style/properties/45da55174d251a833af58e1aa162052d_images.jpg", 48.5m, "Ganuchi Men Casual Brown Casual Shoes", "Casual Shoes", "Casual" },
                    { 11971, 3, "White", "Men", "11971.jpg", "http://assets.myntassets.com/v1/images/style/properties/ab1fe16c66350052ecb0ade9502ebcca_images.jpg", 79.0m, "Fila Men Glow White Sports Shoes", "Sports Shoes", "Sports" },
                    { 11976, 3, "Black", "Men", "11976.jpg", "http://assets.myntassets.com/v1/images/style/properties/f082906efcf97934d09f2bdd2906909b_images.jpg", 43.0m, "Fila Men Paramount Plus Black Shoes", "Casual Shoes", "Casual" },
                    { 11977, 2, "Olive", "Men", "11977.jpg", "http://assets.myntassets.com/v1/images/style/properties/8b227dec8c5f1b552970fd055c46b0ea_images.jpg", 51.0m, "Fila Men Motor Sports Olive Sandals", "Sandals", "Casual" },
                    { 11978, 2, "Navy Blue", "Men", "11978.jpg", "http://assets.myntassets.com/v1/images/style/properties/5c439c0c29672ff85b3aaafb66a43ae8_images.jpg", 73.5m, "FILA Men Aruba Navy Blue Sandal", "Sandals", "Casual" },
                    { 11979, 3, "Black", "Men", "11979.jpg", "http://assets.myntassets.com/v1/images/style/properties/f7f6a5fb69c690023ef5fc3c5c3c39be_images.jpg", 57.0m, "Fila Men Glam Black Casual Shoes", "Casual Shoes", "Casual" },
                    { 11983, 3, "Black", "Men", "11983.jpg", "http://assets.myntassets.com/v1/images/style/properties/a018ed2ebe20c7f8628dada209e42057_images.jpg", 23.5m, "FILA Men Dls Circuit 2 Black Sports Shoes", "Sports Shoes", "Sports" },
                    { 11985, 3, "Black", "Men", "11985.jpg", "http://assets.myntassets.com/v1/images/style/properties/4bfce78151c396213aa4ce1ad204468b_images.jpg", 78.5m, "Fila Men Glow Black Sports Shoes", "Sports Shoes", "Sports" },
                    { 12506, 3, "Brown", "Men", "12506.jpg", "http://assets.myntassets.com/v1/images/style/properties/79b4ee762c04f387ec9a310537adb0ca_images.jpg", 71.5m, "Red Tape Men Brown Shoes", "Casual Shoes", "Casual" },
                    { 12507, 3, "Black", "Men", "12507.jpg", "http://assets.myntassets.com/v1/images/style/properties/b1ff46e8d902c8cf2eb2664e792014a6_images.jpg", 37.0m, "Red Tape Men Casual Black Casual Shoes", "Casual Shoes", "Casual" },
                    { 12508, 3, "Brown", "Men", "12508.jpg", "http://assets.myntassets.com/v1/images/style/properties/cce72430a64274adfa887e387340ce79_images.jpg", 58.0m, "Red Tape Men Casual Brown Casual Shoes", "Casual Shoes", "Casual" },
                    { 12509, 3, "Brown", "Men", "12509.jpg", "http://assets.myntassets.com/v1/images/style/properties/7f5bf1bfc926e96373823989b1c4f420_images.jpg", 66.0m, "Red Tape Men Casual Brown Casual Shoes", "Casual Shoes", "Casual" },
                    { 12704, 3, "Grey", "Men", "12704.jpg", "http://assets.myntassets.com/v1/images/style/properties/eaf8f7339bfa5a6a5375491df92fcba4_images.jpg", 36.0m, "Nike Men Air Relentness Grey Sports Shoes", "Sports Shoes", "Sports" },
                    { 12705, 3, "White", "Men", "12705.jpg", "http://assets.myntassets.com/v1/images/style/properties/88bcb1e302eacafdfe101b3faa625659_images.jpg", 55.0m, "Nike Men Air Courtballistic White Sports Shoes", "Sports Shoes", "Sports" },
                    { 12876, 3, "Black", "Men", "12876.jpg", "http://assets.myntassets.com/v1/images/style/properties/b0627182f0915e431cc6112a15a20407_images.jpg", 44.0m, "Provogue Men Formal Black Formal Shoes", "Formal Shoes", "Formal" },
                    { 12882, 3, "White", "Men", "12882.jpg", "http://assets.myntassets.com/v1/images/style/properties/ebbd9af5051149569869daa74ab478cd_images.jpg", 63.0m, "Fila Men Sports White Shoes", "Sports Shoes", "Sports" },
                    { 12885, 3, "White", "Men", "12885.jpg", "http://assets.myntassets.com/v1/images/style/properties/49ddb7b67b306fd7212e8901412875d0_images.jpg", 50.0m, "Nike Men Air Max Turbulence White Sports Shoes", "Sports Shoes", "Sports" },
                    { 12903, 3, "Green", "Men", "12903.jpg", "http://assets.myntassets.com/v1/images/style/properties/50e188bd4635f2c26717e40fb34f2e1d_images.jpg", 21.5m, "Puma Men Whirlwind Classic Green Casual Shoes", "Casual Shoes", "Casual" },
                    { 12904, 3, "Red", "Men", "12904.jpg", "http://assets.myntassets.com/v1/images/style/properties/327593510d3b633066ceacf188df73ba_images.jpg", 39.5m, "Puma Men Future Cat M1 Engine Red Sports Shoes", "Sports Shoes", "Sports" },
                    { 12956, 3, "Blue", "Men", "12956.jpg", "http://assets.myntassets.com/v1/images/style/properties/3a9f62b28cc78e42ffc030e179f8a438_images.jpg", 38.0m, "ADIDAS Men Sports Blue Sports Shoes", "Sports Shoes", "Sports" },
                    { 12957, 3, "Grey", "Men", "12957.jpg", "http://assets.myntassets.com/v1/images/style/properties/285f77d54aa639885c93fbb6e886824b_images.jpg", 30.0m, "ADIDAS Men Grey Sports Shoes", "Sports Shoes", "Sports" },
                    { 12958, 3, "Black", "Men", "12958.jpg", "http://assets.myntassets.com/v1/images/style/properties/9c0d1badace8d2eb9680232648e94d85_images.jpg", 73.5m, "ADIDAS Men Sports Black Sports Shoes", "Sports Shoes", "Sports" },
                    { 12959, 3, "Black", "Men", "12959.jpg", "http://assets.myntassets.com/v1/images/style/properties/b09d86bef23eccef029df70930c162b8_images.jpg", 34.5m, "ADIDAS Men Sports Black Sports Shoes", "Sports Shoes", "Sports" },
                    { 12960, 3, "White", "Men", "12960.jpg", "http://assets.myntassets.com/v1/images/style/properties/81780f9a8eebc7fb3d57ffffa7f455ae_images.jpg", 55.0m, "ADIDAS Men Sports White Sports Shoes", "Sports Shoes", "Sports" },
                    { 12961, 2, "Brown", "Men", "12961.jpg", "http://assets.myntassets.com/v1/images/style/properties/cd86abdee8834de4aa0447b73cdcdd0c_images.jpg", 32.0m, "ADIDAS Men Casual Brown Sandals", "Sandals", "Casual" },
                    { 12966, 3, "Grey", "Men", "12966.jpg", "http://assets.myntassets.com/v1/images/style/properties/00aa23eeb6dfa9fa2f77ab5d01e04e8f_images.jpg", 46.5m, "ADIDAS Men Snova Glide Grey Sports Shoes", "Sports Shoes", "Sports" },
                    { 12967, 2, "Black", "Men", "12967.jpg", "http://assets.myntassets.com/v1/images/style/properties/c5a22e9ccf9b10e0a89ffbbf3e386584_images.jpg", 50.0m, "ADIDAS Men Spry M Black Sandals", "Sandals", "Casual" },
                    { 12968, 3, "White", "Men", "12968.jpg", "http://assets.myntassets.com/v1/images/style/properties/2a3a255932bd37e5bfc6799552e12527_images.jpg", 78.5m, "ADIDAS Men Allegra White Sports Shoes", "Sports Shoes", "Sports" },
                    { 12969, 3, "Blue", "Men", "12969.jpg", "http://assets.myntassets.com/v1/images/style/properties/af829e3d805b3f99f3905431c425796d_images.jpg", 25.0m, "ADIDAS Men Snova Glide Blue Sports Shoes", "Sports Shoes", "Sports" },
                    { 13072, 3, "Black", "Men", "13072.jpg", "http://assets.myntassets.com/v1/images/style/properties/2fc766a7415035d5855a236326c01366_images.jpg", 30.5m, "Numero Uno Men Black Casual Shoes", "Casual Shoes", "Casual" },
                    { 13073, 3, "White", "Men", "13073.jpg", "http://assets.myntassets.com/v1/images/style/properties/26e93a4246e479e84c16a0ae547d2158_images.jpg", 53.0m, "Numero Uno Men White Shoes", "Casual Shoes", "Casual" },
                    { 13074, 3, "Brown", "Men", "13074.jpg", "http://assets.myntassets.com/v1/images/style/properties/5dfbb2e1085e06bed0b0685f4deeb0a8_images.jpg", 25.5m, "Numero Uno Men Brown Casual Shoes", "Casual Shoes", "Casual" },
                    { 13075, 3, "Black", "Men", "13075.jpg", "http://assets.myntassets.com/v1/images/style/properties/d5e6350d1e72ff1e01b0d1bf9fe98ce8_images.jpg", 29.0m, "Numero Uno Men Black Shoes", "Casual Shoes", "Casual" },
                    { 13080, 3, "Black", "Men", "13080.jpg", "http://assets.myntassets.com/v1/images/style/properties/efef30c05460e90a1e170998dde8f92c_images.jpg", 50.0m, "Numero Uno Men Black Casual Shoes", "Casual Shoes", "Casual" },
                    { 13081, 3, "White", "Men", "13081.jpg", "http://assets.myntassets.com/v1/images/style/properties/f9e12ae63f9217cb691f9c22cf8ac05a_images.jpg", 73.5m, "Numero Uno Men White Casual Shoes", "Casual Shoes", "Casual" },
                    { 13198, 3, "Blue", "Men", "13198.jpg", "http://assets.myntassets.com/v1/images/style/properties/b8053f95ed69df40a632dccac74da643_images.jpg", 63.0m, "ASICS Men Gel DS Sky Speed 2 Running Blue Sports Shoes", "Sports Shoes", "Sports" },
                    { 13214, 3, "White", "Men", "13214.jpg", "http://assets.myntassets.com/v1/images/style/properties/f19436ed7b41f8ee107c2ff56e1cdf13_images.jpg", 23.5m, "ASICS Men Gel 1160 Running White Sports Shoes", "Sports Shoes", "Sports" },
                    { 13215, 3, "Grey", "Men", "13215.jpg", "http://assets.myntassets.com/v1/images/style/properties/54438127ac612583a256b3afcc527d25_images.jpg", 37.0m, "ASICS Men Gel Enduro 7 Running Silver Sports Shoes", "Sports Shoes", "Sports" },
                    { 13359, 3, "Beige", "Men", "13359.jpg", "http://assets.myntassets.com/v1/images/style/properties/c2be49db2edd27cb2b90b834d6531b47_images.jpg", 69.0m, "Timberland Men Juniors Beige Casual Shoes", "Casual Shoes", "Casual" },
                    { 13537, 3, "Brown", "Men", "13537.jpg", "http://assets.myntassets.com/v1/images/style/properties/685dba93fae4bdbde52dfb398e94955c_images.jpg", 27.5m, "Carlton London Men Casual Brown Casual Shoes", "Casual Shoes", "Casual" },
                    { 13646, 3, "Beige", "Men", "13646.jpg", "http://assets.myntassets.com/v1/images/style/properties/ef805ca141a1d056e0363596a2faeec0_images.jpg", 22.5m, "Carlton London Men Casual Beige Casual Shoes", "Casual Shoes", "Casual" },
                    { 13648, 3, "Silver", "Men", "13648.jpg", "http://assets.myntassets.com/v1/images/style/properties/4fcd6ca0e951bce32c8826788ddaebfe_images.jpg", 55.5m, "ADIDAS Silver Astar ride 3M Sports Shoe", "Sports Shoes", "Sports" },
                    { 13649, 3, "Black", "Men", "13649.jpg", "http://assets.myntassets.com/v1/images/style/properties/3053dc9877f1fd1209cfc4ee1b5e9171_images.jpg", 22.5m, "ADIDAS Black Hydroterra Shandal Casual Shoes", "Casual Shoes", "Casual" },
                    { 13676, 3, "Silver", "Men", "13676.jpg", "http://assets.myntassets.com/v1/images/style/properties/b14c8811b942eeb3756ab0a66af54f47_images.jpg", 28.5m, "ADIDAS Men Titan Sports Shoes", "Sports Shoes", "Sports" },
                    { 13677, 3, "White", "Men", "13677.jpg", "http://assets.myntassets.com/v1/images/style/properties/f2a2bdafbb219d1dedaaed75c20853f6_images.jpg", 76.0m, "ADIDAS Men Running White Sports Shoes", "Sports Shoes", "Sports" },
                    { 13679, 3, "White", "Men", "13679.jpg", "http://assets.myntassets.com/v1/images/style/properties/d75102040c965cd59488b69007f766fe_images.jpg", 75.5m, "ADIDAS Men Court Switch Sports Shoes", "Sports Shoes", "Sports" },
                    { 13683, 3, "Blue", "Men", "13683.jpg", "http://assets.myntassets.com/v1/images/style/properties/8c673b0b5c89552c15b72b3c3ae407da_images.jpg", 20.5m, "ADIDAS Men Adi Quest Blue Sports Shoes", "Sports Shoes", "Sports" },
                    { 13684, 3, "Black", "Men", "13684.jpg", "http://assets.myntassets.com/v1/images/style/properties/ab8ada0e4956967c0ad91217175ef162_images.jpg", 72.5m, "ADIDAS Men Dash Casual Shoes", "Casual Shoes", "Casual" },
                    { 13685, 3, "Black", "Men", "13685.jpg", "http://assets.myntassets.com/v1/images/style/properties/1a7a0ee63554920e1445cb3e7431f7d7_images.jpg", 22.0m, "ADIDAS Men Dash Casual Shoes", "Casual Shoes", "Casual" },
                    { 14490, 3, "Grey", "Men", "14490.jpg", "http://assets.myntassets.com/v1/images/style/properties/965790109837039bd54cc16fe885ce9e_images.jpg", 27.5m, "Flying Machine Men Casual Grey Casual Shoes", "Casual Shoes", "Casual" },
                    { 14491, 3, "Black", "Men", "14491.jpg", "http://assets.myntassets.com/v1/images/style/properties/a0743752a7eca3ee0cf69e312a52c4d6_images.jpg", 75.5m, "Flying Machine Men Casual Black Casual Shoes", "Casual Shoes", "Casual" },
                    { 14496, 3, "Grey", "Men", "14496.jpg", "http://assets.myntassets.com/v1/images/style/properties/e049a003fb6a4def8cce97f6ff7e0cc7_images.jpg", 48.5m, "Flying Machine Men Casual Grey Casual Shoes", "Casual Shoes", "Casual" },
                    { 14497, 3, "Green", "Men", "14497.jpg", "http://assets.myntassets.com/v1/images/style/properties/f50c7bc8ea0a995334e9b01d81b45c31_images.jpg", 37.0m, "Flying Machine Men Casual Green Casual Shoes", "Casual Shoes", "Casual" },
                    { 14498, 3, "Black", "Men", "14498.jpg", "http://assets.myntassets.com/v1/images/style/properties/dd4df7d68ef98ab9ebc1ce6d20cbe6b5_images.jpg", 61.0m, "Flying Machine Men Casual Black Casual Shoes", "Casual Shoes", "Casual" },
                    { 14499, 3, "Green", "Men", "14499.jpg", "http://assets.myntassets.com/v1/images/style/properties/405ef20c472619ca9fb6091fb0b97cef_images.jpg", 64.0m, "Flying Machine Men Casual Green Casual Shoes", "Casual Shoes", "Casual" },
                    { 15062, 2, "Brown", "Men", "15062.jpg", "http://assets.myntassets.com/v1/images/style/properties/c748416626eff308712f1aafb439c38d_images.jpg", 23.5m, "Franco Leone Men Brown Sandal", "Sandals", "Casual" },
                    { 15250, 3, "Red", "Men", "15250.jpg", "http://assets.myntassets.com/v1/images/style/properties/0b56b31d1dcb7f9c744080e12d3e0b56_images.jpg", 44.0m, "ADIDAS Originals Men SL 72 Red Casual Shoes", "Casual Shoes", "Casual" },
                    { 15313, 3, "White", "Men", "15313.jpg", "http://assets.myntassets.com/v1/images/style/properties/a5aa3ac937eacec2155ead8ad9c751b6_images.jpg", 60.5m, "ADIDAS Men Aerostar White Sports Shoes", "Sports Shoes", "Sports" },
                    { 15314, 3, "White", "Men", "15314.jpg", "http://assets.myntassets.com/v1/images/style/properties/6c9cf98f7b982edd225753d9cd2d4cd0_images.jpg", 35.0m, "ADIDAS Men Ranger White Sports Shoes", "Sports Shoes", "Sports" },
                    { 15315, 3, "Black", "Men", "15315.jpg", "http://assets.myntassets.com/v1/images/style/properties/647fa9a687c2975ac72e2071b48f627f_images.jpg", 32.0m, "ADIDAS Men Eqt Nitro Fashion Black Sports Shoes", "Sports Shoes", "Sports" },
                    { 15376, 3, "White", "Men", "15376.jpg", "http://assets.myntassets.com/v1/images/style/properties/429d08e06191b69741200ba1d5c32b1d_images.jpg", 77.5m, "FILA Men Fila Boston White Sports Shoes", "Sports Shoes", "Sports" },
                    { 15377, 3, "Navy Blue", "Men", "15377.jpg", "http://assets.myntassets.com/v1/images/style/properties/558836465cadc3972bd8577ac43ccc24_images.jpg", 44.5m, "Fila Men Lobato Navy Blue Casual Shoes", "Casual Shoes", "Casual" },
                    { 15378, 3, "Grey", "Men", "15378.jpg", "http://assets.myntassets.com/v1/images/style/properties/2b6a95deedb1c844304a7f948250af68_images.jpg", 28.5m, "Fila Men Coloda Grey Sports Shoes", "Sports Shoes", "Sports" },
                    { 15379, 3, "Black", "Men", "15379.jpg", "http://assets.myntassets.com/v1/images/style/properties/593368a3e9649a12de803e50fa2ed17a_images.jpg", 53.0m, "Fila Men Lobato Black Casual Shoes", "Casual Shoes", "Casual" },
                    { 15382, 1, "Navy Blue", "Men", "15382.jpg", "http://assets.myntassets.com/v1/images/style/properties/9d16956167f078c3a4b09328fab65b2e_images.jpg", 33.5m, "Fila Men Terra Navy Blue Slippers", "Flip Flops", "Casual" },
                    { 15384, 1, "Black", "Men", "15384.jpg", "http://assets.myntassets.com/v1/images/style/properties/16166d165fed7105e5d1ac7c060703c7_images.jpg", 32.5m, "Filac Men Hawai Black Slippers", "Flip Flops", "Casual" },
                    { 15385, 1, "Blue", "Men", "15385.jpg", "http://assets.myntassets.com/v1/images/style/properties/FILA-Men-Flip-Flops_14793950c89a306fd27bbff93f7b7fcc_images.jpg", 25.5m, "Fila Men Hawai Blue Flip Flops", "Flip Flops", "Casual" },
                    { 15406, 3, "White", "Men", "15406.jpg", "http://assets.myntassets.com/v1/images/style/properties/ca4070668cac17859b445c434bcb512b_images.jpg", 50.5m, "FILA Men FILA Boston White Sports Shoes", "Sports Shoes", "Sports" },
                    { 15510, 3, "Charcoal", "Men", "15510.jpg", "http://assets.myntassets.com/v1/images/style/properties/659ca18f067f9fb78cc7824eaf1d165e_images.jpg", 30.5m, "Rockport Men CV Toe HI Charcoal Casual Shoes", "Casual Shoes", "Casual" },
                    { 15516, 1, "Navy Blue", "Men", "15516.jpg", "http://assets.myntassets.com/v1/images/style/properties/8e61745c35f663f59c82e7e68ae30c23_images.jpg", 22.0m, "Rockport Men Altrezlp Navy Blue Flip Flops", "Flip Flops", "Casual" },
                    { 15517, 3, "Red", "Men", "15517.jpg", "http://assets.myntassets.com/v1/images/style/properties/0ea0e6130d5d4c093e0e516f9b43ced6_images.jpg", 52.0m, "Rockport Men LLandro Red Casual Shoes", "Casual Shoes", "Casual" },
                    { 15518, 3, "Grey", "Men", "15518.jpg", "http://assets.myntassets.com/v1/images/style/properties/44f874fe55936fec7c0fe8679d435344_images.jpg", 65.0m, "Rockport Men Slatkin Grey Casual Shoes", "Casual Shoes", "Casual" },
                    { 15519, 1, "Brown", "Men", "15519.jpg", "http://assets.myntassets.com/v1/images/style/properties/1d16b7a631810087d206ebcc2af4bcea_images.jpg", 23.0m, "Rockport Men Jelba Brown Flip Flops", "Flip Flops", "Casual" },
                    { 15520, 3, "Black", "Men", "15520.jpg", "http://assets.myntassets.com/v1/images/style/properties/a5f34ba3e351e71badbf97de3ae80c15_images.jpg", 40.0m, "Rockport Men CV Wing Black Casual Shoes", "Casual Shoes", "Casual" },
                    { 15521, 1, "Black", "Men", "15521.jpg", "http://assets.myntassets.com/v1/images/style/properties/717a23d80631d14e60bbc954b06c5fb6_images.jpg", 74.0m, "Rockport Men Jelbalp Black Flip Flops", "Flip Flops", "Casual" },
                    { 15713, 3, "Black", "Men", "15713.jpg", "http://assets.myntassets.com/v1/images/style/properties/aea04a305c1e279cec06172c669a5751_images.jpg", 38.0m, "Nike Men Air Relentless Black Sports Shoes", "Sports Shoes", "Sports" },
                    { 15714, 3, "Black", "Men", "15714.jpg", "http://assets.myntassets.com/v1/images/style/properties/45e5d30d4486c3569cb89dab80ed0c66_images.jpg", 27.0m, "Nike Men Free Run+ 2 Black Sports Shoes", "Sports Shoes", "Sports" },
                    { 15722, 3, "Grey", "Men", "15722.jpg", "http://assets.myntassets.com/v1/images/style/properties/9854a566783e31b6172f1deab77281fa_images.jpg", 24.5m, "Nike Men Lunarswift+ 3 Shield Grey Sports Shoes", "Sports Shoes", "Sports" },
                    { 15724, 3, "Grey", "Men", "15724.jpg", "http://assets.myntassets.com/v1/images/style/properties/c958b7cb77f51aff23530d749ad5779a_images.jpg", 62.5m, "Nike Men Free Run+ 2 Shield Grey Sports Shoes", "Sports Shoes", "Sports" },
                    { 15741, 3, "Grey", "Men", "15741.jpg", "http://assets.myntassets.com/v1/images/style/properties/27203442d215ad27a061c5d9c9f6f5fc_images.jpg", 59.0m, "Nike Men Lunarglide + Shield Grey Sports Shoes", "Sports Shoes", "Sports" },
                    { 15746, 3, "White", "Men", "15746.jpg", "http://assets.myntassets.com/v1/images/style/properties/Nike-Men-Ballista-II-White-Sports-Shoes_ea630bb8469a4100c6c62305bdc06174_images.jpg", 32.0m, "Nike Men Ballista II White Sports Shoes", "Sports Shoes", "Sports" },
                    { 15747, 3, "White", "Men", "15747.jpg", "http://assets.myntassets.com/v1/images/style/properties/b57c1eac50336bc23d33e86b454927e6_images.jpg", 76.5m, "Nike Men Ballista SL White Sports Shoes", "Sports Shoes", "Sports" },
                    { 16152, 3, "Brown", "Men", "16152.jpg", "http://assets.myntassets.com/v1/images/style/properties/2ba5a829cc364c32b327839a47f43e8e_images.jpg", 44.5m, "Enroute Men Leather Brown Formal Shoes", "Formal Shoes", "Formal" },
                    { 16153, 3, "Black", "Men", "16153.jpg", "http://assets.myntassets.com/v1/images/style/properties/c80c08ee91ff76e9ef5f3ec53fc6b6a7_images.jpg", 73.5m, "Enroute Men Leather Black Formal Shoes", "Formal Shoes", "Formal" },
                    { 16154, 3, "Black", "Men", "16154.jpg", "http://assets.myntassets.com/v1/images/style/properties/1e1ddab59626e99f7163c2c8c20743b6_images.jpg", 30.5m, "Enroute Men Leather Black Formal Shoes", "Formal Shoes", "Formal" },
                    { 16155, 3, "Brown", "Men", "16155.jpg", "http://assets.myntassets.com/v1/images/style/properties/0bfd0d3daf35ed10a922ec248548470f_images.jpg", 76.5m, "Enroute Men Leather Brown Formal Shoes", "Formal Shoes", "Formal" },
                    { 16162, 2, "Black", "Men", "16162.jpg", "http://assets.myntassets.com/v1/images/style/properties/2aad2e1edb9ea3e6c318df98205f574b_images.jpg", 77.5m, "Enroute Men Leather Black Sandals", "Sandals", "Casual" },
                    { 16163, 3, "Tan", "Men", "16163.jpg", "http://assets.myntassets.com/v1/images/style/properties/f68b67a4d85b376e096423f7f68e2749_images.jpg", 52.5m, "Enroute Men Leather Tan Formal Shoes", "Formal Shoes", "Formal" },
                    { 16164, 2, "Brown", "Men", "16164.jpg", "http://assets.myntassets.com/v1/images/style/properties/58562d18360239a4ccfdef289cecffc6_images.jpg", 54.0m, "Enroute Men Leather Brown Sandals", "Sandals", "Casual" },
                    { 16165, 3, "Tan", "Men", "16165.jpg", "http://assets.myntassets.com/v1/images/style/properties/b3ead7db8f3572f146a7d807742b9f43_images.jpg", 42.5m, "Enroute Men Leather Brown Casual Shoes", "Casual Shoes", "Casual" },
                    { 16732, 1, "Brown", "Men", "16732.jpg", "http://assets.myntassets.com/v1/images/style/properties/c9858c6e801580d97e523d2b1203b47c_images.jpg", 42.5m, "Lotto Men Earth Brown Slipper", "Flip Flops", "Casual" },
                    { 16733, 1, "Black", "Men", "16733.jpg", "http://assets.myntassets.com/v1/images/style/properties/c409e1086cf84af1e6f56d7899e762f8_images.jpg", 71.5m, "Lotto Men Earth Black Slipper", "Flip Flops", "Casual" },
                    { 16734, 1, "Maroon", "Men", "16734.jpg", "http://assets.myntassets.com/v1/images/style/properties/7600f1237827bb23131b59a0c8b9a7bc_images.jpg", 35.5m, "Lotto Men Emeriti Maroon Slipper", "Flip Flops", "Casual" },
                    { 16735, 1, "Black", "Men", "16735.jpg", "http://assets.myntassets.com/v1/images/style/properties/20e7d75f6cef1689d6874a14a9db0933_images.jpg", 38.5m, "Lotto Men Emeriti Black Slipper", "Flip Flops", "Casual" },
                    { 16966, 3, "Black", "Men", "16966.jpg", "http://assets.myntassets.com/v1/images/style/properties/b4a93449c1fd4666bf2572c3d8d9763d_images.jpg", 71.0m, "Reebok Men Sprintfit Lite Black Sports Shoe", "Sports Shoes", "Sports" },
                    { 16969, 2, "Black", "Men", "16969.jpg", "http://assets.myntassets.com/v1/images/style/properties/efca982ea19c2521dda37ed9fb603799_images.jpg", 79.5m, "Puma Men Coupe Black Sandal", "Sandals", "Casual" },
                    { 17026, 1, "Blue", "Men", "17026.jpg", "http://assets.myntassets.com/v1/images/style/properties/1d6742e11f1176b43883efc4cd27ceca_images.jpg", 67.0m, "Gas Men Beach Flip Flops", "Flip Flops", "Casual" },
                    { 17027, 1, "Navy Blue", "Men", "17027.jpg", "http://assets.myntassets.com/v1/images/style/properties/1ce6f219f00dc784baf7715efa0ca189_images.jpg", 57.0m, "Gas Men Navy Blue Flip Flops", "Flip Flops", "Casual" },
                    { 17028, 1, "Grey", "Men", "17028.jpg", "http://assets.myntassets.com/v1/images/style/properties/GAS-Men-Grey-Pine-Flip-Flops_5dac07de3758240986c732d060087771_images.jpg", 78.5m, "GAS Men Grey Pine Flip Flops", "Flip Flops", "Casual" },
                    { 17029, 1, "Black", "Men", "17029.jpg", "http://assets.myntassets.com/v1/images/style/properties/GAS-Men-Black-Pine-Flip-Flops_f6fcae18401c1c1fb8ab5b29c76d0781_images.jpg", 69.5m, "GAS Men Black Pine Flip Flops", "Flip Flops", "Casual" },
                    { 17042, 3, "Grey", "Men", "17042.jpg", "http://assets.myntassets.com/v1/images/style/properties/Gas-Men-White---Grey-Shoes_c9ac34e9a949fe81422026dfc24cebdf_images.jpg", 65.5m, "GAS Men Grey Skate 002 Shoes", "Sports Shoes", "Sports" },
                    { 17043, 3, "Black", "Men", "17043.jpg", "http://assets.myntassets.com/v1/images/style/properties/525f30ac2bcf55f1da135dcc70a1c296_images.jpg", 77.5m, "Gas Men Skate 003 Casual Shoe", "Casual Shoes", "Casual" },
                    { 17044, 2, "Brown", "Men", "17044.jpg", "http://assets.myntassets.com/v1/images/style/properties/8903d2863587633e97148734df907ef4_images.jpg", 59.5m, "Gas Men Aventura Sandal", "Sandals", "Casual" },
                    { 17045, 2, "Brown", "Men", "17045.jpg", "http://assets.myntassets.com/v1/images/style/properties/423467d4533370ea6d8ad7317f09cb9f_images.jpg", 40.5m, "Gas Men Aventura Sandal", "Sandals", "Casual" },
                    { 17410, 3, "White", "Men", "17410.jpg", "http://assets.myntassets.com/v1/images/style/properties/082147936cb571867ca64b0d078f659d_images.jpg", 60.5m, "Lotto Men Atlantica White Sports Shoe", "Sports Shoes", "Sports" },
                    { 17411, 3, "White", "Men", "17411.jpg", "http://assets.myntassets.com/v1/images/style/properties/95dd8b87ceff0247a70579ba850c0164_images.jpg", 25.0m, "Lotto Men Basketball Mid White Sports Shoe", "Sports Shoes", "Sports" },
                    { 17416, 3, "Black", "Men", "17416.jpg", "http://assets.myntassets.com/v1/images/style/properties/1279efc8b61fb461a804f0c1f82f276b_images.jpg", 70.5m, "Lotto Men Atlantica Black Sports Shoe", "Sports Shoes", "Sports" },
                    { 17481, 3, "Black", "Men", "17481.jpg", "http://assets.myntassets.com/v1/images/style/properties/6ddbf82251463a258a89eda4a7c411d6_images.jpg", 30.0m, "Enroute Men Formal Black Formal Shoe", "Formal Shoes", "Formal" },
                    { 17647, 1, "Red", "Men", "17647.jpg", "http://assets.myntassets.com/v1/images/style/properties/Converse-Men-Red-Flip-Flops_e522f6682fc67dad7ee54eee72f94dcc_images.jpg", 73.0m, "Converse Men Red Flip Flops", "Flip Flops", "Casual" },
                    { 17813, 3, "Brown", "Men", "17813.jpg", "http://assets.myntassets.com/v1/images/style/properties/489abfd6cc785c67b99041f7217d33c9_images.jpg", 69.0m, "Lee Cooper Men  Brown Casual Shoe", "Casual Shoes", "Casual" },
                    { 17814, 3, "Black", "Men", "17814.jpg", "http://assets.myntassets.com/v1/images/style/properties/66378e03115ef568fb9c485f5314738f_images.jpg", 35.0m, "Lee Cooper Men  Black Casual Shoe", "Casual Shoes", "Casual" },
                    { 17815, 2, "Black", "Men", "17815.jpg", "http://assets.myntassets.com/v1/images/style/properties/b0303cf0af683b9e314c2046d9b29325_images.jpg", 53.0m, "Lee Cooper Men  Black Sandal", "Sandals", "Casual" },
                    { 17822, 3, "Black", "Men", "17822.jpg", "http://assets.myntassets.com/v1/images/style/properties/a1c9a53125108ea6f659900cfdfe47c5_images.jpg", 63.5m, "Lee Cooper Men  Black Formal Shoe", "Formal Shoes", "Formal" },
                    { 17823, 3, "White", "Men", "17823.jpg", "http://assets.myntassets.com/v1/images/style/properties/36886df8953c40042cc2e47b380dad55_images.jpg", 45.0m, "Nike Men  Court Majestic White Casual Shoe", "Casual Shoes", "Casual" },
                    { 17840, 3, "Red", "Men", "17840.jpg", "http://assets.myntassets.com/v1/images/style/properties/c481346a8ed1ce44ec54b459af7de08a_images.jpg", 50.0m, "Nike Men Air Quick Handle Red Sports Shoe", "Sports Shoes", "Sports" },
                    { 17846, 3, "Black", "Men", "17846.jpg", "http://assets.myntassets.com/v1/images/style/properties/897336e710167034f7e9066114bbb79c_images.jpg", 75.5m, "Nike Men Supergame Black Sports Shoe", "Sports Shoes", "Sports" },
                    { 17847, 3, "White", "Men", "17847.jpg", "http://assets.myntassets.com/v1/images/style/properties/d30175afac8812e0b52c4fb7cc8aa0ee_images.jpg", 34.5m, "Nike Men Air Impetus II White Sports Shoe", "Sports Shoes", "Sports" },
                    { 17960, 2, "Black", "Men", "17960.jpg", "http://assets.myntassets.com/v1/images/style/properties/ef372f03e1ba9c6d634b4b1ee17c7cc7_images.jpg", 62.5m, "Puma Men Hopper Black Sandal", "Sandals", "Casual" },
                    { 18402, 3, "Black", "Men", "18402.jpg", "http://assets.myntassets.com/v1/images/style/properties/865391bfae0dcdf364ce8c996804f2e8_images.jpg", 74.5m, "Skechers Men USA Black Shoe", "Casual Shoes", "Casual" },
                    { 18403, 3, "Black", "Men", "18403.jpg", "http://assets.myntassets.com/v1/images/style/properties/87cd7b092091609ac02f152cb50960f2_images.jpg", 29.0m, "Skechers Men Tone-Ups Black Shoe", "Casual Shoes", "Casual" },
                    { 18404, 3, "Brown", "Men", "18404.jpg", "http://assets.myntassets.com/v1/images/style/properties/d954c9d70790069ca29f9346d28c1a94_images.jpg", 67.5m, "Skechers Men USA Brown Shoe", "Casual Shoes", "Casual" },
                    { 18405, 3, "Brown", "Men", "18405.jpg", "http://assets.myntassets.com/v1/images/style/properties/0864f725df98a182b763bcc00eadecac_images.jpg", 52.5m, "Skechers Men USA Brown Shoe", "Casual Shoes", "Casual" },
                    { 18492, 1, "Blue", "Men", "18492.jpg", "http://assets.myntassets.com/v1/images/style/properties/b5df5f57f0feda7a42510b6ebedf4f4d_images.jpg", 37.0m, "Puma Men Danny Blue Slipper", "Flip Flops", "Casual" },
                    { 18493, 2, "Multi", "Men", "18493.jpg", "http://assets.myntassets.com/v1/images/style/properties/59adcc25bc20fb817f5917d74fed0aca_images.jpg", 25.5m, "Puma Men Duncan Multi Slipper", "Sandals", "Casual" },
                    { 18494, 3, "White", "Men", "18494.jpg", "http://assets.myntassets.com/v1/images/style/properties/cbd54b9ca8c62d49c2c2cb8152777864_images.jpg", 55.5m, "Puma Men Daemon White Sports Shoes", "Sports Shoes", "Sports" },
                    { 18495, 2, "White", "Men", "18495.jpg", "http://assets.myntassets.com/v1/images/style/properties/c78acc78b83e4f2e014215d2a302f04b_images.jpg", 44.5m, "Puma Men Fashion Cat White Slipper", "Sandals", "Casual" },
                    { 18601, 2, "Black", "Men", "18601.jpg", "http://assets.myntassets.com/v1/images/style/properties/b2fc74054083711f62b59120c0c0bddc_images.jpg", 79.5m, "Puma Men Black Roque Sandals", "Sandals", "Sports" },
                    { 18653, 1, "Black", "Men", "18653.jpg", "http://assets.myntassets.com/v1/images/style/properties/53690e3f396f411e184b249672d6ebae_images.jpg", 34.5m, "Fila Men Cush Flex Black Slippers", "Flip Flops", "Casual" },
                    { 18655, 1, "Black", "Men", "18655.jpg", "http://assets.myntassets.com/v1/images/style/properties/914b05f0e6f80353629d2eb59a0b2518_images.jpg", 61.5m, "Fila Men Drop Needle Black Slippers", "Flip Flops", "Casual" },
                    { 18665, 3, "White", "Men", "18665.jpg", "http://assets.myntassets.com/v1/images/style/properties/3f475a31c39bcc9c6045a9f8c7452893_images.jpg", 41.5m, "Fila Men Syncro White Shoes", "Casual Shoes", "Casual" },
                    { 19122, 1, "White", "Men", "19122.jpg", "http://assets.myntassets.com/v1/images/style/properties/15e0953c017540f7644199f7181db74f_images.jpg", 49.0m, "Lotto Men XL Water Man White Slippers", "Flip Flops", "Casual" },
                    { 19123, 1, "Silver", "Men", "19123.jpg", "http://assets.myntassets.com/v1/images/style/properties/69482728a521cbd2ba571e36016d5f63_images.jpg", 24.0m, "Lotto Men XL Water Man Silver Slippers", "Flip Flops", "Casual" },
                    { 19140, 2, "Black", "Men", "19140.jpg", "http://assets.myntassets.com/v1/images/style/properties/f28efdb857ae8608cc72b4165a991603_images.jpg", 62.0m, "Lotto Men Sting Black Sandals", "Sandals", "Casual" },
                    { 19141, 2, "Black", "Men", "19141.jpg", "http://assets.myntassets.com/v1/images/style/properties/02ab0971bf0b184990ad0ebaf94a5bd7_images.jpg", 66.0m, "Lotto Men Revorb Black Sandals", "Sandals", "Casual" },
                    { 19310, 3, "White", "Men", "19310.jpg", "http://assets.myntassets.com/v1/images/style/properties/f9224900952588d6eb8c8dbd8bc6410e_images.jpg", 56.0m, "Nike Men Lunarglide+ 3 White Sports Shoe", "Sports Shoes", "Sports" },
                    { 19311, 3, "White", "Men", "19311.jpg", "http://assets.myntassets.com/v1/images/style/properties/ac5a2fb9462db16f4cf5fc0f3616a9e6_images.jpg", 78.5m, "Nike Men Air Rift MTR White Casual Shoe", "Casual Shoes", "Casual" },
                    { 19329, 3, "Brown", "Men", "19329.jpg", "http://assets.myntassets.com/v1/images/style/properties/bcb01252e8d12d743d85d0001586fee0_images.jpg", 44.0m, "Puma Men Standpunkt Brown Casual Shoes", "Casual Shoes", "Casual" },
                    { 19372, 3, "Brown", "Men", "19372.jpg", "http://assets.myntassets.com/v1/images/style/properties/Red-Tape-Men-Formal-Shoes_69d74d2aac6cc51c38bda7600f0a2d91_images.jpg", 65.5m, "Redtape Men Brown Formal Shoes", "Formal Shoes", "Formal" },
                    { 19387, 3, "Beige", "Men", "19387.jpg", "http://assets.myntassets.com/v1/images/style/properties/4667f5416339437dda1dc3510bb0a27d_images.jpg", 61.0m, "ADIDAS Men Dumont Beige Sports Shoes", "Sports Shoes", "Sports" },
                    { 19772, 3, "Blue", "Men", "19772.jpg", "http://assets.myntassets.com/v1/images/style/properties/4ce7d857814ce0fec13e120fe55522c9_images.jpg", 74.5m, "ADIDAS Men Vigor Blue Casual Shoes", "Casual Shoes", "Casual" },
                    { 19927, 2, "Grey", "Men", "19927.jpg", "http://assets.myntassets.com/v1/images/style/properties/3fa8e7f3bd3eeb217a8cb060d1db2567_images.jpg", 57.5m, "ADIDAS Men Receptor Grey Sandals", "Sandals", "Casual" },
                    { 19928, 1, "Yellow", "Men", "19928.jpg", "http://assets.myntassets.com/v1/images/style/properties/cb0b368d53b7883b638332bb28869881_images.jpg", 71.5m, "ADIDAS Men Adi Wind Yellow Flip Flops", "Flip Flops", "Casual" },
                    { 20695, 3, "Blue", "Men", "20695.jpg", "http://assets.myntassets.com/v1/images/style/properties/e6d5c6f61d04b842531936f3f73dc4e1_images.jpg", 26.0m, "Buckaroo Men Bello Blue Casual Shoes", "Casual Shoes", "Casual" },
                    { 20715, 3, "Black", "Men", "20715.jpg", "http://assets.myntassets.com/v1/images/style/properties/Red-Tape-Men-RTS---6151-BLK-Black-Casual-Shoes_75e89ac3afeed7405d895cf605be80d9_images.jpg", 68.5m, "Red Tape Men Black Leather Casual Shoes", "Casual Shoes", "Smart Casual" },
                    { 20802, 3, "White", "Men", "20802.jpg", "http://assets.myntassets.com/v1/images/style/properties/89f6d664a27c88ebf7d6fc3498875fb9_images.jpg", 22.0m, "Fila Men Racer White Sports Shoes", "Sports Shoes", "Sports" },
                    { 20804, 3, "White", "Men", "20804.jpg", "http://assets.myntassets.com/v1/images/style/properties/b1000636b5755c276de3462524b46e46_images.jpg", 73.0m, "Fila Men Streak White Sports Shoes", "Sports Shoes", "Sports" },
                    { 20805, 1, "Olive", "Men", "20805.jpg", "http://assets.myntassets.com/v1/images/style/properties/aa5794990af2ef0cc5aa7240508c7d6f_images.jpg", 56.5m, "Fila Men Rambler Olive Flip Flops", "Flip Flops", "Casual" },
                    { 20833, 3, "Black", "Men", "20833.jpg", "http://assets.myntassets.com/v1/images/style/properties/7fbee63ac47052f962bd5f25aa8652b8_images.jpg", 69.5m, "Clarks Men Black Formal Shoes", "Formal Shoes", "Formal" },
                    { 20856, 3, "Black", "Men", "20856.jpg", "http://assets.myntassets.com/v1/images/style/properties/fc4d12bcdc99ec17c6cbff23ce164f00_images.jpg", 55.5m, "United Colors of Benetton Men Casual Black Shoes", "Casual Shoes", "Casual" },
                    { 20868, 3, "White", "Men", "20868.jpg", "http://assets.myntassets.com/v1/images/style/properties/4f9f3dde2d270ae1611ea25b98f805d9_images.jpg", 72.5m, "Fila Men Stradd White Casual Shoes", "Casual Shoes", "Casual" },
                    { 20869, 2, "Brown", "Men", "20869.jpg", "http://assets.myntassets.com/v1/images/style/properties/29fd56a0b77043ee672235e0cfd353cc_images.jpg", 65.5m, "Fila Men Camper Brown Sandals", "Sandals", "Casual" },
                    { 20892, 3, "Black", "Men", "20892.jpg", "http://assets.myntassets.com/v1/images/style/properties/095fb3ab7b93692ab527692bbacc4147_images.jpg", 75.5m, "Basics Men Black Casual Shoes", "Casual Shoes", "Casual" },
                    { 20893, 3, "Black", "Men", "20893.jpg", "http://assets.myntassets.com/v1/images/style/properties/3b86808004a5829edc1076ddeb5ebe4f_images.jpg", 74.5m, "Basics Men Black Casual Shoes", "Casual Shoes", "Casual" },
                    { 20894, 3, "Red", "Men", "20894.jpg", "http://assets.myntassets.com/v1/images/style/properties/6cdbcb8a0c91f6f08a5eca566a30ba9e_images.jpg", 27.5m, "Basics Men Red Casual Shoes", "Casual Shoes", "Casual" },
                    { 20895, 3, "Orange", "Men", "20895.jpg", "http://assets.myntassets.com/v1/images/style/properties/e7b1be51dbdb683f6b62b41d4d2ea683_images.jpg", 21.0m, "Basics Men Orange Casual Shoes", "Casual Shoes", "Casual" },
                    { 21091, 3, "Brown", "Men", "21091.jpg", "http://assets.myntassets.com/v1/images/style/properties/cf79419333c910c05cc960d885c51ac3_images.jpg", 62.0m, "Clarks Men Manly Alpine Brown Casual Shoe", "Casual Shoes", "Casual" },
                    { 21175, 3, "White", "Men", "21175.jpg", "http://assets.myntassets.com/v1/images/style/properties/fc0d77a69b91e580d38bffd75a936dcb_images.jpg", 50.5m, "ADIDAS Men Lowell White Sports Shoe", "Sports Shoes", "Sports" },
                    { 21180, 1, "Black", "Men", "21180.jpg", "http://assets.myntassets.com/v1/images/style/properties/b057c9e8d5ccc63369807a12f67a39ac_images.jpg", 20.5m, "ADIDAS Men Adi Cells Black Flip Flops", "Flip Flops", "Casual" },
                    { 21181, 1, "Yellow", "Men", "21181.jpg", "http://assets.myntassets.com/v1/images/style/properties/fc8aa316b1055183689cf6f1487f911a_images.jpg", 58.5m, "ADIDAS Men Adi Stars Tread Yellow Flip Flops", "Flip Flops", "Casual" },
                    { 21186, 1, "Blue", "Men", "21186.jpg", "http://assets.myntassets.com/v1/images/style/properties/e62c55a04b18b09939898571a2cc9258_images.jpg", 26.0m, "ADIDAS Men Star Story Blue Flip Flops", "Flip Flops", "Casual" },
                    { 21187, 1, "Yellow", "Men", "21187.jpg", "http://assets.myntassets.com/v1/images/style/properties/fc3c2314edb31f522eab09b78ebede00_images.jpg", 43.5m, "ADIDAS Men Plugged In Yellow Flip Flops", "Flip Flops", "Casual" },
                    { 21188, 1, "Black", "Men", "21188.jpg", "http://assets.myntassets.com/v1/images/style/properties/ae850f862dc4a53f4914528b52e8e82c_images.jpg", 48.0m, "ADIDAS Men Adi Stars Tread Black Flip Flops", "Flip Flops", "Casual" },
                    { 22101, 3, "Grey", "Men", "22101.jpg", "http://assets.myntassets.com/v1/images/style/properties/74ad44750c9d0e10e88bba88fe5f9910_images.jpg", 35.5m, "Flying Machine Men Grey Casual Shoes", "Casual Shoes", "Casual" },
                    { 22109, 3, "White", "Men", "22109.jpg", "http://assets.myntassets.com/v1/images/style/properties/921f8ec9c2de2e7e7d511d47cb90c290_images.jpg", 59.5m, "Reebok Men White Acciomax II Sports Shoes", "Sports Shoes", "Sports" },
                    { 22130, 3, "Black", "Men", "22130.jpg", "http://assets.myntassets.com/v1/images/style/properties/c63bb9052b4d204abb8260905f118e94_images.jpg", 57.5m, "Provogue Men Black Formal Shoes", "Formal Shoes", "Formal" },
                    { 22131, 3, "Black", "Men", "22131.jpg", "http://assets.myntassets.com/v1/images/style/properties/158c6b88bfcd1176eb8c4497a6ac8c86_images.jpg", 25.0m, "Provogue Men Black Formal Shoes", "Formal Shoes", "Formal" },
                    { 22136, 3, "Black", "Men", "22136.jpg", "http://assets.myntassets.com/v1/images/style/properties/66382fb6d614ca7cada5bd95f7b4cd9c_images.jpg", 59.5m, "Provouge Men Black Formal Shoes", "Formal Shoes", "Formal" },
                    { 22137, 3, "Brown", "Men", "22137.jpg", "http://assets.myntassets.com/v1/images/style/properties/030566390746ba9c76afc7ce7295fbeb_images.jpg", 36.5m, "Provogue Men Brown Formal Shoes", "Formal Shoes", "Formal" },
                    { 22138, 3, "Black", "Men", "22138.jpg", "http://assets.myntassets.com/v1/images/style/properties/14ef53b95d09aa996909d3035e782203_images.jpg", 26.5m, "Provouge Men Black Classic Formal Shoe", "Formal Shoes", "Formal" },
                    { 22139, 3, "Black", "Men", "22139.jpg", "http://assets.myntassets.com/v1/images/style/properties/ed320434e393037062908c10a0368a2d_images.jpg", 51.5m, "Provogue Men Black Formal Shoes", "Formal Shoes", "Formal" },
                    { 22152, 2, "Olive", "Men", "22152.jpg", "http://assets.myntassets.com/v1/images/style/properties/94b46fd2b139a7b2397ca25628704dbd_images.jpg", 73.0m, "Lee Cooper Men Casual Sandals", "Sandals", "Casual" },
                    { 22153, 2, "Brown", "Men", "22153.jpg", "http://assets.myntassets.com/v1/images/style/properties/99808c9bdfee6165a0cec81d0219c1a1_images.jpg", 59.5m, "Lee Cooper Men Brown Casual Sandals", "Sandals", "Casual" },
                    { 22154, 3, "Black", "Men", "22154.jpg", "http://assets.myntassets.com/v1/images/style/properties/8ad35a71d39ef0432055771175ca3adc_images.jpg", 22.5m, "Lee Cooper Men Black Formal Shoes", "Formal Shoes", "Formal" },
                    { 22162, 3, "Black", "Men", "22162.jpg", "http://assets.myntassets.com/v1/images/style/properties/5863961b3510970c2e31d466af69b32b_images.jpg", 67.5m, "Timberland Men Black Casual Shoes", "Casual Shoes", "Casual" },
                    { 22163, 3, "Navy Blue", "Men", "22163.jpg", "http://assets.myntassets.com/v1/images/style/properties/718cc29c21bae96c4a6766bc3c0ecf1d_images.jpg", 40.5m, "Timberland Men Navy Blue Casual Shoes", "Casual Shoes", "Casual" },
                    { 22164, 3, "Brown", "Men", "22164.jpg", "http://assets.myntassets.com/v1/images/style/properties/324b832e603704a1f06c14310f701eb2_images.jpg", 57.5m, "Timberland Men Brown Casual Shoes", "Casual Shoes", "Casual" },
                    { 22165, 3, "Brown", "Men", "22165.jpg", "http://assets.myntassets.com/v1/images/style/properties/8683a67ee6b77e1d0ee1c2ca4d612161_images.jpg", 76.0m, "Timberland Men Brown Casual Shoes", "Casual Shoes", "Casual" },
                    { 22190, 3, "Brown", "Men", "22190.jpg", "http://assets.myntassets.com/v1/images/style/properties/76dfcb181dd18083e724d8100eb962bc_images.jpg", 23.5m, "Timberland Men Light Brown Casual Shoes", "Casual Shoes", "Casual" },
                    { 22191, 3, "Brown", "Men", "22191.jpg", "http://assets.myntassets.com/v1/images/style/properties/ed28f5ea658ff49ab0253f8f8798893a_images.jpg", 66.5m, "Timberland Men Light Brown Casual Shoes", "Casual Shoes", "Casual" },
                    { 22196, 3, "Black", "Men", "22196.jpg", "http://assets.myntassets.com/v1/images/style/properties/13b63be853066689953a150fe1986bba_images.jpg", 22.0m, "Timberland Men Black Casual Shoes", "Casual Shoes", "Casual" },
                    { 22197, 3, "Brown", "Men", "22197.jpg", "http://assets.myntassets.com/v1/images/style/properties/012a3c034f69c794277712a2904a629f_images.jpg", 24.0m, "Timberland Men Brown Casual Shoes", "Casual Shoes", "Casual" },
                    { 22198, 3, "Black", "Men", "22198.jpg", "http://assets.myntassets.com/v1/images/style/properties/70e74ca34b3b534b19d6b006d5bfad0a_images.jpg", 61.5m, "Timberland Men Black Casual Shoes", "Casual Shoes", "Casual" },
                    { 22199, 3, "Black", "Men", "22199.jpg", "http://assets.myntassets.com/v1/images/style/properties/4848cfb30ff987fee622b21322e4451b_images.jpg", 21.5m, "Timberland Men Black Casual Shoes", "Casual Shoes", "Casual" },
                    { 22361, 2, "Navy Blue", "Men", "22361.jpg", "http://assets.myntassets.com/v1/images/style/properties/Reebok-Men-Blue-Twist-Sandals_9d151773708628e8efa686c33561b54a_images.jpg", 76.0m, "Reebok Men Navy Twist Sandals", "Sports Sandals", "Casual" },
                    { 22536, 3, "Green", "Men", "22536.jpg", "http://assets.myntassets.com/v1/images/style/properties/9158e03588d188017e4ea8a8f45c2d5a_images.jpg", 71.0m, "Gas Men Skate Green Casual Shoes", "Casual Shoes", "Casual" },
                    { 22537, 2, "Tan", "Men", "22537.jpg", "http://assets.myntassets.com/v1/images/style/properties/465863ba7b810b5ef6c516fe91c77308_images.jpg", 47.0m, "Gas Men Eldorado Tan Casual  Sandals", "Sandals", "Casual" },
                    { 22703, 3, "Grey", "Men", "22703.jpg", "http://assets.myntassets.com/v1/images/style/properties/f06b700ed9a5c0fb40e3d8c49d2b4efd_images.jpg", 28.0m, "Nike Men Capri II Mid Grey Casual Shoes", "Casual Shoes", "Casual" },
                    { 22704, 3, "White", "Men", "22704.jpg", "http://assets.myntassets.com/v1/images/style/properties/976afdd1471339064495b533489e41bf_images.jpg", 21.5m, "Nike Men Capri II Mid White Casual Shoes", "Casual Shoes", "Casual" },
                    { 22705, 3, "White", "Men", "22705.jpg", "http://assets.myntassets.com/v1/images/style/properties/9f8463e724322e0b47cc9f615acab635_images.jpg", 68.0m, "Nike Men White Capri II Casual Shoe", "Casual Shoes", "Casual" },
                    { 22732, 3, "Olive", "Men", "22732.jpg", "http://assets.myntassets.com/v1/images/style/properties/b3d471d92a849559f43a9a6791a2ad83_images.jpg", 26.5m, "Nike Men Air Max Conquer ACG Olive Sports Boot", "Sports Shoes", "Sports" },
                    { 22733, 3, "Grey", "Men", "22733.jpg", "http://assets.myntassets.com/v1/images/style/properties/8d5a5eb7aae39ed9958de2f8ade64b9c_images.jpg", 46.0m, "Nike Men Dunk High Grey Casual Shoes", "Casual Shoes", "Casual" },
                    { 22841, 3, "Brown", "Men", "22841.jpg", "http://assets.myntassets.com/v1/images/style/properties/8147ab8b6d2586d1c9239cd94ff622a6_images.jpg", 56.5m, "Woodland Men Brown Shoes", "Casual Shoes", "Casual" },
                    { 22846, 3, "Khaki", "Men", "22846.jpg", "http://assets.myntassets.com/v1/images/style/properties/c701bcfc8f04d62ed35016aee985d5f6_images.jpg", 69.0m, "Woodland Men Khaki Casual Shoes", "Casual Shoes", "Casual" },
                    { 22958, 3, "White", "Men", "22958.jpg", "http://assets.myntassets.com/v1/images/style/properties/dac3290ff5092903b72d3043e293a9f6_images.jpg", 57.5m, "Reebok Men White Acciomax Sports Shoes", "Sports Shoes", "Sports" },
                    { 22959, 3, "White", "Men", "22959.jpg", "http://assets.myntassets.com/v1/images/style/properties/d898378df6163532990b75bada43f65d_images.jpg", 56.0m, "Reebok Men White Fusion Sports Shoes", "Sports Shoes", "Sports" },
                    { 23246, 3, "Black", "Men", "23246.jpg", "http://assets.myntassets.com/v1/images/style/properties/af8087a06f0c9ab02a37e22c4cae5dc7_images.jpg", 66.5m, "Arrow Men Formal Black Shoe", "Formal Shoes", "Formal" },
                    { 23247, 3, "Black", "Men", "23247.jpg", "http://assets.myntassets.com/v1/images/style/properties/0201105e4604bc784525d9cf0e972c40_images.jpg", 20.0m, "Arrow Men Formal Black Shoe", "Formal Shoes", "Formal" },
                    { 23248, 3, "Brown", "Men", "23248.jpg", "http://assets.myntassets.com/v1/images/style/properties/f7d8e92858d00fc9326445424a6f8e85_images.jpg", 46.0m, "Arrow Men Formal Brown Shoe", "Formal Shoes", "Formal" },
                    { 23249, 3, "Black", "Men", "23249.jpg", "http://assets.myntassets.com/v1/images/style/properties/ae9b19f9e5b20995dd206e0400b2dbce_images.jpg", 25.5m, "Arrow Men Formal Black Shoes", "Formal Shoes", "Formal" },
                    { 23489, 3, "Black", "Men", "23489.jpg", "http://assets.myntassets.com/v1/images/style/properties/8a6a6a780165d16b0371e34f63f6b23f_images.jpg", 36.0m, "FILA Men Forza 11 Black Sports Shoes", "Sports Shoes", "Sports" },
                    { 23500, 3, "White", "Men", "23500.jpg", "http://assets.myntassets.com/v1/images/style/properties/0734fd1f8aea4117ff2f3810a8d7d30b_images.jpg", 25.5m, "FILA Men Hostile White Sports Shoes", "Sports Shoes", "Sports" },
                    { 23676, 2, "Black", "Men", "23676.jpg", "http://assets.myntassets.com/v1/images/style/properties/fbee867387ae6f303458cb86a7e46fa5_images.jpg", 22.5m, "Red Tape Men Cross Band Black Sandals", "Sandals", "Casual" },
                    { 23677, 2, "Brown", "Men", "23677.jpg", "http://assets.myntassets.com/v1/images/style/properties/ac888d198ff6db5fbee75f6811915cf7_images.jpg", 41.5m, "Red Tape Men Cross Band Brown Sandals", "Sandals", "Casual" },
                    { 23679, 3, "Black", "Men", "23679.jpg", "http://assets.myntassets.com/v1/images/style/properties/fe190c0bcadd3318af38d63b93a9b40e_images.jpg", 42.5m, "Red Tape Men Mocassins Black Casual Shoes", "Casual Shoes", "Casual" },
                    { 23682, 3, "Black", "Men", "23682.jpg", "http://assets.myntassets.com/v1/images/style/properties/b7adbd4e6933e586a69433e31c668ddf_images.jpg", 72.0m, "Red Tape Men Black Casual Shoes", "Casual Shoes", "Casual" },
                    { 23812, 1, "Black", "Men", "23812.jpg", "http://assets.myntassets.com/v1/images/style/properties/97b2e7c6f2bbb75b6d33576adc0571fb_images.jpg", 55.0m, "Puma Men Jiff Black Flip Flops", "Flip Flops", "Casual" },
                    { 23813, 1, "Black", "Men", "23813.jpg", "http://assets.myntassets.com/v1/images/style/properties/fd5ec1e4e38ed0b81635af27cca0e585_images.jpg", 29.0m, "Puma Men Jiff Black Flip Flops", "Flip Flops", "Casual" },
                    { 23814, 3, "Black", "Men", "23814.jpg", "http://assets.myntassets.com/v1/images/style/properties/01aa827decbe2f5e84fd7c854f8d1300_images.jpg", 22.0m, "Puma Men Neo Low Black Casual Shoes", "Casual Shoes", "Casual" },
                    { 23815, 3, "Black", "Men", "23815.jpg", "http://assets.myntassets.com/v1/images/style/properties/01e806e6581f0cd323418cb9344d8ec3_images.jpg", 62.0m, "Puma Men Evo Black Casual Shoes", "Casual Shoes", "Casual" },
                    { 23822, 1, "Red", "Men", "23822.jpg", "http://assets.myntassets.com/v1/images/style/properties/982e0bf3c351aa407d629531c0a249cc_images.jpg", 57.0m, "Puma Men Breeze Red Flip Flops", "Flip Flops", "Casual" },
                    { 23823, 1, "Blue", "Men", "23823.jpg", "http://assets.myntassets.com/v1/images/style/properties/4619265f1f54015175802372aa42c1ec_images.jpg", 72.0m, "Puma Men Breeze Blue Flip Flops", "Flip Flops", "Casual" },
                    { 23824, 1, "Black", "Men", "23824.jpg", "http://assets.myntassets.com/v1/images/style/properties/0c9608b07776a13c6d468f6723361b7b_images.jpg", 64.0m, "Puma Men Java Black Flip Flops", "Flip Flops", "Casual" },
                    { 23825, 1, "Brown", "Men", "23825.jpg", "http://assets.myntassets.com/v1/images/style/properties/005203199ea23de3f97959be14c2533c_images.jpg", 41.5m, "Puma Men Java Brown Flip Flops", "Flip Flops", "Casual" },
                    { 23840, 3, "Brown", "Men", "23840.jpg", "http://assets.myntassets.com/v1/images/style/properties/b676624ef006e153f4ac61d5a70d31d8_images.jpg", 72.5m, "ADIDAS Men Brown Shoes", "Casual Shoes", "Casual" },
                    { 23841, 3, "White", "Men", "23841.jpg", "http://assets.myntassets.com/v1/images/style/properties/856b715d6fc1a22ae326b3e2074549ce_images.jpg", 22.5m, "ADIDAS Men White Snipe Lo Casual Shoes", "Casual Shoes", "Casual" },
                    { 23846, 3, "White", "Men", "23846.jpg", "http://assets.myntassets.com/v1/images/style/properties/2b4da2df280e3672fa30e9aafe76e66c_images.jpg", 41.0m, "ADIDAS Men White Galaxy Elite Sports Shoes", "Sports Shoes", "Sports" },
                    { 23847, 3, "White", "Men", "23847.jpg", "http://assets.myntassets.com/v1/images/style/properties/8b1c19f33a7ab230c7b37aa9e6996f71_images.jpg", 77.5m, "ADIDAS Men White Duramo 3 Sports Shoes", "Sports Shoes", "Sports" },
                    { 23848, 3, "White", "Men", "23848.jpg", "http://assets.myntassets.com/v1/images/style/properties/f959fa984e009c3be2b201faff29e1a5_images.jpg", 22.0m, "ADIDAS Men White Razor Sports Shoes", "Sports Shoes", "Sports" },
                    { 23849, 3, "Black", "Men", "23849.jpg", "http://assets.myntassets.com/v1/images/style/properties/aca469db7fbac91473fc2a810461889d_images.jpg", 51.5m, "ADIDAS Men Black Anzo Breeze Casual Shoes", "Casual Shoes", "Casual" },
                    { 23877, 3, "White", "Men", "23877.jpg", "http://assets.myntassets.com/v1/images/style/properties/68b17ba79c69ba59f3033d921c8a59a9_images.jpg", 38.5m, "Fila Men Cavier White Sports Shoes", "Sports Shoes", "Sports" },
                    { 23882, 3, "Grey", "Men", "23882.jpg", "http://assets.myntassets.com/v1/images/style/properties/498da65eeee9a23f2049449258384d55_images.jpg", 54.5m, "Fila Men Destiny Grey Sports Shoes", "Sports Shoes", "Sports" },
                    { 23884, 3, "White", "Men", "23884.jpg", "http://assets.myntassets.com/v1/images/style/properties/6b1d5e664a4dfdfac8ab8f5587257285_images.jpg", 60.5m, "Fila Men Hitech White Sports Shoes", "Sports Shoes", "Sports" },
                    { 23885, 3, "Grey", "Men", "23885.jpg", "http://assets.myntassets.com/v1/images/style/properties/FILA-Men-Sports-Shoes_f76566f76f49de0fdea5bedbe1c7db67_images.jpg", 68.5m, "Fila Men Grey Hex Sports Shoes", "Sports Shoes", "Sports" },
                    { 24098, 2, "Black", "Men", "24098.jpg", "http://assets.myntassets.com/v1/images/style/properties/3f605d586102ca09379cc592e697610a_images.jpg", 30.5m, "Red Tape Men Black Sandals", "Sandals", "Casual" },
                    { 24099, 2, "Black", "Men", "24099.jpg", "http://assets.myntassets.com/v1/images/style/properties/2257ebd000ba5991411d496ac1211da7_images.jpg", 64.5m, "Red Tape Men Black Sandals", "Sandals", "Casual" },
                    { 24187, 3, "Black", "Men", "24187.jpg", "http://assets.myntassets.com/v1/images/style/properties/fa20b4db514b2caeb4e458fd8ac482db_images.jpg", 30.5m, "Converse Men All Star Black Shoes", "Casual Shoes", "Casual" },
                    { 24250, 3, "White", "Men", "24250.jpg", "http://assets.myntassets.com/v1/images/style/properties/ff82e800185f09437bdd38606dbd4ec6_images.jpg", 75.0m, "Numero Uno Men White Casual Shoes", "Casual Shoes", "Casual" },
                    { 24251, 3, "Black", "Men", "24251.jpg", "http://assets.myntassets.com/v1/images/style/properties/73ac516d10dd631f07415d206bad0c05_images.jpg", 61.0m, "Numero Uno Men Black Casual Shoes", "Casual Shoes", "Casual" },
                    { 24256, 3, "Green", "Men", "24256.jpg", "http://assets.myntassets.com/v1/images/style/properties/2ab9915265f0498a4adf481c64160b8a_images.jpg", 24.5m, "Numero Uno Men Green Casual Shoes", "Casual Shoes", "Casual" },
                    { 24257, 3, "Navy Blue", "Men", "24257.jpg", "http://assets.myntassets.com/v1/images/style/properties/d0ee2c3d9795f7a1d0f5679e3a6cde55_images.jpg", 63.5m, "Numero Uno Men Navy Blue Casual Shoes", "Casual Shoes", "Casual" },
                    { 24258, 3, "White", "Men", "24258.jpg", "http://assets.myntassets.com/v1/images/style/properties/8cf52572340c3592e5f0ede116a0206f_images.jpg", 45.0m, "Numero Uno Men White Casual Shoes", "Casual Shoes", "Casual" },
                    { 24259, 3, "Navy Blue", "Men", "24259.jpg", "http://assets.myntassets.com/v1/images/style/properties/409871b3e6186c220fab46f5d2b90c7c_images.jpg", 54.0m, "Numero Uno Men Navy Blue Shoes", "Casual Shoes", "Casual" },
                    { 24260, 3, "White", "Men", "24260.jpg", "http://assets.myntassets.com/v1/images/style/properties/201ee2059f025456791058e25fd72c4b_images.jpg", 32.5m, "Numero Uno Men White Shoes", "Casual Shoes", "Casual" },
                    { 24408, 3, "Black", "Men", "24408.jpg", "http://assets.myntassets.com/v1/images/style/properties/724a329e2ac5bcf1aadfc7fda484cba9_images.jpg", 58.5m, "ADIDAS Men Black Vanquish Sports Shoes", "Sports Shoes", "Sports" },
                    { 24452, 3, "White", "Men", "24452.jpg", "http://assets.myntassets.com/v1/images/style/properties/e857ada015878612dbcccdb71da818e1_images.jpg", 56.5m, "Nike Men White Court Shuttle IV Sports Shoes", "Sports Shoes", "Sports" },
                    { 24453, 3, "Blue", "Men", "24453.jpg", "http://assets.myntassets.com/v1/images/style/properties/a6cfb0dfdce27e16b5ef4f5ef7e61c6c_images.jpg", 37.0m, "Nike Men Free Run Blue Sports Shoes", "Sports Shoes", "Sports" },
                    { 24454, 3, "White", "Men", "24454.jpg", "http://assets.myntassets.com/v1/images/style/properties/9537d2f7f68f4ab9183337966afcc9e7_images.jpg", 40.5m, "Nike Men Court Majestic White Casual Shoes", "Casual Shoes", "Casual" },
                    { 24462, 1, "Blue", "Men", "24462.jpg", "http://assets.myntassets.com/v1/images/style/properties/833aeb80865a963448ba9d1d4a1b3119_images.jpg", 59.0m, "ADIDAS Men Blue Adi Cliff Flip Flop", "Flip Flops", "Casual" },
                    { 24463, 3, "Brown", "Men", "24463.jpg", "http://assets.myntassets.com/v1/images/style/properties/3451aaaa1af1333806711b8a40c68b16_images.jpg", 58.5m, "Numero Uno Men Brown Casual Shoes", "Casual Shoes", "Casual" },
                    { 24666, 3, "Black", "Men", "24666.jpg", "http://assets.myntassets.com/v1/images/style/properties/378d9bf9c3a96f9c45b1bf75e1f88254_images.jpg", 61.0m, "Converse Men Lace Color Black Casual Shoes", "Casual Shoes", "Casual" },
                    { 24669, 3, "Red", "Men", "24669.jpg", "http://assets.myntassets.com/v1/images/style/properties/5122efbb17cf8719d28f683d5f3b5e50_images.jpg", 31.0m, "Converse Men Red Casual Shoes", "Casual Shoes", "Casual" },
                    { 24695, 2, "Black", "Men", "24695.jpg", "http://assets.myntassets.com/v1/images/style/properties/fd69840076267874eaaef3d85ed7a981_images.jpg", 39.0m, "Lotto Men Hermes Black Sandals", "Sandals", "Casual" },
                    { 24805, 3, "Black", "Men", "24805.jpg", "http://assets.myntassets.com/v1/images/style/properties/Decathlon-Men-Decathlon-Shoes-F300-Fg-Sr-Black-1128765-Z-Coffee-Brown-Sports-Shoes_dd1e6a3a3c04bbd1d1ccb66378bbfff7_images.jpg", 61.0m, "Decathlon Men Black F300 Sports Shoes", "Sports Shoes", "Sports" },
                    { 24835, 3, "Brown", "Men", "24835.jpg", "http://assets.myntassets.com/v1/images/style/properties/Rockport-Men-Brown-CASHAW-CAMEL-SUEDE-Casual-Shoes_47d67001cd53547df2c7b5f9820fc63f_images.jpg", 55.0m, "Rockport Men Brown Cashaw Camel Suede Casual Shoes", "Casual Shoes", "Casual" },
                    { 25572, 3, "Silver", "Men", "25572.jpg", "http://assets.myntassets.com/v1/images/style/properties/a70ae8bb33c1d5a75df76c3791ed5a9f_images.jpg", 60.0m, "Fila Men Superior Silver Sports Shoes", "Sports Shoes", "Sports" },
                    { 25573, 3, "White", "Men", "25573.jpg", "http://assets.myntassets.com/v1/images/style/properties/9e6734638199831640f4ff2252b5e086_images.jpg", 43.5m, "FILA Men Trempet White Sports Shoes", "Sports Shoes", "Sports" },
                    { 25574, 3, "Black", "Men", "25574.jpg", "http://assets.myntassets.com/v1/images/style/properties/70e34aec928c9a25bbb87089725acb41_images.jpg", 36.0m, "FILA Men Trempet Black & White Sports Shoes", "Sports Shoes", "Sports" },
                    { 25575, 3, "White", "Men", "25575.jpg", "http://assets.myntassets.com/v1/images/style/properties/0b529ff91b7d773ea9f1fd242412821c_images.jpg", 50.0m, "Fila Men Surveillance White Shoes", "Sports Shoes", "Sports" },
                    { 26530, 3, "Purple", "Men", "26530.jpg", "http://assets.myntassets.com/v1/images/style/properties/fa0b8460a26ccca6d24d819a7fd5b168_images.jpg", 26.5m, "Gas Men Aishley Greyish Purple Casual Shoes", "Casual Shoes", "Casual" },
                    { 26531, 3, "Olive", "Men", "26531.jpg", "http://assets.myntassets.com/v1/images/style/properties/8c91e3be9885709d1a77975d5e6dc2cb_images.jpg", 57.5m, "Gas Men Arunta Olive Casual Shoes", "Casual Shoes", "Casual" },
                    { 26536, 3, "White", "Men", "26536.jpg", "http://assets.myntassets.com/v1/images/style/properties/9bbb0a99f2262993b7b659959fbcf3bc_images.jpg", 64.5m, "ID Men White Shoes", "Casual Shoes", "Casual" },
                    { 26537, 3, "Blue", "Men", "26537.jpg", "http://assets.myntassets.com/v1/images/style/properties/76c2efe5347ad2bd76f401afa9aef090_images.jpg", 58.0m, "ID Men Blue Shoes", "Casual Shoes", "Casual" },
                    { 26538, 3, "Red", "Men", "26538.jpg", "http://assets.myntassets.com/v1/images/style/properties/6a6ebc47eaf2fe034bcfd94060a285ba_images.jpg", 45.5m, "ID Men Red Shoes", "Casual Shoes", "Casual" },
                    { 26539, 3, "White", "Men", "26539.jpg", "http://assets.myntassets.com/v1/images/style/properties/aebcef2573afb1f229353e0680b81959_images.jpg", 26.5m, "ID Men White & Black Shoes", "Casual Shoes", "Casual" },
                    { 26552, 3, "Black", "Men", "26552.jpg", "http://assets.myntassets.com/v1/images/style/properties/260feb93da07d02483d2c9b5beb15e06_images.jpg", 52.5m, "ID Men Black Shoes", "Casual Shoes", "Casual" },
                    { 26553, 3, "Blue", "Men", "26553.jpg", "http://assets.myntassets.com/v1/images/style/properties/a02747a571130ca2d2aa6f491d8b5fc2_images.jpg", 62.0m, "ID Men Blue Shoes", "Casual Shoes", "Casual" },
                    { 26554, 3, "Blue", "Men", "26554.jpg", "http://assets.myntassets.com/v1/images/style/properties/f49e87ba6c03e16135b2e79da78dc5b8_images.jpg", 24.5m, "ID Men Blue Shoes", "Casual Shoes", "Casual" },
                    { 26555, 3, "Black", "Men", "26555.jpg", "http://assets.myntassets.com/v1/images/style/properties/6835350fa996308624b38edefa6f401e_images.jpg", 51.5m, "ID Men Black & Purple Shoes", "Casual Shoes", "Casual" },
                    { 26562, 3, "Brown", "Men", "26562.jpg", "http://assets.myntassets.com/v1/images/style/properties/4cd68564db2e7a0b1bbbd8def671f534_images.jpg", 28.5m, "Lee Cooper Men Brown Shoes", "Casual Shoes", "Casual" },
                    { 26563, 3, "Tan", "Men", "26563.jpg", "http://assets.myntassets.com/v1/images/style/properties/439813e100f361515c562eb8652a5fb4_images.jpg", 49.5m, "Lee Cooper Men Tan Shoes", "Casual Shoes", "Casual" },
                    { 26590, 1, "Black", "Men", "26590.jpg", "http://assets.myntassets.com/v1/images/style/properties/14f5d521fe39590b0392f3864b499171_images.jpg", 73.0m, "Puma Men Aqua Cat II Power Black Flip Flops", "Flip Flops", "Casual" },
                    { 26591, 1, "Red", "Men", "26591.jpg", "http://assets.myntassets.com/v1/images/style/properties/0e2a28441bfa616d38c5ef95266a69f8_images.jpg", 23.0m, "Puma Men Aqua Cat II Power Red Flip Flops", "Flip Flops", "Casual" },
                    { 26596, 3, "Black", "Men", "26596.jpg", "http://assets.myntassets.com/v1/images/style/properties/c1cd58d59cc5c4ba32826e7373f254c2_images.jpg", 20.5m, "Puma Men Jago Ripstop Black Sports Shoes", "Sports Shoes", "Sports" },
                    { 26597, 3, "Black", "Men", "26597.jpg", "http://assets.myntassets.com/v1/images/style/properties/135fcf39e2e288c944df11c0682f7a6a_images.jpg", 53.0m, "Puma Men Faas 300 Black Sports Shoes", "Sports Shoes", "Sports" },
                    { 26598, 3, "White", "Men", "26598.jpg", "http://assets.myntassets.com/v1/images/style/properties/bd7373a9df659f9dad4eded5a7c0bb90_images.jpg", 64.5m, "Puma Men Faas 300 White Sports Shoes", "Sports Shoes", "Sports" },
                    { 26599, 3, "Blue", "Men", "26599.jpg", "http://assets.myntassets.com/v1/images/style/properties/4a7bc59ac70c9c71216f495d56c5fc02_images.jpg", 65.5m, "Puma Men Faas 300 Blue Sports Shoes", "Sports Shoes", "Sports" },
                    { 26703, 3, "White", "Men", "26703.jpg", "http://assets.myntassets.com/v1/images/style/properties/1038ce9f7220f629cf068d34e286de8c_images.jpg", 53.5m, "Nike Men White Court Shuttle Shoes", "Sports Shoes", "Sports" },
                    { 26704, 3, "White", "Men", "26704.jpg", "http://assets.myntassets.com/v1/images/style/properties/c0a8afcb96adb60a55fcb4748bd21364_images.jpg", 47.5m, "Nike Men White T-Lite 9 SL Shoes", "Sports Shoes", "Sports" },
                    { 27640, 3, "Grey", "Men", "27640.jpg", "http://assets.myntassets.com/v1/images/style/properties/658ea44bbbf88b14adad0e0b59c2197b_images.jpg", 52.0m, "Reebok Men Grey Premier Trinity Sports Shoes", "Sports Shoes", "Sports" },
                    { 28316, 3, "Black", "Men", "28316.jpg", "http://assets.myntassets.com/v1/images/style/properties/057da5e60ea73990e70041ba83e98395_images.jpg", 64.5m, "Red Tape Men Black Shoes", "Casual Shoes", "Casual" },
                    { 28600, 3, "Black", "Men", "28600.jpg", "http://assets.myntassets.com/v1/images/style/properties/00d49e1b2d56259d0ad1ba93e8cbaf21_images.jpg", 79.5m, "Fila Men Torando Black Sports Shoes", "Sports Shoes", "Sports" },
                    { 28606, 3, "Black", "Men", "28606.jpg", "http://assets.myntassets.com/v1/images/style/properties/b3e18cfe9423fe73a067520adf787d5a_images.jpg", 42.5m, "Nike Men Air Twilight Black Shoes", "Sports Shoes", "Casual" },
                    { 28607, 3, "White", "Men", "28607.jpg", "http://assets.myntassets.com/v1/images/style/properties/6c0b08ce2249c0eab0c8d3f90514f780_images.jpg", 67.0m, "Nike Men Dart VII White Sports Shoes", "Sports Shoes", "Sports" },
                    { 28608, 3, "White", "Men", "28608.jpg", "http://assets.myntassets.com/v1/images/style/properties/06ba34f3cad51f867551ef7860e55f08_images.jpg", 58.5m, "Nike Men Dart VII Leather White Sports Shoes", "Sports Shoes", "Sports" },
                    { 28636, 3, "Black", "Men", "28636.jpg", "http://assets.myntassets.com/v1/images/style/properties/5da2b93f195e7f411a75901776a48b71_images.jpg", 77.5m, "Nike Men The Overplay VI Black Shoes", "Sports Shoes", "Casual" },
                    { 28637, 3, "Black", "Men", "28637.jpg", "http://assets.myntassets.com/v1/images/style/properties/25dbd0bcceab68a7ab398c8a582094f6_images.jpg", 33.0m, "Nike Men Air Relentless Black Sports Shoes", "Sports Shoes", "Sports" },
                    { 28638, 3, "White", "Men", "28638.jpg", "http://assets.myntassets.com/v1/images/style/properties/6a1362c08e876980c17a99de4aa7fd92_images.jpg", 73.5m, "Nike Men Dart 9 Leather White Sports Shoes", "Sports Shoes", "Sports" },
                    { 28652, 3, "Black", "Men", "28652.jpg", "http://assets.myntassets.com/v1/images/style/properties/d286cac0d47d4dec862b8adabbab6ceb_images.jpg", 43.0m, "Nike Men Tiempo Natural IV Black Sports Shoes", "Sports Shoes", "Sports" },
                    { 28653, 3, "Black", "Men", "28653.jpg", "http://assets.myntassets.com/v1/images/style/properties/c8b170a1d0ddd0a42661ea8b20244c99_images.jpg", 76.5m, "Nike Men Air Max Quarter Black Sports Shoes", "Sports Shoes", "Sports" },
                    { 28655, 3, "White", "Men", "28655.jpg", "http://assets.myntassets.com/v1/images/style/properties/03024db69975ad4be6f33eb928e08f96_images.jpg", 35.5m, "Nike Men Zoom Structure White Sports Shoes", "Sports Shoes", "Sports" },
                    { 28662, 3, "Black", "Men", "28662.jpg", "http://assets.myntassets.com/v1/images/style/properties/46633b882cd1a13c3b54b6b028345533_images.jpg", 68.0m, "Nike Men Lunar Flow Black Casual Shoes", "Casual Shoes", "Casual" },
                    { 29123, 3, "White", "Men", "29123.jpg", "http://assets.myntassets.com/v1/images/style/properties/dea49e70e6ec5a0d642febe528ffb309_images.jpg", 54.5m, "Puma Men Aquil White Sports Shoes", "Sports Shoes", "Sports" },
                    { 29124, 3, "Black", "Men", "29124.jpg", "http://assets.myntassets.com/v1/images/style/properties/bf4766979f5625bf20c139e574011674_images.jpg", 38.5m, "Puma Men Aquil Black Sports Shoes", "Sports Shoes", "Sports" },
                    { 29570, 3, "Purple", "Men", "29570.jpg", "http://assets.myntassets.com/v1/images/style/properties/49f884ddf4420d869ad143857d3bc33d_images.jpg", 45.5m, "Vans Men Classic Slip-On Purple & Black Shoes", "Casual Shoes", "Casual" },
                    { 29571, 3, "Navy Blue", "Men", "29571.jpg", "http://assets.myntassets.com/v1/images/style/properties/61ff6d0a5a90c48fe528ddeada916425_images.jpg", 28.5m, "Vans Men Classic Slip-On Navy Blue Shoes", "Casual Shoes", "Casual" },
                    { 29576, 3, "White", "Men", "29576.jpg", "http://assets.myntassets.com/v1/images/style/properties/7af1319c8a48caac17777b1efc0cb831_images.jpg", 33.0m, "Vans Men Fontana White Shoes", "Casual Shoes", "Casual" },
                    { 30233, 3, "White", "Men", "30233.jpg", "http://assets.myntassets.com/v1/images/style/properties/115e53e76402ea9af077f2d5e44a7ea4_images.jpg", 60.0m, "Numero Uno Men White Shoes", "Casual Shoes", "Casual" },
                    { 30234, 1, "Black", "Men", "30234.jpg", "http://assets.myntassets.com/v1/images/style/properties/7b99e89eac30c7d4d78d54c8cc67e35a_images.jpg", 71.0m, "Numero Uno Men Black Flip Flops", "Flip Flops", "Casual" },
                    { 30235, 1, "Brown", "Men", "30235.jpg", "http://assets.myntassets.com/v1/images/style/properties/5ba3a67486e2c88961ea1e5689c8563b_images.jpg", 55.0m, "Numero Uno Men Brown Flip Flops", "Flip Flops", "Casual" },
                    { 30250, 1, "Yellow", "Men", "30250.jpg", "http://assets.myntassets.com/v1/images/style/properties/ee0e918c229e76e0e7e61712e9d2ecb3_images.jpg", 48.5m, "Numero Uno Men Yellow Flip Flops", "Flip Flops", "Casual" },
                    { 30251, 1, "Green", "Men", "30251.jpg", "http://assets.myntassets.com/v1/images/style/properties/c54d2b6b2829a69f78eb59fff0ed0e66_images.jpg", 72.5m, "Numero Uno Men Green Flip Flops", "Flip Flops", "Casual" },
                    { 30256, 3, "Black", "Men", "30256.jpg", "http://assets.myntassets.com/v1/images/style/properties/5e6825aad55fd535636671ed72b2c3ee_images.jpg", 78.5m, "Red Tape Men Black Semi Formal Shoes", "Formal Shoes", "Formal" },
                    { 30257, 3, "Grey", "Men", "30257.jpg", "http://assets.myntassets.com/v1/images/style/properties/476ee0d09cd066cf3e7ce229d5491754_images.jpg", 70.0m, "Red Tape Men Grey Shoes", "Casual Shoes", "Casual" },
                    { 30258, 3, "Brown", "Men", "30258.jpg", "http://assets.myntassets.com/v1/images/style/properties/2f78b25ddf5bb5b6a5fe35d68074f420_images.jpg", 35.0m, "Red Tape Men Brown Shoes", "Casual Shoes", "Casual" },
                    { 30259, 3, "Navy Blue", "Men", "30259.jpg", "http://assets.myntassets.com/v1/images/style/properties/8a791850c1df8128183eb59f7fedabe0_images.jpg", 23.5m, "Red Tape Men Navy Blue Shoes", "Casual Shoes", "Casual" },
                    { 30260, 3, "Black", "Men", "30260.jpg", "http://assets.myntassets.com/v1/images/style/properties/0fb65c93f7960b36fea651ab805b13be_images.jpg", 35.0m, "Red Tape Men Black Shoes", "Formal Shoes", "Casual" },
                    { 30261, 3, "Brown", "Men", "30261.jpg", "http://assets.myntassets.com/v1/images/style/properties/002b3bb2558112872d67170f3c394361_images.jpg", 35.0m, "Red Tape Men Brown Formal Shoes", "Formal Shoes", "Formal" },
                    { 31693, 3, "Brown", "Men", "31693.jpg", "http://assets.myntassets.com/v1/images/style/properties/f0b49a9cc297b4fa6ab22363776cdd98_images.jpg", 64.5m, "Ganuchi Men Brown Shoes", "Formal Shoes", "Formal" },
                    { 31946, 3, "Grey", "Men", "31946.jpg", "http://assets.myntassets.com/v1/images/style/properties/860c3801d65995ce20b695cf1aea1a17_images.jpg", 40.5m, "Nike Men Avid Grey Shoes", "Casual Shoes", "Casual" },
                    { 31947, 3, "Grey", "Men", "31947.jpg", "http://assets.myntassets.com/v1/images/style/properties/4274e4e982c115d304677e3167cf478b_images.jpg", 53.5m, "Nike Men Air Pegasus Grey Sports Shoes", "Sports Shoes", "Sports" },
                    { 31948, 3, "Blue", "Men", "31948.jpg", "http://assets.myntassets.com/v1/images/style/properties/9afbca0c8bb6cab7154767902b9bfaf0_images.jpg", 21.5m, "Nike Men Air Pegasus Blue Sports Shoes", "Sports Shoes", "Sports" },
                    { 31949, 3, "White", "Men", "31949.jpg", "http://assets.myntassets.com/v1/images/style/properties/24354f3ae110b7a6aa0fb19ffa6f0f06_images.jpg", 42.5m, "Nike Men Zoom Vomero White Sports Shoes", "Sports Shoes", "Sports" },
                    { 31970, 3, "Black", "Men", "31970.jpg", "http://assets.myntassets.com/v1/images/style/properties/721c5675ac5e1e58e2b864aa122c12df_images.jpg", 75.0m, "Nike Men Lengo Black Sports Shoes", "Sports Shoes", "Sports" },
                    { 31971, 3, "Navy Blue", "Men", "31971.jpg", "http://assets.myntassets.com/v1/images/style/properties/fa47e17256177c9d044bd752e833e954_images.jpg", 49.5m, "Nike Men Dual Fusion TR II Navy Blue Sports Shoes", "Sports Shoes", "Sports" },
                    { 31978, 3, "Grey", "Men", "31978.jpg", "http://assets.myntassets.com/v1/images/style/properties/2b92f105b6f754c0491cd8a443e2787c_images.jpg", 53.0m, "Nike Men Lunarswift +3 Grey Sports Shoes", "Sports Shoes", "Sports" },
                    { 31979, 3, "Grey", "Men", "31979.jpg", "http://assets.myntassets.com/v1/images/style/properties/7befb37221105961c017e679245ce9f6_images.jpg", 78.0m, "Nike Men Lunarswift +3 Grey Sports Shoes", "Sports Shoes", "Sports" },
                    { 31985, 3, "Khaki", "Men", "31985.jpg", "http://assets.myntassets.com/v1/images/style/properties/5d9e6fc038758663af5e6b53b7b90661_images.jpg", 31.0m, "Woodland Men Khaki Shoes", "Casual Shoes", "Casual" },
                    { 32191, 3, "Blue", "Men", "32191.jpg", "http://assets.myntassets.com/v1/images/style/properties/8126b972933d5f9155ef1568a6752019_images.jpg", 37.0m, "ADIDAS Men Phantom Blue Sports Shoes", "Sports Shoes", "Sports" },
                    { 32506, 2, "Brown", "Men", "32506.jpg", "http://assets.myntassets.com/v1/images/style/properties/fdd49471c5869b89864be7a64f46538e_images.jpg", 54.5m, "Franco Leone Men Brown Sandals", "Sandals", "Casual" },
                    { 32507, 2, "Black", "Men", "32507.jpg", "http://assets.myntassets.com/v1/images/style/properties/7d387a74d698f938487fc13e63e0c95e_images.jpg", 43.5m, "Franco Leone Men Black Sandals", "Sandals", "Casual" },
                    { 32508, 2, "Brown", "Men", "32508.jpg", "http://assets.myntassets.com/v1/images/style/properties/5cde18c17d3878b63ca0e4f8f336c28e_images.jpg", 35.0m, "Franco Leone Men Brown Sandals", "Sandals", "Casual" },
                    { 32509, 3, "Black", "Men", "32509.jpg", "http://assets.myntassets.com/v1/images/style/properties/c51d7f146ef4043ec0df9eca9d42669b_images.jpg", 77.5m, "Franco Leone Men Formal Black Formal Shoes", "Formal Shoes", "Formal" },
                    { 32552, 3, "Black", "Men", "32552.jpg", "http://assets.myntassets.com/v1/images/style/properties/18ecb9a34ecd356d39bc6f15b87fe64c_images.jpg", 64.0m, "Playboy Men Black Shoes", "Casual Shoes", "Casual" },
                    { 32553, 3, "Brown", "Men", "32553.jpg", "http://assets.myntassets.com/v1/images/style/properties/cc952bb5bd61f38e58758e8d2bc27820_images.jpg", 52.5m, "Playboy Men Brown Shoes", "Casual Shoes", "Casual" },
                    { 32554, 3, "Black", "Men", "32554.jpg", "http://assets.myntassets.com/v1/images/style/properties/60ea37226c9c5ed103eeedde59116038_images.jpg", 20.0m, "Playboy Men Black Shoes", "Casual Shoes", "Casual" },
                    { 32555, 3, "White", "Men", "32555.jpg", "http://assets.myntassets.com/v1/images/style/properties/cb5de20a8fad6fb3ea14496d5a32f525_images.jpg", 73.0m, "Playboy Men White Shoes", "Casual Shoes", "Casual" },
                    { 32751, 3, "Black", "Men", "32751.jpg", "http://assets.myntassets.com/v1/images/style/properties/ea051d39d65bfdcba994e6cd49061bd7_images.jpg", 62.5m, "FILA Men Liga II Black Shoes", "Casual Shoes", "Casual" },
                    { 32757, 3, "Multi", "Men", "32757.jpg", "http://assets.myntassets.com/v1/images/style/properties/79bf7d8999eeeabe2470ebff7e3a6b9f_images.jpg", 26.5m, "Fila Men Glam II Multi Coloured Shoes", "Casual Shoes", "Casual" },
                    { 32951, 3, "Brown", "Men", "32951.jpg", "http://assets.myntassets.com/v1/images/style/properties/b837a4328c1e64284d4b51bd95a57858_images.jpg", 57.5m, "ADIDAS Neo Men Court Sequence Mid Brown Shoes", "Casual Shoes", "Casual" },
                    { 33641, 1, "Black", "Men", "33641.jpg", "http://assets.myntassets.com/v1/images/style/properties/Lotto-Men-Black-Koro-G-Slippers_a34db65a450a3a80fccb61f5fe41b549_images.jpg", 53.0m, "Lotto Men Black Koro G Slippers", "Flip Flops", "Casual" },
                    { 33646, 2, "Black", "Men", "33646.jpg", "http://assets.myntassets.com/v1/images/style/properties/affe3aa43d16e7d72433a0a2d82cfc9d_images.jpg", 20.0m, "Lotto Men Ridge Black Sandals", "Sandals", "Casual" },
                    { 33647, 2, "Black", "Men", "33647.jpg", "http://assets.myntassets.com/v1/images/style/properties/48443163ef5c78260904604d1d16713c_images.jpg", 28.5m, "Lotto Men Ridge Black Sandals", "Sandals", "Casual" },
                    { 33648, 2, "Brown", "Men", "33648.jpg", "http://assets.myntassets.com/v1/images/style/properties/42344fe581af7a4c62d2a39ceb57be24_images.jpg", 47.0m, "Lotto Men Ridge Brown Sandals", "Sandals", "Casual" },
                    { 33649, 2, "Black", "Men", "33649.jpg", "http://assets.myntassets.com/v1/images/style/properties/070b37867589cbef2dbcc9da03d757ea_images.jpg", 63.0m, "Lotto Men Stride Black Sandals", "Sandals", "Casual" },
                    { 33685, 3, "Black", "Men", "33685.jpg", "http://assets.myntassets.com/v1/images/style/properties/b3f685b0647893db1800788d924c9f24_images.jpg", 75.5m, "Cobblerz Men Black Formal Shoes", "Formal Shoes", "Formal" },
                    { 33766, 3, "Blue", "Men", "33766.jpg", "http://assets.myntassets.com/v1/images/style/properties/e20155c3e811626be6f11308521536a7_images.jpg", 51.5m, "ADIDAS Neo Men Court Evo Blue Shoes", "Casual Shoes", "Casual" },
                    { 33822, 3, "White", "Men", "33822.jpg", "http://assets.myntassets.com/v1/images/style/properties/52ad8ae288ba080d88a116b3c70305ec_images.jpg", 27.5m, "Puma Men Axis White & Grey Sports Shoes", "Sports Shoes", "Sports" },
                    { 33840, 3, "Black", "Men", "33840.jpg", "http://assets.myntassets.com/v1/images/style/properties/02ee800d9466b127f47933dff2d44245_images.jpg", 44.0m, "Puma Men Hypermoto Ducati Black Shoes", "Casual Shoes", "Casual" },
                    { 33841, 3, "White", "Men", "33841.jpg", "http://assets.myntassets.com/v1/images/style/properties/Puma-Men-Drift-Cat-White-Shoes_38bd6e262b67ee3b6d1090c4c52f881a_images.jpg", 35.5m, "Puma Men Drift Cat White Shoes", "Casual Shoes", "Casual" },
                    { 33846, 3, "Black", "Men", "33846.jpg", "http://assets.myntassets.com/v1/images/style/properties/72ccae28a97809e9693607d75ffe9702_images.jpg", 59.5m, "Puma Men Future Cat Black Shoes", "Casual Shoes", "Casual" },
                    { 33847, 3, "White", "Men", "33847.jpg", "http://assets.myntassets.com/v1/images/style/properties/Puma-Men-Future-Cat-White-Shoes_582426f358a2de021996e86cfe3fd737_images.jpg", 79.5m, "Puma Men Future Cat White Shoes", "Casual Shoes", "Casual" },
                    { 33848, 3, "Brown", "Men", "33848.jpg", "http://assets.myntassets.com/v1/images/style/properties/Puma-Men-Drift-Cat-Brown-Shoes_b37c89652031b205bcd19c36d6c686bd_images.jpg", 38.0m, "Puma Men Drift Cat Brown Shoes", "Casual Shoes", "Casual" },
                    { 33849, 3, "Blue", "Men", "33849.jpg", "http://assets.myntassets.com/v1/images/style/properties/0590736a280676ea2cd2b55107484776_images.jpg", 69.0m, "Puma Men Blue Shoes", "Casual Shoes", "Casual" },
                    { 34090, 3, "Navy Blue", "Men", "34090.jpg", "http://assets.myntassets.com/v1/images/style/properties/Numero-Uno-Men-Casual-Shoes-SRB-8-BLU-Blue-Casual-Shoes_06848407c033f5e7c9a5177eb9b2dbb8_images.jpg", 56.0m, "Numero Uno Men Navy Leather Shoes", "Casual Shoes", "Casual" },
                    { 34543, 3, "Brown", "Men", "34543.jpg", "http://assets.myntassets.com/v1/images/style/properties/048de34d76449bb502d6bf75cffe33b9_images.jpg", 30.0m, "Red Tape Men Brown Formal Shoes", "Formal Shoes", "Formal" },
                    { 34632, 3, "Grey", "Men", "34632.jpg", "http://assets.myntassets.com/v1/images/style/properties/af21a7dc11fed0430f6c22dd916eccf4_images.jpg", 62.0m, "Lotto Men Dolce Vita II Grey Sports Shoes", "Sports Shoes", "Sports" },
                    { 34633, 3, "Black", "Men", "34633.jpg", "http://assets.myntassets.com/v1/images/style/properties/23992bccfebfa3bb0e9b3716ccb45abc_images.jpg", 50.5m, "Lotto Men Dolce Vita II Black Sports Shoes", "Sports Shoes", "Sports" },
                    { 34634, 3, "Brown", "Men", "34634.jpg", "http://assets.myntassets.com/v1/images/style/properties/d11cef6a5c018893e354faaf57ea6dcb_images.jpg", 78.5m, "Lotto Men Brown Fella Tres Shoes", "Casual Shoes", "Casual" },
                    { 34635, 3, "Black", "Men", "34635.jpg", "http://assets.myntassets.com/v1/images/style/properties/b21367a701d654464ae8c1ceb521d773_images.jpg", 45.5m, "Lotto Men XD III Black Shoes", "Casual Shoes", "Casual" },
                    { 34749, 3, "White", "Men", "34749.jpg", "http://assets.myntassets.com/v1/images/style/properties/7eae52134ab7fe0ae400d54a01149f27_images.jpg", 52.0m, "Puma Men White Benecio Shoes", "Casual Shoes", "Casual" },
                    { 34785, 2, "Grey", "Men", "34785.jpg", "http://assets.myntassets.com/v1/images/style/properties/91055f7e930ea0d17d5f3a3576a56d0d_images.jpg", 40.5m, "Fila Men Benton Grey Sandals", "Sports Sandals", "Casual" },
                    { 34832, 3, "White", "Men", "34832.jpg", "http://assets.myntassets.com/v1/images/style/properties/0eeb810eac77b956c5b62381e1f3010b_images.jpg", 45.0m, "ADIDAS Men Sukoi White Sports Shoes", "Sports Shoes", "Sports" },
                    { 34835, 3, "Blue", "Men", "34835.jpg", "http://assets.myntassets.com/v1/images/style/properties/c0abfa74fe61af6ba9e5f4936f45e6c7_images.jpg", 28.5m, "ADIDAS Men Blue Chill Sports Shoes", "Sports Shoes", "Sports" },
                    { 34850, 3, "White", "Men", "34850.jpg", "http://assets.myntassets.com/v1/images/style/properties/963388d780f1becd69c93ab0d2f942a6_images.jpg", 41.5m, "ADIDAS Men Falcon Elite White Sports Shoes", "Sports Shoes", "Sports" },
                    { 34851, 3, "Charcoal", "Men", "34851.jpg", "http://assets.myntassets.com/v1/images/style/properties/7cad8f5a17590d439cc96e7760bc138d_images.jpg", 70.0m, "Vans Men Bedford Charcoal Shoes", "Casual Shoes", "Casual" },
                    { 34856, 3, "Black", "Men", "34856.jpg", "http://assets.myntassets.com/v1/images/style/properties/89ee9427e4bb4bb8fcb173bc0bafdf5b_images.jpg", 67.5m, "Vans Men Classic Slip-On Black Shoes", "Casual Shoes", "Casual" },
                    { 34857, 3, "Black", "Men", "34857.jpg", "http://assets.myntassets.com/v1/images/style/properties/0e41c416bc349faead7ebe8851e1a398_images.jpg", 40.5m, "Vans Men Classic Slip-On Black Shoes", "Casual Shoes", "Casual" },
                    { 34858, 3, "Grey", "Men", "34858.jpg", "http://assets.myntassets.com/v1/images/style/properties/a6876fce4fe392cc65478960b1e14120_images.jpg", 74.0m, "Vans Men Classic Slip-On Grey Shoes", "Casual Shoes", "Casual" },
                    { 34860, 3, "Black", "Men", "34860.jpg", "http://assets.myntassets.com/v1/images/style/properties/Vans-Men-Era-Black-Shoes_10b0bb17185116b7844cc95ef27fb0d7_images.jpg", 54.5m, "Vans Men Era Black Shoes", "Casual Shoes", "Casual" },
                    { 34861, 3, "Grey", "Men", "34861.jpg", "http://assets.myntassets.com/v1/images/style/properties/637030c279a66196db7aa13ee458bdaa_images.jpg", 45.0m, "Vans Men Era Grey Shoes", "Casual Shoes", "Casual" },
                    { 35233, 3, "Black", "Men", "35233.jpg", "http://assets.myntassets.com/v1/images/style/properties/Fortune-Men-Formal-Shoes_f09330dbdfb8c18f912f1f98e1fbea7e_images.jpg", 32.0m, "Fortune Men Black Formal Shoes", "Formal Shoes", "Casual" },
                    { 35465, 3, "Blue", "Men", "35465.jpg", "http://assets.myntassets.com/v1/images/style/properties/428ea86c27e68387b1a41b4686edd32a_images.jpg", 74.0m, "Franco Leone Men Blue Shoes", "Casual Shoes", "Casual" },
                    { 35491, 3, "Brown", "Men", "35491.jpg", "http://assets.myntassets.com/v1/images/style/properties/f4dfeba74c1492fcfdc92b6ddbbc0ef6_images.jpg", 45.0m, "Bata Men Mocassino Brown Formal Shoes", "Formal Shoes", "Formal" },
                    { 35511, 1, "Black", "Men", "35511.jpg", "http://assets.myntassets.com/v1/images/style/properties/0affca87e3aba56fdcde8c2c1707c106_images.jpg", 31.0m, "Bata Men Lite Black Flip Flops", "Flip Flops", "Casual" },
                    { 35521, 1, "Blue", "Men", "35521.jpg", "http://assets.myntassets.com/v1/images/style/properties/3f14b5325030c3476514158160768646_images.jpg", 63.5m, "Bata Men Sandy Blue Flip Flops", "Flip Flops", "Casual" },
                    { 35573, 1, "Blue", "Men", "35573.jpg", "http://assets.myntassets.com/v1/images/style/properties/250838b0730b8630f23237809398b114_images.jpg", 22.5m, "Gliders Men Esquire Blue Flip Flops", "Flip Flops", "Casual" },
                    { 35574, 1, "Red", "Men", "35574.jpg", "http://assets.myntassets.com/v1/images/style/properties/9c1df994bfd66e4485b82d0e74066d98_images.jpg", 22.5m, "Gliders Men Esquire Red Flip Flops", "Flip Flops", "Casual" },
                    { 35575, 1, "Green", "Men", "35575.jpg", "http://assets.myntassets.com/v1/images/style/properties/Gliders-Men-Green-Esquire-Flip-Flops_f5168c977080a420cf18c78cb7ca4336_images.jpg", 49.5m, "Gliders Men Green Esquire Flip Flops", "Flip Flops", "Casual" },
                    { 35586, 2, "Brown", "Men", "35586.jpg", "http://assets.myntassets.com/v1/images/style/properties/Gliders-Men-Sandals_4a43911cb2cbea8fe371e01243a0edbe_images.jpg", 29.0m, "Gliders Men Brown Sandals", "Sandals", "Casual" },
                    { 35587, 2, "Brown", "Men", "35587.jpg", "http://assets.myntassets.com/v1/images/style/properties/Gliders-Men-Brown-Leather-Sandals_95633c99c7d10aa8995f5c3d6920374d_images.jpg", 54.0m, "Gliders Men Brown Leather Sandals", "Sandals", "Casual" },
                    { 35588, 2, "Black", "Men", "35588.jpg", "http://assets.myntassets.com/v1/images/style/properties/9d0512618e8f1ab54890cb7e7dddefaf_images.jpg", 59.0m, "Gliders Men Black Sandals", "Sandals", "Casual" },
                    { 35589, 2, "Olive", "Men", "35589.jpg", "http://assets.myntassets.com/v1/images/style/properties/b7a479fe5f56457e930541a789c5df68_images.jpg", 26.0m, "Gliders Men Yellow Sandals", "Sandals", "Casual" },
                    { 35657, 3, "Brown", "Men", "35657.jpg", "http://assets.myntassets.com/v1/images/style/properties/b7ebf4ad88e5685a2f950ba25b2ba717_images.jpg", 43.5m, "U.S. Polo Assn. Men Brown Shoes", "Formal Shoes", "Casual" },
                    { 35668, 1, "Brown", "Men", "35668.jpg", "http://assets.myntassets.com/v1/images/style/properties/7a75f9bde5d5da3ba38110b6464e26de_images.jpg", 54.5m, "U.S. Polo Assn. Men Brown Flip Flops", "Flip Flops", "Casual" },
                    { 35712, 3, "Grey", "Men", "35712.jpg", "http://assets.myntassets.com/v1/images/style/properties/20350a3f6fcaf11905c3609af9ec92a4_images.jpg", 70.0m, "Nike Men Dual Fusion TR III Grey Sports Shoes", "Sports Shoes", "Sports" },
                    { 35713, 3, "Red", "Men", "35713.jpg", "http://assets.myntassets.com/v1/images/style/properties/ce92252df97b5a245757777a5c39a572_images.jpg", 38.5m, "Nike Men Jordan Fly Wade Red Sports Shoes", "Sports Shoes", "Sports" },
                    { 35725, 3, "Beige", "Men", "35725.jpg", "http://assets.myntassets.com/v1/images/style/properties/af4182d4292d371bcc10698fb31da5eb_images.jpg", 60.0m, "Force 10 Men Beige Sports Shoes", "Sports Shoes", "Sports" },
                    { 35777, 3, "Black", "Men", "35777.jpg", "http://assets.myntassets.com/v1/images/style/properties/82a96a5a66ccb900ef4ab90c095baf02_images.jpg", 29.5m, "Force 10 Men Black & Green Sports Shoes", "Sports Shoes", "Sports" },
                    { 36130, 3, "Grey", "Men", "36130.jpg", "http://assets.myntassets.com/v1/images/style/properties/ca603a625578f83eebaa222051bb442b_images.jpg", 64.5m, "Nike Men Dunk High Grey Shoes", "Casual Shoes", "Casual" },
                    { 36131, 3, "Maroon", "Men", "36131.jpg", "http://assets.myntassets.com/v1/images/style/properties/619f32e4177a1dc98bdf266cefb0f4c8_images.jpg", 37.0m, "Nike Men Dunk High Maroon Shoes", "Casual Shoes", "Casual" },
                    { 36138, 3, "White", "Men", "36138.jpg", "http://assets.myntassets.com/v1/images/style/properties/48a23490d5375c27ac130c606f4213b9_images.jpg", 73.0m, "Nike Men Zoom Hyperenforcer White Sports Shoes", "Sports Shoes", "Sports" },
                    { 36139, 3, "Black", "Men", "36139.jpg", "http://assets.myntassets.com/v1/images/style/properties/0834f6ae67b7891d53e9a0d612a6fe46_images.jpg", 78.5m, "Nike Men The Overplay VII Black Sports Shoes", "Sports Shoes", "Sports" },
                    { 36442, 3, "Black", "Men", "36442.jpg", "http://assets.myntassets.com/v1/images/style/properties/cd2866856f1acb4f49239ab4ea2689ef_images.jpg", 52.5m, "Spinn Men Dozer Black Shoes", "Casual Shoes", "Casual" },
                    { 36957, 3, "White", "Men", "36957.jpg", "http://assets.myntassets.com/v1/images/style/properties/bf5fa4d1a7f8828f604656d9ea9f1cde_images.jpg", 28.0m, "Force 10 Men White Sports Shoes", "Sports Shoes", "Sports" },
                    { 37240, 3, "Brown", "Men", "37240.jpg", "http://assets.myntassets.com/v1/images/style/properties/be6ae100e116fd0d18cb0277dd045901_images.jpg", 23.0m, "United Colors of Benetton Men Brown Shoes", "Casual Shoes", "Casual" },
                    { 37241, 3, "Black", "Men", "37241.jpg", "http://assets.myntassets.com/v1/images/style/properties/bb19253f1f8bce9a8ef77375cd346016_images.jpg", 34.0m, "United Colors of Benetton Men Black Shoes", "Casual Shoes", "Casual" },
                    { 37246, 3, "Charcoal", "Men", "37246.jpg", "http://assets.myntassets.com/v1/images/style/properties/1145142948361b0a1e1fbf5a6012c594_images.jpg", 36.5m, "United Colors of Benetton Men Charcoal Shoes", "Casual Shoes", "Casual" },
                    { 37247, 3, "Black", "Men", "37247.jpg", "http://assets.myntassets.com/v1/images/style/properties/aad25041bb4c453db393e317ec0fb2cf_images.jpg", 38.5m, "United Colors of Benetton Men Black Shoes", "Casual Shoes", "Casual" },
                    { 37248, 3, "Brown", "Men", "37248.jpg", "http://assets.myntassets.com/v1/images/style/properties/9b0d6e5c4d9caf019a8bbadc7495a92e_images.jpg", 67.0m, "United Colors of Benetton Men Brown Shoes", "Casual Shoes", "Casual" },
                    { 37249, 3, "Brown", "Men", "37249.jpg", "http://assets.myntassets.com/v1/images/style/properties/d4636e23006874ae87dde460f7724909_images.jpg", 39.0m, "United Colors of Benetton Men Brown Shoes", "Casual Shoes", "Casual" },
                    { 38653, 3, "Black", "Men", "38653.jpg", "http://assets.myntassets.com/v1/images/style/properties/4ccdc8097238b1d029a7c23b0cc58207_images.jpg", 28.0m, "Nike Men Avid Black Casual Shoes", "Casual Shoes", "Casual" },
                    { 38654, 3, "White", "Men", "38654.jpg", "http://assets.myntassets.com/v1/images/style/properties/10365553644b24256ed7221979050d32_images.jpg", 47.5m, "Nike Men Ballista White Sports Shoes", "Sports Shoes", "Sports" },
                    { 38655, 3, "White", "Men", "38655.jpg", "http://assets.myntassets.com/v1/images/style/properties/9f6bc97599ce07ebdf3e1ee8452651fc_images.jpg", 69.5m, "Nike Men Air Impetus II White Sports Shoes", "Sports Shoes", "Sports" },
                    { 38662, 3, "Blue", "Men", "38662.jpg", "http://assets.myntassets.com/v1/images/style/properties/2935b4863e73f5667c427862b3cf2d2b_images.jpg", 55.0m, "Nike Men T90 Shoot IV Hg-B Blue Sports Shoes", "Sports Shoes", "Sports" },
                    { 38663, 3, "Black", "Men", "38663.jpg", "http://assets.myntassets.com/v1/images/style/properties/2c5347917d3e4889a799bc3cb28329b4_images.jpg", 71.5m, "Nike Men Downshifter Black Sports Shoes", "Sports Shoes", "Sports" },
                    { 38664, 3, "Grey", "Men", "38664.jpg", "http://assets.myntassets.com/v1/images/style/properties/eb126f408e5752b645b19578f12bfeb0_images.jpg", 21.0m, "Nike Men Liteforce Grey Shoes", "Casual Shoes", "Casual" },
                    { 38665, 3, "Black", "Men", "38665.jpg", "http://assets.myntassets.com/v1/images/style/properties/088a676c4548550a45922ed68f366c1d_images.jpg", 30.0m, "Nike Men Lunarfly Black Sports Shoes", "Sports Shoes", "Sports" },
                    { 39263, 3, "Black", "Men", "39263.jpg", "http://assets.myntassets.com/v1/images/style/properties/842f3fa981617f2625cb270cdda1a3dd_images.jpg", 76.0m, "Red Chief Men Black Formal Shoes", "Formal Shoes", "Formal" },
                    { 39264, 3, "Black", "Men", "39264.jpg", "http://assets.myntassets.com/v1/images/style/properties/5b75650e8c1215edb927eb5c929a556f_images.jpg", 51.5m, "Red Chief Men Black Formal Shoes", "Formal Shoes", "Formal" },
                    { 39297, 2, "Black", "Men", "39297.jpg", "http://assets.myntassets.com/v1/images/style/properties/5f2f5b0ce27bb55afa0bcce8ceccbacc_images.jpg", 68.5m, "Red Chief Men Black Sandals", "Sandals", "Casual" },
                    { 39310, 3, "Khaki", "Men", "39310.jpg", "http://assets.myntassets.com/v1/images/style/properties/d4970d44d1f2af84c4056852632ce317_images.jpg", 54.0m, "Red Chief Men Khaki Casual Shoes", "Casual Shoes", "Casual" },
                    { 39311, 1, "Multi", "Men", "39311.jpg", "http://assets.myntassets.com/v1/images/style/properties/76d6c7b68001277c4f9298b1fd18be47_images.jpg", 35.5m, "Converse Men Multi Coloured Flip Flop", "Flip Flops", "Casual" },
                    { 39342, 3, "Black", "Men", "39342.jpg", "http://assets.myntassets.com/v1/images/style/properties/6bba9c226b38d438115ac2d952ac9d5e_images.jpg", 23.0m, "Fila Men Zoom Black Shoes", "Casual Shoes", "Casual" },
                    { 39546, 1, "Yellow", "Men", "39546.jpg", "http://assets.myntassets.com/v1/images/style/properties/5bdd4c9e739205e28ee134ff7849bc60_images.jpg", 28.5m, "Numero Uno Men Yellow Flip Flops", "Flip Flops", "Casual" },
                    { 39547, 1, "Red", "Men", "39547.jpg", "http://assets.myntassets.com/v1/images/style/properties/1c648c96a3ef7fd021e5a6462601af0b_images.jpg", 20.5m, "Numero Uno Men Red Flip Flops", "Flip Flops", "Casual" },
                    { 39638, 3, "White", "Men", "39638.jpg", "http://assets.myntassets.com/v1/images/style/properties/021c6c43c0a6a9152f5f4ac18aa2b271_images.jpg", 51.5m, "Lotto Men White Sports Shoes", "Sports Shoes", "Sports" },
                    { 39742, 3, "Red", "Men", "39742.jpg", "http://assets.myntassets.com/v1/images/style/properties/a5ab934bf95b73af42ac8f3ef4f3030e_images.jpg", 23.5m, "Arrow Men Red Shoes", "Casual Shoes", "Casual" },
                    { 39899, 2, "Brown", "Men", "39899.jpg", "http://assets.myntassets.com/v1/images/style/properties/28bf82e35192d2d96f6011c669149e03_images.jpg", 25.0m, "ADIDAS Men Brown Sandals", "Sports Sandals", "Casual" },
                    { 39910, 3, "Blue", "Men", "39910.jpg", "http://assets.myntassets.com/v1/images/style/properties/3c3bda51fa73d8d10ae31bdf79bcbbec_images.jpg", 79.5m, "ADIDAS Men Blue & Red F10 Sports Shoes", "Sports Shoes", "Sports" },
                    { 39942, 3, "Navy Blue", "Men", "39942.jpg", "http://assets.myntassets.com/v1/images/style/properties/d039d725e9893e24fd9f021de968a920_images.jpg", 65.0m, "Gas Men Navy Blue Shoes", "Casual Shoes", "Casual" },
                    { 39943, 3, "Brown", "Men", "39943.jpg", "http://assets.myntassets.com/v1/images/style/properties/f2d705addd04fcf5516aef873254441e_images.jpg", 20.0m, "GAS Men Brown Count Casual Shoes", "Casual Shoes", "Casual" },
                    { 39944, 3, "Grey", "Men", "39944.jpg", "http://assets.myntassets.com/v1/images/style/properties/a63da69bf6b0a00d95dde7d444f57bc5_images.jpg", 23.5m, "GAS Men Grey Namib Shoes", "Casual Shoes", "Casual" },
                    { 39945, 3, "Brown", "Men", "39945.jpg", "http://assets.myntassets.com/v1/images/style/properties/9791ef9c6d02e740a8420299b8f02662_images.jpg", 52.5m, "GAS Men Brown Namib Shoes", "Casual Shoes", "Casual" },
                    { 39972, 3, "Grey", "Men", "39972.jpg", "http://assets.myntassets.com/v1/images/style/properties/GAS-Men-Casual-Shoes_b877c388a1212f0886ad1cb52e5c03fb_images.jpg", 77.0m, "GAS Men Grey Campus Casual Shoes", "Casual Shoes", "Casual" },
                    { 39973, 3, "Brown", "Men", "39973.jpg", "http://assets.myntassets.com/v1/images/style/properties/Gas-Men-Brown-Lear-Shoes_8d7f627491e0cc2c8de97c95ca634d5d_images.jpg", 37.5m, "Gas Men Brown Lear Shoes", "Casual Shoes", "Casual" },
                    { 39974, 3, "Brown", "Men", "39974.jpg", "http://assets.myntassets.com/v1/images/style/properties/Gas-Men-Khaki-Lear-Shoes_ee1f9af8c60c3670398b9251193f3d58_images.jpg", 25.5m, "Gas Men Brown Lear Shoes", "Casual Shoes", "Casual" },
                    { 39975, 3, "Olive", "Men", "39975.jpg", "http://assets.myntassets.com/v1/images/style/properties/Gas-Men-Olive-Swansea-Shoes_3b88d59b9e96bd64e16d0c85ec522979_images.jpg", 70.0m, "Gas Men Olive Swansea Shoes", "Casual Shoes", "Casual" },
                    { 39980, 3, "Brown", "Men", "39980.jpg", "http://assets.myntassets.com/v1/images/style/properties/a7a8fe472fe8efb3f3b92a1a21ba1b6f_images.jpg", 24.0m, "Gas Men Flint Brown Shoes", "Casual Shoes", "Casual" },
                    { 39981, 3, "Grey", "Men", "39981.jpg", "http://assets.myntassets.com/v1/images/style/properties/e8dd5f308885e0e8a533a63b54eaa3ea_images.jpg", 27.5m, "Gas Men Jack Grey Shoes", "Casual Shoes", "Casual" },
                    { 39986, 3, "Navy Blue", "Men", "39986.jpg", "http://assets.myntassets.com/v1/images/style/properties/ca8904a9a90c8c44c7b08519b394e8ac_images.jpg", 38.0m, "Gas Men Mila Navy Blue Shoes", "Casual Shoes", "Casual" },
                    { 39987, 3, "Blue", "Men", "39987.jpg", "http://assets.myntassets.com/v1/images/style/properties/de3bcbc7fc0f6e4ad83fa6c9a3ce89b8_images.jpg", 24.0m, "Gas Men Europa Blue Shoes", "Casual Shoes", "Casual" },
                    { 39988, 3, "White", "Men", "39988.jpg", "http://assets.myntassets.com/v1/images/style/properties/9c3d77147758ab10f12caf6184fe13ef_images.jpg", 51.0m, "Gas Men Europa White Shoes", "Casual Shoes", "Casual" },
                    { 39989, 3, "Blue", "Men", "39989.jpg", "http://assets.myntassets.com/v1/images/style/properties/685c0dd339e58d20bd23e8f23a122f7f_images.jpg", 50.5m, "Gas Men Skate Blue Shoes", "Casual Shoes", "Casual" },
                    { 40322, 3, "White", "Men", "40322.jpg", "http://assets.myntassets.com/v1/images/style/properties/f277dbded1640eaa4ca85c4b8d4ca101_images.jpg", 58.0m, "ADIDAS Men White Sparta Sports Shoes", "Sports Shoes", "Sports" },
                    { 40323, 3, "White", "Men", "40323.jpg", "http://assets.myntassets.com/v1/images/style/properties/af6cf23d24781c8a729f8a7637a38bf8_images.jpg", 71.5m, "ADIDAS Men Black Twenty2yds Sports Shoes", "Sports Shoes", "Sports" },
                    { 40325, 3, "White", "Men", "40325.jpg", "http://assets.myntassets.com/v1/images/style/properties/01840a251f73babcc28a2c5bdef65ebc_images.jpg", 42.5m, "ADIDAS Men White Sport Shoes", "Sports Shoes", "Sports" },
                    { 40776, 1, "Black", "Men", "40776.jpg", "http://assets.myntassets.com/v1/images/style/properties/58f63757145dbcb934e7cc2f00973b4a_images.jpg", 77.5m, "Quiksilver Men Black Flip Flops", "Flip Flops", "Casual" },
                    { 40777, 1, "White", "Men", "40777.jpg", "http://assets.myntassets.com/v1/images/style/properties/dffb0b14b097c0d2b7c4aad14181b055_images.jpg", 54.0m, "Quiksilver Men White Flip Flops", "Flip Flops", "Casual" },
                    { 40778, 1, "Black", "Men", "40778.jpg", "http://assets.myntassets.com/v1/images/style/properties/cbe97f9c9486c3cd2a90881d9c77b7da_images.jpg", 79.5m, "Quiksilver Men Black Flip Flops", "Flip Flops", "Casual" },
                    { 40779, 1, "Brown", "Men", "40779.jpg", "http://assets.myntassets.com/v1/images/style/properties/93422bef704ee5830c23f615bc89fa32_images.jpg", 73.0m, "Quiksilver Men Brown Flip Flops", "Flip Flops", "Casual" },
                    { 40782, 1, "Multi", "Men", "40782.jpg", "http://assets.myntassets.com/v1/images/style/properties/5596dae680b37c9fb4aaa6a265e7177b_images.jpg", 38.0m, "Quiksilver Men Multi Coloured Flip Flops", "Flip Flops", "Casual" },
                    { 40783, 1, "Black", "Men", "40783.jpg", "http://assets.myntassets.com/v1/images/style/properties/d6ee15dc6f8243e59c6e05effce27873_images.jpg", 40.5m, "Quiksilver Men Black Flip Flops", "Flip Flops", "Casual" },
                    { 40784, 1, "Blue", "Men", "40784.jpg", "http://assets.myntassets.com/v1/images/style/properties/0a9e2c771bc3ab2945ea36a09c06418d_images.jpg", 68.0m, "Quiksilver Men Blue Flip Flops", "Flip Flops", "Casual" },
                    { 40785, 1, "White", "Men", "40785.jpg", "http://assets.myntassets.com/v1/images/style/properties/3ac1a2f48ba5767e13a5cb112da62654_images.jpg", 21.5m, "Quiksilver Men White Flip Flops", "Flip Flops", "Casual" },
                    { 40970, 3, "Red", "Men", "40970.jpg", "http://assets.myntassets.com/v1/images/style/properties/81b9dfee83d2f89bfed0aab9e78e6df5_images.jpg", 52.5m, "Buckaroo Men Red Casual Shoes", "Casual Shoes", "Casual" },
                    { 40971, 3, "Brown", "Men", "40971.jpg", "http://assets.myntassets.com/v1/images/style/properties/e5b5823706a1c890f4300f30c92f59b2_images.jpg", 71.5m, "Buckaroo Men Brown Casual Shoes", "Casual Shoes", "Casual" },
                    { 41232, 3, "White", "Men", "41232.jpg", "http://assets.myntassets.com/v1/images/style/properties/2cb299d689b5c26c256c931837d45f7c_images.jpg", 67.5m, "Puma Men White Aquil Sports Shoes", "Sports Shoes", "Sports" },
                    { 41233, 3, "White", "Men", "41233.jpg", "http://assets.myntassets.com/v1/images/style/properties/58b3a748a5d62f503ffd41667422df61_images.jpg", 31.0m, "Puma Men White Aquil Sports Shoes", "Sports Shoes", "Sports" },
                    { 41436, 3, "White", "Men", "41436.jpg", "http://assets.myntassets.com/v1/images/style/properties/75dda63272645c9dedd6fcabd4eabd75_images.jpg", 60.0m, "Lee Cooper Men Black & White Sports Shoes", "Sports Shoes", "Casual" },
                    { 41437, 3, "White", "Men", "41437.jpg", "http://assets.myntassets.com/v1/images/style/properties/a36c588c364a56bc88de7b50101ba1ca_images.jpg", 74.0m, "Lee Cooper Men White Sports Shoes", "Sports Shoes", "Sports" },
                    { 41438, 3, "White", "Men", "41438.jpg", "http://assets.myntassets.com/v1/images/style/properties/00151ff747ecd0822548bc03eae08649_images.jpg", 52.0m, "Lee Cooper Men White Sports Shoes", "Sports Shoes", "Casual" },
                    { 41439, 3, "Black", "Men", "41439.jpg", "http://assets.myntassets.com/v1/images/style/properties/09edfdb4c1dc1478ea35507b0bdc41ce_images.jpg", 68.5m, "Lee Cooper Men Black Sports Shoes", "Sports Shoes", "Sports" },
                    { 41452, 3, "White", "Men", "41452.jpg", "http://assets.myntassets.com/v1/images/style/properties/b108d9994e0371f64073b44b2669a79d_images.jpg", 61.0m, "Lee Cooper Men White Shoes", "Casual Shoes", "Casual" },
                    { 41453, 3, "White", "Men", "41453.jpg", "http://assets.myntassets.com/v1/images/style/properties/ec572c3047ccf6cc9b4190ca455b341c_images.jpg", 67.5m, "Lee Cooper Men White Shoes", "Casual Shoes", "Casual" },
                    { 41454, 3, "White", "Men", "41454.jpg", "http://assets.myntassets.com/v1/images/style/properties/a10af61df2d146c2c714afde54623cbd_images.jpg", 27.0m, "Lee Cooper Men White Shoes", "Casual Shoes", "Casual" },
                    { 41455, 2, "Grey", "Men", "41455.jpg", "http://assets.myntassets.com/v1/images/style/properties/788847bb37bf3ba404eeebcb290c8746_images.jpg", 57.5m, "Lee Cooper Men Grey Sandals", "Sandals", "Casual" },
                    { 41832, 3, "Black", "Men", "41832.jpg", "http://assets.myntassets.com/v1/images/style/properties/ca89d1b053d9453a17193bc0d056b56b_images.jpg", 40.5m, "Skechers Men Black Sneakers", "Casual Shoes", "Casual" },
                    { 41833, 3, "Blue", "Men", "41833.jpg", "http://assets.myntassets.com/v1/images/style/properties/69b375b0bfbed0392edb93b05f2c8cf2_images.jpg", 67.0m, "Skechers Men Blue Shoes", "Casual Shoes", "Casual" },
                    { 41834, 3, "Black", "Men", "41834.jpg", "http://assets.myntassets.com/v1/images/style/properties/2c64a9788774d5c1ac0e149b20a61a7f_images.jpg", 37.5m, "Skechers Men Black Shoes", "Casual Shoes", "Casual" },
                    { 41857, 2, "Olive", "Men", "41857.jpg", "http://assets.myntassets.com/v1/images/style/properties/5209f6e3a73471f764528cf56902d50b_images.jpg", 38.0m, "Bata Men Hummer Grey Sandals", "Sandals", "Casual" },
                    { 41858, 2, "Brown", "Men", "41858.jpg", "http://assets.myntassets.com/v1/images/style/properties/9efd7ae56fafd8f9e64f3829d9d3ca0c_images.jpg", 39.5m, "Estd. 1977 Men Brown Sandals", "Sandals", "Casual" },
                    { 41859, 2, "Black", "Men", "41859.jpg", "http://assets.myntassets.com/v1/images/style/properties/2a07ce87fedfca8928f12f3ddf6b7632_images.jpg", 27.5m, "Estd. 1977 Men Black Sandals", "Sandals", "Casual" },
                    { 41861, 2, "Black", "Men", "41861.jpg", "http://assets.myntassets.com/v1/images/style/properties/b996cb05ae7c16cabfa4cadc23818247_images.jpg", 41.0m, "Estd. 1977 Men Black Sandals", "Sandals", "Casual" },
                    { 41866, 2, "Beige", "Men", "41866.jpg", "http://assets.myntassets.com/v1/images/style/properties/7adfef9d7001cdcb9a58822c0c8b615f_images.jpg", 46.5m, "Estd. 1977 Men Beige & Green Sandals", "Sandals", "Casual" },
                    { 41867, 2, "Red", "Men", "41867.jpg", "http://assets.myntassets.com/v1/images/style/properties/43db177ea76d2f7a1c6ba451fa94200a_images.jpg", 28.0m, "Estd. 1977 Men Red & Brown Sandals", "Sandals", "Casual" },
                    { 41868, 2, "Turquoise Blue", "Men", "41868.jpg", "http://assets.myntassets.com/v1/images/style/properties/c6ee9c292ad6c05a9f0df2cf33de7dd7_images.jpg", 49.5m, "Estd. 1977 Men Turquoise Blue Sandals", "Sandals", "Casual" },
                    { 41869, 2, "Yellow", "Men", "41869.jpg", "http://assets.myntassets.com/v1/images/style/properties/d27dbd8e9666b9af2d72fbfde315f76d_images.jpg", 23.0m, "Estd. 1977 Men Yellow & Brown Sandals", "Sandals", "Casual" },
                    { 42010, 2, "Brown", "Men", "42010.jpg", "http://assets.myntassets.com/v1/images/style/properties/feced0f1dc95b9c967f4518b90bd8316_images.jpg", 41.0m, "Estd. 1977 Men Brown Sandals", "Sandals", "Casual" },
                    { 42011, 2, "Grey", "Men", "42011.jpg", "http://assets.myntassets.com/v1/images/style/properties/b6e0c18ec68cef8f678044abcb9da69f_images.jpg", 36.0m, "Estd. 1977 Men Grey Sandals", "Sandals", "Casual" },
                    { 42016, 3, "Silver", "Men", "42016.jpg", "http://assets.myntassets.com/v1/images/style/properties/1551909acce98338ec85e55a32b04f47_images.jpg", 35.0m, "ADIDAS Men Silver Phaedra Shoes", "Sports Shoes", "Sports" },
                    { 42017, 3, "White", "Men", "42017.jpg", "http://assets.myntassets.com/v1/images/style/properties/c7e25fa074d71959905d645878cb53be_images.jpg", 24.0m, "ADIDAS Men White Phaedra Sports Shoes", "Sports Shoes", "Sports" },
                    { 42019, 3, "Black", "Men", "42019.jpg", "http://assets.myntassets.com/v1/images/style/properties/61a344cf01a57fa31aece78ee5e826d1_images.jpg", 21.0m, "ADIDAS Men Black Pural Desman Shoes", "Casual Shoes", "Casual" },
                    { 42020, 3, "Brown", "Men", "42020.jpg", "http://assets.myntassets.com/v1/images/style/properties/b34a6f424dc8c8853fa2324f509a3303_images.jpg", 57.0m, "ADIDAS Men Brown Mudslide Shoes", "Casual Shoes", "Casual" },
                    { 42042, 3, "White", "Men", "42042.jpg", "http://assets.myntassets.com/v1/images/style/properties/16a858c7c58d665ba030df2f9f326086_images.jpg", 63.5m, "Nike Men Air Relentless 2 MSL White Sports Shoes", "Sports Shoes", "Sports" },
                    { 42043, 3, "Black", "Men", "42043.jpg", "http://assets.myntassets.com/v1/images/style/properties/673b012f8890500c1cc057fadb855541_images.jpg", 58.5m, "Nike Men Black Shoes", "Casual Shoes", "Casual" },
                    { 42044, 3, "Grey", "Men", "42044.jpg", "http://assets.myntassets.com/v1/images/style/properties/2819f41dd9685b02ece177ea8b74afb2_images.jpg", 72.0m, "Nike Men Wardour Chukka White Casual Shoes", "Casual Shoes", "Casual" },
                    { 42045, 3, "Yellow", "Men", "42045.jpg", "http://assets.myntassets.com/v1/images/style/properties/bf609f778c0433c073cf4857238104eb_images.jpg", 34.5m, "Nike Men Wardour Chukka Yellow Casual Shoes", "Casual Shoes", "Casual" },
                    { 42086, 3, "White", "Men", "42086.jpg", "http://assets.myntassets.com/v1/images/style/properties/554d13072770bf16a010c4f6212da393_images.jpg", 45.0m, "ADIDAS Men Mars White Sports Shoes", "Sports Shoes", "Sports" },
                    { 42087, 3, "White", "Men", "42087.jpg", "http://assets.myntassets.com/v1/images/style/properties/37fafc79943235067c410fe05217e8d3_images.jpg", 22.0m, "ADIDAS Men White Aztek Shoes", "Sports Shoes", "Sports" },
                    { 42088, 3, "Brown", "Men", "42088.jpg", "http://assets.myntassets.com/v1/images/style/properties/2b2ccb96bc63978df5e2048b9c3e1958_images.jpg", 53.0m, "ADIDAS Men Brown Zapotec Shoes", "Sports Shoes", "Sports" },
                    { 42089, 3, "White", "Men", "42089.jpg", "http://assets.myntassets.com/v1/images/style/properties/5059a8f382c53105f1bdce6780543934_images.jpg", 43.5m, "ADIDAS Men White Corona Sports Shoes", "Sports Shoes", "Sports" },
                    { 42276, 3, "Navy Blue", "Men", "42276.jpg", "http://assets.myntassets.com/v1/images/style/properties/2e83d57a194c3ca14466b5e46b9e81cc_images.jpg", 61.5m, "Vans Men Navy Blue Michoacan Shoes", "Casual Shoes", "Casual" },
                    { 43335, 3, "Navy Blue", "Men", "43335.jpg", "http://assets.myntassets.com/v1/images/style/properties/5a39c57fe14818bcf26761961d619fae_images.jpg", 57.5m, "Reebok Men Navy Blue Turbo DMX Shear Sports Shoes", "Sports Shoes", "Sports" },
                    { 43350, 3, "Black", "Men", "43350.jpg", "http://assets.myntassets.com/v1/images/style/properties/8735e7bb7c0f6bba6ba42c2249a56817_images.jpg", 41.0m, "Reebok Men Black Fuel Extreme Sports Shoes", "Sports Shoes", "Sports" },
                    { 43357, 3, "Black", "Men", "43357.jpg", "http://assets.myntassets.com/v1/images/style/properties/44010cc893bc40d8ac8e9a94c67dc1d4_images.jpg", 25.5m, "Reebok Men Black Ultimate Vibe Sports Shoes", "Sports Shoes", "Sports" },
                    { 43359, 3, "Grey", "Men", "43359.jpg", "http://assets.myntassets.com/v1/images/style/properties/8b88871337f502b165149a9adfb23495_images.jpg", 56.0m, "Reebok Men Grey Ultimate Vibe Sports Shoes", "Sports Shoes", "Sports" },
                    { 43360, 3, "White", "Men", "43360.jpg", "http://assets.myntassets.com/v1/images/style/properties/204c35089ef0ca53f26baf86eb074e33_images.jpg", 32.0m, "Reebok Men White Ultimate Vibe Sports Shoes", "Sports Shoes", "Sports" },
                    { 43368, 1, "Blue", "Men", "43368.jpg", "http://assets.myntassets.com/v1/images/style/properties/f07545fc41f9696be5a669176a6cdff9_images.jpg", 62.5m, "Reebok Men Blue Possession Flip Flops", "Flip Flops", "Casual" },
                    { 43369, 1, "Black", "Men", "43369.jpg", "http://assets.myntassets.com/v1/images/style/properties/647838a2e988ab55b76c9aa9ddd15ad7_images.jpg", 27.5m, "Reebok Men Black Possession Flip Flops", "Flip Flops", "Casual" },
                    { 43871, 3, "White", "Men", "43871.jpg", "http://assets.myntassets.com/v1/images/style/properties/74a3feb75c7eaba01a38ed501de26ab1_images.jpg", 59.5m, "Puma Men White Driving Power Lo Shoes", "Casual Shoes", "Casual" },
                    { 43876, 3, "White", "Men", "43876.jpg", "http://assets.myntassets.com/v1/images/style/properties/c059090b7cadab7c4c062b2319470c33_images.jpg", 76.0m, "Puma Men White 3.0 Mid Shoes", "Casual Shoes", "Casual" },
                    { 43958, 2, "Olive", "Men", "43958.jpg", "http://assets.myntassets.com/v1/images/style/properties/Puma-Men-Olive-Techno-Ind-Sandal_3e7aa0b204f4317a017dfbefe260700b_images.jpg", 38.0m, "Puma Men Olive Techno Ind Sandal", "Sandals", "Casual" },
                    { 43959, 2, "Grey", "Men", "43959.jpg", "http://assets.myntassets.com/v1/images/style/properties/645e28828551998ae6a4f33226ef3c38_images.jpg", 72.0m, "Puma Men Grey Sandals", "Sandals", "Casual" },
                    { 44406, 3, "Brown", "Men", "44406.jpg", "http://assets.myntassets.com/v1/images/style/properties/554a2be61078071561aea802dc7b6cf3_images.jpg", 75.0m, "Force 10 Men Brown Shoes", "Sports Shoes", "Sports" },
                    { 44511, 2, "Black", "Men", "44511.jpg", "http://assets.myntassets.com/v1/images/style/properties/cb019afbcebf61a9fae59ba48f0a6ee3_images.jpg", 70.5m, "Coolers Men Black Sandals", "Sandals", "Casual" },
                    { 44516, 1, "Black", "Men", "44516.jpg", "http://assets.myntassets.com/v1/images/style/properties/Coolers-Men-POKAR-Black-Flip-Flops_ee113772a64e396ec9166036cdf547c0_images.jpg", 32.5m, "Coolers Men Black Pokar Flip Flops", "Flip Flops", "Casual" },
                    { 44517, 1, "Brown", "Men", "44517.jpg", "http://assets.myntassets.com/v1/images/style/properties/Coolers-Men-POKAR-Brown-Flip-Flops_8b247db935e7cfffb8f5a0b8d578f7bf_images.jpg", 64.5m, "Coolers Men Brown Pokar Flip Flops", "Flip Flops", "Casual" },
                    { 44518, 2, "Black", "Men", "44518.jpg", "http://assets.myntassets.com/v1/images/style/properties/1fe643f6730e29abcd819395dfb9ff92_images.jpg", 42.5m, "Coolers Men Black Sandals", "Sandals", "Casual" },
                    { 44520, 2, "Khaki", "Men", "44520.jpg", "http://assets.myntassets.com/v1/images/style/properties/fa43e463a1ac62d0faf52b69b2be829f_images.jpg", 21.5m, "Coolers Men Khaki Sandals", "Sandals", "Casual" },
                    { 44521, 2, "Black", "Men", "44521.jpg", "http://assets.myntassets.com/v1/images/style/properties/8fdaedb32b00be7b27714bc67055e0d7_images.jpg", 55.0m, "Coolers Men Black Sandals", "Sandals", "Casual" },
                    { 44528, 2, "Black", "Men", "44528.jpg", "http://assets.myntassets.com/v1/images/style/properties/5fdccf41dafc022f36adea9a7df6751c_images.jpg", 39.0m, "Coolers Men Black Sandals", "Sandals", "Casual" },
                    { 44529, 2, "Black", "Men", "44529.jpg", "http://assets.myntassets.com/v1/images/style/properties/Coolers-Men-Black-Sandals_d48cb0b603c630533c0a967fe23476c2_images.jpg", 20.5m, "Coolers Men Black Sandals", "Sandals", "Casual" },
                    { 44544, 2, "Black", "Men", "44544.jpg", "http://assets.myntassets.com/v1/images/style/properties/a534fc3afe0802b1a9d84e28a34104aa_images.jpg", 78.0m, "Coolers Men Black Sandals", "Sandals", "Casual" },
                    { 44545, 2, "Brown", "Men", "44545.jpg", "http://assets.myntassets.com/v1/images/style/properties/007eb7d88e3dc7d17d7cfe15cb8c1ba0_images.jpg", 30.5m, "Coolers Men Brown Sandals", "Sandals", "Casual" },
                    { 44572, 2, "Black", "Men", "44572.jpg", "http://assets.myntassets.com/v1/images/style/properties/Coolers-Men-8141-03-Blue-Sandals_63fc34706dcb4ec3a8b5be5a4d302695_images.jpg", 70.0m, "Coolers Men Black Sports Sandals", "Sports Sandals", "Casual" },
                    { 44573, 2, "Brown", "Men", "44573.jpg", "http://assets.myntassets.com/v1/images/style/properties/0de39b645ec8c893f54e6cb090e8245a_images.jpg", 40.5m, "Coolers Men Brown Sandals", "Sandals", "Casual" },
                    { 44712, 1, "Black", "Men", "44712.jpg", "http://assets.myntassets.com/v1/images/style/properties/b4e92269a1a54fe65b6ba1e189c49325_images.jpg", 26.5m, "Lotto Men Black Campione Flip Flop", "Flip Flops", "Casual" },
                    { 44713, 1, "Black", "Men", "44713.jpg", "http://assets.myntassets.com/v1/images/style/properties/1a690940734f3bc0df5d13791baf68a2_images.jpg", 32.5m, "Lotto Men Black Flip Flops", "Flip Flops", "Casual" },
                    { 44714, 1, "Maroon", "Men", "44714.jpg", "http://assets.myntassets.com/v1/images/style/properties/02d77ac6bf8e51ea28378b0f1bfd7e00_images.jpg", 33.5m, "Lotto Men Maroon Juve Flip Flop", "Flip Flops", "Casual" },
                    { 44715, 1, "Blue", "Men", "44715.jpg", "http://assets.myntassets.com/v1/images/style/properties/ecca5b63a81ffb22a8b30c1674a7ddf0_images.jpg", 60.5m, "Lotto Men Navy Blue Flip Flops", "Flip Flops", "Casual" },
                    { 44740, 3, "White", "Men", "44740.jpg", "http://assets.myntassets.com/v1/images/style/properties/1382dd0726f1748a14305844d4c97f4c_images.jpg", 21.0m, "Globalite Men White Terra Shoes", "Casual Shoes", "Casual" },
                    { 44741, 3, "White", "Men", "44741.jpg", "http://assets.myntassets.com/v1/images/style/properties/5e4da46cbf0c20e10cad459971bf9c76_images.jpg", 63.5m, "Globalite Men White Terra Shoes", "Casual Shoes", "Casual" },
                    { 44746, 3, "Olive", "Men", "44746.jpg", "http://assets.myntassets.com/v1/images/style/properties/d5e7d1528d28993acfc99b38abc73248_images.jpg", 31.5m, "Globalite Men Olive Sparta Shoes", "Casual Shoes", "Casual" },
                    { 44747, 3, "Black", "Men", "44747.jpg", "http://assets.myntassets.com/v1/images/style/properties/32b930343fffe258bcdf6ab9363bb24e_images.jpg", 76.0m, "Globalite Men Black Sparta Shoes", "Casual Shoes", "Casual" },
                    { 44748, 3, "White", "Men", "44748.jpg", "http://assets.myntassets.com/v1/images/style/properties/dc5df4ec13cadd87bff221579e6782b0_images.jpg", 47.0m, "Globalite Men White Dribble Shoes", "Casual Shoes", "Casual" },
                    { 44749, 3, "Grey", "Men", "44749.jpg", "http://assets.myntassets.com/v1/images/style/properties/6e61b750f76a4dccfc376634ecfacb49_images.jpg", 68.0m, "Globalite Men Grey Tracker Shoes", "Casual Shoes", "Casual" },
                    { 44770, 3, "Black", "Men", "44770.jpg", "http://assets.myntassets.com/v1/images/style/properties/4afe5a31ac385e4e43ca98ed9e1ef734_images.jpg", 41.5m, "Globalite Men Black Skid Shoes", "Casual Shoes", "Casual" },
                    { 44771, 3, "Grey", "Men", "44771.jpg", "http://assets.myntassets.com/v1/images/style/properties/07305f0c9d358c32b52a1d3715787121_images.jpg", 40.5m, "Globalite Men Navy Blue Skid Shoes", "Casual Shoes", "Casual" },
                    { 44776, 3, "Black", "Men", "44776.jpg", "http://assets.myntassets.com/v1/images/style/properties/bbdb227514bbad61c52c463df7e226eb_images.jpg", 45.5m, "Lotto Men Black Dolce Vita Shoes", "Casual Shoes", "Casual" },
                    { 44777, 3, "Grey", "Men", "44777.jpg", "http://assets.myntassets.com/v1/images/style/properties/68278d11b6ca39f30e2ea1ce9a4f2ad9_images.jpg", 43.5m, "Lotto Men Grey Dolce Vita Shoes", "Casual Shoes", "Casual" },
                    { 44778, 3, "Grey", "Men", "44778.jpg", "http://assets.myntassets.com/v1/images/style/properties/ca1b67f7619633fc7223b90322f5cf7a_images.jpg", 56.0m, "Lotto Men Grey Skateboard Shoes", "Casual Shoes", "Casual" },
                    { 44779, 3, "White", "Men", "44779.jpg", "http://assets.myntassets.com/v1/images/style/properties/44f436357d4664921418f737f798c559_images.jpg", 26.0m, "Lotto Men White Skateboard Shoes", "Casual Shoes", "Casual" },
                    { 44782, 3, "White", "Men", "44782.jpg", "http://assets.myntassets.com/v1/images/style/properties/7d8732d78a1af4ef6482bbad516358dd_images.jpg", 68.0m, "Lotto Men White Los Angeles II Sports Shoes", "Sports Shoes", "Sports" },
                    { 44783, 3, "White", "Men", "44783.jpg", "http://assets.myntassets.com/v1/images/style/properties/Lotto-Men-White---Silver-Sports-Shoes_fb12adf8cabe4187ee42e754cc1c322c_images.jpg", 59.0m, "Lotto Men White & Silver Sports Shoes", "Sports Shoes", "Sports" },
                    { 44784, 3, "White", "Men", "44784.jpg", "http://assets.myntassets.com/v1/images/style/properties/c462e119a8ee401e9cd03f9e2e7a647f_images.jpg", 60.0m, "Lotto Men White Torcida Shoes", "Sports Shoes", "Casual" },
                    { 44785, 3, "White", "Men", "44785.jpg", "http://assets.myntassets.com/v1/images/style/properties/b76ddd2010ef12c342439f3491f56b73_images.jpg", 78.5m, "Lotto Men L500 FG White Sports Shoes", "Sports Shoes", "Sports" },
                    { 44940, 3, "Brown", "Men", "44940.jpg", "http://assets.myntassets.com/v1/images/style/properties/f4358b5eeaa2a8e70b42db60518f59aa_images.jpg", 72.5m, "Franco Leone Men Brown Makhani Formal Shoes", "Formal Shoes", "Formal" },
                    { 44941, 3, "Black", "Men", "44941.jpg", "http://assets.myntassets.com/v1/images/style/properties/851760e82d34ebdc4b38d0dcd399e3f2_images.jpg", 73.0m, "Franco Leone Men Formal Shoes", "Formal Shoes", "Formal" },
                    { 44947, 3, "White", "Men", "44947.jpg", "http://assets.myntassets.com/v1/images/style/properties/c5bae9174c0e5fe600f0b9fc4e210d08_images.jpg", 64.0m, "Puma Men Mid Biz Ind White Shoes", "Sports Shoes", "Sports" },
                    { 44948, 3, "Black", "Men", "44948.jpg", "http://assets.myntassets.com/v1/images/style/properties/39cef2982137215d71ed41a558159659_images.jpg", 31.5m, "Puma Men Black Aquil II Sports Shoes", "Sports Shoes", "Sports" },
                    { 45602, 3, "Brown", "Men", "45602.jpg", "http://assets.myntassets.com/v1/images/style/properties/6b7d60e42466a293bc7a976449245675_images.jpg", 30.0m, "Arrow Men Brown Formal Shoes", "Formal Shoes", "Formal" },
                    { 45603, 3, "Black", "Men", "45603.jpg", "http://assets.myntassets.com/v1/images/style/properties/8f3b9f4c5f554e39681567b22985966e_images.jpg", 23.0m, "Arrow Men Black Formal Shoes", "Formal Shoes", "Formal" },
                    { 45604, 3, "Brown", "Men", "45604.jpg", "http://assets.myntassets.com/v1/images/style/properties/2b27b053871a6e9325c0f422fe92b67a_images.jpg", 20.5m, "Arrow Men Brown Formal Shoes", "Formal Shoes", "Formal" },
                    { 45605, 3, "Black", "Men", "45605.jpg", "http://assets.myntassets.com/v1/images/style/properties/a05fe01290b257157bc99ca67515ad3e_images.jpg", 22.5m, "Arrow Men Black Formal Shoes", "Formal Shoes", "Formal" },
                    { 45866, 3, "Black", "Men", "45866.jpg", "http://assets.myntassets.com/v1/images/style/properties/c15108156edb0aa796a8a5a549b5ba57_images.jpg", 66.0m, "Numero Uno Men Black Shoes", "Casual Shoes", "Casual" },
                    { 46080, 3, "Blue", "Men", "46080.jpg", "http://assets.myntassets.com/v1/images/style/properties/98648296abe452350f67540957a1c0cc_images.jpg", 33.5m, "ADIDAS Men Blue Sports Shoes", "Sports Shoes", "Sports" },
                    { 46081, 2, "Navy Blue", "Men", "46081.jpg", "http://assets.myntassets.com/v1/images/style/properties/4c6e1b047904fe55b1b3fd4e1f26afea_images.jpg", 29.0m, "ADIDAS Men Navy Blue Benton Sandals", "Sandals", "Casual" },
                    { 46215, 3, "Orange", "Men", "46215.jpg", "http://assets.myntassets.com/v1/images/style/properties/626f831620dfb63d0ecc780806bc7f64_images.jpg", 54.0m, "ADIDAS Men Orange Sports Shoes", "Sports Shoes", "Sports" },
                    { 47190, 3, "Brown", "Men", "47190.jpg", "http://assets.myntassets.com/v1/images/style/properties/77d7bccf564d9807859c6841037f4112_images.jpg", 36.0m, "Franco Leone Men Brown Shoes", "Formal Shoes", "Formal" },
                    { 47191, 3, "Black", "Men", "47191.jpg", "http://assets.myntassets.com/v1/images/style/properties/81cf8c19e59aa21dd516d55a44f49a35_images.jpg", 53.5m, "Franco Leone Men Black Formal Shoes", "Formal Shoes", "Formal" },
                    { 47196, 2, "Brown", "Men", "47196.jpg", "http://assets.myntassets.com/v1/images/style/properties/ff08f4495fe8d8ca799b327cf3487e3a_images.jpg", 66.5m, "Franco Leone Men Brown Sandals", "Sandals", "Casual" },
                    { 47197, 2, "Black", "Men", "47197.jpg", "http://assets.myntassets.com/v1/images/style/properties/4ecc18f38825a3c9b68201fe81ad3871_images.jpg", 55.0m, "Franco Leone Men Black Sandals", "Sandals", "Casual" },
                    { 47198, 2, "Brown", "Men", "47198.jpg", "http://assets.myntassets.com/v1/images/style/properties/08be9002361c65ffa2e08a8f12464f56_images.jpg", 63.0m, "Franco Leone Men Brown Sandals", "Sandals", "Casual" },
                    { 47199, 3, "Brown", "Men", "47199.jpg", "http://assets.myntassets.com/v1/images/style/properties/Franco-Leone-Men-Dark-Brown-Formal-Shoes_a6960feb0858f028113fe4f768fd9aa7_images.jpg", 61.5m, "Franco Leone Men Dark Brown Formal Shoes", "Formal Shoes", "Formal" },
                    { 47248, 3, "Orange", "Men", "47248.jpg", "http://assets.myntassets.com/v1/images/style/properties/c5388128a25bfecd078e864c842b49e8_images.jpg", 67.0m, "Playboy Men Orange Casual Shoes", "Casual Shoes", "Casual" },
                    { 49059, 3, "Charcoal", "Men", "49059.jpg", "http://assets.myntassets.com/v1/images/style/properties/47b68b00549450cdea0d0380dd597663_images.jpg", 65.5m, "Flying Machine Men Charcoal Shoes", "Casual Shoes", "Casual" },
                    { 49060, 3, "Black", "Men", "49060.jpg", "http://assets.myntassets.com/v1/images/style/properties/748aaedd07c35e5681e58e8cfc232675_images.jpg", 50.0m, "Flying Machine Men Black Shoes", "Casual Shoes", "Casual" },
                    { 49061, 3, "Brown", "Men", "49061.jpg", "http://assets.myntassets.com/v1/images/style/properties/815cca1f8f904471959fbe2b8055c177_images.jpg", 31.5m, "Flying Machine Men Brown Shoes", "Casual Shoes", "Casual" },
                    { 49435, 3, "Blue", "Men", "49435.jpg", "http://assets.myntassets.com/v1/images/style/properties/Vans-Men-Blue-Chukka-Boot-Shoes_678a3cfded1ec1bcceca587f6776a926_images.jpg", 22.5m, "Vans Men Blue Shoes", "Casual Shoes", "Casual" },
                    { 49461, 3, "Blue", "Men", "49461.jpg", "http://assets.myntassets.com/v1/images/style/properties/Vans-Men-Blue-Casual-Shoes_f9ad04b071e06c34a04e2c0a047d58a1_images.jpg", 27.0m, "Vans Men Blue Era Scilla Plaid Shoes", "Casual Shoes", "Casual" },
                    { 49468, 3, "Red", "Men", "49468.jpg", "http://assets.myntassets.com/v1/images/style/properties/Vans-Men-Maroon-Old-Skool-Shoes_d4826108fe9e4979766e62df2f7fcd06_images.jpg", 31.5m, "Vans Men Red Old Skool Shoes", "Casual Shoes", "Casual" },
                    { 49469, 3, "Maroon", "Men", "49469.jpg", "http://assets.myntassets.com/v1/images/style/properties/Vans-Men-Maroon-Vulcanized-Canvas-Shoes_720f0b25cb5299caf59f50ea424432a4_images.jpg", 47.0m, "Vans Men Maroon Vulcanized Canvas Shoes", "Casual Shoes", "Casual" },
                    { 49492, 3, "Maroon", "Men", "49492.jpg", "http://assets.myntassets.com/v1/images/style/properties/Vans-Men-Maroon---Grey-Era-Shoes_f95fd18a6cf5c1deede9c2a3304cfd2c_images.jpg", 73.0m, "Vans Men Maroon & Grey Era Shoes", "Casual Shoes", "Casual" },
                    { 49493, 3, "Green", "Men", "49493.jpg", "http://assets.myntassets.com/v1/images/style/properties/Vans-Men-Green---Grey-Era-Shoes_8986f3f6b75ac9b2fd47fb20f22d770d_images.jpg", 59.0m, "Vans Men Green & Grey Era Shoes", "Casual Shoes", "Casual" },
                    { 49494, 3, "Navy Blue", "Men", "49494.jpg", "http://assets.myntassets.com/v1/images/style/properties/Vans-Men-Navy-Blue-Chukka-Boots_68bdb21782c59584f77fc80d9f2413b8_images.jpg", 52.0m, "Vans Men Navy Blue Shoes", "Casual Shoes", "Casual" },
                    { 49495, 3, "Khaki", "Men", "49495.jpg", "http://assets.myntassets.com/v1/images/style/properties/Vans-Men-Khaki-Shoes_dcaf7c703e9c0396650529df2b2a8893_images.jpg", 53.5m, "Vans Men Khaki Shoes", "Casual Shoes", "Casual" },
                    { 50376, 3, "Black", "Men", "50376.jpg", "http://assets.myntassets.com/v1/images/style/properties/b461fc48013e9b45540fe64e99188c9d_images.jpg", 38.0m, "Woodland Men Black Shoes", "Casual Shoes", "Casual" },
                    { 50377, 3, "Brown", "Men", "50377.jpg", "http://assets.myntassets.com/v1/images/style/properties/f99ee11f2167bce272f9456c67581641_images.jpg", 69.5m, "Woodland Men Brown Shoes", "Casual Shoes", "Casual" },
                    { 50725, 3, "Black", "Men", "50725.jpg", "http://assets.myntassets.com/v1/images/style/properties/20866b1a2a15cbc1ce04296ddaeae23a_images.jpg", 50.5m, "Red Chief Men Black Formal Shoes", "Formal Shoes", "Formal" },
                    { 50740, 3, "Black", "Men", "50740.jpg", "http://assets.myntassets.com/v1/images/style/properties/e37ef333be6a8e14be8410580873a611_images.jpg", 21.5m, "Red Chief Men Black Formal Shoes", "Formal Shoes", "Formal" },
                    { 50741, 3, "Black", "Men", "50741.jpg", "http://assets.myntassets.com/v1/images/style/properties/2dba90668d61bd7dd5e25a02d7612ee3_images.jpg", 21.5m, "Red Chief Men Black Shoes", "Casual Shoes", "Casual" },
                    { 50746, 3, "Black", "Men", "50746.jpg", "http://assets.myntassets.com/v1/images/style/properties/70545e7653ee98ed7a82d2b13fc2d93b_images.jpg", 67.0m, "Red Chief Men Black Formal Shoes", "Formal Shoes", "Formal" },
                    { 50747, 3, "Mushroom Brown", "Men", "50747.jpg", "http://assets.myntassets.com/v1/images/style/properties/7a499301c721666d3243360e3e437091_images.jpg", 29.0m, "Red Chief Men Mushroom Brown Shoes", "Casual Shoes", "Casual" },
                    { 50748, 3, "Brown", "Men", "50748.jpg", "http://assets.myntassets.com/v1/images/style/properties/e41f0a7951b6a61de757754f91dde135_images.jpg", 61.0m, "Red Chief Men Brown Shoes", "Casual Shoes", "Casual" },
                    { 50749, 3, "Brown", "Men", "50749.jpg", "http://assets.myntassets.com/v1/images/style/properties/f4cead3fba42e4fee08f3fa55e8e7d8f_images.jpg", 63.0m, "Red Chief Men Brown Shoes", "Casual Shoes", "Casual" },
                    { 50776, 2, "Brown", "Men", "50776.jpg", "http://assets.myntassets.com/v1/images/style/properties/Clarks-Men-Casual-Shoes_9a29e9164d1e0e4d314387e006fc406f_images.jpg", 28.5m, "Clarks Men Brown Leather Sandals", "Sandals", "Casual" },
                    { 50777, 3, "Brown", "Men", "50777.jpg", "http://assets.myntassets.com/v1/images/style/properties/Clarks-Men-Formal-Shoes_d8593516fd4c7bfd45328e976caa96c6_images.jpg", 20.5m, "Clarks Men Dino Limit Brown Formal Shoes", "Formal Shoes", "Formal" },
                    { 50778, 3, "Navy Blue", "Men", "50778.jpg", "http://assets.myntassets.com/v1/images/style/properties/Clarks-Men-Navy-ORSON-LACE-LEATHER-Casual-Shoes_ab896b7d68b6b57dbef40d426819d6b8_images.jpg", 75.0m, "Clarks Men Navy Leather Sneakers", "Casual Shoes", "Casual" },
                    { 53734, 3, "Grey", "Men", "53734.jpg", "http://assets.myntassets.com/v1/images/style/properties/Puma-Men-Grey-Vintage-Ferrari-Casual-Shoes_3d91c7ee3487279c51edecb337de455b_images.jpg", 77.0m, "Puma Men Grey Vintage Ferrari Shoes", "Casual Shoes", "Casual" },
                    { 53735, 3, "Brown", "Men", "53735.jpg", "http://assets.myntassets.com/v1/images/style/properties/Puma-Men-Brown-Vintage-Ferrari-Casual-Shoes_b9fd2ef51fa25279915165c5df88154b_images.jpg", 22.5m, "Puma Men Brown Vintage Ferrari Shoes", "Casual Shoes", "Casual" },
                    { 54516, 3, "White", "Men", "54516.jpg", "http://assets.myntassets.com/v1/images/style/properties/F-Sports-Men-White-Velocity-Sports-Shoes_14345420e63e868eda0ec2e246cdb3b8_images.jpg", 24.0m, "F Sports Men White Velocity Sports Shoes", "Sports Shoes", "Sports" },
                    { 54517, 3, "White", "Men", "54517.jpg", "http://assets.myntassets.com/v1/images/style/properties/F-Sports-Men-White-Bratt-Sports-Shoes_23e61fa2aeee5c1b6f8636b3135c9371_images.jpg", 53.5m, "F Sports Men White Bratt Sports Shoes", "Sports Shoes", "Sports" },
                    { 54518, 3, "White", "Men", "54518.jpg", "http://assets.myntassets.com/v1/images/style/properties/F-Sports-Men-White-Velocity-Sports-Shoes_0cfae4d5115d7dd7372233b70eb1da1b_images.jpg", 46.0m, "F Sports Men White Velocity Sports Shoes", "Sports Shoes", "Sports" },
                    { 54519, 3, "Navy Blue", "Men", "54519.jpg", "http://assets.myntassets.com/v1/images/style/properties/F-Sports-Men-Navy-Blue-Vito-Sports-Shoes_47eee676e62fa156ca3f96052ee2b26c_images.jpg", 53.5m, "F Sports Men Navy Blue Vito Shoes", "Casual Shoes", "Casual" },
                    { 54520, 3, "White", "Men", "54520.jpg", "http://assets.myntassets.com/v1/images/style/properties/F-Sports-Men-White-Vito-Sports-Shoes_f6f00e33998f44a0dacc6d4eb25f2dae_images.jpg", 24.5m, "F Sports Men White Vito Shoes", "Casual Shoes", "Casual" },
                    { 54521, 3, "White", "Men", "54521.jpg", "http://assets.myntassets.com/v1/images/style/properties/F-Sports-Men-White-Voyager-Sports-Shoes_c5ff061b1db80cb997ae9f796e838bb5_images.jpg", 42.5m, "F Sports Men White Voyager Sports Shoes", "Sports Shoes", "Sports" },
                    { 54526, 3, "White", "Men", "54526.jpg", "http://assets.myntassets.com/v1/images/style/properties/F-Sports-Men-White-Zero-Gravity-Sports-Shoes_9626c504719dea085190a02f61246386_images.jpg", 67.0m, "F Sports Men White Zero Gravity Sports Shoes", "Sports Shoes", "Sports" },
                    { 54527, 3, "Black", "Men", "54527.jpg", "http://assets.myntassets.com/v1/images/style/properties/F-Sports-Men-Black-Charger-Sports-Shoes_470be134a38fc74c0f5519f82dfe9de1_images.jpg", 26.0m, "F Sports Men Black Charger Shoes", "Casual Shoes", "Casual" },
                    { 54528, 3, "White", "Men", "54528.jpg", "http://assets.myntassets.com/v1/images/style/properties/F-Sports-Men-White-Charger-Sports-Shoes_eabaab9bccfc72fd0b0abddf314fcd26_images.jpg", 40.0m, "F Sports Men White Charger Shoes", "Casual Shoes", "Casual" },
                    { 54529, 3, "Black", "Men", "54529.jpg", "http://assets.myntassets.com/v1/images/style/properties/F-Sports-Men-Black-Shoes_f4920f8c2dd4277191a4468e5acf397d_images.jpg", 36.5m, "F Sports Men Black Shoes", "Casual Shoes", "Casual" },
                    { 54542, 3, "White", "Men", "54542.jpg", "http://assets.myntassets.com/v1/images/style/properties/F-Sports-Men-White-Hurricane-Sports-Shoes_42056340c92493a9c33526f3b1602fc4_images.jpg", 58.5m, "F Sports Men White Hurricane Sports Shoes", "Sports Shoes", "Sports" },
                    { 54543, 3, "White", "Men", "54543.jpg", "http://assets.myntassets.com/v1/images/style/properties/F-Sports-Men-White-Outlander-Sports-Shoes_b600b7c68b5e9dd8b56dcd8732ce0fda_images.jpg", 53.5m, "F Sports Men White Outlander Sports Shoes", "Sports Shoes", "Casual" },
                    { 54544, 3, "Black", "Men", "54544.jpg", "http://assets.myntassets.com/v1/images/style/properties/F-Sports-Men-Black-Pace-Sports-Shoes_564a9fd92f55538cafab82567a7fbce3_images.jpg", 22.5m, "F Sports Men Black Pace Sports Shoes", "Sports Shoes", "Sports" },
                    { 54740, 3, "Black", "Men", "54740.jpg", "http://assets.myntassets.com/v1/images/style/properties/Vans-Men-Black-Era-Shoes_e1fd73af72d76d932ba25c9738a8586d_images.jpg", 44.5m, "Vans Men Black Era Shoes", "Casual Shoes", "Casual" },
                    { 56410, 3, "Brown", "Men", "56410.jpg", "http://assets.myntassets.com/v1/images/style/properties/GAS-Men-Brown-Casual-Shoes_87737d6282779d5a8bf6553ba8ac024c_images.jpg", 36.0m, "GAS Men Brown Casual Shoes", "Casual Shoes", "Casual" },
                    { 56411, 2, "Brown", "Men", "56411.jpg", "http://assets.myntassets.com/v1/images/style/properties/GAS-Men-Brown-Savana-Sandals_9f858aea5701fd4ea8b5aa550e9c4cf7_images.jpg", 68.5m, "GAS Men Brown Savana Sandals", "Sandals", "Casual" },
                    { 57475, 2, "Black", "Men", "57475.jpg", "http://assets.myntassets.com/v1/images/style/properties/ID-Men-Black-Sandals_249453ea3392792c05e511f9f5644ade_images.jpg", 47.5m, "ID Men Black Sandals", "Sandals", "Casual" },
                    { 57481, 3, "White", "Men", "57481.jpg", "http://assets.myntassets.com/v1/images/style/properties/ID-Men-White---Blue-Casual-Shoes_70c82cd514f95f07ed16d84a9ce750eb_images.jpg", 79.5m, "ID Men White & Blue Casual Shoes", "Casual Shoes", "Casual" },
                    { 57500, 2, "Brown", "Men", "57500.jpg", "http://assets.myntassets.com/v1/images/style/properties/Lee-Cooper-Men-Brown-Sandals_c12090ddca1c01400484d7c8f9fe8a1f_images.jpg", 34.0m, "Lee Cooper Men Brown Sandals", "Sandals", "Casual" },
                    { 57501, 2, "Beige", "Men", "57501.jpg", "http://assets.myntassets.com/v1/images/style/properties/Lee-Cooper-Men-Khaki-Sandals_ae939350de06c0bd99f50d9de1f48635_images.jpg", 55.0m, "Lee Cooper Men Light cocoa Sandals", "Sandals", "Casual" },
                    { 57506, 2, "Brown", "Men", "57506.jpg", "http://assets.myntassets.com/v1/images/style/properties/Lee-Cooper-Men-Brown-Sandals_41be8fa41082876a31ecb2b34fb7a12a_images.jpg", 43.0m, "Lee Cooper Men Brown Sandals", "Sandals", "Casual" },
                    { 57507, 2, "Black", "Men", "57507.jpg", "http://assets.myntassets.com/v1/images/style/properties/Lee-Cooper-Men-Black-Sandals_1b0f7922cd4ca61ee33d35927163a007_images.jpg", 72.0m, "Lee Cooper Men Black  Sandals", "Sandals", "Casual" },
                    { 57508, 2, "Brown", "Men", "57508.jpg", "http://assets.myntassets.com/v1/images/style/properties/Lee-Cooper-Men-Brown-Sandals_3e54af924a452a138ad5aa43aae892f0_images.jpg", 55.0m, "Lee Cooper Men Brown Sandals", "Sandals", "Casual" },
                    { 57509, 3, "Black", "Men", "57509.jpg", "http://assets.myntassets.com/v1/images/style/properties/Provogue-Men-Black-Casual-Shoes_7cfdbdde37f93b7d1d330cb4222a8345_images.jpg", 65.0m, "Provogue Men Black Casual Shoes", "Casual Shoes", "Casual" },
                    { 57530, 3, "Black", "Men", "57530.jpg", "http://assets.myntassets.com/v1/images/style/properties/Provogue-Men-Black-Casual-Shoes_b15379def0848cfdc89755f9c535f303_images.jpg", 47.5m, "Provogue Men Black Casual Shoes", "Casual Shoes", "Casual" },
                    { 57531, 3, "Mushroom Brown", "Men", "57531.jpg", "http://assets.myntassets.com/v1/images/style/properties/Provogue-Men-Mushroom-Brown-Casual-Shoes_63c5624508f1ae3d4ce5256c1e82492a_images.jpg", 72.0m, "Provogue Men Mushroom Brown Casual Shoes", "Casual Shoes", "Casual" },
                    { 57934, 2, "Brown", "Men", "57934.jpg", "http://assets.myntassets.com/v1/images/style/properties/Clarks-Men-Brown-Sandals_de132ea3035bd5070b3d638f6068ec61_images.jpg", 44.0m, "Clarks Men Brown Sandals", "Sandals", "Casual" },
                    { 57935, 2, "Black", "Men", "57935.jpg", "http://assets.myntassets.com/v1/images/style/properties/Clarks-Men-Black-Sandals_32cdfdb1c318dd5bb7c332071bfbd3f7_images.jpg", 34.5m, "Clarks Men Black Leather Closed Sandals", "Sandals", "Casual" },
                    { 57950, 3, "Brown", "Men", "57950.jpg", "http://assets.myntassets.com/v1/images/style/properties/Clarks-Men-Brown-Formal-Shoes_cae81cf723ab38cd1a0921981bba2a05_images.jpg", 33.5m, "Clarks Men Brown Formal Shoes", "Formal Shoes", "Formal" },
                    { 58328, 1, "Blue", "Men", "58328.jpg", "http://assets.myntassets.com/v1/images/style/properties/Lotto-Men-Blue-Flip-Flops_fcb9db63056967ad17bc5937555db441_images.jpg", 39.5m, "Lotto Men Blue Flip Flops", "Flip Flops", "Casual" },
                    { 58329, 1, "Red", "Men", "58329.jpg", "http://assets.myntassets.com/v1/images/style/properties/Lotto-Men-Red-Flip-Flops_504feb7f72ee222980ee2e6e3526e80a_images.jpg", 58.0m, "Lotto Men Red Flip Flops", "Flip Flops", "Casual" },
                    { 59435, 3, "Black", "Men", "59435.jpg", "http://assets.myntassets.com/v1/images/style/properties/Arrow-Men-Black-Formal-Shoes_70a3c7c185338a5636c8c0e668829bb6_images.jpg", 75.5m, "Arrow Men Black Formal Shoes", "Formal Shoes", "Formal" },
                    { 59943, 3, "Black", "Men", "59943.jpg", "http://assets.myntassets.com/v1/images/style/properties/Vans-Men-Black---Red-Casual-Shoes_d58b0db818089598dada89b3cca155aa_images.jpg", 26.0m, "Vans Men Black & Red Casual Shoes", "Casual Shoes", "Casual" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1636);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1637);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1653);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1654);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1806);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1831);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1836);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2211);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2218);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2219);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2220);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2227);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2399);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2477);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2504);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2642);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2817);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2820);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2821);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2826);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2827);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2828);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2963);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2964);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3150);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3151);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3159);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3160);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3161);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3168);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3300);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3306);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3307);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3308);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3309);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3503);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3504);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3550);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3551);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3556);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3557);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3558);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3559);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3560);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3561);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3566);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3567);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3569);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3592);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3594);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3595);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3790);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3797);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3798);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3996);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3997);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3998);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4112);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4113);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4114);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4141);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4171);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4179);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4183);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4184);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4342);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4343);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4344);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4345);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4514);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4515);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4522);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4523);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4524);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4525);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4546);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4547);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4549);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4576);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4577);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4578);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5050);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5238);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5239);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5290);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5291);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5296);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5345);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5404);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5405);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5459);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5461);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5467);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5468);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5469);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5600);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5601);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5606);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5608);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5609);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5638);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5654);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5665);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5690);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5691);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5696);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5697);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5698);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5699);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5896);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5898);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5899);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6362);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6396);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6414);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6423);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6424);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6440);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6441);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6446);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6448);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6470);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6483);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6619);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6620);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6621);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6626);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6627);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6628);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6629);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6642);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6673);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6675);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6680);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6810);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6811);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6816);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6817);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6818);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6821);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6826);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7244);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7330);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7331);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7363);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7364);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7365);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7390);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7391);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7396);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7397);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7398);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7399);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7592);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7593);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7730);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7731);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7753);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7754);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7797);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7799);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7881);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8346);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8527);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8528);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8529);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8912);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8913);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8914);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8970);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8971);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8976);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8979);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8982);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8983);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8984);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9000);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9001);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9030);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9031);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9036);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9037);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9038);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9039);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9052);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9053);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9055);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9090);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9091);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9202);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9203);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9204);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9205);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9400);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9401);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9407);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9430);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9431);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9497);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10037);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10039);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10097);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10174);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10180);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10266);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10267);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10268);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10293);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10294);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10295);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10632);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10633);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10634);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10635);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11851);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11856);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11912);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11913);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11914);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11915);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11922);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11923);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11924);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11940);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11941);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11946);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11947);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11948);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11949);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11971);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11976);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11977);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11978);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11979);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11983);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11985);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12506);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12507);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12508);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12509);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12704);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12705);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12876);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12882);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12885);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12903);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12904);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12956);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12957);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12958);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12959);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12960);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12961);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12966);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12967);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12968);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12969);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13072);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13073);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13074);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13075);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13080);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13081);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13198);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13214);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13215);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13359);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13537);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13646);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13648);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13649);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13676);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13677);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13679);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13683);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13684);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13685);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14490);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14491);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14496);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14497);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14498);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14499);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15062);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15250);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15313);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15314);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15315);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15376);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15377);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15378);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15379);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15382);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15384);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15385);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15406);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15510);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15516);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15517);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15518);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15519);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15520);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15521);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15713);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15714);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15722);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15724);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15741);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15746);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15747);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16152);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16153);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16154);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16155);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16162);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16163);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16164);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16165);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16732);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16733);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16734);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16735);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16966);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16969);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17026);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17027);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17028);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17029);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17042);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17043);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17044);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17045);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17410);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17411);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17416);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17481);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17647);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17813);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17814);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17815);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17822);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17823);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17840);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17846);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17847);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17960);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18402);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18403);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18404);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18405);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18492);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18493);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18494);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18495);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18601);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18653);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18655);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18665);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19122);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19123);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19140);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19141);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19310);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19311);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19329);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19372);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19387);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19772);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19927);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19928);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20695);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20715);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20802);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20804);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20805);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20833);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20856);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20868);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20869);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20892);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20893);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20894);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20895);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21091);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21175);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21180);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21181);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21186);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21187);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21188);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22101);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22109);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22130);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22131);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22136);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22137);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22138);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22139);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22152);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22153);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22154);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22162);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22163);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22164);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22165);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22190);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22191);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22196);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22197);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22198);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22199);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22361);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22536);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22537);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22703);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22704);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22705);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22732);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22733);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22841);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22846);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22958);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22959);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23246);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23247);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23248);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23249);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23489);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23500);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23676);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23677);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23679);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23682);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23812);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23813);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23814);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23815);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23822);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23823);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23824);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23825);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23840);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23841);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23846);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23847);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23848);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23849);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23877);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23882);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23884);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23885);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24098);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24099);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24187);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24250);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24251);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24256);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24257);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24258);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24259);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24260);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24408);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24452);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24453);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24454);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24462);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24463);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24666);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24669);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24695);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24805);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24835);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25572);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25573);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25574);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25575);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26530);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26531);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26536);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26537);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26538);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26539);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26552);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26553);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26554);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26555);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26562);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26563);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26590);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26591);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26596);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26597);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26598);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26599);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26703);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26704);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27640);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28316);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28600);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28606);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28607);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28608);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28636);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28637);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28638);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28652);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28653);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28655);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28662);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29123);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29124);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29570);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29571);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29576);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30233);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30234);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30235);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30250);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30251);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30256);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30257);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30258);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30259);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30260);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30261);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31693);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31946);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31947);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31948);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31949);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31970);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31971);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31978);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31979);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31985);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32191);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32506);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32507);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32508);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32509);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32552);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32553);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32554);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32555);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32751);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32757);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32951);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33641);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33646);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33647);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33648);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33649);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33685);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33766);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33822);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33840);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33841);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33846);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33847);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33848);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33849);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34090);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34543);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34632);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34633);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34634);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34635);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34749);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34785);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34832);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34835);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34850);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34851);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34856);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34857);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34858);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34860);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34861);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35233);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35465);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35491);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35511);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35521);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35573);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35574);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35575);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35586);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35587);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35588);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35589);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35657);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35668);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35712);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35713);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35725);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35777);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36130);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36131);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36138);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36139);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36442);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36957);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37240);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37241);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37246);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37247);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37248);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37249);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38653);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38654);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38655);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38662);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38663);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38664);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38665);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39263);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39264);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39297);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39310);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39311);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39342);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39546);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39547);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39638);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39742);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39899);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39910);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39942);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39943);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39944);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39945);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39972);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39973);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39974);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39975);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39980);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39981);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39986);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39987);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39988);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39989);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40322);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40323);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40325);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40776);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40777);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40778);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40779);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40782);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40783);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40784);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40785);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40970);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40971);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41232);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41233);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41436);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41437);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41438);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41439);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41452);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41453);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41454);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41455);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41832);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41833);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41834);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41857);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41858);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41859);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41861);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41866);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41867);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41868);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41869);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42010);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42011);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42016);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42017);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42019);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42020);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42042);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42043);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42044);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42045);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42086);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42087);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42088);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42089);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42276);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43335);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43350);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43357);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43359);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43360);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43368);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43369);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43871);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43876);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43958);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43959);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44406);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44511);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44516);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44517);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44518);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44520);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44521);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44528);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44529);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44544);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44545);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44572);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44573);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44712);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44713);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44714);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44715);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44740);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44741);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44746);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44747);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44748);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44749);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44770);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44771);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44776);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44777);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44778);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44779);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44782);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44783);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44784);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44785);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44940);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44941);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44947);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44948);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45602);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45603);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45604);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45605);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45866);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46080);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46081);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46215);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47190);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47191);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47196);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47197);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47198);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47199);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47248);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49059);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49060);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49061);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49435);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49461);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49468);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49469);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49492);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49493);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49494);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49495);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50376);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50377);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50725);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50740);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50741);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50746);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50747);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50748);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50749);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50776);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50777);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50778);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53734);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53735);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54516);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54517);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54518);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54519);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54520);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54521);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54526);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54527);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54528);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54529);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54542);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54543);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54544);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54740);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56410);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56411);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57475);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57481);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57500);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57501);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57506);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57507);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57508);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57509);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57530);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57531);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57934);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57935);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57950);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58328);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58329);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59435);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59943);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
