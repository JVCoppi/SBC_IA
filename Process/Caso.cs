using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Process
{
    [BsonIgnoreExtraElements()]
    public class Caso
    {

        public Caso()
        {

        }

        [BsonId]
        public ObjectId _id { get; set; }

        [BsonElement("Caso")]
        public int caso { get; set; }

        [BsonElement("DescDoenca")]
        public String doenca { get; set; }

        [BsonElement("area-damaged")]
        public String area_damaged { get; set; }

        [BsonElement("canker-lesion")]
        public String canker_lesion { get; set; }

        [BsonElement("crop-hist")]
        public String crop_hist { get; set; }

        [BsonElement("date")]
        public String date { get; set; }

        [BsonElement("external decay")]
        public String external_decay { get; set; }

        [BsonElement("fruit spots")]
        public String fruit_spots { get; set; }

        [BsonElement("fruiting-bodies")]
        public String fruiting_bodies { get; set; }

        [BsonElement("fruit-pods")]
        public String fruit_pods { get; set; }

        [BsonElement("germination")]
        public String germination { get; set; }

        [BsonElement("hail")]
        public String hail { get; set; }

        [BsonElement("int-discolor")]
        public String int_discolor { get; set; }

        [BsonElement("leaf-malf")]
        public String leaf_malf { get; set; }

        [BsonElement("leaf-mild")]
        public String leaf_mild { get; set; }

        [BsonElement("leaf-shread")]
        public String leaf_shread { get; set; }

        [BsonElement("leafspots-halo")]
        public String leafspots_halo { get; set; }

        [BsonElement("leafspot-size")]
        public String leafspot_size { get; set; }

        [BsonElement("leafspots-marg")]
        public String leafspots_marg { get; set; }

        [BsonElement("leaves")]
        public String leaves { get; set; }

        [BsonElement("lodging")]
        public String lodging { get; set; }

        [BsonElement("mold-growth")]
        public String mold_growth { get; set; }

        [BsonElement("mycelium")]
        public String mycelium { get; set; }

        [BsonElement("plant-growth")]
        public String plant_growth { get; set; }

        [BsonElement("plant-stand")]
        public String plant_stand { get; set; }

        [BsonElement("precip")]
        public String precip { get; set; }

        [BsonElement("roots")]
        public String roots { get; set; }

        [BsonElement("sclerotia")]
        public String sclerotia { get; set; }

        [BsonElement("seed")]
        public String seed { get; set; }

        [BsonElement("seed-discolor")]
        public String seed_discolor { get; set; }

        [BsonElement("seed-size")]
        public String seed_size { get; set; }

        [BsonElement("seed-tmt")]
        public String seed_tmt { get; set; }

        [BsonElement("severity")]
        public String severity { get; set; }

        [BsonElement("shriveling")]
        public String shriveling { get; set; }

        [BsonElement("stem")]
        public String stem { get; set; }

        [BsonElement("stem-cankers")]
        public String stem_cankers { get; set; }

        [BsonElement("temp")]
        public String temp { get; set; }

        public double SimilaridadeGlobal { get; set; }
    }
}