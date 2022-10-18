using AgriculturalSale.Models;

namespace AgriculturalSale.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
                context.Database.EnsureCreated();

                //ProductType
                if (!context.ProductType.Any())
                {
                    context.ProductType.AddRange(new List<ProductType>()
                    {
                        //1
                      new ProductType()
                      {
                          Name="PAPA BETINA",
                          Details="color: Amarillo claro, Presenta porte de planta alto, follaje verde ligeramente claro, floración abundante y muy poca formación de frutos. Es relativamente temprana (145 días a 2600 msnm), presenta buena calidad culinaria para consumo en fresco y valores de materia seca entre 19 y 21%, textura semicompacta al cocinar, adecuada para sopas y caldos. Es de amplia adaptación para el sistema productivo colombiano (2300-3400msnm) con potencial de rendimiento en condiciones óptimas de cultivo superior a las 40 t•ha-1. Su periodo de reposo de 1,5 meses (15°C y 75% H.R.). Por su color de piel presenta tendencia moderada al verdeamiento, lo implica un manejo en bodegas con muy poca luz.",
                          ImageUrl="http://localhost/img/AgriculturalSale/ProductType/Betina.JPG"
                      },
                      //2
                      new ProductType()
                      {
                          Name="PAPA CRIOLLA AMARILLA",
                          Details="Color: Amarillo,Solanum phureja es una especie de planta fanerógama perteneciente a la familia de las solanáceas. Altamente consumida en los países andinos, conocida comúnmente como papa criolla, amarilla redonda o chaucha.",
                          ImageUrl="http://localhost/img/AgriculturalSale/ProductType/CriollaAmarilla.webp"
                      },
                      //3
                      new ProductType()
                      {
                          Name="PAPA CRIOLLA ROJA",
                          Details="color: rojo,La papa o patata (Solanum tuberosum) es una planta perteneciente a la familia de las solanáceas originaria de Suramérica. Fue domesticada en el altiplano andino por sus habitantes hace unos 8000 años, y más tarde fue llevada a Europa por los españoles como una curiosidad botánica más que como una planta alimenticia.",
                          ImageUrl="http://localhost/img/AgriculturalSale/ProductType/CriollaRoja.jpg"
                      },
                      //4
                      new ProductType()
                      {
                          Name="PAPA ICA UNICA",
                          Details="color: Amarillo claro, con puntos morados,La variedad ICA Única es una variedad colombiana generada por el Instituto Colombiano Agropecuario (ICA). Esta papa es apta para consumo en fresco (sopas y caldos) y para fritura tipo bastón. Los tubérculos son redondos. La piel es crema con presencia de color morado en los ojos, los mismos que son superficiales",
                          ImageUrl="http://localhost/img/AgriculturalSale/ProductType/IcaUnica.jpg"
                      },
                      //5
                      new ProductType()
                      {
                          Name="PAPA R12(ICA HUILA)",
                          Details="color: Rojo claro,Ica Huila: ideal para fritar porque queda crocante. Es similar a la R12 ya que es de gran tamaño. Suprema: excelente para el consumo fresco. Es similar a la pastusa, sin embargo, su cáscara es más delgada; por lo que puede retirarse fácilmente al ser lavada",
                          ImageUrl="http://localhost/img/AgriculturalSale/ProductType/PAPA_R12.jpg"
                      },
                      //6
                      new ProductType()
                      {
                          Name="PAPA RUBI",
                          Details="color: Rojo morado,De Buena Calidad culinaria en el párrafo Consumo fresco, Sabor Excelente, textura al cocinar semicompacta, párr adecuada sopa, caldos y cocida, durante el período comprendido de Reposo de 2,5 meses (15 ° C y HR 75%) ",
                          ImageUrl="http://localhost/img/AgriculturalSale/ProductType/Rubi.JPG"
                      },
                      //7
                      new ProductType()
                      {
                          Name="PAPA PASTUSA SUPERIOR",
                          Details="color: Pardo claro, Tiene excelente calidad culinaria, es versatil para diferentes platos (caldo, sopa, cocida o salada, sudada, etc.) y es relativamente tardía (165 días, 2600 msnm).",
                          ImageUrl="http://localhost/img/AgriculturalSale/ProductType/Superior.JPG"
                      },
                      //8
                      new ProductType()
                      {
                          Name="PAPA TOCARREÑA (SABANERA)",
                          Details="color: Morado con machas pardas clara, tiene una textura firme, presenta un sabor apetitoso y su color es entre pardo con visos morados. Su preparación más común son chips caseros.",
                          ImageUrl="http://localhost/img/AgriculturalSale/ProductType/Tocarre%c3%b1a.jpg"
                      },
                      //9
                      new ProductType()
                      {
                          Name="Zanahoria Hibrida",
                          Details="Contextura alargada, lisa de buen color ",
                          ImageUrl="http://localhost/img/AgriculturalSale/ProductType/zanahoriaHibrida.jpg"
                      },
                      //10
                      new ProductType()
                      {
                          Name="Zanahoria Bejo",
                          Details="De color intenso, uniforme, lisa y muy cilíndrica.",
                          ImageUrl="http://localhost/img/AgriculturalSale/ProductType/ZanahoriaBejo.jpg"
                      },
                      //11
                      new ProductType()
                      {
                          Name="Cebolla Takis ",
                          Details="Cuello muy fino evitando la permeabilización del agua al bulbo. Su bulbo es globoso dorado, firme, muy uniforme, con buena pungencia Hy. De altísima productividad que soporta muy bien la alta densidad de siembra sin afectar la formación globosa del bulbo",
                          ImageUrl="http://localhost/img/AgriculturalSale/ProductType/CebollaTakis.jpg"
                      },
                      //12
                      new ProductType()
                      {
                          Name="Cebolla Sirius",
                          Details="Cebolla de forma globosa, amarilla bulvos de alta calidad y gran dencidad",
                          ImageUrl="http://localhost/img/AgriculturalSale/ProductType/CebollaSirius.jpg"
                      },
                    });
                    context.SaveChanges();

                }
                if (!context.Municipality.Any())
                {
                    context.Municipality.AddRange(new List<Municipality>()
                    {
                        //1
                        new Municipality(){
                          name="Tunja"
                        },
                        //2
                        new Municipality(){
                          name="Sogamoso"
                        },
                        //3
                        new Municipality(){
                          name="Duitama"
                        },
                        //4
                        new Municipality(){
                          name="Chiquinquira"
                        },
                        //5
                        new Municipality(){
                          name="Puerto Boyaca"
                        },
                        //6
                        new Municipality(){
                          name="Paipa"
                        },
                        //7
                        new Municipality(){
                          name="Moniquira"
                        },
                        //8
                        new Municipality(){
                          name="Samaca"
                        },
                        //9
                        new Municipality(){
                          name="Garagoa"
                        },
                        //10
                        new Municipality(){
                          name="Aquitania"
                        },
                        //11
                        new Municipality(){
                          name="Nobsa"
                        },
                        //12
                        new Municipality(){
                          name="Ventaquemada"
                        },
                        //13
                        new Municipality(){
                          name="Combita"
                        },
                        //14
                        new Municipality(){
                          name="Saboya"
                        },
                        //15
                        new Municipality(){
                          name="Tibasosa"
                        },
                        //16
                        new Municipality(){
                          name="Raquira"
                        },
                        //17
                        new Municipality(){
                          name="Santa Rosa de Viterbo"
                        },
                        //18
                        new Municipality(){
                          name="Chita"
                        },
                        //19
                        new Municipality(){
                          name="Otanche"
                        },
                        //20
                        new Municipality(){
                          name="Pauna"
                        },
                        //21
                        new Municipality(){
                          name="Motavita"
                        },
                    });
                    context.SaveChanges();

                }
                if (!context.Location.Any())
                {
                    context.Location.AddRange(new List<Location>()
                    { 
                     //1
                     new Location()
                     {

                         SideWalk="La Hoya",
                         Details="La vereda La Hoya está ubicada en el extremo suroccidental del municipio de Tunja. Limita por el norte con las veredas de Barón Germania y La Lajita, por el sur con el municipio de Ventaquemada, por el noreste con los municipios de Samacá y Cucaita.",
                         MunicipalityId=1,
                     },
                     //2
                     new Location()
                     {
                         SideWalk="Gacal",
                         Details="Ubicada en medio del puente de boyaca la verda la cumpre",
                         MunicipalityId=8
                     },
                     //3
                     new Location()
                     {
                         SideWalk="Bojirque",
                         Details="Ubicada sector tierra negra y alrededores",
                         MunicipalityId=12
                     },
                     //4
                     new Location()
                     {
                         SideWalk="Carbonera",
                         Details=">Zona ubicada entre M. Arcabuco y Chiquiza al norte y Municipio Tunja al sur, Municipio Combita al oriente y Municipio Zora al occidente.",
                         MunicipalityId=21
                     },
                     //5
                     new Location()
                     {
                         SideWalk="Siatame",
                         Details="Zona ubicada entre M. Sta Rosa Dev y Floresta al norte y Municipio Sogamoso al sur, Río (Permanete) al oriente y Municipio Tibasosa al occidente",
                         MunicipalityId =2
                     },
                    });
                    context.SaveChanges();

                }
                if (!context.MethodOfPayment.Any())
                {
                    context.MethodOfPayment.AddRange(new List<MethodOfPayment>()
                    {
                      new MethodOfPayment()
                      {
                          name="Tarjeta Credito"
                      },
                      new MethodOfPayment()
                      {
                          name="Efectivo"
                      },
                      new MethodOfPayment()
                      {
                          name="PSE"
                      },

                    });
                    context.SaveChanges();
                }
                if (!context.Product.Any())
                {
                    context.Product.AddRange(new List<Product>()
                    {
                        //1
                        new Product()
                        {
                            Name="Papa pastusa",
                            ImageUrl="http://localhost/img/AgriculturalSale/Product/Pastusa.jpeg",
                            Details="Papa pastusa de buena calidad de porte delgado",
                            Price=120000,
                            stock="si",
                            ProducTypeId=7,
                            LocationId=3,
                        },
                        //2
                        new Product()
                        {
                            Name="Papa unica",
                            ImageUrl="http://localhost/img/AgriculturalSale/Product/Unica.jpeg",
                            Details="Papa de buena calidad con rastros de pique",
                            Price=100000,
                            stock="si",
                            ProducTypeId=4,
                            LocationId=3,
                        },
                        //3
                        new Product()
                        {
                            Name="Cebolla Takis",
                            ImageUrl="http://localhost/img/AgriculturalSale/Product/takis.jpg",
                            Details="cebolla fina de alta calidad, bien formada",
                            Price=110000,
                            stock="si",
                            ProducTypeId=11,
                            LocationId=5,
                        },
                        //4
                        new Product()
                        {
                            Name="Cebolla Sirius",
                            ImageUrl="http://localhost/img/AgriculturalSale/Product/sirius.jpg",
                            Details="cebolla gruesa",
                            Price=100000,
                            stock="si",
                            ProducTypeId=12,
                            LocationId=2,
                        },
                        //5
                        new Product()
                        {
                            Name="Zanahoria Bejo",
                            ImageUrl="http://localhost/img/AgriculturalSale/Product/bejo.jpg",
                            Details="zanahoria fina buen color",
                            Price=90000,
                            stock = "si",
                            ProducTypeId=10,
                            LocationId=1,
                        },
                    });
                    context.SaveChanges();

                }
                if (!context.Sale.Any())
                {
                    context.Sale.AddRange(new List<Sale>()
                    {
                        //1
                        new Sale()
                        {
                            Date= DateTime.Now,
                            MethodOfPaymentId=1
                        },
                        //2
                        new Sale()
                        {
                            Date=DateTime.Now,
                            MethodOfPaymentId=2
                        },
                    });
                    context.SaveChanges();
                }
                if (!context.SaleDetail.Any())
                {
                    context.SaleDetail.AddRange(new List<SaleDetail>()
                    {
                        //1
                        new SaleDetail()
                        {
                            ProductId=1,
                            SaleId=1,
                            Price=120000,
                            Amount=1
                        },
                        //2
                        new SaleDetail()
                        {
                            ProductId=4,
                            SaleId=2,
                            Price=100000,
                            Amount=1
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
