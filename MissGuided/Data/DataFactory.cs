using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MissGuided.Models;

namespace MissGuided.Data
{
   public static class DataFactory
    {
        public static IList<Detail> detailData { get; private set; }
        private static readonly Master Master1 = new Master { masterID = 1, masterTitle = "New In" };
        private static readonly Master Master2 = new Master { masterID = 2, masterTitle = "Mg Kids" };
        private static readonly Master Master3 = new Master { masterID = 3, masterTitle = "Fall Fits" };
        private static readonly Master Master4 = new Master { masterID = 4, masterTitle = "Carli Bybel x Missguided" };
        private static readonly Master Master5 = new Master { masterID = 5, masterTitle = "Dresses" };
        private static readonly Master Master6 = new Master { masterID = 6, masterTitle = "Tops" };
        private static readonly Master Master7 = new Master { masterID = 7, masterTitle = "Pants" };
        private static readonly Master Master8 = new Master { masterID = 8, masterTitle = "Coats & Jackets" };
        private static readonly Master Master9 = new Master { masterID = 9, masterTitle = "Denim" };
        private static readonly Master Master10 = new Master { masterID = 10, masterTitle = "Jeans" };
        private static readonly Master Master11 = new Master { masterID = 11, masterTitle = "Playboy x Missguided" };
        private static readonly Master Master12 = new Master { masterID = 12, masterTitle = "Loungewear" };
        private static readonly Master Master13 = new Master { masterID = 13, masterTitle = "Clothing" };
        private static readonly Master Master14 = new Master { masterID = 14, masterTitle = "Shop by Fit" };
        private static readonly Master Master15 = new Master { masterID = 15, masterTitle = "Accessories" };
        private static readonly Master Master16 = new Master { masterID = 16, masterTitle = "Shoes" };
        private static readonly Master Master17 = new Master { masterID = 17, masterTitle = "Restyld" };
        private static readonly Master Master18 = new Master { masterID = 18, masterTitle = "Beauty" };
        private static readonly Master Master19 = new Master { masterID = 19, masterTitle = "Shop by Trend" };
        private static readonly Master Master20 = new Master { masterID = 20, masterTitle = "Shop by Occasion" };
        private static readonly Master Master21 = new Master { masterID = 21, masterTitle = "Sale" };
        private static readonly Master Master22 = new Master { masterID = 22, masterTitle = "Clearance" };
        static DataFactory()
        {
            detailData = new ObservableCollection<Detail>()
            {
                new Detail
                {
                    detailID = 1,
                    detailTitle = "view all new in",
                    detailMaster = Master1
                },
                new Detail
                {
                    detailID = 2,
                    detailTitle = "new in this week",
                    detailMaster = Master1
                },
                new Detail
                {
                    detailID = 3,
                    detailTitle = "back in stock",
                    detailMaster = Master1
                },
                new Detail
                {
                    detailID = 4,
                    detailTitle = "new season",
                    detailMaster = Master1
                },
                new Detail
                {
                    detailID = 5,
                    detailTitle = "new in clothing",
                    detailMaster = Master1
                },new Detail
                {
                    detailID = 6,
                    detailTitle = "trengding items",
                    detailMaster = Master1
                },
                new Detail
                {
                    detailID = 7,
                    detailTitle = "new in dresses",
                    detailMaster = Master1
                },
                new Detail
                {
                    detailID = 8,
                    detailTitle = "new in tops",
                    detailMaster = Master1
                },
                new Detail
                {
                    detailID = 9,
                    detailTitle = "new in coats & jackets",
                    detailMaster = Master1
                },
                new Detail
                {
                    detailID = 10,
                    detailTitle = "new in shoes",
                    detailMaster = Master1
                },
                new Detail
                {
                    detailID = 11,
                    detailTitle = "new in trousers",
                    detailMaster = Master1
                },
                new Detail
                {
                    detailID = 12,
                    detailTitle = "new in knitwear",
                    detailMaster = Master1
                },
                new Detail
                {
                    detailID = 13,
                    detailTitle = "new in denim",
                    detailMaster = Master1
                },
                new Detail
                {
                    detailID = 14,
                    detailTitle = "new in co-ordinates",
                    detailMaster = Master1
                },
                new Detail
                {
                    detailID = 15,
                    detailTitle = "new in accessories",
                    detailMaster = Master1
                },
                new Detail
                {
                    detailID = 16,
                    detailTitle = "party shop",
                    detailMaster = Master1
                },
                new Detail
                {
                    detailID = 17,
                    detailTitle = "sean john x missguided",
                    detailMaster = Master1
                },

                new Detail
                {
                    detailID = 18,
                    detailTitle = "viewModels all mg kids",
                    detailMaster = Master2
                },
                new Detail
                {
                    detailID = 19,
                    detailTitle = "baby 3-24 months",
                    detailMaster = Master2
                },
                new Detail
                {
                    detailID = 20,
                    detailTitle = "toddler 2-4 years",
                    detailMaster = Master2
                },
                new Detail
                {
                    detailID = 21,
                    detailTitle = "kids 4-7 years",
                    detailMaster = Master2
                },

                new Detail
                {
                    detailID = 22,
                    detailTitle = "view all fall",
                    detailMaster = Master3
                },
                new Detail
                {
                    detailID = 23,
                    detailTitle = "fall dresses",
                    detailMaster = Master3
                },
                new Detail
                {
                    detailID = 24,
                    detailTitle = "coat & jackets",
                    detailMaster = Master3
                },
                new Detail
                {
                    detailID = 25,
                    detailTitle = "hoodies",
                    detailMaster = Master3
                },
                new Detail
                {
                    detailID = 26,
                    detailTitle = "sweater",
                    detailMaster = Master3
                },
                new Detail
                {
                    detailID = 27,
                    detailTitle = "jeans",
                    detailMaster = Master3
                },
                new Detail
                {
                    detailID = 28,
                    detailTitle = "loungewear",
                    detailMaster = Master3
                },
                new Detail
                {
                    detailID = 29,
                    detailTitle = "hats",
                    detailMaster = Master3
                },
                new Detail
                {
                    detailID = 30,
                    detailTitle = "boots",
                    detailMaster = Master3
                },
                new Detail
                {
                    detailID = 31,
                    detailTitle = "party shop",
                    detailMaster = Master3
                },
                new Detail
                {
                    detailID = 32,
                    detailTitle = "faux leather",
                    detailMaster = Master3
                },
                new Detail
                {
                    detailID = 33,
                    detailTitle = "brown clothing",
                    detailMaster = Master3
                },
                new Detail
                {
                    detailID = 34,
                    detailTitle = "oversized",
                    detailMaster = Master3
                },
                new Detail
                {
                    detailID = 35,
                    detailTitle = "plaid",
                    detailMaster = Master3
                },
                new Detail
                {
                    detailID = 35,
                    detailTitle = "varsity",
                    detailMaster = Master3
                },

                new Detail
                {
                    detailID = 36,
                    detailTitle = "view all dresses",
                    detailMaster = Master5
                },
                new Detail
                {
                    detailID = 37,
                    detailTitle = "bodycon dresses",
                    detailMaster = Master5
                },
                new Detail
                {
                    detailID = 38,
                    detailTitle = "bandage dresses",
                    detailMaster = Master5
                },
                new Detail
                {
                    detailID = 39,
                    detailTitle = "blazer & tuxedo dresses",
                    detailMaster = Master5
                },
                new Detail
                {
                    detailID = 40,
                    detailTitle = "cami dresses",
                    detailMaster = Master5
                },
                new Detail
                {
                    detailID = 41,
                    detailTitle = "casual dresses",
                    detailMaster = Master5
                },
                new Detail
                {
                    detailID = 42,
                    detailTitle = "denim dresses",
                    detailMaster = Master5
                },
                new Detail
                {
                    detailID = 43,
                    detailTitle = "fomal dresses",
                    detailMaster = Master5
                },
                new Detail
                {
                    detailID = 44,
                    detailTitle = "gowns",
                    detailMaster = Master5
                },
                new Detail
                {
                    detailID = 45,
                    detailTitle = "little black dresses",
                    detailMaster = Master5
                },
                new Detail
                {
                    detailID = 46,
                    detailTitle = "maxi dresses",
                    detailMaster = Master5
                },
                new Detail
                {
                    detailID = 47,
                    detailTitle = "midi dresses",
                    detailMaster = Master5
                },
                new Detail
                {
                    detailID = 48,
                    detailTitle = "party dresses",
                    detailMaster = Master5
                },
                new Detail
                {
                    detailID = 49,
                    detailTitle = "short dresses",
                    detailMaster = Master5
                },
                new Detail
                {
                    detailID = 50,
                    detailTitle = "shirt dresses",
                    detailMaster = Master5
                },
                new Detail
                {
                    detailID = 51,
                    detailTitle = "sweater dresses",
                    detailMaster = Master5
                },
                new Detail
                {
                    detailID = 52,
                    detailTitle = "skater dresses",
                    detailMaster = Master5
                },
                new Detail
                {
                    detailID = 53,
                    detailTitle = "smock dresses",
                    detailMaster = Master5
                },
                new Detail
                {
                    detailID = 54,
                    detailTitle = "t-shirts dresses",
                    detailMaster = Master5
                },
                new Detail
                {
                    detailID = 55,
                    detailTitle = "wrap dresses",
                    detailMaster = Master5
                },
                new Detail
                {
                    detailID = 57,
                    detailTitle = "view all",
                    detailMaster = Master5
                },

                new Detail
                {
                    detailID = 58,
                    detailTitle = "bandeau tops",
                    detailMaster = Master6
                },
                new Detail
                {
                    detailID = 59,
                    detailTitle = "blouses",
                    detailMaster = Master6
                },
                new Detail
                {
                    detailID = 60,
                    detailTitle = "bodusuits",
                    detailMaster = Master6
                },
                new Detail
                {
                    detailID = 61,
                    detailTitle = "bralets",
                    detailMaster = Master6
                },
                new Detail
                {
                    detailID = 62,
                    detailTitle = "crop tops",
                    detailMaster = Master6
                },
                new Detail
                {
                    detailID = 63,
                    detailTitle = "cami tops",
                    detailMaster = Master6
                },
                new Detail
                {
                    detailID = 64,
                    detailTitle = "crop tops",
                    detailMaster = Master6
                },
                new Detail
                {
                    detailID = 65,
                    detailTitle = "going out tops",
                    detailMaster = Master6
                },
                new Detail
                {
                    detailID = 66,
                    detailTitle = "graphic tees",
                    detailMaster = Master6
                },
                new Detail
                {
                    detailID = 67,
                    detailTitle = "high neck tops",
                    detailMaster = Master6
                },
                new Detail
                {
                    detailID = 68,
                    detailTitle = "hoodies",
                    detailMaster = Master6
                },
                new Detail
                {
                    detailID = 69,
                    detailTitle = "long sleeve tops",
                    detailMaster = Master6
                },
                new Detail
                {
                    detailID = 70,
                    detailTitle = "plunge tops",
                    detailMaster = Master6
                },
                new Detail
                {
                    detailID = 71,
                    detailTitle = "mesh tops",
                    detailMaster = Master6
                },
                new Detail
                {
                    detailID = 72,
                    detailTitle = "satin tops",
                    detailMaster = Master6
                },
                new Detail
                {
                    detailID = 73,
                    detailTitle = "shirts",
                    detailMaster = Master6
                },
                new Detail
                {
                    detailID = 74,
                    detailTitle = "sweatshirts",
                    detailMaster = Master6
                },
                new Detail
                {
                    detailID = 75,
                    detailTitle = "t-shirts",
                    detailMaster = Master6
                },
                new Detail
                {
                    detailID = 76,
                    detailTitle = "tank tops",
                    detailMaster = Master6
                },
                new Detail
                {
                    detailID = 77,
                    detailTitle = "wrap tops",
                    detailMaster = Master6
                },

                new Detail
                {
                    detailID = 78,
                    detailTitle = "view all pants",
                    detailMaster = Master7
                },
                new Detail
                {
                    detailID = 79,
                    detailTitle = "cigarette pants",
                    detailMaster = Master7
                },
                new Detail
                {
                    detailID = 80,
                    detailTitle = "culottes",
                    detailMaster = Master7
                },
                new Detail
                {
                    detailID = 81,
                    detailTitle = "faux leather pants",
                    detailMaster = Master7
                },
                new Detail
                {
                    detailID = 82,
                    detailTitle = "flared pants",
                    detailMaster = Master7
                },
                new Detail
                {
                    detailID = 83,
                    detailTitle = "high waisted pants",
                    detailMaster = Master7
                },
                new Detail
                {
                    detailID = 84,
                    detailTitle = "joggers",
                    detailMaster = Master7
                },
                new Detail
                {
                    detailID = 85,
                    detailTitle = "skinny pants",
                    detailMaster = Master7
                },
                new Detail
                {
                    detailID = 86,
                    detailTitle = "tapered pants",
                    detailMaster = Master7
                },
                new Detail
                {
                    detailID = 87,
                    detailTitle = "slim leg trousers",
                    detailMaster = Master7
                },
                new Detail
                {
                    detailID = 88,
                    detailTitle = "wide leg pants",
                    detailMaster = Master7
                },

                new Detail
                {
                    detailID = 89,
                    detailTitle = "view all coats & jackets",
                    detailMaster = Master8
                },
                new Detail
                {
                    detailID = 90,
                    detailTitle = "biker jackets",
                    detailMaster = Master8
                },
                new Detail
                {
                    detailID = 91,
                    detailTitle = "faux leather jackets",
                    detailMaster = Master8
                },
                new Detail
                {
                    detailID = 92,
                    detailTitle = "faux fur coats",
                    detailMaster = Master8
                },
                new Detail
                {
                    detailID = 93,
                    detailTitle = "vests",
                    detailMaster = Master8
                },
                new Detail
                {
                    detailID = 94,
                    detailTitle = "long coats",
                    detailMaster = Master8
                },
                new Detail
                {
                    detailID = 95,
                    detailTitle = "padded jakcets",
                    detailMaster = Master8
                },
                new Detail
                {
                    detailID = 96,
                    detailTitle = "shakets",
                    detailMaster = Master8
                },
                new Detail
                {
                    detailID = 97,
                    detailTitle = "shearling jakcets",
                    detailMaster = Master8
                },
                new Detail
                {
                    detailID = 98,
                    detailTitle = "teddy coats",
                    detailMaster = Master8
                },
                new Detail
                {
                    detailID = 99,
                    detailTitle = "tench coats",
                    detailMaster = Master8
                },

                new Detail
                {
                    detailID = 100,
                    detailTitle = "view all",
                    detailMaster = Master9
                },
                new Detail
                {
                    detailID = 101,
                    detailTitle = "jeans",
                    detailMaster = Master9
                },
                new Detail
                {
                    detailID = 102,
                    detailTitle = "denim dresses",
                    detailMaster = Master9
                },
                new Detail
                {
                    detailID = 103,
                    detailTitle = "denim jackets",
                    detailMaster = Master9
                },
                new Detail
                {
                    detailID = 104,
                    detailTitle = "denim overalls",
                    detailMaster = Master9
                },
                new Detail
                {
                    detailID = 105,
                    detailTitle = "denim rompers",
                    detailMaster = Master9
                },
                new Detail
                {
                    detailID =106 ,
                    detailTitle = "denim shirts & tops",
                    detailMaster = Master9
                },
                new Detail
                {
                    detailID = 107,
                    detailTitle = "denim shorts",
                    detailMaster = Master9
                },
                new Detail
                {
                    detailID = 108,
                    detailTitle = "denim skirts",
                    detailMaster = Master9
                },

                new Detail
                {
                    detailID = 109,
                    detailTitle = "view all jeans",
                    detailMaster = Master10
                },
                new Detail
                {
                    detailID = 110,
                    detailTitle = "baggy boyfriend jeans",
                    detailMaster = Master10
                },
                new Detail
                {
                    detailID = 111,
                    detailTitle = "super stretch skinny jeans",
                    detailMaster = Master10
                },
                new Detail
                {
                    detailID = 112,
                    detailTitle = "authentic skinny jeans",
                    detailMaster = Master10
                },
                new Detail
                {
                    detailID = 113,
                    detailTitle = "straigh jeans",
                    detailMaster = Master10
                },
                new Detail
                {
                    detailID = 114,
                    detailTitle = "wide leg jeans",
                    detailMaster = Master10
                },
                new Detail
                {
                    detailID = 115,
                    detailTitle = "dad jeans",
                    detailMaster = Master10
                },
                new Detail
                {
                    detailID = 116,
                    detailTitle = "mom jeans",
                    detailMaster = Master10
                },
                new Detail
                {
                    detailID = 117,
                    detailTitle = "loose jeans",
                    detailMaster = Master10
                },

                new Detail
                {
                    detailID = 118,
                    detailTitle = "view all playboy",
                    detailMaster = Master11
                },
                new Detail
                {
                    detailID = 119,
                    detailTitle = "playboy accessories",
                    detailMaster = Master11
                },
                new Detail
                {
                    detailID = 120,
                    detailTitle = "playboy co-ords",
                    detailMaster = Master11
                },
                new Detail
                {
                    detailID = 121,
                    detailTitle = "playboy dresses",
                    detailMaster = Master11
                },
                new Detail
                {
                    detailID = 122,
                    detailTitle = "playboy hoodies",
                    detailMaster = Master11
                },
                new Detail
                {
                    detailID = 123,
                    detailTitle = "playboy joggers",
                    detailMaster = Master11
                },
                new Detail
                {
                    detailID = 124,
                    detailTitle = "playboy tops",
                    detailMaster = Master11
                },
                new Detail
                {
                    detailID = 125,
                    detailTitle = "playboy shorts",
                    detailMaster = Master11
                },

                new Detail
                {
                    detailID = 126,
                    detailTitle = "plus size loungewear",
                    detailMaster = Master12
                },
                new Detail
                {
                    detailID = 127,
                    detailTitle = "view all loungewear",
                    detailMaster = Master12
                },
                new Detail
                {
                    detailID = 128,
                    detailTitle = "loungewear dresses",
                    detailMaster = Master12
                },
                new Detail
                {
                    detailID = 129,
                    detailTitle = "loungewear hoodies",
                    detailMaster = Master12
                },
                new Detail
                {
                    detailID = 130,
                    detailTitle = "loungewear joggers",
                    detailMaster = Master12
                },
                new Detail
                {
                    detailID = 131,
                    detailTitle = "loungewear jumpsuits & playsuits",
                    detailMaster = Master12
                },
                new Detail
                {
                    detailID = 132,
                    detailTitle = "loungewear knitwear",
                    detailMaster = Master12
                },
                new Detail
                {
                    detailID = 133,
                    detailTitle = "loungewear leggings",
                    detailMaster = Master12
                },
                new Detail
                {
                    detailID = 134,
                    detailTitle = "luongewear tees",
                    detailMaster = Master12
                },
                new Detail
                {
                    detailID = 135,
                    detailTitle = "cosy club",
                    detailMaster = Master12
                },

                new Detail
                {
                    detailID = 136,
                    detailTitle = "view all clothing",
                    detailMaster = Master13
                },
                new Detail
                {
                    detailID = 137,
                    detailTitle = "moss wanted",
                    detailMaster = Master13
                },
                new Detail
                {
                    detailID = 138,
                    detailTitle = "last chance to buy",
                    detailMaster = Master13
                },
                new Detail
                {
                    detailID = 139,
                    detailTitle = "dresses",
                    detailMaster = Master13
                },
                new Detail
                {
                    detailID = 140,
                    detailTitle = "activewear",
                    detailMaster = Master13
                },
                new Detail
                {
                    detailID = 141,
                    detailTitle = "basic shop",
                    detailMaster = Master13
                },
                new Detail
                {
                    detailID = 142,
                    detailTitle = "blazers",
                    detailMaster = Master13
                },
                new Detail
                {
                    detailID = 143,
                    detailTitle = "casual weear",
                    detailMaster = Master13
                },
                new Detail
                {
                    detailID = 144,
                    detailTitle = "coats & jackets",
                    detailMaster = Master13
                },
                new Detail
                {
                    detailID = 145,
                    detailTitle = "two piece outfits",
                    detailMaster = Master13
                },
                new Detail
                {
                    detailID = 146,
                    detailTitle = "denim",
                    detailMaster = Master13
                },
                new Detail
                {
                    detailID = 147,
                    detailTitle = "jeans",
                    detailMaster = Master13
                },
                new Detail
                {
                    detailID = 148,
                    detailTitle = "leggings",
                    detailMaster = Master13
                },
                new Detail
                {
                    detailID = 149,
                    detailTitle = "lingerie",
                    detailMaster = Master13
                },
                new Detail
                {
                    detailID = 149,
                    detailTitle = "modest",
                    detailMaster = Master13
                },
                new Detail
                {
                    detailID = 150,
                    detailTitle = "rompers",
                    detailMaster = Master13
                },
                new Detail
                {
                    detailID = 151,
                    detailTitle = "sleepwear",
                    detailMaster = Master13
                },
                new Detail
                {
                    detailID = 152,
                    detailTitle = "shorts",
                    detailMaster = Master13
                },
                new Detail
                {
                    detailID = 153,
                    detailTitle = "skirts",
                    detailMaster = Master13
                },
                new Detail
                {
                    detailID = 154,
                    detailTitle = "skiwear",
                    detailMaster = Master13
                },
                new Detail
                {
                    detailID = 155,
                    detailTitle = "sweaters",
                    detailMaster = Master13
                },
                new Detail
                {
                    detailID = 156,
                    detailTitle = "swimwear",
                    detailMaster = Master13
                },
                new Detail
                {
                    detailID = 157,
                    detailTitle = "tailoring",
                    detailMaster = Master13
                },
                new Detail
                {
                    detailID = 158,
                    detailTitle = "peace + love",
                    detailMaster = Master13
                },
                new Detail
                {
                    detailID = 159,
                    detailTitle = "mg collection",
                    detailMaster = Master13
                },
                new Detail
                {
                    detailID = 160,
                    detailTitle = "tracksuits",
                    detailMaster = Master13
                },

                new Detail
                {
                    detailID = 161,
                    detailTitle = "plus size",
                    detailMaster = Master14
                },
                new Detail
                {
                    detailID = 162,
                    detailTitle = "ptite",
                    detailMaster = Master14
                },
                new Detail
                {
                    detailID = 163,
                    detailTitle = "maternity",
                    detailMaster = Master14
                },
                new Detail
                {
                    detailID = 164,
                    detailTitle = "tall",
                    detailMaster = Master14
                },

                new Detail
                {
                    detailID = 165,
                    detailTitle = "view all accessories",
                    detailMaster = Master15
                },
                new Detail
                {
                    detailID = 166,
                    detailTitle = "belts",
                    detailMaster = Master15
                },
                new Detail
                {
                    detailID = 167,
                    detailTitle = "face coverings",
                    detailMaster = Master15
                },
                new Detail
                {
                    detailID = 168,
                    detailTitle = "hats",
                    detailMaster = Master15
                },
                new Detail
                {
                    detailID = 169,
                    detailTitle = "hair accessories",
                    detailMaster = Master15
                },
                new Detail
                {
                    detailID = 170,
                    detailTitle = "jewelry",
                    detailMaster = Master15
                },
                new Detail
                {
                    detailID = 171,
                    detailTitle = "sanglasses",
                    detailMaster = Master15
                },
                new Detail
                {
                    detailID = 172,
                    detailTitle = "purses",
                    detailMaster = Master15
                },

                new Detail
                {
                    detailID = 173,
                    detailTitle = "view all shoes",
                    detailMaster = Master16
                },
                new Detail
                {
                    detailID = 174,
                    detailTitle = "barely there heels",
                    detailMaster = Master16
                },
                new Detail
                {
                    detailID = 175,
                    detailTitle = "block heels",
                    detailMaster = Master16
                },
                new Detail
                {
                    detailID = 176,
                    detailTitle = "boots",
                    detailMaster = Master16
                },
                new Detail
                {
                    detailID = 177,
                    detailTitle = "clear heels",
                    detailMaster = Master16
                },
                new Detail
                {
                    detailID = 178,
                    detailTitle = "flat heels",
                    detailMaster = Master16
                },
                new Detail
                {
                    detailID = 179,
                    detailTitle = "high heels",
                    detailMaster = Master16
                },
                new Detail
                {
                    detailID = 180,
                    detailTitle = "mules",
                    detailMaster = Master16
                },
                new Detail
                {
                    detailID = 181,
                    detailTitle = "trainers",
                    detailMaster = Master16
                },
                new Detail
                {
                    detailID = 182,
                    detailTitle = "sandals",
                    detailMaster = Master16
                },

                new Detail
                {
                    detailID = 183,
                    detailTitle = "restyld view all",
                    detailMaster = Master17
                },
                new Detail
                {
                    detailID = 184,
                    detailTitle = "restyld hoodies & sweats",
                    detailMaster = Master17
                },
                new Detail
                {
                    detailID = 185,
                    detailTitle = "restyld trousers",
                    detailMaster = Master17
                },
                new Detail
                {
                    detailID = 186,
                    detailTitle = "restyld tops",
                    detailMaster = Master17
                },
                new Detail
                {
                    detailID = 187,
                    detailTitle = "restyld shorts",
                    detailMaster = Master17
                },

                new Detail
                {
                    detailID = 188,
                    detailTitle = "view all",
                    detailMaster = Master18
                },
                new Detail
                {
                    detailID = 189,
                    detailTitle = "missguided beauty",
                    detailMaster = Master18
                },
                new Detail
                {
                    detailID = 190,
                    detailTitle = "make-up",
                    detailMaster = Master18
                },
                new Detail
                {
                    detailID = 191,
                    detailTitle = "skincare",
                    detailMaster = Master18
                },
                new Detail
                {
                    detailID = 192,
                    detailTitle = "bath & body",
                    detailMaster = Master18
                },
                new Detail
                {
                    detailID = 193,
                    detailTitle = "wellness",
                    detailMaster = Master18
                },
                new Detail
                {
                    detailID = 194,
                    detailTitle = "sun & tan",
                    detailMaster = Master18
                },
                new Detail
                {
                    detailID = 195,
                    detailTitle = "tools & accessories",
                    detailMaster = Master18
                },

                new Detail
                {
                    detailID = 196,
                    detailTitle = "tailoring",
                    detailMaster = Master19
                },
                new Detail
                {
                    detailID = 197,
                    detailTitle = "linen",
                    detailMaster = Master19
                },
                new Detail
                {
                    detailID = 198,
                    detailTitle = "corset",
                    detailMaster = Master19
                },
                new Detail
                {
                    detailID = 199,
                    detailTitle = "faux leather",
                    detailMaster = Master19
                },
                new Detail
                {
                    detailID = 200,
                    detailTitle = "graphics shop",
                    detailMaster = Master19
                },
                new Detail
                {
                    detailID = 201,
                    detailTitle = "mesh",
                    detailMaster = Master19
                },
                new Detail
                {
                    detailID = 202,
                    detailTitle = "milkmaid",
                    detailMaster = Master19
                },
                new Detail
                {
                    detailID = 203,
                    detailTitle = "plaid",
                    detailMaster = Master19
                },
                new Detail
                {
                    detailID = 204,
                    detailTitle = "puff sleeve",
                    detailMaster = Master19
                },
                new Detail
                {
                    detailID = 205,
                    detailTitle = "ruched",
                    detailMaster = Master19
                },
                new Detail
                {
                    detailID = 206,
                    detailTitle = "satin",
                    detailMaster = Master19
                },
                new Detail
                {
                    detailID = 207,
                    detailTitle = "pink outfits",
                    detailMaster = Master19
                },
                new Detail
                {
                    detailID = 208,
                    detailTitle = "prints",
                    detailMaster = Master19
                },
                new Detail
                {
                    detailID = 209,
                    detailTitle = "varsity",
                    detailMaster = Master19
                },
                new Detail
                {
                    detailID = 210,
                    detailTitle = "button up clothing",
                    detailMaster = Master19
                },

                new Detail
                {
                    detailID = 211,
                    detailTitle = "winter warmers",
                    detailMaster = Master20
                },
                new Detail
                {
                    detailID = 212,
                    detailTitle = "back to college",
                    detailMaster = Master20
                },
                new Detail
                {
                    detailID = 213,
                    detailTitle = "party shop",
                    detailMaster = Master20
                },
                new Detail
                {
                    detailID = 214,
                    detailTitle = "work clothes",
                    detailMaster = Master20
                },
                new Detail
                {
                    detailID = 215,
                    detailTitle = "vacation shop",
                    detailMaster = Master20
                },
                new Detail
                {
                    detailID = 216,
                    detailTitle = "airport outfits",
                    detailMaster = Master20
                },
                new Detail
                {
                    detailID = 217,
                    detailTitle = "brunch outfits",
                    detailMaster = Master20
                },
                new Detail
                {
                    detailID = 218,
                    detailTitle = "day drink outfits",
                    detailMaster = Master20
                },
                new Detail
                {
                    detailID = 219,
                    detailTitle = "date night outfits",
                    detailMaster = Master20
                },
                new Detail
                {
                    detailID = 220,
                    detailTitle = "occation dresses & outfits",
                    detailMaster = Master20
                },
                new Detail
                {
                    detailID = 221,
                    detailTitle = "wedding",
                    detailMaster = Master20
                },

                new Detail
                {
                    detailID = 222,
                    detailTitle = "",
                    detailMaster = Master21
                },
                new Detail
                {
                    detailID = 223,
                    detailTitle = "view all sale",
                    detailMaster = Master21
                },
                new Detail
                {
                    detailID = 224,
                    detailTitle = "at least 50% off",
                    detailMaster = Master21
                },
                new Detail
                {
                    detailID = 225,
                    detailTitle = "at least 60% off",
                    detailMaster = Master21
                },
                new Detail
                {
                    detailID = 226,
                    detailTitle = "at least 70% off",
                    detailMaster = Master21
                },
                new Detail
                {
                    detailID = 227,
                    detailTitle = "sale dresses",
                    detailMaster = Master21
                },
                new Detail
                {
                    detailID = 228,
                    detailTitle = "sale tops",
                    detailMaster = Master21
                },
                new Detail
                {
                    detailID = 229,
                    detailTitle = "sale accessories",
                    detailMaster = Master21
                },
                new Detail
                {
                    detailID = 230,
                    detailTitle = "sale coats",
                    detailMaster = Master21
                },
                new Detail
                {
                    detailID = 231,
                    detailTitle = "sale denim",
                    detailMaster = Master21
                },
                new Detail
                {
                    detailID = 232,
                    detailTitle = "sale jeans",
                    detailMaster = Master21
                },
                new Detail
                {
                    detailID = 233,
                    detailTitle = "sale jumpsuits & rompers",
                    detailMaster = Master21
                },
                new Detail
                {
                    detailID = 234,
                    detailTitle = "sale nightwear & lingerie",
                    detailMaster = Master21
                },
                new Detail
                {
                    detailID = 235,
                    detailTitle = "sale pants",
                    detailMaster = Master21
                },
                new Detail
                {
                    detailID = 236,
                    detailTitle = "sale knitwear",
                    detailMaster = Master21
                },
                new Detail
                {
                    detailID = 237,
                    detailTitle = "sale shoes",
                    detailMaster = Master21
                },
                new Detail
                {
                    detailID = 238,
                    detailTitle = "sale shorts",
                    detailMaster = Master21
                },
                new Detail
                {
                    detailID = 239,
                    detailTitle = "sales skirt",
                    detailMaster = Master21
                },
                new Detail
                {
                    detailID = 240,
                    detailTitle = "sale swimwear",
                    detailMaster = Master21
                },
                new Detail
                {
                    detailID = 241,
                    detailTitle = "sale plus size",
                    detailMaster = Master21
                },
                new Detail
                {
                    detailID = 242,
                    detailTitle = "sale petite",
                    detailMaster = Master21
                },
                new Detail
                {
                    detailID = 243,
                    detailTitle = "sale tall",
                    detailMaster = Master21
                },
            };
        }
    }
}