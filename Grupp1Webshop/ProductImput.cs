using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp1Webshop
{
    internal class ProductImput
    {

        public static List<Models.Product> Products { get; set; }

        //public static List<Models.Product> GetAllproducts()
        //{

        //    Products = new List<Models.Product>
        //    {
        //            new Product()
        //            {
        //                Name = "Klänning med rynk",
        //                Size = new List<string>()
        //                {
        //                    "XS",
        //                    "S",
        //                    "M",
        //                    "L",
        //                    "XL"
        //                },
        //                Färg = new List<string>()
        //                {
        //                    "Svart",
        //                },
        //                Price = 299.00,
        //                Kategori = "Klänningar",
        //                Description = "En figurnära, vadlång klänning i mjuk trikå utan ärm. Klänningen har bred halsringning och dold dragkedja bak. Rynk i midjan för en lätt draperad effekt. Rakt skuren nederkant. Ofodrad.",
        //            },
        //            new Product()
        //            {
        //                Name = "Ribbstickad klänning",
        //                Size = new List<string>()
        //                {
        //                    "XS",
        //                    "S",
        //                    "M",
        //                    "L",
        //                    "XL"
        //                },
        //                Färg = new List<string>()
        //                {
        //                    "Svart",
        //                    "Mörkbeige",
        //                    "Crèmevit"
        //                },
        //                Price = 399.00,
        //                Kategori = "Klänningar",
        //                Description = "En kort, figurnära klänning i mjuk, ribbstickad kvalitet med formstickat parti upptill. Klänningen har bred halsringning och lång, vid ärm. Rak nederkant.",
        //            },
        //            new Product()
        //            {
        //                Name = "Omlottklänning med ballongärm",
        //                Size = new List<string>()
        //                {
        //                    "XS",
        //                    "S",
        //                    "M",
        //                    "L",
        //                    "XL"
        //                },
        //                Färg = new List<string>()
        //                {
        //                    "Svart/Randig",
        //                    "Vit",
        //                    "Svart/Blommig"
        //                },
        //                Price = 199.00,
        //                Kategori = "Klänningar",
        //                Description = "En vadlång klänning i mjuk trikå. Klänningen är V-ringad och har omlott fram med breda knytband i ena sidan och smala, dolda knytband i andra sidan. Lätt nedhasad axel och lång ballongärm med smal resår vid ärmslut. Ofodrad.",
        //            },
        //            new Product()
        //            {
        //                Name = "Skjortklänning",
        //                Size = new List<string>()
        //                {
        //                    "XS",
        //                    "S",
        //                    "M",
        //                    "L",
        //                    "XL"
        //                },
        //                Färg = new List<string>()
        //                {
        //                    "Grön",
        //                },
        //                Price = 299.00,
        //                Kategori = "Klänningar",
        //                Description = "En knälång skjortklänning i vävd kvalitet. Den har krage, knäppning fram och okavskärning med motveck bak. Lång, voluminös ärm med bred manschett som har slits och knapp. Öppen bröstficka. Rundad nederkant. Något längre bakstycke.",
        //            },
        //            new Product()
        //            {
        //                Name = "Paljettbroderad omlottklänning",
        //                Size = new List<string>()
        //                {
        //                    "XS",
        //                    "S",
        //                    "M",
        //                    "L",
        //                    "XL"
        //                },
        //                Färg = new List<string>()
        //                {
        //                    "Silver",
        //                },
        //                Price = 499.00,
        //                Kategori = "Klänningar",
        //                Description= "En kort klänning i glittrig, paljettbroderad mesh. Klänningen har axelvaddar och lång ärm. Avskuren med resår i midjan och omlott fram med dold knapp. Hyska och hake i ena sidan. Fodrad.",
        //            },
        //            new Product()
        //            {
        //                Name = "Nätklänning med pärlor",
        //                Size = new List<string>()
        //                {
        //                    "32",
        //                    "34",
        //                    "36",
        //                    "38",
        //                    "40",
        //                    "42",
        //                    "44",
        //                    "46"
        //                },
        //                Färg = new List<string>()
        //                {
        //                    "Silver",
        //                },
        //                Price = 1300.00,
        //                Kategori = "Klänningar",
        //                Description= "Vadlång meshklänning i figurnära passform med pärldetaljer och fransad fåll. Djup rundad ringning bak Längd på klänningen.",
        //            },
        //            new Product()
        //            {
        //                Name = "Kort off shoulder-klänning med volang",
        //                Size = new List<string>()
        //                {
        //                    "XS",
        //                    "S",
        //                    "M",
        //                    "L",
        //                    "XL"
        //                },
        //                Färg = new List<string>()
        //                {
        //                    "Svart",
        //                    "Röd"
        //                },
        //                Price = 1300.00,
        //                Kategori = "Klänningar",
        //                Description= "Kort off shoulder-klänning med stora volanger, figurnära passform och liten slits i sidan.Korsett med stödskenor upptillDold dragkedja i sidan.Klänningens längd: 65 cm / 25,6&quot; (EU 36 / UK 10 / US 4)",
        //            },
        //            new Product()
        //            {
        //                Name = "Utsvängda leggings",
        //                Size = new List<string>()
        //                {
        //                    "XS",
        //                    "S",
        //                    "M",
        //                    "L",
        //                    "XL"
        //                },
        //                Färg = new List<string>()
        //                {
        //                    "Svart",
        //                    "Mörkbrun",
        //                    "Grön",
        //                    "Beige"
        //                },
        //                Price = 249.00,
        //                Kategori = "Byxor",
        //                Description= "Ett par leggings med smala ben. Leggingsen har hög midja med V-skärning samt utsvängda benslut med sprund.",
        //            },
        //            new Product()
        //            {
        //                Name = "Sports tights",
        //                Size = new List<string>()
        //                {
        //                    "XS",
        //                    "S",
        //                    "M",
        //                    "L",
        //                    "XL"
        //                },
        //                Färg = new List<string>()
        //                {
        //                    "Svart"
        //                },
        //                Price = 199.00,
        //                Kategori = "Byxor",
        //                Description= "Sports tights in fast-drying functional fabric designed to help keep you dry and cool while exercising. Regular waist with a wide waist panel containing a concealed key pocket.",
        //            },
        //            new Product()
        //            {
        //                Name = "Löpartights Seamless",
        //                Size = new List<string>()
        //                {
        //                    "XS",
        //                    "S",
        //                    "M",
        //                    "L",
        //                    "XL"
        //                },
        //                Färg = new List<string>()
        //                {
        //                    "Svart"
        //                },
        //                Price = 299.00,
        //                Kategori = "Byxor",
        //                Description= "Ett par löpartights i snabbtorkande funktionsmaterial som håller dig torr och sval vid löpning. De har hög midja med bred, ribbad mudd och dold dragsko samt ficka med tejpad dragkedja bak för trygg förvaring av värdesaker. Reflekterande detaljer för ökad synlighet vid utomhusaktivitet.",
        //            },
        //            new Product()
        //            {
        //                Name = "Dressad byxa",
        //                Size = new List<string>()
        //                {
        //                    "32",
        //                    "34",
        //                    "36",
        //                    "38",
        //                    "40",
        //                    "42",
        //                    "44",
        //                    "46"
        //                },
        //                Färg = new List<string>()
        //                {
        //                    "Svart",
        //                    "Beige",
        //                    "Blå"
        //                },
        //                Price = 299.00,
        //                Kategori = "Byxor",
        //                Description= "Ett par ankellånga, dressade byxor i vävd kvalitet. Byxorna har gylf med dragkedja och knäppning med hyska och hake. Snedställda framfickor och dekorativa stolpfickor bak. Raka ben med veck fram och bak samt lagda veck upptill. Liten slits vid benslut.",
        //            },
        //            new Product()
        //            {
        //                Name = "Straight High Split Jeans",
        //                Size = new List<string>()
        //                {
        //                    "32",
        //                    "34",
        //                    "36",
        //                    "38",
        //                    "40",
        //                    "42",
        //                    "44",
        //                    "46"
        //                },
        //                Färg = new List<string>()
        //                {
        //                    "Denimblå",
        //                    "Ljus denimblå"
        //                },
        //                Price = 399.00,
        //                Kategori = "Byxor",
        //                Description= "Ett par 5-ficksjeans i stadig bomullsdenim. Jeansen har hög midja och raka ben med slits vid benslut. Gylf med dragkedja och knapp.",
        //            },
        //            new Product()
        //            {
        //                Name = "90's Straight High Jeans",
        //                Size = new List<string>()
        //                {
        //                    "32",
        //                    "34",
        //                    "36",
        //                    "38",
        //                    "40",
        //                    "42",
        //                    "44",
        //                    "46"
        //                },
        //                Färg = new List<string>()
        //                {
        //                    "Denimblå",
        //                    "Ljus denimblå"
        //                },
        //                Price = 299.00,
        //                Kategori = "Byxor",
        //                Description= "Ett par hellånga 5-ficksjeans i tvättad bomullsdenim med hårt slitna detaljer. Jeansen har hög midja och raka ben som ger den perfekta 90-talsviben. Knappgylf.",
        //            },
        //            new Product()
        //            {
        //                Name = "Voluminous Stand Collar Blouse",
        //                Size = new List<string>()
        //                {
        //                    "32",
        //                    "34",
        //                    "36",
        //                    "38",
        //                    "40",
        //                    "42",
        //                    "44",
        //                    "46"
        //                },
        //                Färg = new List<string>()
        //                {
        //                    "Vit",
        //                },
        //                Price = 890.00,
        //                Kategori = "Toppar",
        //                Description= "Voluminous stand collar blouse made from cotton featuring a stand collar, long sleeves with gathered cuffs, a buttoned front and a curved hemline in a loose silhouette.",
        //            },
        //            new Product()
        //            {
        //                Name = "Oversized rib-knit jumper",
        //                Size = new List<string>()
        //                {
        //                    "XS",
        //                    "S",
        //                    "M",
        //                    "L"
        //                },
        //                Färg = new List<string>()
        //                {
        //                    "Black/Striped",
        //                    "Cream"
        //                },
        //                Price = 345.00,
        //                Kategori = "Toppar",
        //                Description= "Oversized jumper in a soft rib knit made from a cotton blend. Round neckline, low dropped shoulders, long sleeves and a slit at each side of the hem.",
        //            },

        //    };
        //}
    }
}

